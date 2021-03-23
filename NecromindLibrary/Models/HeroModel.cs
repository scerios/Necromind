using NecromindLibrary.Services;
using System;

namespace NecromindLibrary.Models
{
    public class HeroModel : BaseModel, IPlayer, IAdminSetter
    {
        private int _dmgMin;

        public int DmgMin
        {
            get => _dmgMin;
            private set
            {
                _dmgMin = value;
                OnPropertyChanged("DmgMin");
            }
        }

        private int _dmgMax;

        public int DmgMax
        {
            get => _dmgMax;
            private set
            {
                _dmgMax = value;
                OnPropertyChanged("DmgMax");
            }
        }

        private int _def;

        public int Def
        {
            get => _def;
            private set
            {
                _def = value;
                OnPropertyChanged("Def");
            }
        }

        private int _health;

        public int Health
        {
            get => _health;
            private set
            {
                _health = value;
                OnPropertyChanged("Health");
            }
        }

        private int _healthMax;

        public int HealthMax
        {
            get => _healthMax;
            private set
            {
                _healthMax = value;
                OnPropertyChanged("HealthMax");
            }
        }

        private int _experiencePoints;

        public int ExperiencePoints
        {
            get => _experiencePoints;
            private set
            {
                _experiencePoints = value;
                OnPropertyChanged("ExperiencePoints");
            }
        }

        private int _nextLvlAt;

        public int NextLvlAt
        {
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
            DmgMin = 5;
            DmgMax = 10;
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
            // TODO - Implement take dmg logic.
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
            DmgMin += 5;
            DmgMax += 5;
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

        public void AdminSetName(string name)
        {
            Name = name;
        }

        public void AdminSetGold(int gold)
        {
            Gold = gold;
        }

        public void AdminSetLvl(int lvl)
        {
            Lvl = lvl;
        }

        public void AdminSetDmgMin(int dmg)
        {
            DmgMin = dmg;
        }

        public void AdminSetDmgMax(int dmg)
        {
            DmgMax = dmg;
        }

        public void AdminSetDef(int def)
        {
            Def = def;
        }

        public void AdminSetHealth(int health)
        {
            HealthMax = health;
            Health = health;
        }
    }
}