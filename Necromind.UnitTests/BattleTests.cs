using System;
using System.Collections.Generic;
using System.Text;
using NecromindLibrary.Models;
using NUnit.Framework;

namespace Necromind.UnitTests
{
    public class BattleTests
    {
        private HeroModel _hero;
        private EnemyModel _enemy;

        [SetUp]
        public void Setup()
        {
            _hero = new HeroModel("hero");
            _enemy = new EnemyModel();
        }

        [Test]
        public void HeroAttack_EnemyKilled()
        {
            var enemyOriginalHP = _enemy.Health;
            var heroOriginalXP = _hero.ExperiencePoints;
            var heroOriginalGold = _hero.Gold;

            _hero.Attack(_enemy);

            Assert.That(_enemy.Health, Is.EqualTo(enemyOriginalHP - _hero.Dmg + _enemy.Def));
            Assert.That(_hero.ExperiencePoints, Is.EqualTo(heroOriginalXP + _enemy.Level * 10));
            Assert.That(_hero.Gold, Is.EqualTo(heroOriginalGold + _enemy.Gold));
        }
    }
}
