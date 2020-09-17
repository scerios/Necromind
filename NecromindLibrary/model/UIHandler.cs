using NecromindLibrary.dto;
using NecromindLibrary.helper;
using NecromindLibrary.repository;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NecromindLibrary.model
{
    /// <summary>
    /// Collection of UI handler methods.
    /// </summary>
    public class UIHandler
    {
        // Placeholder convention for hero's name
        public static string HeroNamePlaceholder { get; private set; } = ConfigurationManager.AppSettings["heroNamePlaceholder"];

        // All the needed UI
        public Dictionary<string, Label> Labels { get; private set; }
        public Dictionary<string, Panel> Panels { get; private set; }
        public Dictionary<string, TextBox> TextBoxes { get; private set; }
        public Dictionary<string, GroupBox> GroupBoxes { get; private set; }
        public RichTextBox ConfirmDeleteText { get; private set; }

        // List of dynamically created buttons while loading saved heroes
        public List<Button> CreatedButtons { get; private set; } = new List<Button>();
        // List of all the loaded heroes as DTOs
        public List<HeroDTO> HeroesAsDTO { get; private set; } = new List<HeroDTO>();

        // The hero which is currently being played
        public HeroModel Hero { get; private set; }

        /// <summary>
        /// Takes all the needed UI from the NecromindUI and stores them as static variables.
        /// </summary>
        /// <param name="panels">A dictionary of panels.</param>
        /// <param name="labels">A dictionary of labels.</param>
        /// <param name="textBoxes">A dictionary of textboxes.</param>
        /// <param name="groupBoxes">A dictionary of groupboxes</param>
        /// <param name="confirmDeleteText">The rich textbox to confirm deleting a hero.</param>
        public void TakeAllUI(Dictionary<string, Panel> panels, Dictionary<string, Label> labels, Dictionary<string, TextBox> textBoxes,
            Dictionary<string, GroupBox> groupBoxes, RichTextBox confirmDeleteText)
        {
            Panels = panels;
            Labels = labels;
            TextBoxes = textBoxes;
            GroupBoxes = groupBoxes;
            ConfirmDeleteText = confirmDeleteText;
        }

        /// <summary>
        /// Resets the game panel to the original values.
        /// </summary>
        public void ResetGame()
        {
            GroupBoxes["heroDetails"].Text = HeroNamePlaceholder + "'s Details";
            GroupBoxes["heroItems"].Text = HeroNamePlaceholder + "'s Items";
            Labels["heroHealth"].Text = "";
            Labels["heroGold"].Text = "";
            Labels["heroXP"].Text = "";
            Labels["heroLevel"].Text = "";
            Labels["heroDamage"].Text = "";
            Labels["heroDefense"].Text = "";
        }

        /// <summary>
        /// Creates a new hero if the name is not already taken.
        /// </summary>
        public void CreateNewHero()
        {
            TextBox newHeroName = TextBoxes["newHeroName"];

            if (!UIHelper.IsNameAlreadyTaken(DataAccess.GetAllHeroesAsDTO(), newHeroName))
            {
                int insertedId = DataAccess.CreateNewHero(newHeroName.Text);

                if (insertedId > 0)
                {
                    Hero = DataAccess.GetHeroById(insertedId);
                    SetHeroDetails();

                    newHeroName.Text = "";
                    Panels["game"].BringToFront();
                }
                else
                {
                    MessageBox.Show("Couldn't connect to the database. Please try again.");
                }
            }
            else
            {
                MessageBox.Show($"The entered name: '{ newHeroName.Text }' is already taken. Please pick another one.");
                newHeroName.Text = "";
            }
            
        }

        /// <summary>
        /// Creates a button for each saved heroes and adds an event to load any of them upon click event. 
        /// </summary>
        public void ShowAllLoadedHeroes()
        {
            HeroesAsDTO = DataAccess.GetAllHeroesAsDTO();

            if (HeroesAsDTO.Count == 0)
            {
                MessageBox.Show("There's no hero yet to load. Create a new one first!");
            }
            else if (HeroesAsDTO.Count() == 1 && HeroesAsDTO.First().Id == 0) // Failed to connect to DB
            {
                MessageBox.Show(HeroesAsDTO.First().Name);
            }
            else
            {
                int btnLoadHeroLocX = 480;
                int btnDeleteHeroLocX = 590;
                int btnLocY = 100;

                foreach (HeroDTO hero in HeroesAsDTO)
                {
                    Button btnLoadHero = UIHelper.CreateButton(
                        hero.Name,
                        "btnLoad" + hero.Name,
                        100,
                        25,
                        btnLoadHeroLocX,
                        btnLocY,
                        Color.FromArgb(211, 84, 0), // Orange color
                        Color.FromArgb(229, 232, 232), // Soft gray-ish white color
                        FlatStyle.Flat
                    );

                    CreatedButtons.Add(btnLoadHero);

                    btnLoadHero.Click += (s, ev) =>
                    {
                        LoadHeroByIdBtn(hero.Id);
                    };

                    Panels["loadGame"].Controls.Add(btnLoadHero);

                    Button btnDeleteHero = UIHelper.CreateButton(
                        "X",
                        "btnDelete" + hero.Name,
                        25,
                        25,
                        btnDeleteHeroLocX,
                        btnLocY,
                        Color.FromArgb(23, 32, 42), // Blue-ish color (exactly like the window background)
                        Color.FromArgb(214, 48, 49), // Red color
                        FlatStyle.Flat
                    );

                    CreatedButtons.Add(btnDeleteHero);

                    btnDeleteHero.Click += (s, ev) =>
                    {
                        DeleteHeroByIdBtn(hero);
                    };

                    btnLocY += 40;

                    Panels["loadGame"].Controls.Add(btnDeleteHero);
                }

                Panels["loadGame"].BringToFront();
            }
        }

        /// <summary>
        /// Gets all the information from the database of a single hero by its ID, sets all the needed labels in the game panel and brings the game panel to the front.
        /// </summary>
        /// <param name="id">ID of hero.</param>
        private void LoadHeroByIdBtn(int id)
        {
            Hero = DataAccess.GetHeroById(id);
            SetHeroDetails();
            Panels["game"].BringToFront();
        }

        /// <summary>
        /// Deletes a hero by ID then reloads the loadGame panel.
        /// </summary>
        /// <param name="hero">A hero as HeroDTO.</param>
        private void DeleteHeroByIdBtn(HeroDTO hero)
        {
            TextBox deleteHeroName = TextBoxes["deleteHeroName"];

            foreach (Control control in Panels["loadGame"].Controls)
            {
                control.Enabled = false;
            }

            ConfirmDeleteText = UIHelper.ApplyCustomStyleToRichTextConfirmDelete(hero.Name, ConfirmDeleteText);
            deleteHeroName.Focus();

            Panels["confirmDelete"].BringToFront();

            deleteHeroName.KeyPress += (s, ev) =>
            {
                // If ENTER is pressed
                if (ev.KeyChar == (char)13)
                {
                    if (deleteHeroName.Text == hero.Name)
                    {
                        if(DataAccess.TryDeleteHeroById(hero.Id))
                        {
                            HeroesAsDTO.Remove(hero);
                            foreach (Button createdButton in CreatedButtons)
                            {
                                Panels["loadGame"].Controls.Remove(createdButton);
                            }

                            ShowAllLoadedHeroes();
                            HideConfirmDeletePanel(hero.Name);

                            if (HeroesAsDTO.Count() == 0)
                            {
                                Panels["menu"].BringToFront();
                            }
                        }
                    }
                }

                // If ESCAPE is pressed
                if (ev.KeyChar == (char)27)
                {
                    HideConfirmDeletePanel(hero.Name);
                }
            };
        }

        /// <summary>
        /// Hides and resets the confirm delete panel and restores controls on the load game panel. 
        /// </summary>
        /// <param name="heroName">Name of the hero which was supposed to be deleted.</param>
        private void HideConfirmDeletePanel(string heroName)
        {
            foreach (Control control in Panels["loadGame"].Controls)
            {
                control.Enabled = true;
            }

            Panels["confirmDelete"].SendToBack();
            TextBoxes["deleteHeroName"].Text = "";
            ConfirmDeleteText.Text = ConfirmDeleteText.Text.Replace(heroName, HeroNamePlaceholder);
        }

        /// <summary>
        /// Sets all the labels and group boxes texts for the hero to the current hero's values.
        /// </summary>
        private void SetHeroDetails()
        {
            GroupBox heroDetails = GroupBoxes["heroDetails"];
            GroupBox heroItems = GroupBoxes["heroItems"];

            if (Hero.Name.EndsWith("s") || Hero.Name.EndsWith("S"))
            {
                heroDetails.Text = heroDetails.Text.Replace(HeroNamePlaceholder + "'s", Hero.Name + "'");
                heroItems.Text = heroItems.Text.Replace(HeroNamePlaceholder + "'s", Hero.Name + "'");
            } 
            else
            {
                heroDetails.Text = heroDetails.Text.Replace(HeroNamePlaceholder, Hero.Name);
                heroItems.Text = heroItems.Text.Replace(HeroNamePlaceholder, Hero.Name);
            }
            
            Labels["heroHealth"].Text = Hero.HitPointsMax.ToString() + " / " + Hero.HitPoints.ToString();
            Labels["heroGold"].Text = Hero.Gold.ToString();
            Labels["heroXP"].Text = Hero.ExperiencePoints.ToString() + " / " + Hero.NextLevelAt.ToString();
            Labels["heroLevel"].Text = Hero.Level.ToString();
            Labels["heroDamage"].Text = Hero.Damage.ToString();
            Labels["heroDefense"].Text = Hero.Defense.ToString();
        }
    }
}
