using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.models
{
    public class KillableModel : CharacterModel
    {
        public int HitPoints { get; set; }
        public int HitPointsMax { get; set; }
        public int Damage { get; set; }
        public int Defense { get; set; }
        public int Level { get; set; }
        public int Gold { get; set; }
    }
}
