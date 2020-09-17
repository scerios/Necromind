using NecromindLibrary.dto;
using NecromindLibrary.model;
using NecromindLibrary.repository;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NecromindLibrary.helper
{
    /// <summary>
    /// Collection of UI handler helper methods.
    /// </summary>
    public static class UIHelper
    {
        // Placeholder convention for hero's name
        private static readonly string heroNamePlaceholder = ConfigurationManager.AppSettings["heroNamePlaceholder"];

        private static List<Button> createdButtons;
        private static List<HeroDTO> heroesAsDTO;
        private static HeroModel hero;

        /// <summary>
        /// Resets the game panel to the original values.
        /// </summary>
        /// <param name="labels">A dictionary of labels.</param>
        /// <param name="heroDetails">A group box of hero details.</param>
        public static void ResetGame(Dictionary<string, Label> labels, GroupBox heroDetails)
        {
            heroDetails.Text = heroNamePlaceholder + "'s Details";
            labels["heroHealth"].Text = "";
            labels["heroGold"].Text = "";
            labels["heroXP"].Text = "";
            labels["heroLevel"].Text = "";
            labels["heroDamage"].Text = "";
            labels["heroDefense"].Text = "";
        }

        /// <summary>
        /// Creates a new hero if the name is not already taken.
        /// </summary>
        /// <param name="panels">A dictionary of panels.</param>
        /// <param name="labels">A dictionary of labels.</param>
        /// <param name="heroName">A textbox where the new hero's name is written by the user.</param>
        /// <param name="heroDetails">A group box of hero details.</param>
        public static void CreateNewHero(Dictionary<string, Panel> panels, Dictionary<string, Label> labels, TextBox heroName, GroupBox heroDetails)
        {
            if (!IsNameAlreadyTaken(DataAccess.GetAllHeroesAsDTO(), heroName))
            {
                int insertedId = DataAccess.CreateNewHero(heroName.Text);

                if (insertedId > 0)
                {
                    hero = DataAccess.GetHeroById(insertedId);
                    SetHeroDetails(hero, labels, heroDetails);

                    heroName.Text = "";
                    panels["game"].BringToFront();
                }
                else
                {
                    MessageBox.Show("Couldn't connect to the database. Please try again.");
                }
            }
            else
            {
                MessageBox.Show($"{ heroName.Text } is already taken. Please pick another one.");
                heroName.Text = "";
            }
            
        }

        /// <summary>
        /// Checks among all the heroes if the user given name is already taken.
        /// </summary>
        /// <param name="heroes">A list of heroes as HeroDTO.</param>
        /// <returns>True if name already taken. False otherwise.</returns>
        private static bool IsNameAlreadyTaken(List<HeroDTO> heroes, TextBox heroName)
        {
            bool isNameAlreadyTaken = false;

            foreach (HeroDTO hero in heroes)
            {
                if (hero.Name == heroName.Text)
                {
                    isNameAlreadyTaken = true;
                    break;
                }
            }

            return isNameAlreadyTaken;
        }

        /// <summary>
        /// Creates a button for each saved heroes and adds an event to load any of them upon click event. 
        /// </summary>
        /// <param name="panels">A dictionary of panels.</param>
        /// <param name="labels">A dictionary of labels.</param>
        /// <param name="heroDetails">A group box of hero details.</param>
        /// <param name="heroToDelete">A textbox where the user enters the hero's name which should be deleted.</param>
        /// <param name="textConfirmDelete">A rich textbox with custom style to show user info about deleting hero.</param>
        public static void ShowAllLoadedHeroes(Dictionary<string, Panel> panels, Dictionary<string, Label> labels, GroupBox heroDetails, TextBox heroToDelete, RichTextBox textConfirmDelete)
        {
            List<HeroDTO> heroes = DataAccess.GetAllHeroesAsDTO();

            if (heroes.Count == 0)
            {
                MessageBox.Show("There's no hero yet to load. Create a new one first!");
            }
            else if (heroes.Count() == 1 && heroes.First().Id == 0) // Failed to connect to DB
            {
                MessageBox.Show(heroes.First().Name);
            }
            else
            {
                heroesAsDTO = heroes;
                createdButtons = new List<Button>();

                int btnLoadHeroLocX = 430;
                int btnDeleteHeroLocX = 540;
                int btnLocY = 100;

                foreach (HeroDTO hero in heroes)
                {
                    Button btnLoadHero = CreateButton(
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

                    createdButtons.Add(btnLoadHero);

                    btnLoadHero.Click += (s, ev) =>
                    {
                        LoadHeroByIdBtn(hero.Id, panels, labels, heroDetails);
                    };

                    panels["loadGame"].Controls.Add(btnLoadHero);

                    Button btnDeleteHero = CreateButton(
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

                    createdButtons.Add(btnDeleteHero);

                    btnDeleteHero.Click += (s, ev) =>
                    {
                        DeleteHeroByIdBtn(hero, panels, labels, heroDetails, heroToDelete, textConfirmDelete);
                    };

                    btnLocY += 40;

                    panels["loadGame"].Controls.Add(btnDeleteHero);
                }
                    panels["loadGame"].BringToFront();
            }
        }

        /// <summary>
        /// Gets all the information from the database of a single hero by its ID, sets all the needed labels in the game panel and brings the game panel to the front.
        /// </summary>
        /// <param name="id">ID of hero.</param>
        /// <param name="panels">A dictionary of panels.</param>
        /// <param name="labels">A dictionary of labels.</param>
        /// <param name="heroDetails">A group box of hero details.</param>
        private static void LoadHeroByIdBtn(int id, Dictionary<string, Panel> panels, Dictionary<string, Label> labels, GroupBox heroDetails)
        {
            hero = DataAccess.GetHeroById(id);
            SetHeroDetails(hero, labels, heroDetails);
            panels["game"].BringToFront();
        }

        /// <summary>
        /// Deletes a hero by ID then reloads the loadGame panel.
        /// </summary>
        /// <param name="hero">A hero as HeroDTO.</param>
        /// <param name="panels">A dictionary of panels.</param>
        /// <param name="labels">A dictionary of labels.</param>
        /// <param name="heroDetails">A group box of hero details.</param>
        /// <param name="heroToDelete">A textbox where the user enters the hero's name which should be deleted.</param>
        /// <param name="textConfirmDelete">A rich textbox with custom style to show user info about deleting hero.</param>
        private static void DeleteHeroByIdBtn(HeroDTO hero, Dictionary<string, Panel> panels, Dictionary<string, Label> labels,
                                                GroupBox heroDetails, TextBox heroToDelete, RichTextBox textConfirmDelete)
        {
            foreach (Control control in panels["loadGame"].Controls)
            {
                control.Enabled = false;
            }

            ApplyCustomStyleToRichTextConfirmDelete(hero, textConfirmDelete);
            heroToDelete.Focus();
            panels["confirmDelete"].BringToFront();

            heroToDelete.KeyPress += (s, ev) =>
            {
                // If ENTER is pressed
                if (ev.KeyChar == (char)13)
                {
                    if (heroToDelete.Text == hero.Name)
                    {
                        if(DataAccess.TryDeleteHeroById(hero.Id))
                        {
                            heroesAsDTO.Remove(hero);
                            foreach (Button createdButton in createdButtons)
                            {
                                panels["loadGame"].Controls.Remove(createdButton);
                            }

                            ShowAllLoadedHeroes(panels, labels, heroDetails, heroToDelete, textConfirmDelete);
                            HideConfirmDeletePanel(hero, panels, heroToDelete, textConfirmDelete);
                            if (heroesAsDTO.Count() == 0)
                            {
                                panels["menu"].BringToFront();
                            }
                        }
                    }
                }

                // If ESCAPE is pressed
                if (ev.KeyChar == (char)27)
                {
                    HideConfirmDeletePanel(hero, panels, heroToDelete, textConfirmDelete);
                }
            };
        }

        /// <summary>
        /// Hides and resets the confirm delete panel and restores controls on the load game panel. 
        /// </summary>
        /// <param name="hero">A hero as HeroDTO</param>
        /// <param name="panels">>A dictionary of panels.</param>
        /// <param name="textBoxConfirmDelete">A text box for the user to enter the name of the hero.</param>
        /// <param name="richTextBoxConfirmDelete">A rich text box which shows warning message with custom style to the user.</param>
        private static void HideConfirmDeletePanel(HeroDTO hero, Dictionary<string, Panel> panels, TextBox textBoxConfirmDelete, RichTextBox richTextBoxConfirmDelete)
        {
            foreach (Control control in panels["loadGame"].Controls)
            {
                control.Enabled = true;
            }

            panels["confirmDelete"].SendToBack();
            textBoxConfirmDelete.Text = "";
            richTextBoxConfirmDelete.Text = richTextBoxConfirmDelete.Text.Replace(hero.Name, heroNamePlaceholder);
        }

        /// <summary>
        /// Applies custom style to rich text confirm delete.
        /// </summary>
        /// <param name="hero">A hero as HeroDTO.</param>
        /// <param name="richTextBoxConfirmDelete">A rich text box which shows warning message with custom style to the user.</param>
        private static void ApplyCustomStyleToRichTextConfirmDelete(HeroDTO hero, RichTextBox richTextBoxConfirmDelete)
        {
            richTextBoxConfirmDelete.Text = richTextBoxConfirmDelete.Text.Replace(heroNamePlaceholder, hero.Name);

            int startPositionOfEnter = richTextBoxConfirmDelete.Text.IndexOf("ENTER");
            int startPositionOfEsc = richTextBoxConfirmDelete.Text.IndexOf("ESC");

            Font font = richTextBoxConfirmDelete.Font;
            FontStyle bold = FontStyle.Bold;

            richTextBoxConfirmDelete.SelectAll();
            richTextBoxConfirmDelete.SelectionAlignment = HorizontalAlignment.Center;
            richTextBoxConfirmDelete.Select(26, 6);
            richTextBoxConfirmDelete.SelectionColor = Color.FromArgb(214, 48, 49); // Red color
            richTextBoxConfirmDelete.SelectionFont = new Font(font, bold);
            richTextBoxConfirmDelete.Select(startPositionOfEnter, 5);
            richTextBoxConfirmDelete.SelectionColor = Color.FromArgb(0, 184, 148); // Green color
            richTextBoxConfirmDelete.SelectionFont = new Font(font, bold);
            richTextBoxConfirmDelete.Select(startPositionOfEsc, 3);
            richTextBoxConfirmDelete.SelectionColor = Color.FromArgb(253, 203, 110); // Yellow color
            richTextBoxConfirmDelete.SelectionFont = new Font(font, bold);
        }

        /// <summary>
        /// Creates a button with custom style.
        /// </summary>
        /// <param name="text">Text to show</param>
        /// <param name="name">Name of the button</param>
        /// <param name="sizeX">Size of axis X</param>
        /// <param name="sizeY">Size of axis Y</param>
        /// <param name="locX">Location on axis X</param>
        /// <param name="locY">Location on axis Y</param>
        /// <param name="backColor">Background color</param>
        /// <param name="foreColor">Text color</param>
        /// <param name="style">Button style</param>
        /// <returns></returns>
        private static Button CreateButton(string text, string name, int sizeX, int sizeY, int locX, int locY, Color backColor, Color foreColor, FlatStyle style)
        {
            Button button = new Button();
            button.Text = text;
            button.Name = name;
            button.Size = new Size(sizeX, sizeY);
            button.Location = new Point(locX, locY);
            button.BackColor = backColor;
            button.ForeColor = foreColor;
            button.FlatStyle = style;
            button.Font = new Font(ConfigurationManager.AppSettings["fontStyle"], 10);
            button.Anchor = AnchorStyles.None;
            button.FlatAppearance.BorderSize = 0;

            return button;
        }

        /// <summary>
        /// Sets all the labels and the hero details (group box) text to the current hero's values.
        /// </summary>
        /// <param name="hero">A hero model.</param>
        /// <param name="labels">A dictionary of labels.</param>
        /// <param name="heroDetails">A group box of hero details.</param>
        public static void SetHeroDetails(HeroModel hero, Dictionary<string, Label> labels, GroupBox heroDetails)
        {
            if (hero.Name.EndsWith("s") || hero.Name.EndsWith("S"))
            {
                heroDetails.Text = heroDetails.Text.Replace(heroNamePlaceholder + "'s", hero.Name + "'");
            } 
            else
            {
                heroDetails.Text = heroDetails.Text.Replace(heroNamePlaceholder, hero.Name);
            }
            
            labels["heroHealth"].Text = hero.HitPointsMax.ToString() + " / " + hero.HitPoints.ToString();
            labels["heroGold"].Text = hero.Gold.ToString();
            labels["heroXP"].Text = hero.ExperiencePoints.ToString() + " / " + hero.NextLevelAt.ToString();
            labels["heroLevel"].Text = hero.Level.ToString();
            labels["heroDamage"].Text = hero.Damage.ToString();
            labels["heroDefense"].Text = hero.Defense.ToString();
        }
    }
}
