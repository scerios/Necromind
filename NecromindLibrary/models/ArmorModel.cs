using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.models
{
    /// <summary>
    /// Represents a piece of armor.
    /// </summary>
    public class ArmorModel : ItemModel
    {
        /// <summary>
        /// How much defense the armor provides.
        /// </summary>
        public int Defense { get; set; }
    }
}
