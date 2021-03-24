using System;

namespace NecromindUI.Views.Menu
{
    public interface IMenuLoad : IError, IConfirmDelete
    {
        event EventHandler BtnLoadHeroClick;
    }
}