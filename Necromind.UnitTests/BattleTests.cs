using NecromindLibrary.Models;
using NUnit.Framework;
using System;

namespace Necromind.UnitTests
{
    public class BattleTests
    {
        private HeroAdminModel _hero;
        private EnemyAdminModel _enemy;

        [SetUp]
        public void Setup()
        {
            _hero = new HeroAdminModel("hero");
            _enemy = new EnemyAdminModel();

            _hero.AdminSetDmgMin(10);
            _enemy.AdminSetDef(0);
        }

        [Test]
        public void HeroAttack_EnemyDamagedOne()
        {
            _hero.Attack(_enemy);

            Assert.That(_enemy.Health, Is.EqualTo(20));
        }

        [Test]
        public void HeroAttack_EnemyDamagedTwice()
        {
            _hero.Attack(_enemy);
            _hero.Attack(_enemy);

            Assert.That(_enemy.Health, Is.EqualTo(10));
        }
    }
}