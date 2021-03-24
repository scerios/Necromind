using NecromindLibrary.Models;
using NUnit.Framework;
using System;

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
            var heroOriginalHP = _hero.Health;

            _hero.TakeDmgFrom(_enemy);
            _hero.Heal(5);

            Assert.That(_hero.Health, Is.InRange(95, 100));
        }

        [Test]
        public void Consume_FullyHeal()
        {
            _hero.TakeDmgFrom(_enemy);
            _hero.TakeDmgFrom(_enemy);
            _hero.TakeDmgFrom(_enemy);
            _hero.TakeDmgFrom(_enemy);
            _hero.FullyHeal();

            Assert.That(_hero.Health, Is.EqualTo(_hero.HealthMax));
        }
    }
}