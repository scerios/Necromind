using System;
using System.Windows.Forms;

namespace NecromindUI.Views
{
    public interface IAdminEnemies
    {
        string AddEnemyName { get; set; }
        string EditEnemyName { get; set; }
        string AddLvl { get; set; }
        string EditLvl { get; set; }
        string AddGold { get; set; }
        string EditGold { get; set; }
        string AddDmgMin { get; set; }
        string EditDmgMin { get; set; }
        string AddDmgMax { get; set; }
        string EditDmgMax { get; set; }
        string AddDef { get; set; }
        string EditDef { get; set; }
        string AddHealth { get; set; }
        string EditHealth { get; set; }
        ListBox Enemies { get; }
        Timer TimHideAdd { get; }
        Timer TimHideEdit { get; }
        Label LabEnemyAdd { get; }
        Label LabEnemyEdit { get; }
    }
}