using System.Windows.Forms;

namespace NecromindUI.Views.Admin
{
    public interface IAdminHeroes
    {
        string HeroName { get; set; }
        string Lvl { get; set; }
        string Gold { get; set; }
        string DmgMin { get; set; }
        string DmgMax { get; set; }
        string Def { get; set; }
        string Health { get; set; }
        ListBox Heroes { get; }
        Timer TimHide { get; }
        Label LabHeroEdit { get; }
    }
}