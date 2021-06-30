using MongoDB.Bson.Serialization.Attributes;
using NecromindLibrary.Services;
using NecromindLibrary.Services.GameMechanisms;
using System;

namespace NecromindLibrary.Models
{
    public class HeroModel : BaseCharacterModel, IPlayer
    {
        protected int _dmgMin;

        public int DmgMin
        {
            get => _dmgMin;
            private set
            {
                _dmgMin = value;
                OnPropertyChanged();
            }
        }

        protected int _dmgMax;

        public int DmgMax
        {
            get => _dmgMax;
            private set
            {
                _dmgMax = value;
                OnPropertyChanged();
            }
        }

        protected int _def;

        public int Def
        {
            get => _def;
            private set
            {
                _def = value;
                OnPropertyChanged();
            }
        }

        protected int _health;

        public int Health
        {
            get => _health;
            private set
            {
                _health = value;
                OnPropertyChanged();

                if (_health < 1)
                    Die();
            }
        }

        protected int _healthMax;

        public int HealthMax
        {
            get => _healthMax;
            private set
            {
                _healthMax = value;
                OnPropertyChanged();
            }
        }

        protected int _experiencePoints;

        public int ExperiencePoints
        {
            get => _experiencePoints;
            private set
            {
                _experiencePoints = value;
                OnPropertyChanged();
            }
        }

        protected int _nextLvlAt;

        public int NextLvlAt
        {
            get => _nextLvlAt;
            private set
            {
                _nextLvlAt = value;
                OnPropertyChanged();
            }
        }

        protected int _posX = 0;

        [BsonIgnore]
        public int PosX
        {
            get => _posX;
            private set
            {
                _posX = value;
            }
        }

        protected int _posY = 0;

        [BsonIgnore]
        public int PosY
        {
            get => _posY;
            private set
            {
                _posY = value;
            }
        }

        private bool _isAlive = true;

        [BsonIgnore]
        public bool IsAlive
        {
            get => _isAlive;

            private set
            {
                _isAlive = value;
            }
        }

        protected HeroModel()
        {
        }

        public event EventHandler OnMoveNorth;

        public event EventHandler OnMoveSouth;

        public event EventHandler OnMoveWest;

        public event EventHandler OnMoveEast;

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

        public int Attack(IFighter enemy) =>
            enemy.TakeDmg(RandomGeneratorService.CalculateRandomAttackDmg(DmgMin, DmgMax));

        public int TakeDmg(int dmg)
        {
            var actualDmg = 0;

            if (dmg - Def > 0)
                actualDmg = dmg - Def;

            if (Health - actualDmg <= 0)
            {
                Health = 0;
                IsAlive = false;
            }
            else
                Health -= actualDmg;

            return actualDmg;
        }

        public int Fortify()
        {
            // TODO - Figure out how fortify should work.
            return 2;
        }

        public void Die()
        {
            // TODO - Figure out how death should work.
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

        public void MoveNorth()
        {
            PosY--;
            OnMoveNorth?.Invoke(this, new System.EventArgs());
        }

        public void MoveSouth()
        {
            PosY++;
            OnMoveSouth?.Invoke(this, new System.EventArgs());
        }

        public void MoveWest()
        {
            PosX--;
            OnMoveWest?.Invoke(this, new System.EventArgs());
        }

        public void MoveEast()
        {
            PosX++;
            OnMoveEast?.Invoke(this, new System.EventArgs());
        }
    }
}