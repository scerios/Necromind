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
        int Dmg { get; }

        /// <summary>
        /// Defense points which helps reducing incoming damage.
        /// </summary>
        int Def { get; }

        /// <summary>
        /// Current health points.
        /// </summary>
        int Health { get; }

        /// <summary>
        /// Maximum health points.
        /// </summary>
        int HealthMax { get; }

        /// <summary>
        /// Performs an attack against the target.
        /// </summary>
        /// <param name="enemy">An enemy which can fight.</param>
        void Attack(IFighter enemy);

        /// <summary>
        /// Takes dmg from the incoming attack.
        /// </summary>
        /// <param name="enemy">The enemy which attacks.</param>
        void TakeDmg(IFighter enemy);

        /// <summary>
        /// When healthpoints reach 0, the character dies.
        /// </summary>
        void Die(IFighter enemy);
    }
}
