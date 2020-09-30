using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using NecromindLibrary.helper;
using NecromindLibrary.model;
using NecromindLibrary.repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Windows.Forms;

namespace NecromindLibrary.service
{
    /// <summary>
    /// Collection of UI handler methods.
    /// </summary>
    public class UIHandler
    {
        private UIHelper UIHelper;
        private DataAccess DataAccess;
        private GameLogic GameLogic;
        private MenuLogic MenuLogic;
        
        #region Configuration Settings

        // Placeholder convention for hero's name
        public readonly string HeroNamePlaceholder = ConfigurationManager.AppSettings["heroNamePlaceholder"];
        public readonly string TargetNamePlaceholder = ConfigurationManager.AppSettings["targetNamePlaceholder"];

        // All the needed panel reference names
        public readonly string Menu = ConfigurationManager.AppSettings["panelMenu"];
        public readonly string NewGame = ConfigurationManager.AppSettings["panelNewGame"];
        public readonly string LoadGame = ConfigurationManager.AppSettings["panelLoadGame"];
        public readonly string Game = ConfigurationManager.AppSettings["panelGame"];
        public readonly string ConfirmDelete = ConfigurationManager.AppSettings["panelConfirmDelete"];

        public readonly string Error = ConfigurationManager.AppSettings["panelError"];

        public readonly string Location = ConfigurationManager.AppSettings["panelLocation"];
        public readonly string Vendor = ConfigurationManager.AppSettings["panelVendor"];

        public readonly string Trade = ConfigurationManager.AppSettings["panelTrade"];
        public readonly string QuestHandle = ConfigurationManager.AppSettings["panelQuestHandle"];
        public readonly string Fight = ConfigurationManager.AppSettings["panelFight"];

        // All the needed label reference names
        public readonly string HeroHealth = ConfigurationManager.AppSettings["labelHeroHealth"];
        public readonly string HeroGold = ConfigurationManager.AppSettings["labelHeroGold"];
        public readonly string HeroXP = ConfigurationManager.AppSettings["labelHeroXP"];
        public readonly string HeroLevel = ConfigurationManager.AppSettings["labelHeroLevel"];
        public readonly string HeroDamage = ConfigurationManager.AppSettings["labelHeroDamage"];
        public readonly string HeroDefense = ConfigurationManager.AppSettings["labelHeroDefense"];

        public readonly string ErrorTitle = ConfigurationManager.AppSettings["labelErrorTitle"];
        public readonly string ErrorMsg = ConfigurationManager.AppSettings["labelErrorMsg"];

        // All the needed textbox reference names
        public readonly string NewHeroName = ConfigurationManager.AppSettings["textBoxNewHeroName"];
        public readonly string DeleteHeroName = ConfigurationManager.AppSettings["textBoxDeleteHeroName"];

        // All the needed rich textbox reference names
        public readonly string ConfirmDeleteText = ConfigurationManager.AppSettings["richTextBoxConfirmDelete"];
        public readonly string EventLog = ConfigurationManager.AppSettings["richTextBoxEventLog"];

        // All the needed group box reference names
        public readonly string HeroDetails = ConfigurationManager.AppSettings["groupBoxHeroDetails"];
        public readonly string HeroInventory = ConfigurationManager.AppSettings["groupBoxHeroInventory"];
        public readonly string HeroQuests = ConfigurationManager.AppSettings["groupBoxHeroQuests"];

        public readonly string TargetDetails = ConfigurationManager.AppSettings["groupBoXTargetDetails"];
        public readonly string TargetInventory = ConfigurationManager.AppSettings["groupBoxTargetInventory"];
        public readonly string TargetQuests = ConfigurationManager.AppSettings["groupBoxTargetQuests"];

        // All the needed listbox reference names
        public readonly string HeroActiveQuests = ConfigurationManager.AppSettings["listBoxHeroActiveQuests"];
        public readonly string HeroItems = ConfigurationManager.AppSettings["listBoxHeroItems"];

        public readonly string TargetAvailableQuests = ConfigurationManager.AppSettings["listBoxTargetAvailableQuests"];
        public readonly string TargetItems = ConfigurationManager.AppSettings["listBoxTargetItems"];

        // All the needed button reference names
        public readonly string BtnDeleteHero = ConfigurationManager.AppSettings["btnDeleteHero"];

        public readonly string BtnBrangor = ConfigurationManager.AppSettings["btnBrangor"];
        public readonly string BtnShoj = ConfigurationManager.AppSettings["btnShoj"];
        public readonly string BtnViascen = ConfigurationManager.AppSettings["btnViascen"];

        public readonly string BtnTown = ConfigurationManager.AppSettings["btnTown"];
        public readonly string BtnOutskirts = ConfigurationManager.AppSettings["btnOutskirts"];
        public readonly string BtnMonastery = ConfigurationManager.AppSettings["btnMonastery"];

        public readonly string BtnBuy = ConfigurationManager.AppSettings["btnBuy"];
        public readonly string BtnSell = ConfigurationManager.AppSettings["btnSell"];

        public readonly string BtnAccept = ConfigurationManager.AppSettings["btnAccept"];
        public readonly string BtnComplete = ConfigurationManager.AppSettings["btnComplete"];

        public readonly string BtnAttack = ConfigurationManager.AppSettings["btnAttack"];
        public readonly string BtnFortify = ConfigurationManager.AppSettings["btnFortify"];
        public readonly string BtnUseItem = ConfigurationManager.AppSettings["btnUseItem"];

        public readonly string BtnForward = ConfigurationManager.AppSettings["btnForward"];

        #endregion

        // Collection name to store heroes.
        public readonly string HeroesCollection = ConfigurationManager.AppSettings["heroesCollection"];

        #region UI collections

        // All the needed UI
        public Dictionary<string, Panel> Panels { get; private set; }
        public Dictionary<string, Label> Labels { get; private set; }
        public Dictionary<string, TextBox> TextBoxes { get; private set; }
        public Dictionary<string, RichTextBox> RichTextBoxes { get; private set; }
        public Dictionary<string, GroupBox> GroupBoxes { get; private set; }
        public Dictionary<string, ListBox> ListBoxes { get; private set; }
        public Dictionary<string, Button> Buttons { get; private set; }

        #endregion

        // List of dynamically created buttons while loading saved heroes
        private List<Button> CreatedButtons = new List<Button>();

        public UIHandler()
        {
            UIHelper = new UIHelper(this);
            DataAccess = new DataAccess(UIHelper);
            GameLogic = new GameLogic(this, UIHelper);
            MenuLogic = new MenuLogic(this, UIHelper, DataAccess, GameLogic);
        }

        /// <summary>
        /// Takes all the needed UI from the NecromindUI project and stores them as variables.
        /// </summary>
        /// <param name="panels">A dictionary of panels.</param>
        /// <param name="labels">A dictionary of labels.</param>
        /// <param name="textBoxes">A dictionary of textboxes.</param>
        /// <param name="richTextBoxes">A dictionary of rich textboxes.</param>
        /// <param name="groupBoxes">A dictionary of group boxes.</param>
        /// <param name="listBoxes">A dictionary of listboxes.</param>
        /// <param name="buttons">A dictionary of buttons.</param>
        public void TakeAllUI(Dictionary<string, Panel> panels, Dictionary<string, Label> labels, Dictionary<string, TextBox> textBoxes,
            Dictionary<string, RichTextBox> richTextBoxes, Dictionary<string, GroupBox> groupBoxes, Dictionary<string, ListBox> listBoxes, Dictionary<string, Button> buttons)
        {
            Panels = panels;
            Labels = labels;
            TextBoxes = textBoxes;
            RichTextBoxes = richTextBoxes;
            GroupBoxes = groupBoxes;
            ListBoxes = listBoxes;
            Buttons = buttons;
        }

        /// <summary>
        /// Resets the game panel to the original values.
        /// </summary>
        public void ResetGameTexts()
        {
            GroupBoxes[HeroDetails].Text = HeroNamePlaceholder + "'s Details";
            GroupBoxes[HeroInventory].Text = HeroNamePlaceholder + "'s Inventory";
            GroupBoxes[HeroQuests].Text = HeroNamePlaceholder + "'s Quests";

            GroupBoxes[TargetDetails].Text = TargetNamePlaceholder + "'s Details";
            GroupBoxes[TargetInventory].Text = TargetNamePlaceholder + "'s Inventory";
            GroupBoxes[TargetQuests].Text = TargetNamePlaceholder + "'s Quests";

            RichTextBoxes[EventLog].Text = "";
            Labels[HeroHealth].Text = "";
            Labels[HeroGold].Text = "";
            Labels[HeroXP].Text = "";
            Labels[HeroLevel].Text = "";
            Labels[HeroDamage].Text = "";
            Labels[HeroDefense].Text = "";
        }

        /// <summary>
        /// Creates 2 buttons for each saved heroes and adds events to load or delete any of them. 
        /// </summary>
        public void ShowAllLoadedHeroes()
        {
            foreach (Button button in CreatedButtons)
            {
                Panels[LoadGame].Controls.Remove(button);
            }

            List<HeroModel> Heroes = DataAccess.GetAllRecords<HeroModel>(HeroesCollection);

            if (Heroes.Count == 0)
            {
                BringSelectedPanelToFront(Menu);
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
                        MenuLogic.SetHeroToDelete(hero);
                        DeleteHeroByIdBtn(hero);
                    };

                    btnLocY += 40;

                    Panels[LoadGame].Controls.Add(btnDeleteHero);
                }

                BringSelectedPanelToFront(LoadGame);
            }
        }

        /// <summary>
        /// Gets all the information from the database of a single hero by its ID, sets all the needed labels in the game panel and brings the game panel to the front.
        /// </summary>
        /// <param name="id">ID of hero.</param>
        private void LoadHeroByIdBtn(Guid id)
        {
            GameLogic.Hero = DataAccess.GetRecordById<HeroModel>(HeroesCollection, id);
            SetHeroDetails();
            BringSelectedPanelToFront(Game);
            GameLogic.StartGame();
        }

        /// <summary>
        /// Deletes a hero by ID then reloads the loadGame panel.
        /// </summary>
        /// <param name="hero">A hero.</param>
        private void DeleteHeroByIdBtn(HeroModel hero)
        {
            TextBox heroName = TextBoxes[DeleteHeroName];

            UIHelper.SetControlsAvailability(Panels[LoadGame].Controls, false);

            RichTextBoxes[ConfirmDeleteText] = UIHelper.ApplyCustomStyleToRichTextConfirmDelete(hero.Name, RichTextBoxes[ConfirmDeleteText]);
            heroName.Focus();

            BringSelectedPanelToFront(ConfirmDelete);

            heroName.KeyUp += (s, ev) =>
            {
                Buttons[BtnDeleteHero].Enabled = heroName.Text == hero.Name;
            };

            heroName.KeyDown += (s, ev) =>
            {
                switch (ev.KeyCode)
                {
                    case Keys.Enter: // If ENTER is pressed

                        if (Buttons[BtnDeleteHero].Enabled)
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
                        else
                        {
                            ev.SuppressKeyPress = true;
                        }

                        break;

                    case Keys.Escape: // If ESCAPE is pressed

                        HideConfirmDeletePanel(hero.Name);

                        break;
                }
            };
        }

        /// <summary>
        /// Hides and resets the confirm delete panel and restores controls on the load game panel. 
        /// </summary>
        /// <param name="heroName">Name of the hero which was supposed to be deleted.</param>
        public void HideConfirmDeletePanel(string heroName)
        {
            MenuLogic.SetHeroToDelete(null);
            UIHelper.SetControlsAvailability(Panels[LoadGame].Controls, true);

            SendSelectedPanelToBack(ConfirmDelete);

            TextBoxes[DeleteHeroName].Text = "";
            RichTextBoxes[ConfirmDeleteText].Text = RichTextBoxes[ConfirmDeleteText].Text.Replace(heroName, HeroNamePlaceholder);
        }

        /// <summary>
        /// Sets all the labels and group boxes texts for the hero to the current hero's values.
        /// </summary>
        public void SetHeroDetails()
        {
            GroupBox details = GroupBoxes[HeroDetails];
            GroupBox inventory = GroupBoxes[HeroInventory];
            GroupBox quests = GroupBoxes[HeroQuests];

            if (GameLogic.Hero.Name.EndsWith("s") || GameLogic.Hero.Name.EndsWith("S"))
            {
                details.Text = details.Text.Replace(HeroNamePlaceholder + "'s", GameLogic.Hero.Name + "'");
                inventory.Text = inventory.Text.Replace(HeroNamePlaceholder + "'s", GameLogic.Hero.Name + "'");
                quests.Text = quests.Text.Replace(HeroNamePlaceholder + "'s", GameLogic.Hero.Name + "'");
            } 
            else
            {
                details.Text = details.Text.Replace(HeroNamePlaceholder, GameLogic.Hero.Name);
                inventory.Text = inventory.Text.Replace(HeroNamePlaceholder, GameLogic.Hero.Name);
                quests.Text = quests.Text.Replace(HeroNamePlaceholder, GameLogic.Hero.Name);
            }
            
            Labels[HeroHealth].Text = GameLogic.Hero.HitPointsMax.ToString() + " / " + GameLogic.Hero.HitPoints.ToString();
            Labels[HeroGold].Text = GameLogic.Hero.Gold.ToString();
            Labels[HeroXP].Text = GameLogic.Hero.ExperiencePoints.ToString() + " / " + GameLogic.Hero.NextLevelAt.ToString();
            Labels[HeroLevel].Text = GameLogic.Hero.Level.ToString();
            Labels[HeroDamage].Text = GameLogic.Hero.Damage.ToString();
            Labels[HeroDefense].Text = GameLogic.Hero.Defense.ToString();
        }

        /// <summary>
        /// Brings the selected panel to the front.
        /// </summary>
        /// <param name="panelName">Name of the panel.</param>
        public void BringSelectedPanelToFront(string panelName)
        {
            Panels[panelName].BringToFront();
        }

        /// <summary>
        /// Sends the selected panel to the back.
        /// </summary>
        /// <param name="panelName">Name of the panel.</param>
        public void SendSelectedPanelToBack(string panelName)
        {
            Panels[panelName].SendToBack();
        }
    }
}
