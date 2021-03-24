using System;

namespace NecromindUI.Views.Menu
{
    public interface IConfirmDelete
    {
        bool IsPanConfDelVisible { get; set; }
        string HeroName { get; set; }
        string ConfirmName { get; set; }
        bool IsBtnDelHeroEnabled { get; set; }
    }
}