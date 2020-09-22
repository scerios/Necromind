using NecromindLibrary.service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;

namespace NecromindUI
{
    public partial class Necromind : Form
    {
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

        // All the needed UI to set dynamically
        private static Dictionary<string, Panel> Panels = new Dictionary<string, Panel>();
        private static Dictionary<string, Label> Labels = new Dictionary<string, Label>();
        private static Dictionary<string, TextBox> TextBoxes = new Dictionary<string, TextBox>();
        private static Dictionary<string, GroupBox> GroupBoxes = new Dictionary<string, GroupBox>();
        private static Dictionary<string, Button> Buttons = new Dictionary<string, Button>();

        public Necromind()
        {
            // Forces Visual Studio to show error messages in english.
            if (Debugger.IsAttached) CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            InitializeComponent();
            startGame();
        }

        private void startGame()
        {
            setPanels();
            setLabels();
            setTextBoxes();
            setGroupBoxes();
            setButtons();
            sendAllUIToLibrary();
            showMainMenu();
        }

        private void setPanels()
        {
            Panels.Add(menu, panelMenu);
            Panels.Add(newGame, panelNewGame);
            Panels.Add(loadGame, panelLoadGame);
            Panels.Add(game, panelGame);
            Panels.Add(confirmDelete, panelConfirmDelete);
            Panels.Add(error, panelError);
        }

        private void setLabels()
        {
            Labels.Add(heroHealth, labelHeroHealthValue);
            Labels.Add(heroGold, labelHeroGoldValue);
            Labels.Add(heroXP, labelHeroXPValue);
            Labels.Add(heroLevel, labelHeroLevelValue);
            Labels.Add(heroDamage, labelHeroDamageValue);
            Labels.Add(heroDefense, labelHeroDefenseValue);

            Labels.Add(errorTitle, labelErrorTitle);
            Labels.Add(errorMsg, labelErrorMsg);
        }

        private void setTextBoxes()
        {
            TextBoxes.Add(newHeroName, textBoxNewHeroName);
            TextBoxes.Add(deleteHeroName, textBoxDeleteHeroName);
        }

        private void setGroupBoxes()
        {
            GroupBoxes.Add(heroDetails, groupBoxHeroDetails);
            GroupBoxes.Add(heroInventory, groupBoxHeroItems);
            GroupBoxes.Add(targetDetails, groupBoxTargetDetails);
            GroupBoxes.Add(targetInventory, groupBoxTargetInventory);
        }

        private void setButtons()
        {
            Buttons.Add(deleteHero, btnDeleteHero);
        }

        private void sendAllUIToLibrary()
        {
            UIHandler.TakeAllUI(Panels, Labels, TextBoxes, GroupBoxes, Buttons, richTextBoxConfirmDelete);
        }

        private void showMainMenu()
        {
            Panels[menu].BringToFront();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Panels[newGame].BringToFront();
            textBoxNewHeroName.Focus();
        }

        private void btnCreateNewHero_Click(object sender, EventArgs e)
        {
            UIHandler.CreateNewHero();
        }

        private void textBoxNewHeroName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If ENTER is pressed
            if (e.KeyChar == (char)13)
            {
                btnCreateNewHero_Click(sender, new EventArgs());
            }
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            UIHandler.ShowAllLoadedHeroes();
        }

        private void btnBackFromNewGame_Click(object sender, EventArgs e)
        {
            showMainMenu();
        }

        private void btnBackFromLoadGame_Click(object sender, EventArgs e)
        {
            showMainMenu();
        }

        private void btnBackFromGame_Click(object sender, EventArgs e)
        {
            showMainMenu();
            UIHandler.ResetGame();
        }

        private void Necromind_KeyPress(object sender, KeyPressEventArgs e)
        {
            // TODO - Track user's position on the panels so by pressing ESC it should act like click on Back

            // If ESC is pressed
            if (e.KeyChar == (char)27)
            {
                UIHandler.Panels[error].SendToBack();
            }
        }

        private void buttonDeleteHero_Click(object sender, EventArgs e)
        {
            UIHandler.DeleteHero();
        }
    }
}
