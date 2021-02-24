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
        int HealthPoints { get; }

        /// <summary>
        /// Maximum health points.
        /// </summary>
        int HealthPointsMax { get; }

        /// <summary>
        /// Performs an attack against the target. Attack dmg is calculated by subtracting enemy's def from attackers dmg.
        /// </summary>
        /// <param name="enemy">An enemy which can fight.</param>
        void Attack(IFighter enemy);

        /// <summary>
        /// Takes dmg from the incoming attack.
        /// </summary>
        /// <param name="amount">The actual dmg of the attack.</param>
        void TakeDmg(int amount);

        /// <summary>
        /// When healthpoints reach 0, the character dies.
        /// </summary>
        void Die();
    }
}
