using NecromindLibrary.service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;

namespace NecromindUI
{
    public partial class Necromind : Form
    {
        private UIService _UIService;
        private MenuService _menuService;
        private GameService _gameService;

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
            _UIService = UIService.Instance;
            _menuService = MenuService.Instance;
            _gameService = GameService.Instance;

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
            Panels.Add(_UIService.Menu, panelMenu);
            Panels.Add(_UIService.NewGame, panelNewGame);
            Panels.Add(_UIService.LoadGame, panelLoadGame);
            Panels.Add(_UIService.Game, panelGame);
            Panels.Add(_UIService.ConfirmDelete, panelConfirmDelete);

            Panels.Add(_UIService.Error, panelError);

            Panels.Add(_UIService.Location, panelLocation);
            Panels.Add(_UIService.Vendor, panelVendor);

            Panels.Add(_UIService.Trade, panelTrade);
            Panels.Add(_UIService.QuestHandle, panelQuestHandle);
            Panels.Add(_UIService.Fight, panelFight);
        }

        private void setLabels()
        {
            Labels.Add(_UIService.HeroHealth, labelHeroHealthValue);
            Labels.Add(_UIService.HeroGold, labelHeroGoldValue);
            Labels.Add(_UIService.HeroXP, labelHeroXPValue);
            Labels.Add(_UIService.HeroLevel, labelHeroLevelValue);
            Labels.Add(_UIService.HeroDamage, labelHeroDamageValue);
            Labels.Add(_UIService.HeroDefense, labelHeroDefenseValue);

            Labels.Add(_UIService.ErrorTitle, labelErrorTitle);
            Labels.Add(_UIService.ErrorMsg, labelErrorMsg);
        }

        private void setTextBoxes()
        {
            TextBoxes.Add(_UIService.NewHeroName, textBoxNewHeroName);
            TextBoxes.Add(_UIService.DeleteHeroName, textBoxDeleteHeroName);
        }

        private void setRichTextBoxes()
        {
            RichTextBoxes.Add(_UIService.ConfirmDeleteText, richTextBoxConfirmDelete);
            RichTextBoxes.Add(_UIService.EventLog, richTextBoxEventLog);
        }

        private void setGroupBoxes()
        {
            GroupBoxes.Add(_UIService.HeroDetails, groupBoxHeroDetails);
            GroupBoxes.Add(_UIService.HeroInventory, groupBoxHeroInventory);
            GroupBoxes.Add(_UIService.HeroQuests, groupBoxHeroQuests);

            GroupBoxes.Add(_UIService.TargetDetails, groupBoxTargetDetails);
            GroupBoxes.Add(_UIService.TargetInventory, groupBoxTargetInventory);
            GroupBoxes.Add(_UIService.TargetQuests, groupBoxTargetQuests);
        }

        private void setListBoxes()
        {
            ListBoxes.Add(_UIService.HeroActiveQuests, listBoxHeroActiveQuests);
            ListBoxes.Add(_UIService.HeroItems, listBoxHeroItems);

            ListBoxes.Add(_UIService.TargetAvailableQuests, listBoxTargetAvailableQuests);
            ListBoxes.Add(_UIService.TargetItems, listBoxTargetItems);
        }

        private void setButtons()
        {
            Buttons.Add(_UIService.BtnDeleteHero, btnDeleteHero);

            Buttons.Add(_UIService.BtnBrangor, btnBrangor);
            Buttons.Add(_UIService.BtnShoj, btnShoj);
            Buttons.Add(_UIService.BtnViascen, btnViascen);

            Buttons.Add(_UIService.BtnTown, btnTown);
            Buttons.Add(_UIService.BtnOutskirts, btnOutskirts);
            Buttons.Add(_UIService.BtnMonastery, btnMonastery);

            Buttons.Add(_UIService.BtnBuy, btnBuy);
            Buttons.Add(_UIService.BtnSell, btnSell);

            Buttons.Add(_UIService.BtnAccept, btnAccept);
            Buttons.Add(_UIService.BtnComplete, btnComplete);

            Buttons.Add(_UIService.BtnAttack, btnAttack);
            Buttons.Add(_UIService.BtnFortify, btnFortify);
            Buttons.Add(_UIService.BtnUseItem, btnUseItem);

            Buttons.Add(_UIService.BtnForward, btnForward);
        }

        private void sendAllUIToLibrary()
        {
            _UIService.TakeAllUI(Panels, Labels, TextBoxes, RichTextBoxes, GroupBoxes, ListBoxes, Buttons);
        }

        private void showMainMenu()
        {
            Panels[_UIService.Menu].BringToFront();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Panels[_UIService.NewGame].BringToFront();
            textBoxNewHeroName.Focus();
        }

        private void btnCreateNewHero_Click(object sender, EventArgs e)
        {
            _menuService.CreateNewHero();
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
            _menuService.ShowAllLoadedHeroes();
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
            _UIService.ResetGameTexts();
        }

        private void Necromind_KeyPress(object sender, KeyPressEventArgs e)
        {
            // TODO - Track user's position on the panels so by pressing ESC it should act like click on Back

            // If ESC is pressed
            if (e.KeyChar == (char)27)
            {
                _UIService.Panels[_UIService.Error].SendToBack();
            }
        }

        private void buttonDeleteHero_Click(object sender, EventArgs e)
        {
            _menuService.DeleteHero();
        }

        private void btnOutskirts_Click(object sender, EventArgs e)
        {
            _gameService.MoveToOutSkirts();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            _gameService.MoveForward();
        }
    }
}
