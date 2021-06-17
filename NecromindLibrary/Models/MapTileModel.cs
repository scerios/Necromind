using MongoDB.Bson.Serialization.Attributes;
using System;

namespace NecromindLibrary.Models
{
    public class MapTileModel
    {
        /// <summary>
        /// ID of the tile.
        /// </summary>
        [BsonId]
        public Guid Id { get; private set; }

        /// <summary>
        /// Position on the X axis.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Position on the Y axis.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// ID of the held location.
        /// </summary>
        public Guid LocationId { get; set; }
    }
}