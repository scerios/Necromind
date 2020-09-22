using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.model
{
    /// <summary>
    /// Represents an armor a hero can equip.
    /// </summary>
    public class ArmorModel : ItemModel
    {
        /// <summary>
        /// How much defense the armor provides.
        /// </summary>
        public int Defense { get; set; }
    }
}
