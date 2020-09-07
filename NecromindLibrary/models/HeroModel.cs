using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.models
{
    public class HeroModel : KillableModel
    {
        public int ExperiencePoints { get; set; }
        public int NextLevelAt { get; set; }
        public List<QuestModel> Quests { get; set; }
        public WeaponModel WeaponSlot { get; set; }
        public ArmorModel ArmorSlot { get; set; }
    }
}
