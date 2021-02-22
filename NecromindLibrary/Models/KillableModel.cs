using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.model
{
    /// <summary>
    /// Represents a living character which can be killed in combat.
    /// </summary>
    public class KillableModel : CharacterModel, INotifyPropertyChanged
    {
        /// <summary>
        /// How many health points the character currently has.
        /// </summary>
        private int _healthPoints;
        public int HealthPoints 
        {
            get => _healthPoints;

            set
            {
                _healthPoints = value;
                OnPropertyChanged("HealthPoints");

                if (_healthPoints < 0)
                {
                    IsAlive = false;
                }
            }
        }

        /// <summary>
        /// How many health point is the maximum for the character.
        /// </summary>
        private int _healthPointsMax;
        public int HealthPointsMax
        {
            get => _healthPointsMax; 
            set
            {
                _healthPointsMax = value;
                OnPropertyChanged("HealthPointsMax");
            }
        }

        /// <summary>
        /// How much damage the character can deal.
        /// </summary>
        private int _damage;
        public int Damage 
        {
            get => _damage; 
            set
            {
                _damage = value;
                OnPropertyChanged("Damage");
            }
        }

        /// <summary>
        /// How much damage reduction the character has.
        /// </summary>
        private int _defense;
        public int Defense 
        {
            get => _defense;
            set
            {
                _defense = value;
                OnPropertyChanged("Defense");
            }
        }

        /// <summary>
        /// Current level of the character.
        /// </summary>
        private int _level;
        public int Level 
        {
            get => _level;
            set
            {
                _level = value;
                OnPropertyChanged("Level");
            }
        }

        /// <summary>
        /// How much gold the character currently has.
        /// </summary>
        private int _gold;
        public int Gold 
        {
            get => _gold;
            set
            {
                _gold = value;
                OnPropertyChanged("Gold");
            } 
        }

        public bool IsAlive { get; set; } = true;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
