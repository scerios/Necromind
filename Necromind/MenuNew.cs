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
    public partial class MenuNew : UserControl, IMenuNew
    {
        private readonly MenuNewPresenter _presenter;
        public Panel PanelError
        {
            get => panelError;
        }

        public string Title
        {
            get => labelErrorTitle.Text;

            set
            {
                labelErrorTitle.Text = value;
            }
        }

        public string Msg
        {
            get => labelErrorMsg.Text;

            set
            {
                labelErrorMsg.Text = value;
            }
        }

        public event EventHandler BtnBackClick;

        public MenuNew()
        {
            InitializeComponent();
            _presenter = new MenuNewPresenter(this);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            BtnBackClick?.Invoke(this, e);
        }
    }
}
