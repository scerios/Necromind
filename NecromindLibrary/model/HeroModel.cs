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
        public int ExperiencePoints { get; set; }

        /// <summary>
        /// At how much experience points is the next level.
        /// </summary>
        public int NextLevelAt { get; set; }

        /// <summary>
        /// A list of active quests.
        /// </summary>
        public List<QuestModel> ActiveQuests { get; set; }

        /// <summary>
        /// A list of completed quests.
        /// </summary>
        public List<QuestModel> CompletedQuests { get; set; }

        /// <summary>
        /// A weapon currently equipped.
        /// </summary>
        public WeaponModel Weapon { get; set; }

        /// <summary>
        /// An armor currently equipped.
        /// </summary>
        public ArmorModel Armor { get; set; }

        public HeroModel()
        {

        }

        /// <summary>
        /// Creates a new hero with the given name and default values.
        /// </summary>
        /// <param name="name">Name of the hero.</param>
        public HeroModel(string name)
        {
            Name = name;
            HitPoints = 100;
            HitPointsMax = 100;
            Damage = 10;
            Defense = 5;
            Level = 1;
            ExperiencePoints = 1;
            NextLevelAt = 1000;
            Armor = null;
            Weapon = null;
            ActiveQuests = null;
            CompletedQuests = null;
            Inventory = null;
        }

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
