using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.Models
{
    /// <summary>
    /// Base class for any character.
    /// </summary>
    public class BaseModel
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
        /// How much gold the character has.
        /// </summary>
        public int Gold { get; set; }

        /// <summary>
        /// On which level the character is.
        /// </summary>
        public int Level { get; set; }
    }
}
