using MongoDB.Bson.Serialization.Attributes;
using System;

namespace NecromindLibrary.Models
{
    /// <summary>
    /// Holds a location on the map where the hero can go.
    /// </summary>
    public class LocationModel
    {
        /// <summary>
        /// ID of the location.
        /// </summary>
        [BsonId]
        public Guid Id { get; private set; }

        /// <summary>
        /// Name of the location.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of the location.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// True if location can spawn enemies.
        /// </summary>
        public bool IsHostile { get; set; }

        /// <summary>
        /// Array of enemy IDs which can spawn on the location.
        /// </summary>
        public Guid[] Enemies { get; set; }
    }
}