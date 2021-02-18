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
        private readonly MenuNew _menuNew;
        private readonly MenuLoad _menuLoad;

        public Necromind()
        {
            // Forces Visual Studio to show error messages in english.
            if (Debugger.IsAttached) CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo("en-US");

            _menuNew = new MenuNew();
            _menuLoad = new MenuLoad();

            InitializeComponent();
        }

        private void ActivateView(UserControl view)
        {
            Controls.Add(view);
            view.BringToFront();
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            ActivateView(_menuNew);

            _menuNew.BtnBackClick += new EventHandler(MenuNew_BtnBackClick);
        }

        private void MenuNew_BtnBackClick(object sender, EventArgs e)
        {
            Controls.Remove(_menuNew);
        }

        private void BtnLoadGame_Click(object sender, EventArgs e)
        {
            ActivateView(_menuLoad);
            _menuLoad.LoadHeroes();

            _menuLoad.BtnBackClick += new EventHandler(MenuLoad_BtnBackClick);
        }

        private void MenuLoad_BtnBackClick(object sender, EventArgs e)
        {
            Controls.Remove(_menuLoad);
        }
    }
}
