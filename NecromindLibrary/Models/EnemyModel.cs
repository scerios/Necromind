using NecromindLibrary.Services;
using System;

namespace NecromindLibrary.Models
{
    public class EnemyModel : BaseModel, IFighter
    {
        public int DmgMin { get; private set; }
        public int DmgMax { get; private set; }

        public int Def { get; private set; }

        public int Health { get; private set; }

        public int HealthMax { get; private set; }

        /// <summary>
        /// This constructor is for testing purposes.
        /// </summary>
        public EnemyModel()
        {
            Gold = 100;
            Lvl = 1;
            DmgMin = 5;
            DmgMax = 5;
            Def = 5;
            Health = 5;
            HealthMax = 5;
        }

        public EnemyModel(EnemyModel scheme)
        {
            Id = scheme.Id;
            Name = scheme.Name;
            Gold = scheme.Gold;
            Lvl = scheme.Lvl;
            DmgMin = scheme.DmgMin;
            DmgMax = scheme.DmgMax;
            Def = scheme.Def;
            Health = scheme.Health;
            HealthMax = scheme.HealthMax;
        }

        public void Attack(IFighter enemy)
        {
            enemy.TakeDmg(this);
        }

        public void TakeDmg(IFighter enemy)
        {
            //Health -= enemy.Dmg - Def;
            //if (Health < 1)
            //{
            //    Die(enemy);
            //}
        }

        public void Die(IFighter enemy)
        {
            var levelablePlayer = enemy as ILevelable;
            levelablePlayer.GainExperience(Lvl);

            var traderPlayer = enemy as ITrader;
            traderPlayer.RecieveGold(Gold);
        }
    }
}