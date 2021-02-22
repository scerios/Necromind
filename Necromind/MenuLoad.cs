using Necromind.Presenters;
using Necromind.Views;
using NecromindLibrary.model;
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            _presenter.HideError();
        }
    }
}
