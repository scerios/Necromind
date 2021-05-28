using System.Windows.Forms;

namespace NecromindUI.Views.Admin
{
    public interface IAdminHeroes
    {
        string LabName { get; set; }
        string TbLvl { get; set; }
        string TbGold { get; set; }
        string TbDmgMin { get; set; }
        string TbDmgMax { get; set; }
        string TbDef { get; set; }
        string TbHealth { get; set; }
        bool LabLvlError { get; set; }
        bool LabGoldError { get; set; }
        bool LabDmgError { get; set; }
        bool LabDefError { get; set; }
        bool LabHealthError { get; set; }
        ListBox LbHeroes { get; }
        Timer TimHide { get; }
        Label LabHeroEdit { get; }
    }
}