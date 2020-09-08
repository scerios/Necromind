using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.models
{
    /// <summary>
    /// Represents a living character which can be killed in combat.
    /// </summary>
    public class KillableModel : CharacterModel
    {
        /// <summary>
        /// How many health points the character currently has.
        /// </summary>
        [Column("hitpoints")]
        public int HitPoints { get; set; }
        /// <summary>
        /// How many health point is the maximum for the character.
        /// </summary>
        [Column("hitpoints_max")]
        public int HitPointsMax { get; set; }
        /// <summary>
        /// How much damage the character can deal.
        /// </summary>
        [Column("damage")]
        public int Damage { get; set; }
        /// <summary>
        /// How much damage reduction the character has.
        /// </summary>
        [Column("defense")]
        public int Defense { get; set; }
        /// <summary>
        /// Current level of the character.
        /// </summary>
        [Column("level")]
        public int Level { get; set; }
        /// <summary>
        /// How much gold the character currently has.
        /// </summary>
        [Column("gold")]
        public int Gold { get; set; }
    }
}
