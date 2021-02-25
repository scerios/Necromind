using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindUI.Views
{
    public interface IGameMain
    {
        string CurrentLocation { get; set; }
        string HeroName { get; set; }
        string HealthMax { get; set; }
        string Health { get; set; }
        string Dmg { get; set; }
        string Def { get; set; }
        string Gold { get; set; }
        string Lvl { get; set; }
    }
}
