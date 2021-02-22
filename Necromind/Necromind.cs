using Necromind.Views;
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

namespace Necromind
{
    public partial class Necromind : Form
    {
        private MenuNew _menuNew;
        private MenuLoad _menuLoad;

        public Necromind()
        {
            // Forces Visual Studio to show error messages in english.
            if (Debugger.IsAttached) CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo("en-US");

            InitializeComponent();
        }

        private void ActivateView(UserControl view)
        {
            Controls.Add(view);
            view.BringToFront();
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            _menuNew = new MenuNew();
            ActivateView(_menuNew);

            _menuNew.BtnBackClick += new EventHandler(MenuNew_BtnBackClick);
        }

        private void MenuNew_BtnBackClick(object sender, EventArgs e)
        {
            Controls.Remove(_menuNew);
        }

        private void BtnLoadGame_Click(object sender, EventArgs e)
        {
            _menuLoad = new MenuLoad();
            ActivateView(_menuLoad);
            _menuLoad.LoadHeroes();

            _menuLoad.BtnBackClick += new EventHandler(MenuLoad_BtnBackClick);
            _menuLoad.BtnDelHeroClick += new EventHandler(MenuLoad_BtnDelHeroClick);
        }

        private void MenuLoad_BtnBackClick(object sender, EventArgs e)
        {
            Controls.Remove(_menuLoad);
        }

        private void MenuLoad_BtnDelHeroClick(object sender, EventArgs e)
        {
            Controls.Remove(_menuLoad);
            BtnLoadGame_Click(sender, e);
        }
    }
}
