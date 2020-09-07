using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.models
{
    /// <summary>
    /// Represents a Hero.
    /// </summary>
    public class HeroModel : KillableModel
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
        public List<QuestModel> Quests { get; set; }
        /// <summary>
        /// A weapon currently equipped.
        /// </summary>
        public WeaponModel WeaponSlot { get; set; }
        /// <summary>
        /// An armor currently equipped.
        /// </summary>
        public ArmorModel ArmorSlot { get; set; }
    }
}
