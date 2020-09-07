using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.models
{
    /// <summary>
    /// Represents a weapon the hero can equip.
    /// </summary>
    public class WeaponModel : ItemModel
    {
        /// <summary>
        /// How much damage the weapon gives.
        /// </summary>
        public int Damage { get; set; }
    }
}
