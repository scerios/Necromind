using NecromindUI.Views;
using NecromindLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;
using NecromindLibrary.Repository;
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

        public void InitUIForHero(HeroModel hero)
        {
            _hero = hero;
            SetHeroStats();
            SetHeroLabelDatabindings();
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
    }
}
