using System;
using System.Windows.Forms;

namespace NecromindUI.Views.Admin
{
    public interface IAdminEnemies
    {
        string TbCreateName { get; set; }
        string TbEditName { get; set; }
        string TbCreateLvl { get; set; }
        string TbEditLvl { get; set; }
        string TbCreateGold { get; set; }
        string TbEditGold { get; set; }
        string TbCreateDmgMin { get; set; }
        string TbEditDmgMin { get; set; }
        string TbCreateDmgMax { get; set; }
        string TbEditDmgMax { get; set; }
        string TbCreateDef { get; set; }
        string TbEditDef { get; set; }
        string TbCreateHealth { get; set; }
        string TbEditHealth { get; set; }
        bool BtnEditIsEnabled { get; set; }
        bool BtnDelIsEnabled { get; set; }
        ListBox LbEnemies { get; }
        Timer TimHideCreate { get; }
        Timer TimHideEdit { get; }
        Label LabEnemyCreate { get; }
        Label LabEnemyEdit { get; }
    }
}