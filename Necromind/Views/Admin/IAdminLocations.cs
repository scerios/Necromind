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
        bool CreateIsHostile { get; set; }
        bool EditIsHostile { get; set; }
        ListBox Locations { get; }
        ListBox CreateEnemies { get; }
        ListBox CreateAddedEnemies { get; }
        ListBox EditEnemies { get; }
        ListBox EditAddedEnemies { get; }
        Timer TimHideAdd { get; }
        Timer TimHideEdit { get; }
        Label LabEnemyAdd { get; }
        Label LabEnemyEdit { get; }
    }
}