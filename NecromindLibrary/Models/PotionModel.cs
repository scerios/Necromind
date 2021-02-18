using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.model
{
    /// <summary>
    /// Represents a potion which can refill some health.
    /// </summary>
    public class PotionModel : ItemModel
    {
        /// <summary>
        /// Amount of health returned by the potion.
        /// </summary>
        public int HealthValue { get; set; }
    }
}
