using NecromindLibrary.repository;
using NecromindLibrary.service;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.model
{
    /// <summary>
    /// Represents a Hero.
    /// </summary>
    public class HeroModel : KillableModel, IBattle
    {
        /// <summary>
        /// How much experience points the hero currently has.
        /// </summary>
        [Column("experience_points")]
        public int ExperiencePoints { get; set; }
        /// <summary>
        /// At how much experience points is the next level.
        /// </summary>
        [Column("next_level_at")]
        public int NextLevelAt { get; set; }
        /// <summary>
        /// A list of active quests.
        /// </summary>
        [Column("active_quest_ids")]
        public string ActiveQuestsIds { get; set; }
        /// <summary>
        /// A list of completed quests.
        /// </summary>
        [Column("completed_quest_ids")]
        public string CompletedQuestsIds { get; set; }
        /// <summary>
        /// A weapon currently equipped.
        /// </summary>
        [Column("weapon_id")]
        public int WeaponId { get; set; }
        /// <summary>
        /// An armor currently equipped.
        /// </summary>
        [Column("armor_id")]
        public int ArmorId { get; set; }

        /// <summary>
        /// Attacks the target KillableModel and returns the value which the target will be damaged.
        /// </summary>
        /// <param name="model">A KillableModel which will be attacked.</param>
        /// <returns>The actual damage as an int.</returns>
        public int AttackTarget(KillableModel model)
        {
            return this.Damage - model.Defense;
        }
    }
}
