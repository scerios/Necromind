using System;

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
    }
}