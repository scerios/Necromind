﻿using MongoDB.Bson.Serialization.Attributes;
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

        private bool _isRested = true;

        [BsonIgnore]
        public bool IsRested
        {
            get => _isRested;

            private set
            {
                _isRested = value;
            }
        }

        private int _originalDef;

        [BsonIgnore]
        public int OriginalDef
        {
            get => _originalDef;

            private set
            {
                _originalDef = value;
            }
        }

        protected HeroModel()
        {
        }

        public event EventHandler OnMovedNorth;

        public event EventHandler OnMovedSouth;

        public event EventHandler OnMovedWest;

        public event EventHandler OnMovedEast;

        public event EventHandler OnRested;

        public HeroModel(string name)
        {
            Name = name;
            Health = 100;
            HealthMax = 100;
            DmgMin = 5;
            DmgMax = 10;
            Def = 2;
            Lvl = 1;
            ExperiencePoints = 1;
            NextLvlAt = 1000;
        }

        public int Attack(IAttacker enemy) =>
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

        public void SetOriginalDef()
        {
            OriginalDef = Def;
        }

        public int Fortify()
        {
            OriginalDef = Def;

            var extraDef = Def / 2;
            Def += extraDef;

            return extraDef;
        }

        public void EndFortification()
        {
            Def = OriginalDef;
            IsRested = false;
        }

        public void BecomeRested()
        {
            IsRested = true;
            OnRested?.Invoke(this, new System.EventArgs());
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
            OnMovedNorth?.Invoke(this, new System.EventArgs());
        }

        public void MoveSouth()
        {
            PosY++;
            OnMovedSouth?.Invoke(this, new System.EventArgs());
        }

        public void MoveWest()
        {
            PosX--;
            OnMovedWest?.Invoke(this, new System.EventArgs());
        }

        public void MoveEast()
        {
            PosX++;
            OnMovedEast?.Invoke(this, new System.EventArgs());
        }
    }
}