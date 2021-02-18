using NecromindLibrary.model;
using NecromindLibrary.service;
using NUnit.Framework;

namespace Necromind.UnitTests
{
    public class BattleServiceTests
    {
        private HeroModel _hero;
        private MonsterModel _enemy;

        [SetUp]
        public void Setup()
        {
            _hero = new HeroModel();
            _hero.HealthPoints = 100;
            
            _enemy = new MonsterModel();
            _enemy.Name = "Skeleton";
            _enemy.HealthPoints = 100;

        }

        [Test]
        public void Attack_HeroAttacksTargetWith10DamageTargetHas5Defense_TargetLoses5HealthOutOf100()
        {
            _hero.Damage = 10;
            _enemy.Defense = 5;

            var battleService = new BattleService(_hero);
            battleService.Attack(_hero, _enemy);

            Assert.That(_enemy.HealthPoints, Is.EqualTo(95));
        }
    }
}