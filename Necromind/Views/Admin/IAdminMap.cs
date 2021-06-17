using System;
using System.Windows.Forms;

namespace NecromindUI.Views.Admin
{
    public interface IAdminMap
    {
        string LabX { get; set; }
        string LabY { get; set; }
        string LabLocName { get; set; }
        string LabLocDescription { get; set; }
        string TbJumpX { get; set; }
        string TbJumpY { get; set; }
        bool LabAccessibleTick { get; set; }
        bool LabAccessibleCross { get; set; }
        bool LabHostileTick { get; set; }
        bool LabHostileCross { get; set; }

        ListBox LbLocations { get; }
    }
}