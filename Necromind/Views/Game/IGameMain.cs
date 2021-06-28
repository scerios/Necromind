using System.Windows.Forms;

namespace NecromindUI.Views.Game
{
    public interface IGameMain
    {
        bool PanIsExitVisible { get; set; }
        bool PanIsInteractionVisible { get; set; }
        bool BtnIsNorthEnabled { get; set; }
        bool BtnIsSouthEnabled { get; set; }
        bool BtnIsWestEnabled { get; set; }
        bool BtnIsEastEnabled { get; set; }
        string HeroName { get; set; }
        RichTextBox EventLog { get; }
        Label LabLocationName { get; }

        Label LabHealthMax { get; }
        Label LabHealth { get; }
        Label LabDmgMin { get; }
        Label LabDmgMax { get; }
        Label LabDef { get; }
        Label LabGold { get; }
        Label LabLvl { get; }
    }
}