﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NecromindLibrary.Models
{
    /// <summary>
    /// Base class for any character.
    /// </summary>
    public class BaseCharacterModel : INotifyPropertyChanged
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
        protected int _gold;

        public int Gold
        {
            get => _gold;
            protected set
            {
                _gold = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// On which level the character is.
        /// </summary>
        protected int _lvl;

        public int Lvl
        {
            get => _lvl;
            protected set
            {
                _lvl = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}