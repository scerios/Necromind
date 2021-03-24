using System;

namespace NecromindUI.Views.Menu
{
    public interface IError
    {
        bool IsPanErrorVisible { get; set; }
        string Title { get; set; }
        string Msg { get; set; }
    }
}