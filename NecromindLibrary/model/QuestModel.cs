using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.model
{
    /// <summary>
    /// Represent a quest which the hero can complete.
    /// </summary>
    public class QuestModel
    {
        /// <summary>
        /// ID of the quest.
        /// </summary>
        [BsonId]
        public Guid Id { get; set; }

        /// <summary>
        /// Name of the quest.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A descriptive note about what needs to be done to complete the quest.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// How much experience points the quest gives upon completition.
        /// </summary>
        public int ExperienceReward { get; set; }

        /// <summary>
        /// Items the quest may gives upon completition.
        /// </summary>
        public List<ItemModel> Rewards { get; set; }

        /// <summary>
        /// Items the quest needs from the hero to complete.
        /// </summary>
        public List<ItemModel> Expectations { get; set; }
    }
}
