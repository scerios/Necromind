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
        private int _roundCounter = 0;
        private int _fortifiedRound = 0;

        public BattleService(HeroModel hero, EnemyModel enemy)
        {
            _hero = hero;
            _hero.SetOriginalDef();

            _enemy = enemy;
            _msgLogger.AppendMessage($"\nYou have encountered a { enemy.Name }!", UISettings.ErrorColor);
        }

        public void AttackOpponent()
        {
            _msgLogger.AppendMessage($"\nYou attack the { _enemy.Name } and deal { _hero.Attack(_enemy) } damage to it.", UISettings.SuccessColor);

            if (IsEnemyAlive())
            {
                EnemyRetaliate();
                NextRound();
            }
            else
                FinalizeBattle();
        }

        public void Fortify()
        {
            _fortifiedRound = _roundCounter;
            _msgLogger.AppendMessage($"\nYou ready yourself for incoming attacks and by doing so you gain +{ _hero.Fortify() } Def for 3 rounds.", UISettings.SuccessColor);

            EnemyRetaliate();
            NextRound();
        }

        private void EndFortification()
        {
            _msgLogger.AppendMessage($"\nYou become tired of so much awareness and cannot keep up your defensive stance anymore.", UISettings.ErrorColor);

            _hero.EndFortification();
        }

        private void BecomeRested()
        {
            _msgLogger.AppendMessage($"\nYou become rested and you are able to fortify yourself again!.", UISettings.SuccessColor);

            _fortifiedRound = 0;
            _hero.BecomeRested();
        }

        private void EnemyRetaliate() =>
            _msgLogger.AppendMessage($"The { _enemy.Name } retaliates and deals { _enemy.Attack(_hero) } damage to you.", UISettings.ErrorColor);

        private bool IsEnemyAlive() =>
            _enemy.IsAlive;

        private void FinalizeBattle()
        {
            _msgLogger.AppendMessage($"You have defeated the { _enemy.Name }!", UISettings.SuccessColor);

            if (IsHeroFortified())
                _hero.EndFortification();
        }

        private void NextRound()
        {
            if (IsHeroFortified() && IsHeroTired())
                EndFortification();

            if (IsHeroRested())
                BecomeRested();

            _roundCounter++;
        }

        private bool IsHeroFortified() =>
            _hero.Def > _hero.OriginalDef;

        private bool IsHeroTired() =>
            _roundCounter - _fortifiedRound > 2;

        private bool IsHeroRested() =>
            !_hero.IsRested && _roundCounter - _fortifiedRound > 4;
    }
}