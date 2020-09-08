using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.models
{
    /// <summary>
    /// Represent a quest which the hero can complete.
    /// </summary>
    public class QuestModel
    {
        /// <summary>
        /// ID of the quest.
        /// </summary>
        [Column("id")]
        public int Id { get; set; }
        /// <summary>
        /// Name of the quest.
        /// </summary>
        [Column("name")]
        public string Name { get; set; }
        /// <summary>
        /// A descriptive note about what needs to be done to complete the quest.
        /// </summary>
        [Column("description")]
        public string Description { get; set; }
        /// <summary>
        /// How much experience points the quest gives upon completition.
        /// </summary>
        [Column("experience_reward")]
        public int ExperienceReward { get; set; }
        /// <summary>
        /// Items the quest may gives upon completition.
        /// </summary>
        [Column("reward_item_ids")]
        public List<ItemModel> Rewards { get; set; }
        /// <summary>
        /// Items the quest needs from the hero to complete.
        /// </summary>
        [Column("expected_item_ids")]
        public List<ItemModel> Expectations { get; set; }
    }
}
