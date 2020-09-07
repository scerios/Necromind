using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.models
{
    public class QuestModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ExperienceReward { get; set; }
        public List<ItemModel> Rewards { get; set; }
        public List<ItemModel> Expectations { get; set; }
    }
}
