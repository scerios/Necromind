﻿using NecromindLibrary.Models;
using NecromindLibrary.Repository;
using NecromindLibrary.Services;
using NecromindUI.Views;
using System.Configuration;

namespace NecromindUI.Presenters
{
    public class GameMainPresenter
    {
        private readonly MongoConnector _mongoConnector;
        private readonly IGameMain _gameMain;
        private HeroModel _hero;

        public GameMainPresenter(IGameMain gameMain)
        {
            _gameMain = gameMain;
            _mongoConnector = MongoConnector.GetInstance();
        }

        private void SetHeroStats()
        {
            _gameMain.HeroName = _hero.Name;
            _gameMain.LabHealthMax.Text = _hero.HealthMax.ToString();
            _gameMain.LabHealth.Text = _hero.Health.ToString();
            _gameMain.LabDmg.Text = _hero.Dmg.ToString();
            _gameMain.LabDef.Text = _hero.Def.ToString();
            _gameMain.LabGold.Text = _hero.Gold.ToString();
            _gameMain.LabLvl.Text = _hero.Lvl.ToString();
        }

        private void SetHeroLabelDatabindings()
        {
            _gameMain.LabHealthMax.DataBindings.Add("Text", _hero, "HealthMax");
            _gameMain.LabHealth.DataBindings.Add("Text", _hero, "Health");
            _gameMain.LabDmg.DataBindings.Add("Text", _hero, "Dmg");
            _gameMain.LabDef.DataBindings.Add("Text", _hero, "Def");
            _gameMain.LabGold.DataBindings.Add("Text", _hero, "Gold");
            _gameMain.LabLvl.DataBindings.Add("Text", _hero, "Lvl");
        }

        private void ClearHeroLabelDatabindings()
        {
            _gameMain.LabHealthMax.DataBindings.Clear();
            _gameMain.LabHealth.DataBindings.Clear();
            _gameMain.LabDmg.DataBindings.Clear();
            _gameMain.LabDef.DataBindings.Clear();
            _gameMain.LabGold.DataBindings.Clear();
            _gameMain.LabLvl.DataBindings.Clear();
        }

        private void ScrollEventLogToBottom()
        {
            _gameMain.EventLog.SelectionStart = _gameMain.EventLog.Text.Length;
            _gameMain.EventLog.ScrollToCaret();
        }

        public void InitUIForHero(HeroModel hero)
        {
            _hero = hero;
            SetHeroStats();
            SetHeroLabelDatabindings();
        }

        public void SetEventLog(string msg)
        {
            _gameMain.EventLog.Text = TextService.FormatEventMsg(msg);
            ScrollEventLogToBottom();
        }

        public void AppendEventLog(string msg)
        {
            _gameMain.EventLog.Text = _gameMain.EventLog + "\n" + TextService.FormatEventMsg(msg);
            ScrollEventLogToBottom();
        }

        public void SetLocationName(string name)
        {
            _gameMain.CurrentLocation = name;
        }

        public void ShowPanExit()
        {
            _gameMain.IsPanExitVisible = true;
        }

        public void HidePanExit()
        {
            _gameMain.IsPanExitVisible = false;
        }

        public void SaveGame()
        {
            _mongoConnector.TryUpsertRecord(ConfigurationManager.AppSettings.Get("heroesCollection"), _hero.Id, _hero);
            ClearHeroLabelDatabindings();
        }

        public void ShowFriendlyUI()
        {
        }
    }
}