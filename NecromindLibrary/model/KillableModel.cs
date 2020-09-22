using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.model
{
    /// <summary>
    /// Represents a living character which can be killed in combat.
    /// </summary>
    public class KillableModel : CharacterModel
    {
        /// <summary>
        /// How many health points the character currently has.
        /// </summary>
        public int HitPoints { get; set; }

        /// <summary>
        /// How many health point is the maximum for the character.
        /// </summary>
        public int HitPointsMax { get; set; }

        /// <summary>
        /// How much damage the character can deal.
        /// </summary>
        public int Damage { get; set; }

        /// <summary>
        /// How much damage reduction the character has.
        /// </summary>
        public int Defense { get; set; }

        /// <summary>
        /// Current level of the character.
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// How much gold the character currently has.
        /// </summary>
        public int Gold { get; set; }
    }
}
