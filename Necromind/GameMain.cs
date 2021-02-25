using NecromindUI.Presenters;
using NecromindUI.Views;
using NecromindLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace NecromindUI
{
    public partial class GameMain : UserControl, IGameMain
    {
        private readonly GameMainPresenter _presenter;
        private readonly HeroModel _hero;

        public bool IsPanExitVisible
        {
            get => panExit.Visible;

            set
            {
                panExit.Visible = value;
            }
        }
        public string CurrentLocation
        {
            get => labLocation.Text;

            set
            {
                labLocation.Text = value;
            }
        }

        public string HeroName
        {
            get => labName.Text;

            set
            {
                labName.Text = value;
            }
        }

        public string HealthMax
        {
            get => labMaxHealthValue.Text;

            set
            {
                labMaxHealthValue.Text = value;
            }
        }

        public string Health
        {
            get => labHealthValue.Text;

            set
            {
                labHealthValue.Text = value;
            }
        }

        public string Dmg
        {
            get => labDmgValue.Text;

            set
            {
                labDmgValue.Text = value;
            }
        }

        public string Def
        {
            get => labDefValue.Text;

            set
            {
                labDefValue.Text = value;
            }
        }

        public string Gold
        {
            get => labGoldValue.Text;

            set
            {
                labGoldValue.Text = value;
            }
        }

        public string Lvl
        {
            get => labLvlValue.Text;

            set
            {
                labLvlValue.Text = value;
            }
        }

        public event EventHandler BackToMenu;

        public GameMain(HeroModel hero)
        {
            InitializeComponent();
            _hero = hero;
            _presenter = new GameMainPresenter(this);
            SetHeroStats();
        }

        private void SetHeroStats()
        {
            _presenter.SetHeroStats(_hero);

        }

        private void GameMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (IsPanExitVisible)
                {
                    _presenter.HidePanExit();
                }
                else
                {
                    _presenter.ShowPanExit();
                }
            }
        }

        private void BtnSaveExit_Click(object sender, EventArgs e)
        {
            BackToMenu?.Invoke(sender, e);
            _presenter.SaveGame(_hero);
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            _presenter.HidePanExit();
        }
    }
}
