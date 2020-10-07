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
        private static Dictionary<string, Panel> _panels = new Dictionary<string, Panel>();
        private static Dictionary<string, Label> _labels = new Dictionary<string, Label>();
        private static Dictionary<string, TextBox> _textBoxes = new Dictionary<string, TextBox>();
        private static Dictionary<string, RichTextBox> _richTextBoxes = new Dictionary<string, RichTextBox>();
        private static Dictionary<string, GroupBox> _groupBoxes = new Dictionary<string, GroupBox>();
        private static Dictionary<string, ListBox> _listBoxes = new Dictionary<string, ListBox>();
        private static Dictionary<string, Button> _buttons = new Dictionary<string, Button>();

        public Necromind()
        {
            // Forces Visual Studio to show error messages in english.
            if (Debugger.IsAttached) CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo("en-US");

            InitializeComponent();
            startGame();
        }

        private void startGame()
        {
            _UIService = UIService.GetInstance();
            _menuService = MenuService.GetInstance();
            _gameService = GameService.GetInstance();

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

        #region Dictionary setters

        private void setPanels()
        {
            _panels.Add(_UIService.Menu, panelMenu);
            _panels.Add(_UIService.NewGame, panelNewGame);
            _panels.Add(_UIService.LoadGame, panelLoadGame);
            _panels.Add(_UIService.Game, panelGame);
            _panels.Add(_UIService.ConfirmDelete, panelConfirmDelete);

            _panels.Add(_UIService.Error, panelError);

            _panels.Add(_UIService.Location, panelLocation);
            _panels.Add(_UIService.Vendor, panelVendor);

            _panels.Add(_UIService.Trade, panelTrade);
            _panels.Add(_UIService.QuestHandle, panelQuestHandle);
            _panels.Add(_UIService.Fight, panelFight);
        }

        private void setLabels()
        {
            _labels.Add(_UIService.HeroHealth, labelHeroHealthValue);
            _labels.Add(_UIService.HeroGold, labelHeroGoldValue);
            _labels.Add(_UIService.HeroXP, labelHeroXPValue);
            _labels.Add(_UIService.HeroLevel, labelHeroLevelValue);
            _labels.Add(_UIService.HeroDamage, labelHeroDamageValue);
            _labels.Add(_UIService.HeroDefense, labelHeroDefenseValue);

            _labels.Add(_UIService.ErrorTitle, labelErrorTitle);
            _labels.Add(_UIService.ErrorMsg, labelErrorMsg);
        }

        private void setTextBoxes()
        {
            _textBoxes.Add(_UIService.NewHeroName, textBoxNewHeroName);
            _textBoxes.Add(_UIService.DeleteHeroName, textBoxDeleteHeroName);
        }

        private void setRichTextBoxes()
        {
            _richTextBoxes.Add(_UIService.ConfirmDeleteText, richTextBoxConfirmDelete);
            _richTextBoxes.Add(_UIService.EventLog, richTextBoxEventLog);
        }

        private void setGroupBoxes()
        {
            _groupBoxes.Add(_UIService.HeroDetails, groupBoxHeroDetails);
            _groupBoxes.Add(_UIService.HeroInventory, groupBoxHeroInventory);
            _groupBoxes.Add(_UIService.HeroQuests, groupBoxHeroQuests);

            _groupBoxes.Add(_UIService.TargetDetails, groupBoxTargetDetails);
            _groupBoxes.Add(_UIService.TargetInventory, groupBoxTargetInventory);
            _groupBoxes.Add(_UIService.TargetQuests, groupBoxTargetQuests);
        }

        private void setListBoxes()
        {
            _listBoxes.Add(_UIService.HeroActiveQuests, listBoxHeroActiveQuests);
            _listBoxes.Add(_UIService.HeroItems, listBoxHeroItems);

            _listBoxes.Add(_UIService.TargetAvailableQuests, listBoxTargetAvailableQuests);
            _listBoxes.Add(_UIService.TargetItems, listBoxTargetItems);
        }

        private void setButtons()
        {
            _buttons.Add(_UIService.BtnDeleteHero, btnDeleteHero);

            _buttons.Add(_UIService.BtnBrangor, btnBrangor);
            _buttons.Add(_UIService.BtnShoj, btnShoj);
            _buttons.Add(_UIService.BtnViascen, btnViascen);

            _buttons.Add(_UIService.BtnTown, btnTown);
            _buttons.Add(_UIService.BtnOutskirts, btnOutskirts);
            _buttons.Add(_UIService.BtnMonastery, btnMonastery);

            _buttons.Add(_UIService.BtnBuy, btnBuy);
            _buttons.Add(_UIService.BtnSell, btnSell);

            _buttons.Add(_UIService.BtnAccept, btnAccept);
            _buttons.Add(_UIService.BtnComplete, btnComplete);

            _buttons.Add(_UIService.BtnAttack, btnAttack);
            _buttons.Add(_UIService.BtnFortify, btnFortify);
            _buttons.Add(_UIService.BtnUseItem, btnUseItem);

            _buttons.Add(_UIService.BtnForward, btnForward);
        }

        #endregion

        private void sendAllUIToLibrary()
        {
            _UIService.TakeAllUI(_panels, _labels, _textBoxes, _richTextBoxes, _groupBoxes, _listBoxes, _buttons);
        }

        private void showMainMenu()
        {
            _UIService.BringPanelToFront(_UIService.Menu);
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            _UIService.BringPanelToFront(_UIService.NewGame);
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
