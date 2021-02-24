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
        public void Attack_EnemyKilled()
        {
            var enemyOriginalHP = _enemy.HealthPoints;
            var heroOriginalXP = _hero.ExperiencePoints;
            _hero.Attack(_enemy);

            Assert.That(_enemy.HealthPoints, Is.EqualTo(enemyOriginalHP - _hero.Dmg + _enemy.Def));
            Assert.That(_hero.ExperiencePoints, Is.EqualTo(heroOriginalXP + _enemy.Level * 10));
        }
    }
}
