using NecromindUI.Presenters;
using NecromindUI.Views;
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
        public bool IsErrorPanVisible
        {
            get => panError.Visible;

            set
            {
                panError.Visible = value;
            }
        }

        public string Title
        {
            get => labErrorTitle.Text;

            set
            {
                labErrorTitle.Text = value;
            }
        }

        public string Msg
        {
            get => labErrorMsg.Text;

            set
            {
                labErrorMsg.Text = value;
            }
        }

        public string HeroName
        {
            get => tbHeroName.Text;

            set
            {
                tbHeroName.Text = value;
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

        private void BtnCreateNewHero_Click(object sender, EventArgs e)
        {
            _presenter.TryCreateHero();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            _presenter.HideError();
        }
    }
}
