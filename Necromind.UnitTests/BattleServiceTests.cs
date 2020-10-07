using NecromindLibrary.model;
using NecromindLibrary.service;
using NUnit.Framework;

namespace Necromind.UnitTests
{
    public class BattleServiceTests
    {
        private HeroModel _hero;
        private KillableModel _enemy;

        [SetUp]
        public void Setup()
        {
            _hero = new HeroModel();
            _enemy = new KillableModel();
        }

        [Test]
        public void GenerateRandomLevel_HeroLevelOne_EnemyLevelBetween0And3()
        {
            _hero.Level = 1;

            var battleService = new BattleService(_hero);
            var result = battleService.GenerateRandomLevel();

            Assert.That(result, Is.AtLeast(1).And.LessThan(3));
        }

        [Test]
        public void GenerateRandomLevel_HeroLevelFive_EnemyLevelBetween3And7()
        {
            _hero.Level = 5;

            var battleService = new BattleService(_hero);
            var result = battleService.GenerateRandomLevel();

            Assert.That(result, Is.AtLeast(4).And.LessThan(7));
        }

        [Test]
        public void GenerateEnemyHealth_EnemyLevelOne_EnemyHealthBetween90And110()
        {
            _enemy.Level = 1;

            var battleService = new BattleService(_hero);
            var result = battleService.GenerateRandomHealth();

            Assert.That(result, Is.AtLeast(90).And.LessThanOrEqualTo(110));
        }
    }
}