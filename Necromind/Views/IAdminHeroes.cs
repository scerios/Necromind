using System.Windows.Forms;

namespace NecromindUI.Views
{
    public interface IAdminHeroes
    {
        string HeroName { get; set; }
        string Lvl { get; set; }
        string Gold { get; set; }
        string Dmg { get; set; }
        string Def { get; set; }
        string Health { get; set; }
        ListBox Heroes { get; }
    }
}