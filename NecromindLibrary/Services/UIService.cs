//using NecromindLibrary.model;
//using System.Collections;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Drawing;
//using System.Windows.Forms;

//namespace NecromindLibrary.service
//{
//    public class UIService
//    {
//        private static UIService _instance;

//        #region Configuration Settings

//        // Placeholder convention for hero's name
//        public readonly string HeroNamePlaceholder = ConfigurationManager.AppSettings["heroNamePlaceholder"];
//        public readonly string TargetNamePlaceholder = ConfigurationManager.AppSettings["targetNamePlaceholder"];

//        // All the needed panel reference names
//        public readonly string Menu = ConfigurationManager.AppSettings["panelMenu"];
//        public readonly string NewGame = ConfigurationManager.AppSettings["panelNewGame"];
//        public readonly string LoadGame = ConfigurationManager.AppSettings["panelLoadGame"];
//        public readonly string Game = ConfigurationManager.AppSettings["panelGame"];
//        public readonly string ConfirmDelete = ConfigurationManager.AppSettings["panelConfirmDelete"];

//        public readonly string Error = ConfigurationManager.AppSettings["panelError"];

//        public readonly string Location = ConfigurationManager.AppSettings["panelLocation"];
//        public readonly string Vendor = ConfigurationManager.AppSettings["panelVendor"];

//        public readonly string Trade = ConfigurationManager.AppSettings["panelTrade"];
//        public readonly string QuestHandle = ConfigurationManager.AppSettings["panelQuestHandle"];
//        public readonly string Fight = ConfigurationManager.AppSettings["panelFight"];

//        // All the needed label reference names
//        public readonly string HeroHealth = ConfigurationManager.AppSettings["labelHeroHealth"];
//        public readonly string HeroMaxHealth = ConfigurationManager.AppSettings["labelHeroMaxHealth"];
//        public readonly string HeroGold = ConfigurationManager.AppSettings["labelHeroGold"];
//        public readonly string HeroXP = ConfigurationManager.AppSettings["labelHeroXP"];
//        public readonly string HeroNextLevelAt = ConfigurationManager.AppSettings["labelHeroNextLevelAt"];
//        public readonly string HeroLevel = ConfigurationManager.AppSettings["labelHeroLevel"];
//        public readonly string HeroDamage = ConfigurationManager.AppSettings["labelHeroDamage"];
//        public readonly string HeroDefense = ConfigurationManager.AppSettings["labelHeroDefense"];

//        public readonly string ErrorTitle = ConfigurationManager.AppSettings["labelErrorTitle"];
//        public readonly string ErrorMsg = ConfigurationManager.AppSettings["labelErrorMsg"];

//        // All the needed textbox reference names
//        public readonly string NewHeroName = ConfigurationManager.AppSettings["textBoxNewHeroName"];
//        public readonly string DeleteHeroName = ConfigurationManager.AppSettings["textBoxDeleteHeroName"];

//        // All the needed rich textbox reference names
//        public readonly string ConfirmDeleteText = ConfigurationManager.AppSettings["richTextBoxConfirmDelete"];
//        public readonly string EventLog = ConfigurationManager.AppSettings["richTextBoxEventLog"];

//        // All the needed group box reference names
//        public readonly string HeroDetails = ConfigurationManager.AppSettings["groupBoxHeroDetails"];
//        public readonly string HeroInventory = ConfigurationManager.AppSettings["groupBoxHeroInventory"];
//        public readonly string HeroQuests = ConfigurationManager.AppSettings["groupBoxHeroQuests"];

//        public readonly string TargetDetails = ConfigurationManager.AppSettings["groupBoXTargetDetails"];
//        public readonly string TargetInventory = ConfigurationManager.AppSettings["groupBoxTargetInventory"];
//        public readonly string TargetQuests = ConfigurationManager.AppSettings["groupBoxTargetQuests"];

//        // All the needed listbox reference names
//        public readonly string HeroActiveQuests = ConfigurationManager.AppSettings["listBoxHeroActiveQuests"];
//        public readonly string HeroItems = ConfigurationManager.AppSettings["listBoxHeroItems"];

//        public readonly string TargetAvailableQuests = ConfigurationManager.AppSettings["listBoxTargetAvailableQuests"];
//        public readonly string TargetItems = ConfigurationManager.AppSettings["listBoxTargetItems"];

//        // All the needed button reference names
//        public readonly string BtnDeleteHero = ConfigurationManager.AppSettings["btnDeleteHero"];

//        public readonly string BtnBrangor = ConfigurationManager.AppSettings["btnBrangor"];
//        public readonly string BtnShoj = ConfigurationManager.AppSettings["btnShoj"];
//        public readonly string BtnViascen = ConfigurationManager.AppSettings["btnViascen"];

//        public readonly string BtnTown = ConfigurationManager.AppSettings["btnTown"];
//        public readonly string BtnOutskirts = ConfigurationManager.AppSettings["btnOutskirts"];
//        public readonly string BtnMonastery = ConfigurationManager.AppSettings["btnMonastery"];

//        public readonly string BtnBuy = ConfigurationManager.AppSettings["btnBuy"];
//        public readonly string BtnSell = ConfigurationManager.AppSettings["btnSell"];

//        public readonly string BtnAccept = ConfigurationManager.AppSettings["btnAccept"];
//        public readonly string BtnComplete = ConfigurationManager.AppSettings["btnComplete"];

//        public readonly string BtnAttack = ConfigurationManager.AppSettings["btnAttack"];
//        public readonly string BtnFortify = ConfigurationManager.AppSettings["btnFortify"];
//        public readonly string BtnUseItem = ConfigurationManager.AppSettings["btnUseItem"];

//        public readonly string BtnForward = ConfigurationManager.AppSettings["btnForward"];

//        #endregion

//        #region UI collections

//        // All the needed UI
//        public Dictionary<string, Panel> Panels { get; private set; }
//        public Dictionary<string, Label> Labels { get; private set; }
//        public Dictionary<string, TextBox> TextBoxes { get; private set; }
//        public Dictionary<string, RichTextBox> RichTextBoxes { get; private set; }
//        public Dictionary<string, GroupBox> GroupBoxes { get; private set; }
//        public Dictionary<string, ListBox> ListBoxes { get; private set; }
//        public Dictionary<string, Button> Buttons { get; private set; }

//        #endregion

//        private UIService()
//        {
//        }

//        /// <summary>
//        /// Returns the only instance which was created due to singleton pattern.
//        /// </summary>
//        /// <returns>The only UIService instance.</returns>
//        public static UIService GetInstance()
//        {
//            if (_instance == null)
//            {
//                _instance = new UIService();
//            }

//            return _instance;
//        }

//        /// <summary>
//        /// Takes all the needed UI from the NecromindUI project and stores them as variables.
//        /// </summary>
//        /// <param name="panels">A dictionary of panels.</param>
//        /// <param name="labels">A dictionary of labels.</param>
//        /// <param name="textBoxes">A dictionary of textboxes.</param>
//        /// <param name="richTextBoxes">A dictionary of rich textboxes.</param>
//        /// <param name="groupBoxes">A dictionary of group boxes.</param>
//        /// <param name="listBoxes">A dictionary of listboxes.</param>
//        /// <param name="buttons">A dictionary of buttons.</param>
//        public void TakeAllUI(Dictionary<string, Panel> panels, Dictionary<string, Label> labels, Dictionary<string, TextBox> textBoxes,
//            Dictionary<string, RichTextBox> richTextBoxes, Dictionary<string, GroupBox> groupBoxes, Dictionary<string, ListBox> listBoxes, Dictionary<string, Button> buttons)
//        {
//            Panels = panels;
//            Labels = labels;
//            TextBoxes = textBoxes;
//            RichTextBoxes = richTextBoxes;
//            GroupBoxes = groupBoxes;
//            ListBoxes = listBoxes;
//            Buttons = buttons;
//        }

//        /// <summary>
//        /// Resets the game panel to the original values.
//        /// </summary>
//        public void ResetGameTexts()
//        {
//            GroupBoxes[HeroDetails].Text = HeroNamePlaceholder + "'s Details";
//            GroupBoxes[HeroInventory].Text = HeroNamePlaceholder + "'s Inventory";
//            GroupBoxes[HeroQuests].Text = HeroNamePlaceholder + "'s Quests";

//            GroupBoxes[TargetDetails].Text = TargetNamePlaceholder + "'s Details";
//            GroupBoxes[TargetInventory].Text = TargetNamePlaceholder + "'s Inventory";
//            GroupBoxes[TargetQuests].Text = TargetNamePlaceholder + "'s Quests";

//            RichTextBoxes[EventLog].Text = "";
//            Labels[HeroMaxHealth].Text = "";
//            Labels[HeroHealth].Text = "";
//            Labels[HeroGold].Text = "";
//            Labels[HeroNextLevelAt].Text = "";
//            Labels[HeroXP].Text = "";
//            Labels[HeroLevel].Text = "";
//            Labels[HeroDamage].Text = "";
//            Labels[HeroDefense].Text = "";
//        }

//        /// <summary>
//        /// Sets all the labels and group boxes texts for the hero to the current hero's values.
//        /// </summary>
//        public void SetHeroDetails(HeroModel hero)
//        {
//            GroupBox details = GroupBoxes[HeroDetails];
//            GroupBox inventory = GroupBoxes[HeroInventory];
//            GroupBox quests = GroupBoxes[HeroQuests];

//            if (hero.Name.EndsWith("s") || hero.Name.EndsWith("S"))
//            {
//                details.Text = details.Text.Replace(HeroNamePlaceholder + "'s", hero.Name + "'");
//                inventory.Text = inventory.Text.Replace(HeroNamePlaceholder + "'s", hero.Name + "'");
//                quests.Text = quests.Text.Replace(HeroNamePlaceholder + "'s", hero.Name + "'");
//            }
//            else
//            {
//                details.Text = details.Text.Replace(HeroNamePlaceholder, hero.Name);
//                inventory.Text = inventory.Text.Replace(HeroNamePlaceholder, hero.Name);
//                quests.Text = quests.Text.Replace(HeroNamePlaceholder, hero.Name);
//            }

//            Labels[HeroMaxHealth].Text = hero.HealthPointsMax.ToString();
//            Labels[HeroHealth].Text = hero.HealthPoints.ToString();
//            Labels[HeroGold].Text = hero.Gold.ToString();
//            Labels[HeroNextLevelAt].Text = hero.NextLevelAt.ToString();
//            Labels[HeroXP].Text = hero.ExperiencePoints.ToString();
//            Labels[HeroLevel].Text = hero.Level.ToString();
//            Labels[HeroDamage].Text = hero.Damage.ToString();
//            Labels[HeroDefense].Text = hero.Defense.ToString();
//        }

//        /// <summary>
//        /// Displays an error window with custom title and message. Also formats the message to add linebreaks.
//        /// </summary>
//        /// <param name="title">Title of the error.</param>
//        /// <param name="msg">Message of the error.</param>
//        public void DisplayError(string title, string msg)
//        {
//            msg = FormatErrorMsg(msg);
//            Labels[ErrorTitle].Text = title;
//            Labels[ErrorMsg].Text = msg;
//            BringPanelToFront(Error);
//        }

//        /// <summary>
//        /// Brings the selected panel to the front.
//        /// </summary>
//        /// <param name="panelName">Name of the panel.</param>
//        public void BringPanelToFront(string panelName)
//        {
//            Panels[panelName].BringToFront();
//        }

//        /// <summary>
//        /// Sends the selected panel to the back.
//        /// </summary>
//        /// <param name="panelName">Name of the panel.</param>
//        public void SendPanelToBack(string panelName)
//        {
//            Panels[panelName].SendToBack();
//        }

//        /// <summary>
//        /// Hides and resets the confirm delete panel and restores controls on the load game panel.
//        /// </summary>
//        /// <param name="heroName">Name of the hero which was supposed to be deleted.</param>
//        public void HideConfirmDeletePanel(string heroName)
//        {
//            SetControlsAvailability(Panels[LoadGame].Controls, true);

//            SendPanelToBack(ConfirmDelete);

//            TextBoxes[DeleteHeroName].Text = "";
//            RichTextBoxes[ConfirmDeleteText].Text = RichTextBoxes[ConfirmDeleteText].Text.Replace(heroName, HeroNamePlaceholder);
//        }

//        /// <summary>
//        /// Applies custom style to rich text confirm delete.
//        /// </summary>
//        /// <param name="heroName">Name of the hero which is supposed to be deleted.</param>
//        public RichTextBox ApplyCustomStyleToRichTextConfirmDelete(string heroName, RichTextBox confirmDeleteText)
//        {
//            confirmDeleteText.Text = confirmDeleteText.Text.Replace(HeroNamePlaceholder, heroName);

//            int startPositionOfEnter = confirmDeleteText.Text.IndexOf("ENTER");
//            int startPositionOfEsc = confirmDeleteText.Text.IndexOf("ESC");

//            Font font = confirmDeleteText.Font;
//            FontStyle bold = FontStyle.Bold;

//            confirmDeleteText.SelectAll();
//            confirmDeleteText.SelectionAlignment = HorizontalAlignment.Center;
//            confirmDeleteText.Select(26, 6);
//            confirmDeleteText.SelectionColor = Color.FromArgb(214, 48, 49); // Red color
//            confirmDeleteText.SelectionFont = new Font(font, bold);
//            confirmDeleteText.Select(startPositionOfEnter, 5);
//            confirmDeleteText.SelectionColor = Color.FromArgb(0, 184, 148); // Green color
//            confirmDeleteText.SelectionFont = new Font(font, bold);
//            confirmDeleteText.Select(startPositionOfEsc, 3);
//            confirmDeleteText.SelectionColor = Color.FromArgb(253, 203, 110); // Yellow color
//            confirmDeleteText.SelectionFont = new Font(font, bold);

//            return confirmDeleteText;
//        }

//        /// <summary>
//        /// Creates a button with custom style.
//        /// </summary>
//        /// <param name="text">Text to show</param>
//        /// <param name="name">Name of the button</param>
//        /// <param name="sizeX">Size of axis X</param>
//        /// <param name="sizeY">Size of axis Y</param>
//        /// <param name="locX">Location on axis X</param>
//        /// <param name="locY">Location on axis Y</param>
//        /// <param name="backColor">Background color</param>
//        /// <param name="foreColor">Text color</param>
//        /// <param name="style">Button style</param>
//        /// <returns></returns>
//        public Button CreateButton(string text, string name, int sizeX, int sizeY, int locX, int locY, Color backColor, Color foreColor, FlatStyle style)
//        {
//            Button button = new Button();
//            button.Text = text;
//            button.Name = name;
//            button.Size = new Size(sizeX, sizeY);
//            button.Location = new Point(locX, locY);
//            button.BackColor = backColor;
//            button.ForeColor = foreColor;
//            button.FlatStyle = style;
//            button.Font = new Font(ConfigurationManager.AppSettings["fontStyle"], 10);
//            button.Anchor = AnchorStyles.None;
//            button.FlatAppearance.BorderSize = 0;

//            return button;
//        }

//        /// <summary>
//        /// Sets the controls availability.
//        /// </summary>
//        /// <param name="controls">A list of controls which should be enabled/disabled.</param>
//        /// <param name="isAvailable">True if controls should be enabled. False otherwise.</param>
//        public void SetControlsAvailability(Control.ControlCollection controls, bool isAvailable)
//        {
//            foreach (Control control in controls)
//            {
//                control.Enabled = isAvailable;
//            }
//        }

//        /// <summary>
//        /// Adds the button to the panels control.
//        /// </summary>
//        /// <param name="button"></param>
//        /// <param name="panelName"></param>
//        public void AddButtonToPanelControl(Button button, string panelName)
//        {
//            Panels[panelName].Controls.Add(button);
//        }

//        /// <summary>
//        /// Removes the control of selected buttons from selected panel.
//        /// </summary>
//        /// <param name="buttons">List of buttons to remove.</param>
//        /// <param name="panelName">Name of the panel.</param>
//        public void RemoveButtonControlsFromPanel(List<Button> buttons, string panelName)
//        {
//            foreach (Button button in buttons)
//            {
//                Panels[panelName].Controls.Remove(button);
//            }
//        }

//        /// <summary>
//        /// Displays an error window with custom title and message.
//        /// </summary>
//        /// <param name="title">Title of the error window.</param>
//        /// <param name="msg">Message of the error.</param>
//        private string FormatErrorMsg(string msg)
//        {
//            int i = 25;

//            // Adds linebreaks to the msg to display it correctly
//            while (i < msg.Length - 10)
//            {
//                string msgPartToBreak = msg.Substring(i, 10);
//                int index = msgPartToBreak.IndexOf(" ");
//                index = i + index;

//                char[] chars = msg.ToCharArray();
//                chars[index] = '\n';
//                msg = new string(chars);

//                i += 25;
//            }
//            return msg;
//        }

//        /// <summary>
//        /// Sets a buttons enabled property. By default the enabled color will be standard blue-ish. Optional: enabled color.
//        /// </summary>
//        /// <param name="button">Button which about to be set.</param>
//        /// <param name="isAvailable">True if available. False otherwise.</param>
//        /// <param name="color">Optional. If set this will be the enabled color.</param>
//        /// <returns></returns>
//        public void SetButtonAvailability(Button button, bool isAvailable, Color color = default)
//        {
//            button.Enabled = isAvailable;

//            if (color == default)
//            {
//                button.BackColor = isAvailable ? Color.FromArgb(11, 84, 100) : Color.FromArgb(127, 140, 141);
//            }
//            else
//            {
//                button.BackColor = isAvailable ? color : Color.FromArgb(127, 140, 141);
//            }
//        }

//        /// <summary>
//        /// Sets the event log text.
//        /// </summary>
//        /// <param name="text">The text which shall be written.</param>
//        /// <param name="isAppend">True if text should be appended. False if text should be replaced.</param>
//        /// <param name="isAddLinebreak">True if a linebreak should be appended. False otherwise.</param>
//        public void SetEventLogText(string text, bool isAppend = false, bool isAddLinebreak = false)
//        {
//            string eventLogText = RichTextBoxes[EventLog].Text;

//            RichTextBoxes[EventLog].Text = isAppend ? eventLogText + "\n" + text : text;

//            eventLogText = RichTextBoxes[EventLog].Text;

//            RichTextBoxes[EventLog].Text = isAddLinebreak ? eventLogText + "\n" : eventLogText;

//            RichTextBoxes[EventLog].SelectionStart = eventLogText.Length;
//            RichTextBoxes[EventLog].ScrollToCaret();
//        }

//        /// <summary>
//        /// Sets the UI (buttons) to match as the player is in town, also displays a message.
//        /// </summary>
//        public void SetUIToTown()
//        {
//            SetButtonAvailability(Buttons[BtnForward], false);
//            SetButtonAvailability(Buttons[BtnShoj], true);
//            SetButtonAvailability(Buttons[BtnBrangor], true);
//            SetButtonAvailability(Buttons[BtnViascen], true);
//            SetButtonAvailability(Buttons[BtnOutskirts], true);

//            SetEventLogText("You are in town.", false);
//        }

//        /// <summary>
//        /// Sets the UI (buttons) to match as the player in out of town, also displays a custom message.
//        /// </summary>
//        /// <param name="welcomeMsg">The message to be displayed.</param>
//        public void SetUIToOutOfTown(string welcomeMsg)
//        {
//            SetButtonAvailability(Buttons[BtnForward], true);
//            SetButtonAvailability(Buttons[BtnShoj], false);
//            SetButtonAvailability(Buttons[BtnBrangor], false);
//            SetButtonAvailability(Buttons[BtnViascen], false);
//            SetButtonAvailability(Buttons[BtnOutskirts], false);

//            SetEventLogText(welcomeMsg, false);
//        }

//        /// <summary>
//        /// Sets the UI to match as the player is in combat.
//        /// </summary>
//        public void SetUIToBattle(string targetName)
//        {
//            SetButtonAvailability(Buttons[BtnAttack], true);
//            SetButtonAvailability(Buttons[BtnFortify], true);
//            SetButtonAvailability(Buttons[BtnForward], false);
//            SetButtonAvailability(Buttons[BtnTown], false);
//            SetButtonAvailability(Buttons[BtnOutskirts], false);

//            GroupBoxes[TargetDetails].Visible = true;
//            GroupBoxes[TargetDetails].Text = targetName + "'s Details";
//        }
//    }
//}
