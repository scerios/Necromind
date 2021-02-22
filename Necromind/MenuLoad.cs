using Necromind.Presenters;
using Necromind.Views;
using NecromindLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NecromindUI
{
    public partial class MenuLoad : UserControl, IMenuLoad
    {
        private readonly MenuLoadPresenter _presenter;

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

        public bool IsConfDelPanVisible
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

        public event EventHandler BtnBackClick;
        public event EventHandler BtnDelHeroClick;

        public MenuLoad()
        {
            InitializeComponent();
            _presenter = new MenuLoadPresenter(this);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            BtnBackClick?.Invoke(this, e);
        }

        public void LoadHeroes()
        {
            var heroes = _presenter.GetAllHeroes(ConfigurationManager.AppSettings["heroesCollection"]);

            foreach (var hero in heroes)
            {
                Controls.Add(hero);
            }
        }

        private void BtnErrorClose_Click(object sender, EventArgs e)
        {
            _presenter.HideError();
        }

        private void BtnDeleteHero_Click(object sender, EventArgs e)
        {
            _presenter.DeleteHero();
            BtnDelHeroClick?.Invoke(this, e);
        }

        private void BtnDelClose_Click(object sender, EventArgs e)
        {
            _presenter.HideConfDelPanel();
        }
    }
}
