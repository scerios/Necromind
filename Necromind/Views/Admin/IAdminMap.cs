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
        bool IndicatorsOff { set; }
        bool LabIsAccessible { set; }
        bool LabIsHostile { set; }
        bool BtnIsNorthEnabled { get; set; }
        bool BtnIsSouthEnabled { get; set; }
        bool BtnIsWestEnabled { get; set; }
        bool BtnIsEastEnabled { get; set; }
        bool BtnIsAttachEnabled { get; set; }
        bool BtnIsDetachEnabled { get; set; }
        bool BtnIsSaveEnabled { get; set; }

        ListBox LbLocations { get; }
    }
}