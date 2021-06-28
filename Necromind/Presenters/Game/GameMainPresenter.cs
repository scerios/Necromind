﻿using NecromindLibrary.Config;
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
        private readonly MapService _mapService = new MapService();
        public readonly Dictionary<Keys, Action> UserInputActions = new Dictionary<Keys, Action>();
        public readonly MessageLogger MsgLogger = MessageLogger.GetInstance();
        private HeroModel _hero;

        public GameMainPresenter(IGameMain gameMain)
        {
            _gameMain = gameMain;
            SetUserInputActions();
        }

        public void StartGame(HeroModel hero)
        {
            _hero = hero;

            SetLocationName();
            SetHeroStats();
            SetHeroLabelDatabindings();

            _mapService.SetNeighborhood();
            _mapService.SetNeighborhoodLocations();
            SetMovementBtns();

            MsgLogger.SetMessage(GetCurrentLocationDesc(), UISettings.TextColorDefault);
            MsgLogger.AppendMessage($"\n{ GetSurroundingLocationsNames() }", UISettings.TextColorInfo);
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
                MsgLogger.SetMessage(GetCurrentLocationDesc(), UISettings.TextColorDefault);
                MsgLogger.AppendMessage($"\n{ GetSurroundingLocationsNames() }", UISettings.TextColorInfo);

                SetLocationName();
                SetMovementBtns();
            }
        }

        public void MoveSouth()
        {
            if (_gameMain.BtnIsSouthEnabled)
            {
                _mapService.MoveSouth();
                MsgLogger.SetMessage(GetCurrentLocationDesc(), UISettings.TextColorDefault);
                MsgLogger.AppendMessage($"\n{ GetSurroundingLocationsNames() }", UISettings.TextColorInfo);

                SetLocationName();
                SetMovementBtns();
            }
        }

        public void MoveWest()
        {
            if (_gameMain.BtnIsWestEnabled)
            {
                _mapService.MoveWest();
                MsgLogger.SetMessage(GetCurrentLocationDesc(), UISettings.TextColorDefault);
                MsgLogger.AppendMessage($"\n{ GetSurroundingLocationsNames() }", UISettings.TextColorInfo);

                SetLocationName();
                SetMovementBtns();
            }
        }

        public void MoveEast()
        {
            if (_gameMain.BtnIsEastEnabled)
            {
                _mapService.MoveEast();
                MsgLogger.SetMessage(GetCurrentLocationDesc(), UISettings.TextColorDefault);
                MsgLogger.AppendMessage($"\n{ GetSurroundingLocationsNames() }", UISettings.TextColorInfo);

                SetLocationName();
                SetMovementBtns();
            }
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

        private void SetUserInputActions()
        {
            UserInputActions.Add(Keys.W, () => MoveNorth());
            UserInputActions.Add(Keys.S, () => MoveSouth());
            UserInputActions.Add(Keys.A, () => MoveWest());
            UserInputActions.Add(Keys.D, () => MoveEast());
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