using NecromindLibrary.Config;
using NecromindLibrary.EventArgs;
using NecromindLibrary.Models;
using NecromindLibrary.Repository;
using NecromindLibrary.Services;
using NecromindUI.Presenters.Game;
using NecromindUI.Views.Game;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NecromindUI.UserControls.Game
{
    public partial class GameMain : UserControl, IGameMain
    {
        #region Properties

        private readonly GameMainPresenter _presenter;
        private readonly MongoConnector _mongoConnector = MongoConnector.GetInstance();
        private readonly List<Panel> _map = new List<Panel>();

        #region Bools

        public bool PanIsExitVisible
        {
            get => panExit.Visible;
            set
            {
                panExit.Visible = value;

                if (value)
                    panExit.BringToFront();
                else
                    panExit.SendToBack();
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

        #endregion Bools

        public Panel PanTarget
        {
            get => panTarget;
        }

        public Panel PanFriendlyInteraction
        {
            get => panFriendlyInteraction;
        }

        public Panel PanHostileInteraction
        {
            get => panHostileInteraction;
        }

        public RichTextBox EventLog
        {
            get => rtbEventLog;
        }

        public Label LabLocationName
        {
            get => labLocation;
        }

        #region Hero

        public string HeroName
        {
            get => labHeroName.Text;
            set
            {
                labHeroName.Text = value;
            }
        }

        public Label LabHeroHealthMax
        {
            get => labHeroHealthMax;
        }

        public Label LabHeroHealth
        {
            get => labHeroHealth;
        }

        public Label LabHeroDmgMin
        {
            get => labHeroDmgMin;
        }

        public Label LabHeroDmgMax
        {
            get => labHeroDmgMax;
        }

        public Label LabHeroDef
        {
            get => labHeroDef;
        }

        public Label LabHeroGold
        {
            get => labHeroGold;
        }

        public Label LabHeroLvl
        {
            get => labHeroLvl;
        }

        #endregion Hero

        #region Target

        public string TargetName
        {
            get => labTargetName.Text;

            set
            {
                labTargetName.Text = value;
            }
        }

        public Label LabTargetHealthMax
        {
            get => labTargetHealthMax;
        }

        public Label LabTargetHealth
        {
            get => labTargetHealth;
        }

        public Label LabTargetDmgMin
        {
            get => labTargetDmgMin;
        }

        public Label LabTargetDmgMax
        {
            get => labTargetDmgMax;
        }

        public Label LabTargetDef
        {
            get => labTargetDef;
        }

        public Label LabTargetGold
        {
            get => labTargetGold;
        }

        public Label LabTargetLvl
        {
            get => labTargetLvl;
        }

        #endregion Target

        #endregion Properties

        public event EventHandler OnSaveExitClick;

        public GameMain(HeroModel hero)
        {
            LoadMap();
            InitializeComponent();

            _presenter = new GameMainPresenter(this, hero, _map);

            SetPresenterEventListeners();
            SetHerosEventListeners(hero);

            _presenter.StartGame();
        }

        public void ToggleExitPanVisibility()
        {
            _presenter.TogglePanExitVisibility();
        }

        private void LoadMap()
        {
            int locY = 10;

            for (int i = -10; i <= 10; i++)
            {
                int locX = 10;
                locY += UISettings.MapTileSize;

                for (int j = -10; j <= 10; j++)
                {
                    var tile = _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, j, i);

                    locX += UISettings.MapTileSize;

                    if (tile == null)
                        Controls.Add(UIService.CreateMapPanel(locX, locY, j, i, UISettings.EmptyTileColor));
                    else
                    {
                        var location = _mongoConnector.GetRecordById<LocationModel>(DBConfig.LocationsCollection, tile.LocationId.ToString());

                        if (!location.IsAccessible)
                            Controls.Add(UIService.CreateMapPanel(locX, locY, j, i, UISettings.UnaccessibleTileColor));

                        if (location.IsHostile)
                            Controls.Add(UIService.CreateMapPanel(locX, locY, j, i, UISettings.ErrorColor));
                        else
                            Controls.Add(UIService.CreateMapPanel(locX, locY, j, i, UISettings.SuccessColor));
                    }

                    _map.Add((Panel)Controls.Find("pan" + j + "I" + i, false)[0]);
                }
            }
        }

        private void SetPresenterEventListeners()
        {
            _presenter.MsgLogger.OnMessageRaised += GameMessageRaised;
            _presenter.MsgLogger.OnMessageAppend += GameMessageAppend;
        }

        private void SetHerosEventListeners(HeroModel hero)
        {
            hero.MovedNorth += MoveNorth;
            hero.MovedSouth += MoveSouth;
            hero.MovedWest += MoveWest;
            hero.MovedEast += MoveEast;
        }

        private void BtnSaveExit_Click(object sender, EventArgs e)
        {
            _presenter.SaveAndExitGame();
            _presenter.MsgLogger.OnMessageRaised -= GameMessageRaised;
            _presenter.MsgLogger.OnMessageAppend -= GameMessageAppend;

            OnSaveExitClick?.Invoke(sender, e);
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

        private void MoveNorth(object sender, EventArgs e)
        {
            _presenter.MoveNorth();
        }

        private void MoveSouth(object sender, EventArgs e)
        {
            _presenter.MoveSouth();
        }

        private void MoveWest(object sender, EventArgs e)
        {
            _presenter.MoveWest();
        }

        private void MoveEast(object sender, EventArgs e)
        {
            _presenter.MoveEast();
        }
    }
}