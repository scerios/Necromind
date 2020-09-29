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
        // All the needed UI to set dynamically
        private static Dictionary<string, Panel> Panels = new Dictionary<string, Panel>();
        private static Dictionary<string, Label> Labels = new Dictionary<string, Label>();
        private static Dictionary<string, TextBox> TextBoxes = new Dictionary<string, TextBox>();
        private static Dictionary<string, RichTextBox> RichTextBoxes = new Dictionary<string, RichTextBox>();
        private static Dictionary<string, GroupBox> GroupBoxes = new Dictionary<string, GroupBox>();
        private static Dictionary<string, ListBox> ListBoxes = new Dictionary<string, ListBox>();
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
            setRichTextBoxes();
            setGroupBoxes();
            setListBoxes();
            setButtons();
            sendAllUIToLibrary();
            showMainMenu();
        }

        private void setPanels()
        {
            Panels.Add(UIHandler.Menu, panelMenu);
            Panels.Add(UIHandler.NewGame, panelNewGame);
            Panels.Add(UIHandler.LoadGame, panelLoadGame);
            Panels.Add(UIHandler.Game, panelGame);
            Panels.Add(UIHandler.ConfirmDelete, panelConfirmDelete);

            Panels.Add(UIHandler.Error, panelError);

            Panels.Add(UIHandler.Location, panelLocation);
            Panels.Add(UIHandler.Vendor, panelVendor);

            Panels.Add(UIHandler.Trade, panelTrade);
            Panels.Add(UIHandler.QuestHandle, panelQuestHandle);
            Panels.Add(UIHandler.Fight, panelFight);
        }

        private void setLabels()
        {
            Labels.Add(UIHandler.HeroHealth, labelHeroHealthValue);
            Labels.Add(UIHandler.HeroGold, labelHeroGoldValue);
            Labels.Add(UIHandler.HeroXP, labelHeroXPValue);
            Labels.Add(UIHandler.HeroLevel, labelHeroLevelValue);
            Labels.Add(UIHandler.HeroDamage, labelHeroDamageValue);
            Labels.Add(UIHandler.HeroDefense, labelHeroDefenseValue);

            Labels.Add(UIHandler.ErrorTitle, labelErrorTitle);
            Labels.Add(UIHandler.ErrorMsg, labelErrorMsg);
        }

        private void setTextBoxes()
        {
            TextBoxes.Add(UIHandler.NewHeroName, textBoxNewHeroName);
            TextBoxes.Add(UIHandler.DeleteHeroName, textBoxDeleteHeroName);
        }

        private void setRichTextBoxes()
        {
            RichTextBoxes.Add(UIHandler.ConfirmDeleteText, richTextBoxConfirmDelete);
            RichTextBoxes.Add(UIHandler.EventLog, richTextBoxEventLog);
        }

        private void setGroupBoxes()
        {
            GroupBoxes.Add(UIHandler.HeroDetails, groupBoxHeroDetails);
            GroupBoxes.Add(UIHandler.HeroInventory, groupBoxHeroInventory);
            GroupBoxes.Add(UIHandler.HeroQuests, groupBoxHeroQuests);

            GroupBoxes.Add(UIHandler.TargetDetails, groupBoxTargetDetails);
            GroupBoxes.Add(UIHandler.TargetInventory, groupBoxTargetInventory);
            GroupBoxes.Add(UIHandler.TargetQuests, groupBoxTargetQuests);
        }

        private void setListBoxes()
        {
            ListBoxes.Add(UIHandler.HeroActiveQuests, listBoxHeroActiveQuests);
            ListBoxes.Add(UIHandler.HeroItems, listBoxHeroItems);

            ListBoxes.Add(UIHandler.TargetAvailableQuests, listBoxTargetAvailableQuests);
            ListBoxes.Add(UIHandler.TargetItems, listBoxTargetItems);
        }

        private void setButtons()
        {
            Buttons.Add(UIHandler.BtnDeleteHero, btnDeleteHero);

            Buttons.Add(UIHandler.BtnBrangor, btnBrangor);
            Buttons.Add(UIHandler.BtnShoj, btnShoj);
            Buttons.Add(UIHandler.BtnViascen, btnViascen);

            Buttons.Add(UIHandler.BtnTown, btnTown);
            Buttons.Add(UIHandler.BtnOutskirts, btnOutskirts);
            Buttons.Add(UIHandler.BtnMonastery, btnMonastery);

            Buttons.Add(UIHandler.BtnBuy, btnBuy);
            Buttons.Add(UIHandler.BtnSell, btnSell);

            Buttons.Add(UIHandler.BtnAccept, btnAccept);
            Buttons.Add(UIHandler.BtnComplete, btnComplete);

            Buttons.Add(UIHandler.BtnAttack, btnAttack);
            Buttons.Add(UIHandler.BtnFortify, btnFortify);
            Buttons.Add(UIHandler.BtnUseItem, btnUseItem);
        }

        private void sendAllUIToLibrary()
        {
            UIHandler.TakeAllUI(Panels, Labels, TextBoxes, RichTextBoxes, GroupBoxes, ListBoxes, Buttons);
        }

        private void showMainMenu()
        {
            Panels[UIHandler.Menu].BringToFront();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Panels[UIHandler.NewGame].BringToFront();
            textBoxNewHeroName.Focus();
        }

        private void btnCreateNewHero_Click(object sender, EventArgs e)
        {
            MenuLogic.CreateNewHero();
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
                UIHandler.Panels[UIHandler.Error].SendToBack();
            }
        }

        private void buttonDeleteHero_Click(object sender, EventArgs e)
        {
            MenuLogic.DeleteHero();
        }

        private void btnOutskirts_Click(object sender, EventArgs e)
        {
            GameLogic.MoveToOutSkirts();
        }
    }
}
