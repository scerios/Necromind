using Necromind.Views;
using NecromindLibrary.Models;
using NecromindLibrary.Repository;
using NecromindLibrary.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Necromind.Presenters
{
    public class MenuNewPresenter
    {
        private readonly IMenuNew _menuNew;

        public MenuNewPresenter(IMenuNew menuNew)
        {
            _menuNew = menuNew;
        }

        public void TryCreateHero()
        {
            var mongoConnector = MongoConnector.GetInstance();
            if (mongoConnector.TryCreateNewRecord(ConfigurationManager.AppSettings.Get("heroesCollection"), new HeroModel(_menuNew.HeroName)))
            {
                // TODO - Start the game with the created hero or go to load page so the player can select which hero they want to play.
            }
            else
            {
                DisplayError();
            }
        }

        private void DisplayError()
        {
            var textService = new TextService();
            _menuNew.Title = "Hero couldn't be saved.";
            _menuNew.Msg = textService.FormatErrorMsg("There was an error during saving to database. Please try again.");
            _menuNew.IsErrorPanVisible = true;
        }

        public void HideError()
        {
            _menuNew.IsErrorPanVisible = false;
            _menuNew.Title = "";
            _menuNew.Msg = "";
        }
    }
}
