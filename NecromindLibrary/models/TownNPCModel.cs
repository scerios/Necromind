using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.models
{
    /// <summary>
    /// Represents a friendly NPC which can give quests.
    /// </summary>
    public class TownNPCModel : CharacterModel
    {
        /// <summary>
        /// A list of quests the NPC might provide.
        /// </summary>
        public List<QuestModel> Quests { get; set; }
    }
}
