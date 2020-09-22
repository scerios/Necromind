using NecromindLibrary.helper;
using NecromindLibrary.model;
using NecromindLibrary.repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NecromindLibrary.service
{
    /// <summary>
    /// Collection of UI handler methods.
    /// </summary>
    public static class UIHandler
    {
        // Placeholder convention for hero's name
        public static string HeroNamePlaceholder { get; private set; } = ConfigurationManager.AppSettings["heroNamePlaceholder"];

        // All the needed panel reference names
        private static readonly string menu = ConfigurationManager.AppSettings["panelMenu"];
        private static readonly string newGame = ConfigurationManager.AppSettings["panelNewGame"];
        private static readonly string loadGame = ConfigurationManager.AppSettings["panelLoadGame"];
        private static readonly string game = ConfigurationManager.AppSettings["panelGame"];
        private static readonly string confirmDelete = ConfigurationManager.AppSettings["panelConfirmDelete"];
        private static readonly string error = ConfigurationManager.AppSettings["panelError"];

        // All the needed label reference names
        private static readonly string heroHealth = ConfigurationManager.AppSettings["labelHeroHealth"];
        private static readonly string heroGold = ConfigurationManager.AppSettings["labelHeroGold"];
        private static readonly string heroXP = ConfigurationManager.AppSettings["labelHeroXP"];
        private static readonly string heroLevel = ConfigurationManager.AppSettings["labelHeroLevel"];
        private static readonly string heroDamage = ConfigurationManager.AppSettings["labelHeroDamage"];
        private static readonly string heroDefense = ConfigurationManager.AppSettings["labelHeroDefense"];
        private static readonly string errorTitle = ConfigurationManager.AppSettings["labelErrorTitle"];
        private static readonly string errorMsg = ConfigurationManager.AppSettings["labelErrorMsg"];

        // All the needed textbox reference names
        private static readonly string newHeroName = ConfigurationManager.AppSettings["textBoxNewHeroName"];
        private static readonly string deleteHeroName = ConfigurationManager.AppSettings["textBoxDeleteHeroName"];

        // All the needed group box reference names
        private static readonly string heroDetails = ConfigurationManager.AppSettings["groupBoxHeroDetails"];
        private static readonly string heroInventory = ConfigurationManager.AppSettings["groupBoxHeroInventory"];
        private static readonly string targetDetails = ConfigurationManager.AppSettings["groupBoXTargetDetails"];
        private static readonly string targetInventory = ConfigurationManager.AppSettings["groupBoxTargetInventory"];

        // All the needed button reference names
        private static readonly string deleteHero = ConfigurationManager.AppSettings["btnDeleteHero"];

        // Collection name to store heroes.
        private static readonly string HeroesCollection = "heroes";

        // All the needed UI
        public static Dictionary<string, Label> Labels { get; private set; }
        public static Dictionary<string, Panel> Panels { get; private set; }
        public static Dictionary<string, TextBox> TextBoxes { get; private set; }
        public static Dictionary<string, GroupBox> GroupBoxes { get; private set; }
        public static Dictionary<string, Button> Buttons { get; private set; }
        public static RichTextBox ConfirmDeleteText { get; private set; }

        // List of dynamically created buttons while loading saved heroes
        public static List<Button> CreatedButtons { get; private set; } = new List<Button>();

        // The hero which is currently being played
        public static HeroModel Hero { get; private set; }

        // The hero which is about to be deleted
        public static HeroModel HeroToDelete { get; private set; }

        /// <summary>
        /// Takes all the needed UI from the NecromindUI project and stores them as static variables.
        /// </summary>
        /// <param name="panels">A dictionary of panels.</param>
        /// <param name="labels">A dictionary of labels.</param>
        /// <param name="textBoxes">A dictionary of textboxes.</param>
        /// <param name="groupBoxes">A dictionary of groupboxes</param>
        /// <param name="confirmDeleteText">The rich textbox to confirm deleting a hero.</param>
        public static void TakeAllUI(Dictionary<string, Panel> panels, Dictionary<string, Label> labels, Dictionary<string, TextBox> textBoxes,
            Dictionary<string, GroupBox> groupBoxes, Dictionary<string, Button> buttons, RichTextBox confirmDeleteText)
        {
            Panels = panels;
            Labels = labels;
            TextBoxes = textBoxes;
            GroupBoxes = groupBoxes;
            Buttons = buttons;
            ConfirmDeleteText = confirmDeleteText;
        }

        /// <summary>
        /// Resets the game panel to the original values.
        /// </summary>
        public static void ResetGame()
        {
            GroupBoxes[heroDetails].Text = HeroNamePlaceholder + "'s Details";
            GroupBoxes[heroInventory].Text = HeroNamePlaceholder + "'s Items";
            Labels[heroHealth].Text = "";
            Labels[heroGold].Text = "";
            Labels[heroXP].Text = "";
            Labels[heroLevel].Text = "";
            Labels[heroDamage].Text = "";
            Labels[heroDefense].Text = "";
        }

        /// <summary>
        /// Creates a new hero if the name is not already taken.
        /// </summary>
        public static void CreateNewHero()
        {
            TextBox heroName = TextBoxes[newHeroName];
            List<HeroModel> heroes = DataAccess.GetAllRecords<HeroModel>(HeroesCollection);

            if (heroName.Text.Length < 3)
            {
                UIHelper.DisplayError("Name too short", "Name must be at least 3 characters long");
            }
            else if (UIHelper.IsNameAvailable(heroes, heroName.Text))
            {
                Hero = new HeroModel(heroName.Text);
                Guid defaultHeroId = Hero.Id;

                Hero.Id = DataAccess.TryCreateNewRecord(HeroesCollection, Hero);

                if (defaultHeroId != Hero.Id)
                {
                    SetHeroDetails();

                    Panels[game].BringToFront();
                }
            }
            else
            {
                UIHelper.DisplayError("Name unavailable", $"The name: \"{ heroName.Text }\" you entered is already taken. Pick another one.");
            }
            
            heroName.Text = "";
        }

        /// <summary>
        /// Creates 2 buttons for each saved heroes and adds events to load or delete any of them. 
        /// </summary>
        public static void ShowAllLoadedHeroes()
        {
            List<HeroModel> Heroes = DataAccess.GetAllRecords<HeroModel>(HeroesCollection);

            if (Heroes.Count == 0)
            {
                Panels[menu].BringToFront();
                UIHelper.DisplayError("Nothing to load.", "There's no hero yet to load. Create a new one first!");
            }
            else
            {
                int btnLoadHeroLocX = 480;
                int btnDeleteHeroLocX = 590;
                int btnLocY = 100;

                foreach (HeroModel hero in Heroes)
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

                    Panels[loadGame].Controls.Add(btnLoadHero);

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
                        HeroToDelete = hero;
                        DeleteHeroByIdBtn(hero);
                    };

                    btnLocY += 40;

                    Panels[loadGame].Controls.Add(btnDeleteHero);
                }

                Panels[loadGame].BringToFront();
            }
        }

        /// <summary>
        /// Gets all the information from the database of a single hero by its ID, sets all the needed labels in the game panel and brings the game panel to the front.
        /// </summary>
        /// <param name="id">ID of hero.</param>
        private static void LoadHeroByIdBtn(Guid id)
        {
            Hero = DataAccess.GetRecordById<HeroModel>(HeroesCollection, id);
            SetHeroDetails();
            Panels[game].BringToFront();
        }

        /// <summary>
        /// Deletes a hero by ID then reloads the loadGame panel.
        /// </summary>
        /// <param name="hero">A hero.</param>
        private static void DeleteHeroByIdBtn(HeroModel hero)
        {
            TextBox heroName = TextBoxes[deleteHeroName];

            UIHelper.SetControlsAvailability(Panels[loadGame].Controls, false);

            ConfirmDeleteText = UIHelper.ApplyCustomStyleToRichTextConfirmDelete(hero.Name, ConfirmDeleteText);
            heroName.Focus();

            Panels[confirmDelete].BringToFront();

            heroName.KeyUp += (s, ev) =>
            {
                if (heroName.Text == hero.Name)
                {
                    Buttons[deleteHero].Enabled = true;
                }
                else
                {
                    Buttons[deleteHero].Enabled = false;
                }
            };

            heroName.KeyPress += (s, ev) =>
            {
                switch (ev.KeyChar)
                {
                    case (char)13: // If ENTER is pressed

                        if (Buttons[deleteHero].Enabled)
                        {
                            if (DataAccess.TryDeleteRecordById<HeroModel>(HeroesCollection, hero.Id))
                            {
                                foreach (Button createdButton in CreatedButtons)
                                {
                                    Panels[loadGame].Controls.Remove(createdButton);
                                }

                                ShowAllLoadedHeroes();
                                HideConfirmDeletePanel(hero.Name);
                            }
                        }

                        break;

                    case (char)27: // If ESCAPE is pressed

                        HideConfirmDeletePanel(hero.Name);

                        break;
                }
            };
        }

        public static void DeleteHero()
        {
            string heroName = HeroToDelete.Name;
            if (DataAccess.TryDeleteRecordById<HeroModel>(HeroesCollection, HeroToDelete.Id))
            {
                ShowAllLoadedHeroes();
                HideConfirmDeletePanel(heroName);
            }
        }

        /// <summary>
        /// Hides and resets the confirm delete panel and restores controls on the load game panel. 
        /// </summary>
        /// <param name="heroName">Name of the hero which was supposed to be deleted.</param>
        private static void HideConfirmDeletePanel(string heroName)
        {
            HeroToDelete = null;
            UIHelper.SetControlsAvailability(Panels[loadGame].Controls, true);

            Panels[confirmDelete].SendToBack();
            TextBoxes[deleteHeroName].Text = "";
            ConfirmDeleteText.Text = ConfirmDeleteText.Text.Replace(heroName, HeroNamePlaceholder);
        }

        /// <summary>
        /// Sets all the labels and group boxes texts for the hero to the current hero's values.
        /// </summary>
        private static void SetHeroDetails()
        {
            GroupBox details = GroupBoxes[heroDetails];
            GroupBox inventory = GroupBoxes[heroInventory];

            if (Hero.Name.EndsWith("s") || Hero.Name.EndsWith("S"))
            {
                details.Text = details.Text.Replace(HeroNamePlaceholder + "'s", Hero.Name + "'");
                inventory.Text = inventory.Text.Replace(HeroNamePlaceholder + "'s", Hero.Name + "'");
            } 
            else
            {
                details.Text = details.Text.Replace(HeroNamePlaceholder, Hero.Name);
                inventory.Text = inventory.Text.Replace(HeroNamePlaceholder, Hero.Name);
            }
            
            Labels[heroHealth].Text = Hero.HitPointsMax.ToString() + " / " + Hero.HitPoints.ToString();
            Labels[heroGold].Text = Hero.Gold.ToString();
            Labels[heroXP].Text = Hero.ExperiencePoints.ToString() + " / " + Hero.NextLevelAt.ToString();
            Labels[heroLevel].Text = Hero.Level.ToString();
            Labels[heroDamage].Text = Hero.Damage.ToString();
            Labels[heroDefense].Text = Hero.Defense.ToString();
        }
    }
}
