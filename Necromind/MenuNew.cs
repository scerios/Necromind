using Necromind.Presenters;
using Necromind.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NecromindUI
{
    public partial class MenuNew : UserControl
    {
        public MenuNew()
        {
            InitializeComponent();
        }

        private void btnBackFromNewGame_Click(object sender, EventArgs e)
        {
            SendToBack();
            Visible = false;
        }
    }
}
