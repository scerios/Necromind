using System.Windows.Forms;

namespace NecromindUI.Views
{
    public interface IGameMain
    {
        bool IsPanExitVisible { get; set; }
        string CurrentLocation { get; set; }
        string HeroName { get; set; }
        RichTextBox EventLog { get; }
        Label LabHealthMax { get; }
        Label LabHealth { get; }
        Label LabDmg { get; }
        Label LabDef { get; }
        Label LabGold { get; }
        Label LabLvl { get; }
    }
}