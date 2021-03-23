using System;
using System.Windows.Forms;

namespace NecromindUI.Views
{
    public interface IAdminEnemies
    {
        string EnemyName { get; set; }
        string Lvl { get; set; }
        string Gold { get; set; }
        string DmgMin { get; set; }
        string DmgMax { get; set; }
        string Def { get; set; }
        string Health { get; set; }
        Timer TimHide { get; }
        Label LabEnemyAdded { get; }
    }
}