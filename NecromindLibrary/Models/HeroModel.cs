using NecromindLibrary.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.Models
{
    public class HeroModel : BaseModel, IPlayer
    {
        public int Dmg { get; private set; }

        public int Def { get; private set; }

        public int Health { get; private set; }

        public int HealthMax { get; private set; }

        public int ExperiencePoints { get; private set; }

        public int NextLevelAt { get; private set; }

        public HeroModel(string name)
        {
            Name = name;
            Health = 100;
            HealthMax = 100;
            Dmg = 10;
            Def = 5;
            Level = 1;
            ExperiencePoints = 1;
            NextLevelAt = 1000;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Attack(IFighter enemy)
        {
            enemy.TakeDmg(this);
        }

        public void TakeDmg(IFighter enemy)
        {
            Health -= enemy.Dmg - Def;
            if (Health < 1)
            {
                Die(enemy);
            }
        }

        public void Die(IFighter enemy)
        {
            // TODO - Implement die logic (Game Over).
            throw new NotImplementedException();
        }

        public void Heal(int amount)
        {
            if (Health + amount < HealthMax)
            {
                Health += amount;
            }
            else
            {
                FullyHeal();
            }

        }

        public void FullyHeal()
        {
            Health = HealthMax;
        }

        public void GainExperience(int level)
        {
            ExperiencePoints += level * 10;

            if (ExperiencePoints >= NextLevelAt)
            {
                LevelUp();
            }
        }

        public void LevelUp()
        {
            Level++;
            Dmg += 10;
            Def += 2;
            HealthMax += 20;
            FullyHeal();
            NextLevelAt += Level * 1000;
        }

        public void GiveGold(ITrader trader, int amount)
        {
            trader.RecieveGold(amount);
        }

        public void RecieveGold(int amount)
        {
            Gold += amount;
        }
    }
}
