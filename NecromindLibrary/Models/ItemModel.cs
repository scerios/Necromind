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
    /// A base class for all the items.
    /// </summary>
    public class ItemModel
    {
        /// <summary>
        /// ID in the database.
        /// </summary>
        [BsonId]
        public Guid Id { get; set; }

        /// <summary>
        /// Name of the item.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Buying price of the item.
        /// </summary>
        public int BuyPrice { get; set; }

        /// <summary>
        /// Selling price of the item.
        /// </summary>
        public int SellPrice { get; set; }

        /// <summary>
        /// Decides if the item can be sold to merchant or not.
        /// </summary>
        public bool IsSellable { get; set; }
    }
}
