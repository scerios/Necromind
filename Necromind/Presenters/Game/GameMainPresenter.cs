using NecromindLibrary.Config;
using NecromindLibrary.Models;
using NecromindLibrary.Repository;
using NecromindLibrary.Services;
using NecromindUI.Views.Game;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NecromindUI.Presenters.Game
{
    public class GameMainPresenter
    {
        private readonly IGameMain _gameMain;
        private readonly MongoConnector _mongoConnector = MongoConnector.GetInstance();
        private readonly MapService _mapService = new MapService();
        private HeroModel _hero;

        private readonly Dictionary<Keys, Action> _userInputActions = new Dictionary<Keys, Action>();
        public Dictionary<Keys, Action> UserInputActions => _userInputActions;

        private readonly MessageLogger _msgLogger = MessageLogger.GetInstance();
        public MessageLogger MsgLogger => _msgLogger;

        public GameMainPresenter(IGameMain gameMain)
        {
            _gameMain = gameMain;
            SetUserInputActions();
        }

        public void StartGame(HeroModel hero)
        {
            _hero = hero;

            _msgLogger.RaiseMessage(GetCurrentLocationDesc());

            SetLocationName();
            SetHeroStats();

            SetHeroLabelDatabindings();
            _mapService.SetNeighborhood();
            SetMovementBtns();
        }

        public void SetEventLog(string msg)
        {
            _gameMain.EventLog.Text = TextService.FormatEventMsg(msg);
            ScrollEventLogToBottom();
        }

        public void AppendEventLog(string msg)
        {
            _gameMain.EventLog.Text = _gameMain.EventLog.Text + "\n" + TextService.FormatEventMsg(msg);
            ScrollEventLogToBottom();
        }

        public string GetCurrentLocationDesc() =>
            _mapService.Location.Description;

        public void TogglePanExitVisibility()
        {
            if (_gameMain.IsPanExitVisible)
            {
                _gameMain.IsPanExitVisible = false;
            }
            else
            {
                _gameMain.IsPanExitVisible = true;
            }
        }

        public void SaveAndExitGame()
        {
            _mongoConnector.TryUpsertRecord(DBConfig.HeroesCollection, _hero.Id, _hero);
            ClearHeroLabelDatabindings();
            ClearLocationDataBinding();
        }

        public void ShowFriendlyUI()
        {
            // TODO - Add logic to show friendly UI.
        }

        #region Movement

        public void MoveNorth()
        {
            if (_gameMain.BtnIsNorthEnabled)
            {
                _mapService.MoveNorth();
                SetLocationName();
                SetMovementBtns();
            }
        }

        public void MoveSouth()
        {
            if (_gameMain.BtnIsSouthEnabled)
            {
                _mapService.MoveSouth();
                SetLocationName();
                SetMovementBtns();
            }
        }

        public void MoveWest()
        {
            if (_gameMain.BtnIsWestEnabled)
            {
                _mapService.MoveWest();
                SetLocationName();
                SetMovementBtns();
            }
        }

        public void MoveEast()
        {
            if (_gameMain.BtnIsEastEnabled)
            {
                _mapService.MoveEast();
                SetLocationName();
                SetMovementBtns();
            }
        }

        #endregion Movement

        #region Setters

        private void SetUserInputActions()
        {
            _userInputActions.Add(Keys.W, () => MoveNorth());
            _userInputActions.Add(Keys.S, () => MoveSouth());
            _userInputActions.Add(Keys.A, () => MoveWest());
            _userInputActions.Add(Keys.D, () => MoveEast());
        }

        private void SetLocationName()
        {
            _gameMain.LabLocationName.Text = _mapService.Location.Name;
        }

        private void SetHeroStats()
        {
            _gameMain.HeroName = _hero.Name;
            _gameMain.LabHealthMax.Text = _hero.HealthMax.ToString();
            _gameMain.LabHealth.Text = _hero.Health.ToString();
            _gameMain.LabDmgMin.Text = _hero.DmgMin.ToString();
            _gameMain.LabDmgMax.Text = _hero.DmgMax.ToString();
            _gameMain.LabDef.Text = _hero.Def.ToString();
            _gameMain.LabGold.Text = _hero.Gold.ToString();
            _gameMain.LabLvl.Text = _hero.Lvl.ToString();
        }

        private void SetHeroLabelDatabindings()
        {
            _gameMain.LabHealthMax.DataBindings.Add("Text", _hero, "HealthMax");
            _gameMain.LabHealth.DataBindings.Add("Text", _hero, "Health");
            _gameMain.LabDmgMin.DataBindings.Add("Text", _hero, "DmgMin");
            _gameMain.LabDmgMax.DataBindings.Add("Text", _hero, "DmgMax");
            _gameMain.LabDef.DataBindings.Add("Text", _hero, "Def");
            _gameMain.LabGold.DataBindings.Add("Text", _hero, "Gold");
            _gameMain.LabLvl.DataBindings.Add("Text", _hero, "Lvl");
        }

        private void SetMovementBtns()
        {
            _gameMain.BtnIsNorthEnabled = _mapService.DoesCurrentHasNorthNeighbor() && _mapService.IsNorthOfCurrentAccessible();
            _gameMain.BtnIsSouthEnabled = _mapService.DoesCurrentHasSouthNeighbor() && _mapService.IsSouthOfCurrentAccessible();
            _gameMain.BtnIsWestEnabled = _mapService.DoesCurrentHasWestNeighbor() && _mapService.IsWestOfCurrentAccessible();
            _gameMain.BtnIsEastEnabled = _mapService.DoesCurrentHasEastNeighbor() && _mapService.IsEastOfCurrentAccessible();
        }

        #endregion Setters

        #region Clear

        private void ClearHeroLabelDatabindings()
        {
            _gameMain.LabHealthMax.DataBindings.Clear();
            _gameMain.LabHealth.DataBindings.Clear();
            _gameMain.LabDmgMin.DataBindings.Clear();
            _gameMain.LabDmgMax.DataBindings.Clear();
            _gameMain.LabDef.DataBindings.Clear();
            _gameMain.LabGold.DataBindings.Clear();
            _gameMain.LabLvl.DataBindings.Clear();
        }

        private void ClearLocationDataBinding()
        {
            _gameMain.LabLocationName.DataBindings.Clear();
        }

        #endregion Clear

        private void ScrollEventLogToBottom()
        {
            _gameMain.EventLog.SelectionStart = _gameMain.EventLog.Text.Length;
            _gameMain.EventLog.ScrollToCaret();
        }
    }
}