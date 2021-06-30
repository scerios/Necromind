using System.Windows.Forms;

namespace NecromindUI.Views.Game
{
    public interface IGameMain
    {
        bool PanIsExitVisible { get; set; }
        bool BtnIsNorthEnabled { get; set; }
        bool BtnIsSouthEnabled { get; set; }
        bool BtnIsWestEnabled { get; set; }
        bool BtnIsEastEnabled { get; set; }
        string HeroName { get; set; }
        string TargetName { get; set; }
        Panel PanTarget { get; }
        Panel PanFriendlyInteraction { get; }
        Panel PanHostileInteraction { get; }
        RichTextBox EventLog { get; }
        Label LabLocationName { get; }
        Label LabHeroHealthMax { get; }
        Label LabHeroHealth { get; }
        Label LabHeroDmgMin { get; }
        Label LabHeroDmgMax { get; }
        Label LabHeroDef { get; }
        Label LabHeroGold { get; }
        Label LabHeroLvl { get; }
        Label LabTargetHealthMax { get; }
        Label LabTargetHealth { get; }
        Label LabTargetDmgMin { get; }
        Label LabTargetDmgMax { get; }
        Label LabTargetDef { get; }
        Label LabTargetGold { get; }
        Label LabTargetLvl { get; }
    }
}