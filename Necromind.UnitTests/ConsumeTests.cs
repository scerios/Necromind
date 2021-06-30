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
            _hero = new HeroAdminModel("hero");
            _enemy = new EnemyAdminModel();
        }

        [Test]
        public void Consume_Heal()
        {
            _hero.TakeDmg(10);
            _hero.Heal(5);

            Assert.That(_hero.Health, Is.InRange(95, 100));
        }

        [Test]
        public void Consume_FullyHeal()
        {
            _hero.TakeDmg(10);
            _hero.TakeDmg(10);
            _hero.TakeDmg(10);
            _hero.TakeDmg(10);
            _hero.FullyHeal();

            Assert.That(_hero.Health, Is.EqualTo(_hero.HealthMax));
        }
    }
}