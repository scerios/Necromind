using NecromindLibrary.Config;
using NecromindLibrary.Models;
using System;

namespace NecromindLibrary.Services
{
    public class BattleService
    {
        private readonly MessageLogger _msgLogger = MessageLogger.GetInstance();
        private readonly HeroModel _hero;
        private readonly EnemyModel _enemy;

        public BattleService(HeroModel hero, EnemyModel enemy)
        {
            _hero = hero;
            _enemy = enemy;
            _msgLogger.AppendMessage($"\nYou have encountered a { enemy.Name }!", UISettings.ErrorColor);
        }

        public void AttackOpponent()
        {
            _msgLogger.AppendMessage($"\nYou attack the { _enemy.Name } and deal { _hero.Attack(_enemy) } damage to it.", UISettings.SuccessColor);

            if (_enemy.IsAlive)
                _msgLogger.AppendMessage($"The { _enemy.Name } retaliates and deals { _enemy.Attack(_hero) } damage to you.", UISettings.ErrorColor);
            else
                _msgLogger.AppendMessage($"You have defeated the { _enemy.Name }!", UISettings.SuccessColor);
        }
    }
}