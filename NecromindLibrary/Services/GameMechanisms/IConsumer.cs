using System;

namespace NecromindLibrary.Services.GameMechanisms
{
    /// <summary>
    /// Consumers can consume items and can heal at certain points.
    /// </summary>
    public interface IConsumer
    {
        /// <summary>
        /// Heals the character by a specific amount.
        /// </summary>
        /// <param name="amount"></param>
        void Heal(int amount);

        /// <summary>
        /// Fully heals the character.
        /// </summary>
        void FullyHeal();
    }
}