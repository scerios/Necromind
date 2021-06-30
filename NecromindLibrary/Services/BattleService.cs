using NecromindLibrary.Config;
using NecromindLibrary.Models;
using System;

namespace NecromindLibrary.Services
{
    public class BattleService
    {
        private MessageLogger _msgLogger = MessageLogger.GetInstance();
        private readonly HeroModel _hero;
        private readonly EnemyModel _enemy;

        public BattleService(HeroModel hero, EnemyModel enemy)
        {
            _hero = hero;
            _enemy = enemy;
            _msgLogger.AppendMessage($"\nYou have encountered a { enemy.Name }!", UISettings.ErrorColor);
        }
    }
}