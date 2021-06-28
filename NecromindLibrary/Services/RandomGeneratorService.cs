using System;
using System.Collections.Generic;

namespace NecromindLibrary.Services
{
    public static class RandomGeneratorService
    {
        private static readonly Random _rng = new Random();
        private const int SPAWN_CHANCE_PERCENT = 20;

        public static bool IsEnemySpawned()
        {
            return _rng.Next(1, 100 / SPAWN_CHANCE_PERCENT) == 1;
        }

        public static Guid GetRandomEnemyId(List<Guid> enemies)
        {
            return enemies[_rng.Next(1, enemies.Count)];
        }
    }
}