using MongoDB.Bson.Serialization.Attributes;
using System;

namespace NecromindLibrary.Models
{
    /// <summary>
    /// A collection of locations as a 5x5 area.
    /// </summary>
    public class AreaModel
    {
        /// <summary>
        /// ID of the area.
        /// </summary>
        [BsonId]
        public Guid Id { get; private set; }

        /// <summary>
        /// Name of the area.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A 5x5 matrix of locations.
        /// </summary>
        public LocationModel[,] Locations { get; set; } = new LocationModel[5, 5];
    }
}