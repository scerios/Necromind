﻿using NecromindUI.Views;
using NecromindLibrary.Models;
using NecromindUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NecromindUI
{
    public partial class Necromind : Form
    {
        private MenuNew _menuNew;
        private MenuLoad _menuLoad;
        private GameMain _gameMain;

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
            Controls.Remove(view);
            view.Dispose();
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            _menuNew = new MenuNew();
            ActivateView(_menuNew);

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

            _gameMain.BackToMenu += new EventHandler(GameMain_BackToMenu);
        }

        private void GameMain_BackToMenu(object sender, EventArgs e)
        {
            DeactivateView(_gameMain);
        }
    }
}
