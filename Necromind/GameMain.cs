using Necromind;
using NecromindLibrary.Models;
using NecromindUI.Presenters;
using NecromindUI.Views;
using System;
using System.Windows.Forms;

namespace NecromindUI
{
    public partial class GameMain : UserControl, IGameMain
    {
        private readonly GameMainPresenter _presenter;
        private readonly GameFriendlyInteraction _gameFriendlyInteraction;
        private readonly GameEnemyInteraction _gameEnemyInteraction;

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

        public RichTextBox EventLog
        {
            get => rtbEventLog;
        }

        public Label LabHealthMax
        {
            get => labHealthMaxValue;
        }

        public Label LabHealth
        {
            get => labHealthValue;
        }

        public Label LabDmgMin
        {
            get => labDmgMinValue;
        }

        public Label LabDmgMax
        {
            get => labDmgMaxValue;
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

        public event EventHandler BtnBackToMenu;

        public GameMain(HeroModel hero)
        {
            InitializeComponent();
            _presenter = new GameMainPresenter(this);
            _gameFriendlyInteraction = new GameFriendlyInteraction();
            _gameEnemyInteraction = new GameEnemyInteraction();
            StartGame(hero);
        }

        private void BtnSaveExit_Click(object sender, EventArgs e)
        {
            BtnBackToMenu?.Invoke(sender, e);
            _presenter.SaveAndExitGame();
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            _presenter.TogglePanExitVisibility();
        }

        private void BtnNorth_Click(object sender, EventArgs e)
        {
            // TODO - Implement move north logic.
        }

        private void BtnSouth_Click(object sender, EventArgs e)
        {
            // TODO - Implement move south logic.
        }

        private void BtnWest_Click(object sender, EventArgs e)
        {
            // TODO - Implement move west logic.
        }

        private void BtnEast_Click(object sender, EventArgs e)
        {
            // TODO - Implement move east logic.
        }

        private void ActivateView(Panel panel, UserControl view)
        {
            panel.Controls.Add(view);
            view.BringToFront();
        }

        private void DeactivateView(Panel panel, UserControl view)
        {
            panel.Controls.Remove(view);
        }

        private void StartGame(HeroModel hero)
        {
            InitUIFor(hero);
            SetLocationName("Town Square");
            SetEventLog("You are in the town square");
        }

        private void InitUIFor(HeroModel hero)
        {
            _presenter.InitUIFor(hero);
        }

        private void SetLocationName(string name)
        {
            _presenter.SetLocationName(name);
        }

        private void SetEventLog(string msg)
        {
            _presenter.SetEventLog(msg);
        }

        private void ShowFriendlyUI()
        {
            ActivateView(panInteraction, _gameFriendlyInteraction);
        }

        private void HideFriendlyUI()
        {
            DeactivateView(panInteraction, _gameFriendlyInteraction);
        }

        private void ShowEnemyUI()
        {
            ActivateView(panInteraction, _gameEnemyInteraction);
        }

        private void HideEnemyUI()
        {
            DeactivateView(panInteraction, _gameEnemyInteraction);
        }

        public void ToggleExitPanVisibility()
        {
            _presenter.TogglePanExitVisibility();
        }
    }
}