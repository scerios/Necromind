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
        public Label LabHealthMax
        {
            get => labHealthMaxValue;
        }
        public Label LabHealth
        {
            get => labHealthValue;
        }
        public Label LabDmg
        {
            get => labDmgValue;
        }
        public Label LabDef
        {
            get => labDefValue;
        }
        public Label LabGold
        {
            get => labGoldValue;
        }
        public Label LabLvl
        {
            get => labLvlValue;
        }

        public event EventHandler BackToMenu;

        public GameMain(HeroModel hero)
        {
            InitializeComponent();
            _presenter = new GameMainPresenter(this);
            InitUIForHero(hero);
        }

        private void InitUIForHero(HeroModel hero)
        {
            _presenter.InitUIForHero(hero);

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
            _presenter.SaveGame();
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            _presenter.HidePanExit();
        }
    }
}
