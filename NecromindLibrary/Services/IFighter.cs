using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.Services
{
    /// <summary>
    /// Fighters can attack, defend and have health points.
    /// </summary>
    public interface IFighter
    {
        /// <summary>
        /// Actual damage the character deals.
        /// </summary>
        int Dmg { get; set; }

        /// <summary>
        /// Defense points which helps reducing incoming damage.
        /// </summary>
        int Def { get; set; }

        /// <summary>
        /// Current health points.
        /// </summary>
        int HealthPoints { get; set; }

        /// <summary>
        /// Maximum health points.
        /// </summary>
        int HealthPointsMax { get; set; }
    }
}
