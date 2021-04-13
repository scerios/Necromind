using MongoDB.Bson.Serialization.Attributes;
using NecromindLibrary.Services;
using System;

namespace NecromindLibrary.Models
{
    public class HeroModel : BaseCharacterModel, IPlayer, IAdminSetter
    {
        private int _dmgMin;

        public int DmgMin
        {
            get => _dmgMin;
            private set
            {
                _dmgMin = value;
                OnPropertyChanged();
            }
        }

        private int _dmgMax;

        public int DmgMax
        {
            get => _dmgMax;
            private set
            {
                _dmgMax = value;
                OnPropertyChanged();
            }
        }

        private int _def;

        public int Def
        {
            get => _def;
            private set
            {
                _def = value;
                OnPropertyChanged();
            }
        }

        private int _health;

        public int Health
        {
            get => _health;
            private set
            {
                _health = value;
                OnPropertyChanged();
            }
        }

        private int _healthMax;

        public int HealthMax
        {
            get => _healthMax;
            private set
            {
                _healthMax = value;
                OnPropertyChanged();
            }
        }

        private int _experiencePoints;

        public int ExperiencePoints
        {
            get => _experiencePoints;
            private set
            {
                _experiencePoints = value;
                OnPropertyChanged();
            }
        }

        private int _nextLvlAt;

        public int NextLvlAt
        {
            get => _nextLvlAt;
            private set
            {
                _nextLvlAt = value;
                OnPropertyChanged();
            }
        }

        private int _locationX;

        [BsonIgnore]
        public int LocationX
        {
            get => _locationX;
        }

        private int _locationY;

        [BsonIgnore]
        public int LocationY
        {
            get => _locationY;
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
            enemy.TakeDmgFrom(this);
        }

        public void TakeDmgFrom(IFighter enemy)
        {
            var rng = new Random();
            var rawDmg = rng.Next(enemy.DmgMin, enemy.DmgMax);
            Health -= rawDmg - Def;

            if (Health < 1)
            {
                DieBy(enemy);
            }
        }

        public void DieBy(IFighter enemy)
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

        public void GainExperience(int amount)
        {
            ExperiencePoints += amount;

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

        public void AdminSetGold(string gold)
        {
            _gold = Int32.Parse(gold);
        }

        public void AdminSetLvl(string lvl)
        {
            _lvl = Int32.Parse(lvl);
        }

        public void AdminSetDmgMin(string dmg)
        {
            _dmgMin = Int32.Parse(dmg);
        }

        public void AdminSetDmgMax(string dmg)
        {
            _dmgMax = Int32.Parse(dmg);
        }

        public void AdminSetDef(string def)
        {
            _def = Int32.Parse(def);
        }

        public void AdminSetHealth(string health)
        {
            var healthAsInt = Int32.Parse(health);
            _healthMax = healthAsInt;
            _health = healthAsInt;
        }
    }
}