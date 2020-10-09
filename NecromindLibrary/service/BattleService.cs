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
        private UIService _UIService = UIService.GetInstance();
        private Random random = new Random();
        private HeroModel _currentHero;
        private KillableModel _currentEnemy = new MonsterModel();

        public BattleService(HeroModel hero)
        {
            _currentHero = hero;
            GenerateRandomEnemy();
        }

        /// <summary>
        /// Generates an enemy with random details.
        /// </summary>
        private void GenerateRandomEnemy()
        {
            _currentEnemy.Name = "Skeleton";
            _currentEnemy.Level = GenerateRandomLevel();
            _currentEnemy.HealthPointsMax = GenerateRandomHealth();
            _currentEnemy.HealthPoints = _currentEnemy.HealthPointsMax;
            _currentEnemy.Damage = GenerateRandomDamage();
            _currentEnemy.Defense = GenerateRandomDefense();
            _currentEnemy.Gold = GenerateRandomGold();
        }

        /// <summary>
        /// Generates a random int for the enemy's level based on the hero's current level.
        /// </summary>
        /// <returns>A random int.</returns>
        private int GenerateRandomLevel()
        {
            int minLevel = _currentHero.Level == 1 ? 1 : _currentHero.Level;

            return random.Next(minLevel, _currentHero.Level + 1);
        }

        /// <summary>
        /// Generates a random int for the enemy's maximum/current hitpoints based on the enemy's level.
        /// </summary>
        /// <returns>A random int.</returns>
        private int GenerateRandomHealth()
        {
            return random.Next(_currentEnemy.Level * 20 + 100 - 20, _currentEnemy.Level * 20 + 100 + 20);
        }

        /// <summary>
        /// Generates a random int for the enemy's damage based on the enemy's level.
        /// </summary>
        /// <returns>A random int.</returns>
        private int GenerateRandomDamage()
        {
            return random.Next(_currentEnemy.Level * 5, _currentEnemy.Level * 5 + 5);
        }

        /// <summary>
        /// Generates a random int for the enemy's defense based on the enemy's level.
        /// </summary>
        /// <returns>A random int.</returns>
        private int GenerateRandomDefense()
        {
            return random.Next(_currentEnemy.Level * 2, _currentEnemy.Level * 3 + 2);
        }

        /// <summary>
        /// Generates a random int for the enemy's gold based on random values.
        /// </summary>
        /// <returns>A random int.</returns>
        private int GenerateRandomGold()
        {
            int probability = random.Next(0, 3);
            int gold = 0;

            switch (probability)
            {
                case 0:
                    break;

                case 1:
                    gold = random.Next(1, _currentEnemy.Level * 5);
                    break;

                case 2:
                    gold = random.Next(_currentEnemy.Level * 5, _currentEnemy.Level * 10);
                    break;
            }

            return gold;
        }

        /// <summary>
        /// Returns the enemy's name as a string.
        /// </summary>
        /// <returns>The enemy's name as a string.</returns>
        public string GetEnemyName()
        {
            return _currentEnemy.Name;
        }

        /// <summary>
        /// The hero attacks the target then if the target is still alive it strikes back.
        /// </summary>
        public void AttackTarget()
        {
            _currentEnemy.HealthPoints -= _currentHero.Damage - _currentEnemy.Defense;
            _UIService.SetEventLogText($"You have dealt { _currentHero.Damage - _currentEnemy.Defense } damage to the { _currentEnemy.Name }. { _currentEnemy.HealthPoints } remains.", true);

            if (_currentEnemy.HealthPoints < 1)
            {
                _currentEnemy.OnKilled += EnemyKilled;
            }
            else
            {
                AttackHero();
            }
        }

        private void EnemyKilled(object sender, EventArgs e)
        {
            _UIService.SetEventLogText("You have killed the enemy", true, true);
        }

        /// <summary>
        /// The enemy attacks the hero.
        /// </summary>
        private void AttackHero()
        {
            _currentHero.HealthPoints -= _currentEnemy.Damage - _currentHero.Defense;
            _UIService.SetEventLogText($"The { _currentEnemy.Name } have dealt { _currentEnemy.Damage - _currentHero.Defense } damage to you. { _currentHero.HealthPoints } remains.", true, true);

            if (_currentHero.HealthPoints < 1)
            {
                _currentHero.OnKilled += HeroKilled;
            }
        }

        private void HeroKilled(object sender, EventArgs e)
        {
            _UIService.SetEventLogText("You have been killed");
        }
    }
}
