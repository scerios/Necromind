using MongoDB.Bson.Serialization.Attributes;
using NecromindLibrary.Services;
using NecromindLibrary.Services.GameMechanisms;
using System;

namespace NecromindLibrary.Models
{
    public class EnemyModel : BaseCharacterModel, IFighter
    {
        protected string _combinedName;

        public string CombinedName
        {
            get => _combinedName;
            protected set
            {
                _combinedName = value;
            }
        }

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

        private bool _isAlive = true;

        [BsonIgnore]
        public bool IsAlive
        {
            get => _isAlive;

            private set
            {
                _isAlive = value;
                OnDeath?.Invoke(this, new System.EventArgs());
            }
        }

        public event EventHandler OnDeath;

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
            Def = 5;
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
            return 0;
        }

        public void Die()
        {
        }
    }
}