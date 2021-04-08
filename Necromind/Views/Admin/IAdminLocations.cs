using System;
using System.Windows.Forms;

namespace NecromindUI.Views.Admin
{
    public interface IAdminLocations
    {
        string CreateName { get; set; }
        string EditName { get; set; }
        string CreateDescription { get; set; }
        string EditDescription { get; set; }
        bool CbCreateIsHostile { get; set; }
        bool CbEditIsHostile { get; set; }
        bool CbCreateIsAccessible { get; set; }
        bool CbEditIsAccessible { get; set; }
        bool PanCreateEnemies { get; set; }
        bool PanEditEnemies { get; set; }
        ListBox Locations { get; }
        ListBox CreateEnemies { get; }
        ListBox CreateAddedEnemies { get; }
        ListBox EditEnemies { get; }
        ListBox EditAddedEnemies { get; }
        Timer TimHideAdd { get; }
        Timer TimHideEdit { get; }
        Label LabLocationAdd { get; }
        Label LabLocationEdit { get; }
    }
}