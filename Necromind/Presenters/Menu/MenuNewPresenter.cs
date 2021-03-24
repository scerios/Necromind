using NecromindLibrary.Models;
using NecromindLibrary.Repository;
using NecromindLibrary.Services;
using NecromindUI.Views.Menu;
using System;
using System.Configuration;

namespace NecromindUI.Presenters.Menu
{
    public class MenuNewPresenter
    {
        private readonly MongoConnector _connector;
        private readonly IMenuNew _menuNew;

        public MenuNewPresenter(IMenuNew menuNew)
        {
            _menuNew = menuNew;
            _connector = MongoConnector.GetInstance();
        }

        public bool IsHeroNameAvailable()
        {
            var heroes = _connector.GetAllRecords<HeroModel>(ConfigurationManager.AppSettings.Get("heroesCollection"));

            return !ValidationService.IsHeroNameAlreadyRegistered(heroes, _menuNew.HeroName);
        }

        public bool IsHeroCreated()
        {
            return _connector.TryCreateNewRecord(ConfigurationManager.AppSettings.Get("heroesCollection"), new HeroModel(_menuNew.HeroName));
        }

        public void DisplayError(string title, string msg)
        {
            _menuNew.Title = title;
            _menuNew.Msg = TextService.FormatErrorMsg(msg);
            _menuNew.IsPanErrorVisible = true;
        }

        public void HideError()
        {
            _menuNew.IsPanErrorVisible = false;
            _menuNew.Title = "";
            _menuNew.Msg = "";
        }
    }
}