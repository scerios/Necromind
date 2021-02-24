using NecromindLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.Models
{
    public class EnemyModel : BaseModel, IFighter
    {
        public int Dmg { get; private set; }

        public int Def { get; private set; }

        public int HealthPoints { get; private set; }

        public int HealthPointsMax { get; private set; }

        /// <summary>
        /// This constructor is for testing purposes.
        /// </summary>
        public EnemyModel()
        {
            Gold = 100;
            Level = 1;
            Dmg = 10;
            Def = 5;
            HealthPoints = 5;
            HealthPointsMax = 5;
        }

        public EnemyModel(EnemyModel scheme)
        {
            Id = scheme.Id;
            Name = scheme.Name;
            Gold = scheme.Gold;
            Level = scheme.Level;
            Dmg = scheme.Dmg;
            Def = scheme.Def;
            HealthPoints = scheme.HealthPoints;
            HealthPointsMax = scheme.HealthPointsMax;
        }

        public void Attack(IFighter enemy)
        {
            enemy.TakeDmg(this);
        }

        public void TakeDmg(IFighter enemy)
        {
            HealthPoints -= enemy.Dmg - Def;
            if (HealthPoints < 1)
            {
                Die(enemy);
            }
        }

        public void Die(IFighter enemy)
        {
            var levelablePlayer = enemy as ILevelable;
            levelablePlayer.GainExperience(Level);

            var traderPlayer = enemy as ITrader;
            traderPlayer.RecieveGold(Gold);
        }
    }
}
