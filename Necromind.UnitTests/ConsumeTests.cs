using NecromindLibrary.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Necromind.UnitTests
{
    public class ConsumeTests
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
        public void Consume_Heal()
        {
            var heroOriginalHP = _hero.HealthPoints;

            _hero.TakeDmg(_enemy);
            _hero.TakeDmg(_enemy);
            _hero.Heal(5);

            Assert.That(_hero.HealthPoints, Is.EqualTo(heroOriginalHP - (_enemy.Dmg - _hero.Def) * 2 + 5));
        }

        [Test]
        public void Consume_FullyHeal()
        {
            _hero.TakeDmg(_enemy);
            _hero.TakeDmg(_enemy);
            _hero.Heal(100);

            Assert.That(_hero.HealthPoints, Is.EqualTo(_hero.HealthPointsMax));
        }
    }
}
