using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.model
{
    /// <summary>
    /// Base class for any character.
    /// </summary>
    public class CharacterModel
    {
        /// <summary>
        /// ID of character.
        /// </summary>
        [BsonId]
        public Guid Id { get; set; }

        /// <summary>
        /// Name of character.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// List of items the character has.
        /// </summary>
        public string Inventory { get; set; }
    }
}
