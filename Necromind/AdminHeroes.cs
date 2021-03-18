﻿using NecromindUI.Presenters;
using NecromindUI.Views;
using System;
using System.Windows.Forms;

namespace Necromind
{
    public partial class AdminHeroes : UserControl, IAdminHeroes
    {
        private readonly AdminHeroesPresenter _presenter;

        public string HeroName
        {
            get => tbName.Text;
            set
            {
                tbName.Text = value;
            }
        }

        public string Lvl
        {
            get => tbLvl.Text;

            set
            {
                tbLvl.Text = value;
            }
        }

        public string Gold
        {
            get => tbGold.Text;

            set
            {
                tbGold.Text = value;
            }
        }

        public string DmgMin
        {
            get => tbDmgMin.Text;

            set
            {
                tbDmgMin.Text = value;
            }
        }

        public string DmgMax
        {
            get => tbDmgMax.Text;

            set
            {
                tbDmgMax.Text = value;
            }
        }

        public string Def
        {
            get => tbDef.Text;

            set
            {
                tbDef.Text = value;
            }
        }

        public string Health
        {
            get => tbHealth.Text;

            set
            {
                tbHealth.Text = value;
            }
        }

        public ListBox Heroes
        {
            get => lbHeroes;
        }

        public AdminHeroes()
        {
            InitializeComponent();
            _presenter = new AdminHeroesPresenter(this);
        }

        private void LbHeroes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _presenter.GetSelectedHeroStats();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            _presenter.UpdateHero();
        }
    }
}