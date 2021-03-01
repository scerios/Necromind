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
        private int _dmg;
        public int Dmg {
            get => _dmg;
            private set
            {
                _dmg = value;
                OnPropertyChanged("Dmg");
            }
        }

        private int _def;
        public int Def {
            get => _def;
            private set
            {
                _def = value;
                OnPropertyChanged("Def");
            }
        }

        private int _health;
        public int Health {
            get => _health;
            private set
            {
                _health = value;
                OnPropertyChanged("Health");
            }
        }

        private int _healthMax;
        public int HealthMax {
            get => _healthMax;
            private set
            {
                _healthMax = value;
                OnPropertyChanged("HealthMax");
            }
        }

        private int _experiencePoints;
        public int ExperiencePoints {
            get => _experiencePoints;
            private set
            {
                _experiencePoints = value;
                OnPropertyChanged("ExperiencePoints");
            }
        }

        private int _nextLvlAt;
        public int NextLvlAt {
            get => _nextLvlAt;
            private set
            {
                _nextLvlAt = value;
                OnPropertyChanged("NextLvlAt");
            }
        }

        public HeroModel(string name)
        {
            Name = name;
            Health = 100;
            HealthMax = 100;
            Dmg = 10;
            Def = 5;
            Lvl = 1;
            ExperiencePoints = 1;
            NextLvlAt = 1000;
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
            // TODO - Implement die logic.
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

            if (ExperiencePoints >= NextLvlAt)
            {
                LevelUp();
            }
        }

        public void LevelUp()
        {
            Lvl++;
            Dmg += 10;
            Def += 2;
            HealthMax += 20;
            FullyHeal();
            NextLvlAt += Lvl * 1000;
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
