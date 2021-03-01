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

        public GameMainPresenter(IGameMain gameMain)
        {
            _gameMain = gameMain;
            _mongoConnector = MongoConnector.GetInstance();
        }

        private void SetHeroStats(HeroModel hero)
        {
            _gameMain.HeroName = hero.Name;
            _gameMain.LabHealthMax.Text = hero.HealthMax.ToString();
            _gameMain.LabHealth.Text = hero.Health.ToString();
            _gameMain.LabDmg.Text = hero.Dmg.ToString();
            _gameMain.LabDef.Text = hero.Def.ToString();
            _gameMain.LabGold.Text = hero.Gold.ToString();
            _gameMain.LabLvl.Text = hero.Lvl.ToString();
        }

        private void SetHeroLabelDatabindings(HeroModel hero)
        {
            _gameMain.LabHealthMax.DataBindings.Add("Text", hero, "HealthMax");
            _gameMain.LabHealth.DataBindings.Add("Text", hero, "Health");
            _gameMain.LabDmg.DataBindings.Add("Text", hero, "Dmg");
            _gameMain.LabDef.DataBindings.Add("Text", hero, "Def");
            _gameMain.LabGold.DataBindings.Add("Text", hero, "Gold");
            _gameMain.LabLvl.DataBindings.Add("Text", hero, "Lvl");
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
            SetHeroStats(hero);
            SetHeroLabelDatabindings(hero);
        }

        public void ShowPanExit()
        {
            _gameMain.IsPanExitVisible = true;
        }

        public void HidePanExit()
        {
            _gameMain.IsPanExitVisible = false;
        }

        public void SaveGame(HeroModel hero)
        {
            _mongoConnector.TryUpsertRecord(ConfigurationManager.AppSettings.Get("heroesCollection"), hero.Id, hero);
            ClearHeroLabelDatabindings();
        }
    }
}
