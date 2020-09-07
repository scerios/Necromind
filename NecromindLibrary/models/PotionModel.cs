using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.models
{
    /// <summary>
    /// Represents a potion which can refill some health.
    /// </summary>
    public class PotionModel
    {
        /// <summary>
        /// Amount of health returned by the potion.
        /// </summary>
        public int HealthValue { get; set; }
    }
}
