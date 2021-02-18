using Necromind.Views;
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
        public Necromind()
        {
            // Forces Visual Studio to show error messages in english.
            if (Debugger.IsAttached) CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo("en-US");

            InitializeComponent();
        }

        private void ActivateView(UserControl view)
        {
            view.BringToFront();
            view.Visible = true;
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            ActivateView(ucMenuNew);
        }

        private void BtnLoadGame_Click(object sender, EventArgs e)
        {
            ActivateView(ucMenuLoad);
        }
    }
}
