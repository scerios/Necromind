using NecromindLibrary.Models;
using NUnit.Framework;
using System;

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
        public void HeroAttack_EnemyDamagedOne()
        {
            _hero.Attack(_enemy);

            Assert.That(_enemy.Health, Is.InRange(24, 29));
        }

        [Test]
        public void HeroAttack_EnemyDamagedTwice()
        {
            _hero.Attack(_enemy);
            _hero.Attack(_enemy);

            Assert.That(_enemy.Health, Is.InRange(18, 28));
        }
    }
}