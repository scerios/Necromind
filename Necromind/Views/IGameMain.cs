using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NecromindUI.Views
{
    public interface IGameMain
    {
        bool IsPanExitVisible { get; set; }
        string CurrentLocation { get; set; }
        string HeroName { get; set; }
        string EventLog { get; set; }
        Label LabHealthMax { get; }
        Label LabHealth { get; }
        Label LabDmg { get; }
        Label LabDef { get; }
        Label LabGold { get; }
        Label LabLvl { get; }
    }
}
