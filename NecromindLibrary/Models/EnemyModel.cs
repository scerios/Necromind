﻿using NecromindLibrary.Services;
using System;

namespace NecromindLibrary.Models
{
    public class EnemyModel : BaseCharacterModel, IFighter, IAdminSetter
    {
        private string _combinedName;

        public string CombinedName
        {
            get => _combinedName;
            private set
            {
                _combinedName = value;
            }
        }

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

        /// <summary>
        /// This constructor is for testing purposes.
        /// </summary>
        public EnemyModel()
        {
            Name = "Dummy";
            Gold = 100;
            Lvl = 1;
            DmgMin = 8;
            DmgMax = 15;
            Def = 4;
            Health = 30;
            HealthMax = 30;
            CombinedName = Name + " " + Lvl;
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
            CombinedName = Name + " " + Lvl;
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
            var levelablePlayer = enemy as ILevelable;
            levelablePlayer.GainExperience(Lvl);

            var traderPlayer = enemy as ITrader;
            traderPlayer.RecieveGold(Gold);
        }

        public void AdminSetName(string name)
        {
            Name = name;
        }

        public void AdminSetGold(int gold)
        {
            Gold = gold;
        }

        public void AdminSetGold(string gold)
        {
            Gold = Int32.Parse(gold);
        }

        public void AdminSetLvl(int lvl)
        {
            Lvl = lvl;
        }

        public void AdminSetLvl(string lvl)
        {
            Lvl = Int32.Parse(lvl);
        }

        public void AdminSetDmgMin(int dmg)
        {
            DmgMin = dmg;
        }

        public void AdminSetDmgMin(string dmg)
        {
            DmgMin = Int32.Parse(dmg);
        }

        public void AdminSetDmgMax(int dmg)
        {
            DmgMax = dmg;
        }

        public void AdminSetDmgMax(string dmg)
        {
            DmgMax = Int32.Parse(dmg);
        }

        public void AdminSetDef(int def)
        {
            Def = def;
        }

        public void AdminSetDef(string def)
        {
            Def = Int32.Parse(def);
        }

        public void AdminSetHealth(int health)
        {
            HealthMax = health;
            Health = health;
        }

        public void AdminSetHealth(string health)
        {
            var healthAsInt = Int32.Parse(health);
            HealthMax = healthAsInt;
            Health = healthAsInt;
        }

        public void AdminSetCombinedName()
        {
            CombinedName = Name + " " + Lvl;
        }
    }
}