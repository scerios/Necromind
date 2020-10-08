using NecromindLibrary.model;
using NecromindLibrary.service;
using NUnit.Framework;

namespace Necromind.UnitTests
{
    public class BattleServiceTests
    {
        private HeroModel _hero;

        [SetUp]
        public void Setup()
        {
            _hero = new HeroModel();
        }

        [Test]
        public void GenerateRandomLevel_HeroLevelOne_EnemyLevelBetween0And3()
        {
            _hero.Level = 1;

            var battleService = new BattleService(_hero);
            //var result = battleService.GenerateRandomLevel();

            //Assert.That(result, Is.AtLeast(1).And.LessThan(3));
        }
    }
}