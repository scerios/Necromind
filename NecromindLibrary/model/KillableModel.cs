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
        private int _hitPoints;
        /// <summary>
        /// How many health points the character currently has.
        /// </summary>
        public int HitPoints {
            get 
            { 
                return _hitPoints; 
            } 

            set
            {
                _hitPoints = value;
                OnPropertyChanged("HitPoints");
            }
        }

        /// <summary>
        /// How many health point is the maximum for the character.
        /// </summary>
        public int HitPointsMax { get; set; }

        /// <summary>
        /// How much damage the character can deal.
        /// </summary>
        public int Damage { get; set; }

        /// <summary>
        /// How much damage reduction the character has.
        /// </summary>
        public int Defense { get; set; }

        /// <summary>
        /// Current level of the character.
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// How much gold the character currently has.
        /// </summary>
        public int Gold { get; set; }

        public event EventHandler OnKilled;
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
