using System;

namespace NecromindLibrary.Services.GameMechanisms
{
    /// <summary>
    /// Fighters can attack, defend and have health points.
    /// </summary>
    public interface IAttacker
    {
        /// <summary>
        /// Minimum damage the character deals.
        /// </summary>
        int DmgMin { get; }

        /// <summary>
        /// Maximum damage the character deals.
        /// </summary>
        int DmgMax { get; }

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
        int Attack(IAttacker enemy);

        /// <summary>
        /// Takes incoming damage by the given amount.
        /// </summary>
        /// <param name="dmg">The actual incoming damage.</param>
        int TakeDmg(int dmg);

        /// <summary>
        /// When healthpoints reach 0, the character dies.
        /// </summary>
        void Die();
    }
}