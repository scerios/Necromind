using NecromindLibrary.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.service
{
    public class BattleService
    {
        private Random random = new Random();
        private HeroModel _currentHero;
        private KillableModel _currentEnemy;

        public BattleService(HeroModel hero)
        {
            _currentHero = hero;
        }

        private void GenerateRandomEnemy()
        {
            var enemy = new MonsterModel();

            enemy.Level = GenerateRandomLevel();
        }

        public int GenerateRandomLevel()
        {
            int minLevel = _currentHero.Level == 1 ? 1 : _currentHero.Level;

            return random.Next(minLevel, _currentHero.Level + 1);
        }

        public int GenerateRandomHealth()
        {
            return 100;
        }
    }
}
