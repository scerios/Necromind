using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.Services
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
