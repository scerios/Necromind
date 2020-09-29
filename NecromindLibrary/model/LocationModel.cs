using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.model
{
    /// <summary>
    /// Represent a location where the hero can go.
    /// </summary>
    public class LocationModel
    {
        /// <summary>
        /// ID of the location.
        /// </summary>
        [BsonId]
        public Guid Id { get; set; }

        /// <summary>
        /// Name of the location.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A linear area in where the hero can move.
        /// </summary>
        public int[] Map { get; set; }
    }
}
