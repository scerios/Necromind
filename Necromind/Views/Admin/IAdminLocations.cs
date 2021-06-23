using System;
using System.Windows.Forms;

namespace NecromindUI.Views.Admin
{
    public interface IAdminLocations
    {
        string TbCreateName { get; set; }
        string TbEditName { get; set; }
        string TbCreateDescription { get; set; }
        string TbEditDescription { get; set; }
        bool CbCreateIsHostile { get; set; }
        bool CbEditIsHostile { get; set; }
        bool CbCreateIsAccessible { get; set; }
        bool CbEditIsAccessible { get; set; }
        bool PanCreateEnemies { get; set; }
        bool PanEditEnemies { get; set; }
        bool LabNameCError { get; set; }
        bool LabNameMError { get; set; }
        ListBox LbLocations { get; }
        ListBox LbCreateEnemies { get; }
        ListBox LbCreateAddedEnemies { get; }
        ListBox LbEditEnemies { get; }
        ListBox LbEditAddedEnemies { get; }
        Timer TimHideAdd { get; }
        Timer TimHideEdit { get; }
        Label LabLocationAdd { get; }
        Label LabLocationEdit { get; }
    }
}