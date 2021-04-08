using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

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
        /// True if player can move to this location. False otherwise.
        /// </summary>
        public bool IsAccessible { get; set; }

        /// <summary>
        /// True if location can spawn enemies.
        /// </summary>
        public bool IsHostile { get; set; }

        /// <summary>
        /// List of enemy IDs which can spawn on the location.
        /// </summary>
        public List<Guid> Enemies { get; set; } = new List<Guid>();
    }
}