using NecromindLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;

namespace NecromindUI
{
    public partial class NecromindOld : Form
    {
        //private UIService _UIService;
        //private MenuService _menuService;
        //private GameService _gameService;

        // All the needed UI to set dynamically
        private Dictionary<string, Panel> _panels = new Dictionary<string, Panel>();
        private Dictionary<string, Label> _labels = new Dictionary<string, Label>();
        private Dictionary<string, TextBox> _textBoxes = new Dictionary<string, TextBox>();
        private Dictionary<string, RichTextBox> _richTextBoxes = new Dictionary<string, RichTextBox>();
        private Dictionary<string, GroupBox> _groupBoxes = new Dictionary<string, GroupBox>();
        private Dictionary<string, ListBox> _listBoxes = new Dictionary<string, ListBox>();
        private Dictionary<string, Button> _buttons = new Dictionary<string, Button>();

        public NecromindOld()
        {
            // Forces Visual Studio to show error messages in english.
            if (Debugger.IsAttached) CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo("en-US");

            InitializeComponent();
            StartGame();
        }

        private void StartGame()
        {
            //_UIService = UIService.GetInstance();
            //_menuService = MenuService.GetInstance(GlobalConfig.Connection);
            //_gameService = GameService.GetInstance();

            //SetPanels();
            //SetLabels();
            //SetTextBoxes();
            //SetRichTextBoxes();
            //SetGroupBoxes();
            //SetListBoxes();
            //SetButtons();
            //SendAllUIToLibrary();
            //ShowMainMenu();
        }

        //#region Dictionary setters

        //private void SetPanels()
        //{
        //    _panels.Add(_UIService.Menu, panelMenu);
        //    _panels.Add(_UIService.NewGame, panelNewGame);
        //    _panels.Add(_UIService.LoadGame, panelLoadGame);
        //    _panels.Add(_UIService.Game, panelGame);
        //    _panels.Add(_UIService.ConfirmDelete, panelConfirmDelete);

        //    _panels.Add(_UIService.Error, panelError);

        //    _panels.Add(_UIService.Location, panelLocation);
        //    _panels.Add(_UIService.Vendor, panelVendor);

        //    _panels.Add(_UIService.Trade, panelTrade);
        //    _panels.Add(_UIService.QuestHandle, panelQuestHandle);
        //    _panels.Add(_UIService.Fight, panelFight);
        //}

        //private void SetLabels()
        //{
        //    _labels.Add(_UIService.HeroHealth, labelHeroHealthValue);
        //    _labels.Add(_UIService.HeroMaxHealth, labelHeroMaxHealthValue);
        //    _labels.Add(_UIService.HeroGold, labelHeroGoldValue);
        //    _labels.Add(_UIService.HeroXP, labelHeroXPValue);
        //    _labels.Add(_UIService.HeroNextLevelAt, labelHeroNextLevelAtValue);
        //    _labels.Add(_UIService.HeroLevel, labelHeroLevelValue);
        //    _labels.Add(_UIService.HeroDamage, labelHeroDamageValue);
        //    _labels.Add(_UIService.HeroDefense, labelHeroDefenseValue);

        //    _labels.Add(_UIService.ErrorTitle, labelErrorTitle);
        //    _labels.Add(_UIService.ErrorMsg, labelErrorMsg);
        //}

        //private void SetTextBoxes()
        //{
        //    _textBoxes.Add(_UIService.NewHeroName, textBoxNewHeroName);
        //    _textBoxes.Add(_UIService.DeleteHeroName, textBoxDeleteHeroName);
        //}

        //private void SetRichTextBoxes()
        //{
        //    _richTextBoxes.Add(_UIService.ConfirmDeleteText, richTextBoxConfirmDelete);
        //    _richTextBoxes.Add(_UIService.EventLog, richTextBoxEventLog);
        //}

        //private void SetGroupBoxes()
        //{
        //    _groupBoxes.Add(_UIService.HeroDetails, groupBoxHeroDetails);
        //    _groupBoxes.Add(_UIService.HeroInventory, groupBoxHeroInventory);
        //    _groupBoxes.Add(_UIService.HeroQuests, groupBoxHeroQuests);

        //    _groupBoxes.Add(_UIService.TargetDetails, groupBoxTargetDetails);
        //    _groupBoxes.Add(_UIService.TargetInventory, groupBoxTargetInventory);
        //    _groupBoxes.Add(_UIService.TargetQuests, groupBoxTargetQuests);
        //}

        //private void SetListBoxes()
        //{
        //    _listBoxes.Add(_UIService.HeroActiveQuests, listBoxHeroActiveQuests);
        //    _listBoxes.Add(_UIService.HeroItems, listBoxHeroItems);

        //    _listBoxes.Add(_UIService.TargetAvailableQuests, listBoxTargetAvailableQuests);
        //    _listBoxes.Add(_UIService.TargetItems, listBoxTargetItems);
        //}

        //private void SetButtons()
        //{
        //    _buttons.Add(_UIService.BtnDeleteHero, btnDeleteHero);

        //    _buttons.Add(_UIService.BtnBrangor, btnBrangor);
        //    _buttons.Add(_UIService.BtnShoj, btnShoj);
        //    _buttons.Add(_UIService.BtnViascen, btnViascen);

        //    _buttons.Add(_UIService.BtnTown, btnTown);
        //    _buttons.Add(_UIService.BtnOutskirts, btnOutskirts);
        //    _buttons.Add(_UIService.BtnMonastery, btnMonastery);

        //    _buttons.Add(_UIService.BtnBuy, btnBuy);
        //    _buttons.Add(_UIService.BtnSell, btnSell);

        //    _buttons.Add(_UIService.BtnAccept, btnAccept);
        //    _buttons.Add(_UIService.BtnComplete, btnComplete);

        //    _buttons.Add(_UIService.BtnAttack, btnAttack);
        //    _buttons.Add(_UIService.BtnFortify, btnFortify);
        //    _buttons.Add(_UIService.BtnUseItem, btnUseItem);

        //    _buttons.Add(_UIService.BtnForward, btnForward);
        //}

        //#endregion

        //private void SendAllUIToLibrary()
        //{
        //    _UIService.TakeAllUI(_panels, _labels, _textBoxes, _richTextBoxes, _groupBoxes, _listBoxes, _buttons);
        //}

        //private void ShowMainMenu()
        //{
        //    _UIService.BringPanelToFront(_UIService.Menu);
        //}

        //private void BtnNewGame_Click(object sender, EventArgs e)
        //{
        //    _UIService.BringPanelToFront(_UIService.NewGame);
        //    textBoxNewHeroName.Focus();
        //}

        //private void BtnCreateNewHero_Click(object sender, EventArgs e)
        //{
        //    _menuService.CreateNewHero();
        //}

        //private void TextBoxNewHeroName_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    // If ENTER is pressed
        //    if (e.KeyChar == (char)13)
        //    {
        //        BtnCreateNewHero_Click(sender, new EventArgs());
        //    }
        //}

        //private void BtnLoadGame_Click(object sender, EventArgs e)
        //{
        //    _menuService.ShowAllLoadedHeroes();
        //}

        //private void BtnBackFromNewGame_Click(object sender, EventArgs e)
        //{
        //    ShowMainMenu();
        //}

        //private void BtnBackFromLoadGame_Click(object sender, EventArgs e)
        //{
        //    ShowMainMenu();
        //}

        //private void BtnBackFromGame_Click(object sender, EventArgs e)
        //{
        //    ShowMainMenu();
        //    _UIService.ResetGameTexts();
        //}

        //private void Necromind_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    // If ESC is pressed
        //    if (e.KeyChar == (char)27)
        //    {
        //        _UIService.Panels[_UIService.Error].SendToBack();
        //    }
        //}

        //private void BtnDeleteHero_Click(object sender, EventArgs e)
        //{
        //    _menuService.DeleteHero();
        //}

        //private void BtnOutskirts_Click(object sender, EventArgs e)
        //{
        //    _gameService.MoveToOutSkirts();
        //}

        //private void BtnForward_Click(object sender, EventArgs e)
        //{
        //    _gameService.MoveForward();
        //}

        //private void BtnTown_Click(object sender, EventArgs e)
        //{
        //    _gameService.MoveToTown();
        //}

        //private void BtnAttack_Click(object sender, EventArgs e)
        //{
        //    _gameService.AttackTarget();
        //}
    }
}
