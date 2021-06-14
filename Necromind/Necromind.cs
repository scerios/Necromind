using NecromindLibrary.Models;
using NecromindUI.UserControls.Game;
using NecromindUI.UserControls.Menu;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;

namespace NecromindUI
{
    public partial class Necromind : Form
    {
        private MenuNew _menuNew;
        private MenuLoad _menuLoad;
        private GameMain _gameMain;
        private MenuAdmin _menuAdmin;

        public Necromind()
        {
            // Forces Visual Studio to show error messages in english.
            if (Debugger.IsAttached) CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo("en-US");

            InitializeComponent();
        }

        private void ActivateView(UserControl view)
        {
            Controls.Add(view);
            view.Select();
            view.BringToFront();
        }

        private void DeactivateView(UserControl view)
        {
            view.Dispose();
            Controls.Remove(view);
        }

        private void Necromind_KeyDown(object sender, KeyEventArgs e)
        {
            if (_gameMain != null)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    _gameMain.ToggleExitPanVisibility();
                }
            }
            else
            {
                if (e.KeyCode == Keys.A && e.Modifiers == Keys.Control)
                {
                    _menuAdmin = new MenuAdmin();
                    _menuAdmin.tbPassword.Focus();
                    _menuAdmin.BtnBackCLick += new EventHandler(MenuAdmin_BtnBackClick);

                    ActivateView(_menuAdmin);
                }
            }
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            _menuNew = new MenuNew();
            ActivateView(_menuNew);
            _menuNew.tbHeroName.Focus();

            _menuNew.BtnBackClick += new EventHandler(MenuNew_BtnBackClick);
            _menuNew.BtnGoToMenuLoadClick += new EventHandler(MenuNew_BtnGoToMenuLoadClick);
        }

        private void MenuNew_BtnBackClick(object sender, EventArgs e)
        {
            DeactivateView(_menuNew);
        }

        private void MenuNew_BtnGoToMenuLoadClick(object sender, EventArgs e)
        {
            DeactivateView(_menuNew);

            BtnLoadGame_Click(this, e);
        }

        private void BtnLoadGame_Click(object sender, EventArgs e)
        {
            _menuLoad = new MenuLoad();
            ActivateView(_menuLoad);
            _menuLoad.LoadHeroes();

            _menuLoad.BtnBackClick += new EventHandler(MenuLoad_BtnBackClick);
            _menuLoad.BtnDelHeroClick += new EventHandler(MenuLoad_BtnDelHeroClick);
            _menuLoad.BtnLoadHeroClick += new EventHandler(GameMainLoad);
        }

        private void MenuLoad_BtnBackClick(object sender, EventArgs e)
        {
            DeactivateView(_menuLoad);
        }

        private void MenuLoad_BtnDelHeroClick(object sender, EventArgs e)
        {
            DeactivateView(_menuLoad);
            BtnLoadGame_Click(sender, e);
        }

        private void GameMainLoad(object sender, EventArgs e)
        {
            DeactivateView(_menuLoad);
            _gameMain = new GameMain(PlayerModel.Hero);
            ActivateView(_gameMain);

            _gameMain.BtnBackToMenu += new EventHandler(GameMain_BtnBackToMenu);
        }

        private void GameMain_BtnBackToMenu(object sender, EventArgs e)
        {
            DeactivateView(_gameMain);
            _gameMain = null;
        }

        private void MenuAdmin_BtnBackClick(object sender, EventArgs e)
        {
            DeactivateView(_menuAdmin);
        }
    }
}