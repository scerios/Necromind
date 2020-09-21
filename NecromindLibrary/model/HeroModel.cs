using NecromindLibrary.service;
using NUnit.Framework;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

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
        public List<QuestModel> ActiveQuestIds { get; set; }
        /// <summary>
        /// A list of completed quests.
        /// </summary>
        [Column("completed_quest_ids")]
        public List<QuestModel> CompletedQuestIds { get; set; }
        /// <summary>
        /// A weapon currently equipped.
        /// </summary>
        [Column("weapon_id")]
        public WeaponModel Weapon { get; set; }
        /// <summary>
        /// An armor currently equipped.
        /// </summary>
        [Column("armor_id")]
        public ArmorModel Armor { get; set; }

        /// <summary>
        /// Attacks the target KillableModel and returns the attacked target hitpoints after the damage was done.
        /// </summary>
        /// <param name="model">A KillableModel which will be attacked.</param>
        /// <returns>The hitpoints of attacked KillableModel after attack as an int.</returns>
        public int AttackTarget(KillableModel model)
        {
            return model.HitPoints - (this.Damage - model.Defense);
        }
    }
}
