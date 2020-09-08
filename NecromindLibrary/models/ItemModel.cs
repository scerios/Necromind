using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.models
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
    }
}
