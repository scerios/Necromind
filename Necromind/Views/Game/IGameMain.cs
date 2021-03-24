using System.Windows.Forms;

namespace NecromindUI.Views.Game
{
    public interface IGameMain
    {
        bool IsPanExitVisible { get; set; }
        string CurrentLocation { get; set; }
        string HeroName { get; set; }
        RichTextBox EventLog { get; }
        Label LabHealthMax { get; }
        Label LabHealth { get; }
        Label LabDmgMin { get; }
        Label LabDmgMax { get; }
        Label LabDef { get; }
        Label LabGold { get; }
        Label LabLvl { get; }
    }
}