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

        //public EnemyModel(EnemyModel scheme)
        //{
        //    Id = scheme.Id;
        //    Name = scheme.Name;
        //    Gold = scheme.Gold;
        //    Level = scheme.Level;
        //    Dmg = scheme.Dmg;
        //    Def = scheme.Def;
        //    HealthPoints = scheme.HealthPoints;
        //    HealthPointsMax = scheme.HealthPointsMax;
        //}

        public void Attack(IFighter enemy)
        {
            enemy.TakeDmg(Dmg - enemy.Def);
        }

        public void TakeDmg(int amount)
        {
            HealthPoints -= amount;
            if (HealthPoints < 1)
            {
                Die();
            }
        }

        public void Die()
        {

        }
    }
}
