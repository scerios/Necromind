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
        [Column("id")]
        public int Id { get; set; }
        /// <summary>
        /// Name of the item.
        /// </summary>
        [Column("name")]
        public string Name { get; set; }
        /// <summary>
        /// Buying price of the item.
        /// </summary>
        [Column("buy_price")]
        public int BuyPrice { get; set; }
        /// <summary>
        /// Selling price of the item.
        /// </summary>
        [Column("sell_price")]
        public int SellPrice { get; set; }
        /// <summary>
        /// Decides if the item can be sold to merchant or not.
        /// </summary>
        [Column("is_sellable")]
        public bool IsSellable { get; set; }
    }
}
