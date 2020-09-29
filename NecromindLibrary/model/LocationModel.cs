using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.model
{
    public enum LocationType
    {
        Town = 0,
        OutSkirts = 1,
        Monastery = 2
    }
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

        public LocationModel(LocationType location)
        {
            switch (location.ToString())
            {
                case "Town":
                    Name = "Town";

                    break;

                case "OutSkirts":
                    Name = "OutSkirts";
                    Map = SetMap();

                    break;

                case "Monastery":
                    Name = "Monastery";
                    Map = SetMap();

                    break;
            }
        }

        /// <summary>
        /// Builds a map randomly by giving each index either a 0 (empty tile) or 1 (enemy).
        /// </summary>
        /// <returns>The builded map.</returns>
        public int[] SetMap()
        {
            int[] area = new int[10];
            Random rng = new Random();

            //bool isChestGenerated = false;

            for (int i = 0; i < 10; i++)
            {
                //if (!isChestGenerated)
                //{
                //    int tile = rng.Next(0, 3);
                //    area[i] = tile;
                //    isChestGenerated = true;
                //}
                //else
                //{
                //    int tile = rng.Next(0, 2);
                //    area[i] = tile;
                //}

                int tile = rng.Next(0, 2);
                area[i] = tile;
            }

            return area;
        }
    }
}
