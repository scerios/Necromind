using NecromindLibrary.EventArgs;
using NecromindLibrary.Models;
using NecromindUI.Presenters.Game;
using NecromindUI.Views.Game;
using System;
using System.Windows.Forms;

namespace NecromindUI.UserControls.Game
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

        public bool BtnIsNorthEnabled
        {
            get => btnNorth.Enabled;

            set
            {
                btnNorth.Enabled = value;
            }
        }

        public bool BtnIsSouthEnabled
        {
            get => btnSouth.Enabled;

            set
            {
                btnSouth.Enabled = value;
            }
        }

        public bool BtnIsWestEnabled
        {
            get => btnWest.Enabled;

            set
            {
                btnWest.Enabled = value;
            }
        }

        public bool BtnIsEastEnabled
        {
            get => btnEast.Enabled;

            set
            {
                btnEast.Enabled = value;
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

        public Label LabLocationName
        {
            get => labLocation;
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

            _presenter.MsgLogger.OnMessageRaised += GameMessageRaised;
            _presenter.MsgLogger.OnMessageAppend += GameMessageAppend;
            _presenter.StartGame(hero);
        }

        public void ToggleExitPanVisibility()
        {
            _presenter.TogglePanExitVisibility();
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
            _presenter.MoveNorth();
        }

        private void BtnSouth_Click(object sender, EventArgs e)
        {
            _presenter.MoveSouth();
        }

        private void BtnWest_Click(object sender, EventArgs e)
        {
            _presenter.MoveWest();
        }

        private void BtnEast_Click(object sender, EventArgs e)
        {
            _presenter.MoveEast();
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

        private void GameMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (_presenter.UserInputActions.ContainsKey(e.KeyCode))
            {
                _presenter.UserInputActions[e.KeyCode].Invoke();
            }
        }

        private void GameMessageRaised(object sender, GameMessageEventArgs e)
        {
            _presenter.SetEventLog(e.Message, e.Color);
        }

        private void GameMessageAppend(object sender, GameMessageEventArgs e)
        {
            _presenter.AppendEventLog(e.Message, e.Color);
        }
    }
}