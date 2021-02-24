using NecromindLibrary.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Necromind.UnitTests
{
    public class LevelTests
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
        public void Level_LevelUp()
        {
            _hero.GainExperience(100);

            Assert.That(_hero.Level, Is.EqualTo(2));
        }
    }
}
