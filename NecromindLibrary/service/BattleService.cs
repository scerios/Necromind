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

        public KillableModel GetCurrentEnemy()
        {
            return _currentEnemy;
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
        /// Attacker attacks the target and if attacker was the Hero and target is still alive then target will retaliate (attacks back).
        /// </summary>
        /// <param name="attacker">A Killable model who attacks.</param>
        /// <param name="target">A KillableModel who defends.</param>
        public void Attack(KillableModel attacker, KillableModel target)
        {
            int damage = GetActualDamage(attacker.Damage, target.Defense);

            if (damage > 0)
            {
                target.HealthPoints -= damage;

                if (attacker.GetType() == typeof(HeroModel))
                {
                    _UIService.SetEventLogText($"You have dealt { damage } damage to the { target.Name }.", true);

                    if (!target.IsAlive)
                    {
                        _UIService.SetEventLogText($"You have killed the { target.Name }.", true);
                    }
                    else
                    {
                        _UIService.SetEventLogText($"The { target.Name } has { target.HealthPoints } hitpoints remaining.", true, true);

                        // Target (an enemy of the hero) will retaliate after being attacked.
                        Attack(target, attacker);
                    }
                }
                else
                {
                    _UIService.SetEventLogText($"The { attacker.Name } has dealt { damage } damage to you.", true);
                    
                    if (!target.IsAlive)
                    {
                        _UIService.SetEventLogText($"You have died.", true);
                    }
                    else
                    {
                        _UIService.SetEventLogText($"You have { target.HealthPoints } hitpoints remaining.", true, true);
                    }
                }
            }
        }

        /// <summary>
        /// Counts the damage by subtracting target's defense out of attacker's damage.
        /// </summary>
        /// <param name="attackerDamage">Integer value of attacker's damage.</param>
        /// <param name="targetDefense">Integer value of target's defense.</param>
        /// <returns>The damage which is going to be dealt.</returns>
        private int GetActualDamage(int attackerDamage, int targetDefense)
        {
            return attackerDamage - targetDefense;
        }
    }
}
