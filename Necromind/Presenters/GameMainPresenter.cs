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

        public void SetHeroStats(HeroModel hero)
        {
            _gameMain.HeroName = hero.Name;
            _gameMain.HealthMax = hero.HealthMax.ToString();
            _gameMain.Health = hero.Health.ToString();
            _gameMain.Dmg = hero.Dmg.ToString();
            _gameMain.Def = hero.Def.ToString();
            _gameMain.Gold = hero.Gold.ToString();
            _gameMain.Lvl = hero.Level.ToString();
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
        }
    }
}
