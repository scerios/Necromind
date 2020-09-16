using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.model
{
    /// <summary>
    /// Represents a weapon the hero can equip.
    /// </summary>
    public class WeaponModel : ItemModel
    {
        /// <summary>
        /// How much damage the weapon gives.
        /// </summary>
        [Column("damage")]
        public int Damage { get; set; }
    }
}
