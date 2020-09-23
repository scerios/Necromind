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
        public static readonly string HeroNamePlaceholder = ConfigurationManager.AppSettings["heroNamePlaceholder"];

        // All the needed panel reference names
        public static readonly string Menu = ConfigurationManager.AppSettings["panelMenu"];
        public static readonly string NewGame = ConfigurationManager.AppSettings["panelNewGame"];
        public static readonly string LoadGame = ConfigurationManager.AppSettings["panelLoadGame"];
        public static readonly string Game = ConfigurationManager.AppSettings["panelGame"];
        public static readonly string ConfirmDelete = ConfigurationManager.AppSettings["panelConfirmDelete"];
        public static readonly string Error = ConfigurationManager.AppSettings["panelError"];

        // All the needed label reference names
        public static readonly string HeroHealth = ConfigurationManager.AppSettings["labelHeroHealth"];
        public static readonly string HeroGold = ConfigurationManager.AppSettings["labelHeroGold"];
        public static readonly string HeroXP = ConfigurationManager.AppSettings["labelHeroXP"];
        public static readonly string HeroLevel = ConfigurationManager.AppSettings["labelHeroLevel"];
        public static readonly string HeroDamage = ConfigurationManager.AppSettings["labelHeroDamage"];
        public static readonly string HeroDefense = ConfigurationManager.AppSettings["labelHeroDefense"];
        public static readonly string ErrorTitle = ConfigurationManager.AppSettings["labelErrorTitle"];
        public static readonly string ErrorMsg = ConfigurationManager.AppSettings["labelErrorMsg"];

        // All the needed textbox reference names
        public static readonly string NewHeroName = ConfigurationManager.AppSettings["textBoxNewHeroName"];
        public static readonly string DeleteHeroName = ConfigurationManager.AppSettings["textBoxDeleteHeroName"];

        // All the needed group box reference names
        public static readonly string HeroDetails = ConfigurationManager.AppSettings["groupBoxHeroDetails"];
        public static readonly string HeroInventory = ConfigurationManager.AppSettings["groupBoxHeroInventory"];
        public static readonly string TargetDetails = ConfigurationManager.AppSettings["groupBoXTargetDetails"];
        public static readonly string TargetInventory = ConfigurationManager.AppSettings["groupBoxTargetInventory"];

        // All the needed button reference names
        public static readonly string DeleteHeroBtn = ConfigurationManager.AppSettings["btnDeleteHero"];

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
        private static List<Button> CreatedButtons = new List<Button>();

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
            GroupBoxes[HeroDetails].Text = HeroNamePlaceholder + "'s Details";
            GroupBoxes[HeroInventory].Text = HeroNamePlaceholder + "'s Items";
            Labels[HeroHealth].Text = "";
            Labels[HeroGold].Text = "";
            Labels[HeroXP].Text = "";
            Labels[HeroLevel].Text = "";
            Labels[HeroDamage].Text = "";
            Labels[HeroDefense].Text = "";
        }

        /// <summary>
        /// Creates a new hero if the name is not already taken.
        /// </summary>
        public static void CreateNewHero()
        {
            TextBox heroName = TextBoxes[NewHeroName];
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

                    Panels[Game].BringToFront();
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
                Panels[Menu].BringToFront();
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

                    Panels[LoadGame].Controls.Add(btnLoadHero);

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

                    Panels[LoadGame].Controls.Add(btnDeleteHero);
                }

                Panels[LoadGame].BringToFront();
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
            Panels[Game].BringToFront();
        }

        /// <summary>
        /// Deletes a hero by ID then reloads the loadGame panel.
        /// </summary>
        /// <param name="hero">A hero.</param>
        private static void DeleteHeroByIdBtn(HeroModel hero)
        {
            TextBox heroName = TextBoxes[DeleteHeroName];

            UIHelper.SetControlsAvailability(Panels[LoadGame].Controls, false);

            ConfirmDeleteText = UIHelper.ApplyCustomStyleToRichTextConfirmDelete(hero.Name, ConfirmDeleteText);
            heroName.Focus();

            Panels[ConfirmDelete].BringToFront();

            heroName.KeyUp += (s, ev) =>
            {
                if (heroName.Text == hero.Name)
                {
                    Buttons[DeleteHeroBtn].Enabled = true;
                }
                else
                {
                    Buttons[DeleteHeroBtn].Enabled = false;
                }
            };

            // TODO - Pressing enter creates bug, sort it out!

            heroName.KeyPress += (s, ev) =>
            {
                switch (ev.KeyChar)
                {
                    case (char)13: // If ENTER is pressed

                        if (Buttons[DeleteHeroBtn].Enabled)
                        {
                            if (DataAccess.TryDeleteRecordById<HeroModel>(HeroesCollection, hero.Id))
                            {
                                foreach (Button createdButton in CreatedButtons)
                                {
                                    Panels[LoadGame].Controls.Remove(createdButton);
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

        /// <summary>
        /// Deletes a record.
        /// </summary>
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
            UIHelper.SetControlsAvailability(Panels[LoadGame].Controls, true);

            Panels[ConfirmDelete].SendToBack();
            TextBoxes[DeleteHeroName].Text = "";
            ConfirmDeleteText.Text = ConfirmDeleteText.Text.Replace(heroName, HeroNamePlaceholder);
        }

        /// <summary>
        /// Sets all the labels and group boxes texts for the hero to the current hero's values.
        /// </summary>
        private static void SetHeroDetails()
        {
            GroupBox details = GroupBoxes[HeroDetails];
            GroupBox inventory = GroupBoxes[HeroInventory];

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
            
            Labels[HeroHealth].Text = Hero.HitPointsMax.ToString() + " / " + Hero.HitPoints.ToString();
            Labels[HeroGold].Text = Hero.Gold.ToString();
            Labels[HeroXP].Text = Hero.ExperiencePoints.ToString() + " / " + Hero.NextLevelAt.ToString();
            Labels[HeroLevel].Text = Hero.Level.ToString();
            Labels[HeroDamage].Text = Hero.Damage.ToString();
            Labels[HeroDefense].Text = Hero.Defense.ToString();
        }
    }
}
