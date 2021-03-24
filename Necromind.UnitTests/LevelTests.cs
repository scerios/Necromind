using NecromindLibrary.Models;
using NUnit.Framework;
using System;

namespace Necromind.UnitTests
{
    public class LevelTests
    {
        private HeroModel _hero;

        [SetUp]
        public void Setup()
        {
            _hero = new HeroModel("hero");
        }

        [Test]
        public void Level_LevelUp()
        {
            _hero.GainExperience(1001);

            Assert.That(_hero.Lvl, Is.EqualTo(2));
        }
    }
}