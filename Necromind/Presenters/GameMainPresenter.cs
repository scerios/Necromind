using NecromindUI.Views;
using NecromindLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindUI.Presenters
{
    public class GameMainPresenter
    {
        private readonly IGameMain _gameMain;

        public GameMainPresenter(IGameMain gameMain)
        {
            _gameMain = gameMain;
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
    }
}
