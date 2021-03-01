using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.Models
{
    /// <summary>
    /// Base class for any character.
    /// </summary>
    public class BaseModel : INotifyPropertyChanged
    {
        /// <summary>
        /// ID of character.
        /// </summary>
        [BsonId]
        public Guid Id { get; protected set; }

        /// <summary>
        /// Name of character.
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// How much gold the character has.
        /// </summary>
        private int _gold;
        public int Gold {
            get => _gold;
            protected set
            {
                _gold = value;
                OnPropertyChanged("Gold");
            }
        }

        /// <summary>
        /// On which level the character is.
        /// </summary>
        private int _lvl;
        public int Lvl {
            get => _lvl;
            protected set
            {
                _lvl = value;
                OnPropertyChanged("Lvl");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
