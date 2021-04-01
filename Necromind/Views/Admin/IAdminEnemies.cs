using System;
using System.Windows.Forms;

namespace NecromindUI.Views.Admin
{
    public interface IAdminEnemies
    {
        string CreateName { get; set; }
        string EditName { get; set; }
        string CreateLvl { get; set; }
        string EditLvl { get; set; }
        string CreateGold { get; set; }
        string EditGold { get; set; }
        string CreateDmgMin { get; set; }
        string EditDmgMin { get; set; }
        string CreateDmgMax { get; set; }
        string EditDmgMax { get; set; }
        string CreateDef { get; set; }
        string EditDef { get; set; }
        string CreateHealth { get; set; }
        string EditHealth { get; set; }
        ListBox Enemies { get; }
        Timer TimHideCreate { get; }
        Timer TimHideEdit { get; }
        Label LabEnemyCreate { get; }
        Label LabEnemyEdit { get; }
    }
}