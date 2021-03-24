using NecromindUI.Presenters;
using NecromindUI.Views.Menu;
using System;
using System.Windows.Forms;

namespace NecromindUI.UserControls.Menu
{
    public partial class MenuNew : UserControl, IMenuNew
    {
        private readonly MenuNewPresenter _presenter;

        public bool IsPanErrorVisible
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

        public event EventHandler BtnGoToMenuLoadClick;

        public MenuNew()
        {
            InitializeComponent();
            _presenter = new MenuNewPresenter(this);
        }

        private void TbHeroName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnCreateNewHero_Click(this, e);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            BtnBackClick?.Invoke(this, e);
        }

        private void BtnCreateNewHero_Click(object sender, EventArgs e)
        {
            if (_presenter.IsHeroNameAvailable())
            {
                if (_presenter.IsHeroCreated())
                {
                    BtnGoToMenuLoadClick?.Invoke(this, e);
                }
                else
                {
                    _presenter.DisplayError(
                        "Hero couldn't be saved.",
                        "There was an error during saving to database. Please try again."
                        );
                }
            }
            else
            {
                _presenter.DisplayError(
                    "Hero already exists.",
                    $"The name \"{ HeroName }\" is taken by one of your characters already. You need to pick another one."
                    );

                HeroName = "";
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            _presenter.HideError();
        }
    }
}