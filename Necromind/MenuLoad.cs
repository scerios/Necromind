using Necromind.Presenters;
using Necromind.Views;
using NecromindLibrary.model;
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
        public event EventHandler BtnBackClick;

        public MenuLoad()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            BtnBackClick?.Invoke(this, e);
        }

        public void LoadHeroes()
        {
            var menuLoadPresenter = new MenuLoadPresenter(this);
            var heroes = menuLoadPresenter.GetAllHeroes(ConfigurationManager.AppSettings["heroesCollection"]);

            foreach (var hero in heroes)
            {
                Controls.Add(hero);
            }
        }
    }
}
