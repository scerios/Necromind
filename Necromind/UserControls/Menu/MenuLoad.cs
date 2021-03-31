using NecromindLibrary.Config;
using NecromindLibrary.Models;
using NecromindLibrary.Services;
using NecromindUI.Config;
using NecromindUI.Presenters.Menu;
using NecromindUI.Views.Menu;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NecromindUI.UserControls.Menu
{
    public partial class MenuLoad : UserControl, IMenuLoad
    {
        private readonly MenuLoadPresenter _presenter;

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

        public bool IsPanConfDelVisible
        {
            get => panConfDel.Visible;
            set
            {
                panConfDel.Visible = value;
            }
        }

        public string HeroName
        {
            get => labHeroName.Text;
            set
            {
                labHeroName.Text = value;
            }
        }

        public string ConfirmName
        {
            get => tbDelHeroName.Text;
            set
            {
                tbDelHeroName.Text = value;
            }
        }

        public bool IsBtnDelHeroEnabled
        {
            get => btnDelHero.Enabled;
            set
            {
                btnDelHero.Enabled = value;
            }
        }

        public event EventHandler BtnBackClick;

        public event EventHandler BtnDelHeroClick;

        public event EventHandler BtnLoadHeroClick;

        public MenuLoad()
        {
            InitializeComponent();
            _presenter = new MenuLoadPresenter(this);
        }

        public void LoadHeroes()
        {
            var heroes = _presenter.GetAllHeroes(DBConfig.HeroesCollection);
            int btnLoadHeroLocX = 500;
            int btnDeleteHeroLocX = 610;
            int btnLocY = 100;

            foreach (HeroModel hero in heroes)
            {
                Button btnLoadHero = UIService.CreateButton(
                    hero.Name,
                    "btnLoad" + hero.Name,
                    100,
                    25,
                    btnLoadHeroLocX,
                    btnLocY,
                    10,
                    UISettings.OrangeColor,
                    UISettings.WhiteColor,
                    FlatStyle.Flat,
                    ContentAlignment.MiddleCenter
                );

                Controls.Add(btnLoadHero);

                btnLoadHero.Click += (sender, e) =>
                {
                    PlayerModel.Hero = hero;
                    BtnLoadHeroClick?.Invoke(sender, e);
                };

                Button btnDelHero = UIService.CreateButton(
                    "X",
                    "btnDelete" + hero.Name,
                    25,
                    25,
                    btnDeleteHeroLocX,
                    btnLocY,
                    12,
                    UISettings.BackgroundColor,
                    UISettings.RedColor,
                    FlatStyle.Flat,
                    ContentAlignment.MiddleLeft
                );

                Controls.Add(btnDelHero);

                btnDelHero.Click += (sender, e) =>
                {
                    _presenter.HeroToDelId = hero.Id;
                    _presenter.DisplayPanConfDel(hero.Name);
                };

                btnLocY += 40;
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            BtnBackClick?.Invoke(this, e);
        }

        private void BtnErrorClose_Click(object sender, EventArgs e)
        {
            _presenter.HideError();
        }

        private void BtnLoadHero_Click(object sender, EventArgs e)
        {
            BtnLoadHeroClick?.Invoke(this, e);
        }

        private void BtnDelHero_Click(object sender, EventArgs e)
        {
            _presenter.DeleteHero();
            BtnDelHeroClick?.Invoke(this, e);
        }

        private void BtnDelClose_Click(object sender, EventArgs e)
        {
            _presenter.HidePanConfDel();
        }

        private void TbDelHeroName_TextChanged(object sender, EventArgs e)
        {
            _presenter.ChangeBtnDelHeroAvailability();
        }
    }
}