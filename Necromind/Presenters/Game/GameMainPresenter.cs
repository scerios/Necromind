using NecromindLibrary.Config;
using NecromindLibrary.Models;
using NecromindLibrary.Repository;
using NecromindLibrary.Services;
using NecromindUI.Views.Game;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NecromindUI.Presenters.Game
{
    public class GameMainPresenter
    {
        // TODO - Figure out fight logic.

        private const string UNDER_CONSTRUCTION = "A magical barrier blocks the way.";
        private readonly IGameMain _gameMain;
        private readonly MongoConnector _mongoConnector = MongoConnector.GetInstance();
        private readonly MapService _mapService;
        private BattleService _battleService;
        public readonly Dictionary<Keys, Action> UserInputActions = new Dictionary<Keys, Action>();
        public readonly MessageLogger MsgLogger = MessageLogger.GetInstance();
        private readonly HeroModel _hero;
        private EnemyModel _enemy;

        public GameMainPresenter(IGameMain gameMain, HeroModel hero, List<Panel> map)
        {
            _gameMain = gameMain;
            _hero = hero;
            _mapService = new MapService(_hero.PosX, _hero.PosY, map);
            //EnableUserInputActions();
        }

        public void StartGame()
        {
            SetLocationName();
            SetHeroDatabindings();

            _mapService.SetNeighborhood();
            _mapService.SetNeighborhoodLocations();

            SetMovementBtns();
            SetEventLogInfo();
        }

        #region Event log

        public void SetEventLog(string msg, Color color)
        {
            _gameMain.EventLog.Clear();
            _gameMain.EventLog.SelectionStart = _gameMain.EventLog.TextLength;
            _gameMain.EventLog.SelectionLength = 0;

            _gameMain.EventLog.SelectionColor = color;
            _gameMain.EventLog.AppendText(msg);
            _gameMain.EventLog.SelectionColor = _gameMain.EventLog.ForeColor;
            ScrollEventLogToBottom();
        }

        public void AppendEventLog(string msg, Color color)
        {
            _gameMain.EventLog.SelectionStart = _gameMain.EventLog.TextLength;
            _gameMain.EventLog.SelectionLength = 0;

            _gameMain.EventLog.SelectionColor = color;
            _gameMain.EventLog.AppendText("\n" + msg);
            _gameMain.EventLog.SelectionColor = _gameMain.EventLog.ForeColor;
            ScrollEventLogToBottom();
        }

        #endregion Event log

        public void TogglePanExitVisibility()
        {
            if (_gameMain.PanIsExitVisible)
            {
                _gameMain.PanIsExitVisible = false;
            }
            else
            {
                _gameMain.PanIsExitVisible = true;
            }
        }

        public void SaveAndExitGame()
        {
            _mongoConnector.TryUpsertRecord(DBConfig.HeroesCollection, _hero.Id, _hero);
            ClearHeroDatabindings();
            ClearLocationDataBinding();
        }

        #region Movement

        public void MoveNorth()
        {
            if (_gameMain.BtnIsNorthEnabled)
            {
                _mapService.MoveNorth();

                SetEventLogInfo();
                CheckForEnemy();
                SetLocationName();
            }
        }

        public void MoveSouth()
        {
            if (_gameMain.BtnIsSouthEnabled)
            {
                _mapService.MoveSouth();

                SetEventLogInfo();
                CheckForEnemy();
                SetLocationName();
            }
        }

        public void MoveWest()
        {
            if (_gameMain.BtnIsWestEnabled)
            {
                _mapService.MoveWest();

                SetEventLogInfo();
                CheckForEnemy();
                SetLocationName();
            }
        }

        public void MoveEast()
        {
            if (_gameMain.BtnIsEastEnabled)
            {
                _mapService.MoveEast();

                SetEventLogInfo();
                CheckForEnemy();
                SetLocationName();
            }
        }

        private void CheckForEnemy()
        {
            if (IsTileHostileAndEnemyAppears())
                InitFight();
            else
                SetMovementBtns();
        }

        private bool IsTileHostileAndEnemyAppears() =>
            _mapService.Location.IsHostile && RandomGeneratorService.IsEnemySpawned();

        private void InitFight()
        {
            //DisableUserInputActions();
            DisableMovementBtns();

            _enemy = _mongoConnector.GetRecordById<EnemyModel>(DBConfig.EnemiesCollection, RandomGeneratorService.GetRandomEnemyId(_mapService.Location.Enemies).ToString());

            _battleService = new BattleService(_hero, _enemy);

            TogglePanTargetVisibility();
            TogglePanHostileInteractionVisibility();
            SetHostileTargetDataBindings();
        }

        #endregion Movement

        #region Getters

        private string GetCurrentLocationDesc() =>
            _mapService.Location.Description;

        private string GetSurroundingLocationsNames()
        {
            string north = _mapService.NorthLocationOfCurrent != null ?
                $"{ _mapService.NorthLocationOfCurrent.Name } - { _mapService.NorthLocationOfCurrent.Description }" : UNDER_CONSTRUCTION;

            string south = _mapService.SouthLocationOfCurrent != null ?
                $"{ _mapService.SouthLocationOfCurrent.Name } - { _mapService.SouthLocationOfCurrent.Description }" : UNDER_CONSTRUCTION;

            string west = _mapService.WestLocationOfCurrent != null ?
                $"{ _mapService.WestLocationOfCurrent.Name } - { _mapService.WestLocationOfCurrent.Description }" : UNDER_CONSTRUCTION;

            string east = _mapService.EastLocationOfCurrent != null ?
                $"{ _mapService.EastLocationOfCurrent.Name } - { _mapService.EastLocationOfCurrent.Description }" : UNDER_CONSTRUCTION;

            return $"North: { north }\nSouth: { south }\nWest: { west }\nEast: { east }";
        }

        #endregion Getters

        #region Setters

        private void EnableUserInputActions()
        {
            UserInputActions.Add(Keys.W, () => _hero.MoveNorth());
            UserInputActions.Add(Keys.S, () => _hero.MoveSouth());
            UserInputActions.Add(Keys.A, () => _hero.MoveWest());
            UserInputActions.Add(Keys.D, () => _hero.MoveEast());
        }

        private void DisableUserInputActions()
        {
            UserInputActions.Clear();
        }

        private void SetLocationName()
        {
            _gameMain.LabLocationName.Text = _mapService.Location.Name;
        }

        private void SetHeroDatabindings()
        {
            _gameMain.HeroName = _hero.Name;
            _gameMain.LabHeroHealthMax.DataBindings.Add("Text", _hero, "HealthMax");
            _gameMain.LabHeroHealth.DataBindings.Add("Text", _hero, "Health");
            _gameMain.LabHeroDmgMin.DataBindings.Add("Text", _hero, "DmgMin");
            _gameMain.LabHeroDmgMax.DataBindings.Add("Text", _hero, "DmgMax");
            _gameMain.LabHeroDef.DataBindings.Add("Text", _hero, "Def");
            _gameMain.LabHeroGold.DataBindings.Add("Text", _hero, "Gold");
            _gameMain.LabHeroLvl.DataBindings.Add("Text", _hero, "Lvl");
        }

        private void SetHostileTargetDataBindings()
        {
            _gameMain.TargetName = _enemy.Name;
            _gameMain.LabTargetHealthMax.DataBindings.Add("Text", _enemy, "HealthMax");
            _gameMain.LabTargetHealth.DataBindings.Add("Text", _enemy, "Health");
            _gameMain.LabTargetDmgMin.DataBindings.Add("Text", _enemy, "DmgMin");
            _gameMain.LabTargetDmgMax.DataBindings.Add("Text", _enemy, "DmgMax");
            _gameMain.LabTargetDef.DataBindings.Add("Text", _enemy, "Def");
            _gameMain.LabTargetGold.DataBindings.Add("Text", _enemy, "Gold");
            _gameMain.LabTargetLvl.DataBindings.Add("Text", _enemy, "Lvl");
        }

        private void SetMovementBtns()
        {
            _gameMain.BtnIsNorthEnabled = _mapService.DoesCurrentHasNorthNeighbor() && _mapService.IsNorthOfCurrentAccessible();
            _gameMain.BtnIsSouthEnabled = _mapService.DoesCurrentHasSouthNeighbor() && _mapService.IsSouthOfCurrentAccessible();
            _gameMain.BtnIsWestEnabled = _mapService.DoesCurrentHasWestNeighbor() && _mapService.IsWestOfCurrentAccessible();
            _gameMain.BtnIsEastEnabled = _mapService.DoesCurrentHasEastNeighbor() && _mapService.IsEastOfCurrentAccessible();
        }

        private void DisableMovementBtns()
        {
            _gameMain.BtnIsNorthEnabled = false;
            _gameMain.BtnIsSouthEnabled = false;
            _gameMain.BtnIsWestEnabled = false;
            _gameMain.BtnIsEastEnabled = false;
        }

        private void SetEventLogInfo()
        {
            MsgLogger.SetMessage(GetCurrentLocationDesc(), UISettings.TextColorDefault);
            MsgLogger.AppendMessage($"\n{ GetSurroundingLocationsNames() }", UISettings.TextColorInfo);
        }

        #endregion Setters

        #region Clear

        private void ClearHeroDatabindings()
        {
            _gameMain.LabHeroHealthMax.DataBindings.Clear();
            _gameMain.LabHeroHealth.DataBindings.Clear();
            _gameMain.LabHeroDmgMin.DataBindings.Clear();
            _gameMain.LabHeroDmgMax.DataBindings.Clear();
            _gameMain.LabHeroDef.DataBindings.Clear();
            _gameMain.LabHeroGold.DataBindings.Clear();
            _gameMain.LabHeroLvl.DataBindings.Clear();
        }

        private void ClearLocationDataBinding()
        {
            _gameMain.LabLocationName.DataBindings.Clear();
        }

        private void ClearHostileTargetDataBindings()
        {
            _gameMain.LabTargetHealthMax.DataBindings.Clear();
            _gameMain.LabTargetHealth.DataBindings.Clear();
            _gameMain.LabTargetDmgMin.DataBindings.Clear();
            _gameMain.LabTargetDmgMax.DataBindings.Clear();
            _gameMain.LabTargetDef.DataBindings.Clear();
            _gameMain.LabTargetGold.DataBindings.Clear();
            _gameMain.LabTargetLvl.DataBindings.Clear();
        }

        #endregion Clear

        private void TogglePanTargetVisibility()
        {
            if (_gameMain.PanTarget.Visible)
                _gameMain.PanTarget.Visible = false;
            else
                _gameMain.PanTarget.Visible = true;
        }

        private void TogglePanFriendlyInteractionVisibility()
        {
            if (_gameMain.PanFriendlyInteraction.Visible)
                _gameMain.PanFriendlyInteraction.Visible = false;
            else
                _gameMain.PanFriendlyInteraction.Visible = true;
        }

        private void TogglePanHostileInteractionVisibility()
        {
            if (_gameMain.PanHostileInteraction.Visible)
                _gameMain.PanHostileInteraction.Visible = false;
            else
                _gameMain.PanHostileInteraction.Visible = true;
        }

        private void ScrollEventLogToBottom()
        {
            _gameMain.EventLog.SelectionStart = _gameMain.EventLog.Text.Length;
            _gameMain.EventLog.ScrollToCaret();
        }
    }
}