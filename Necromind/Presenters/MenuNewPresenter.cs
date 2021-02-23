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
            var heroes = mongoConnector.GetAllRecords<HeroModel>(ConfigurationManager.AppSettings.Get("heroesCollection"));
            var validationService = new ValidationService();
            var heroName = _menuNew.HeroName;

            if (!validationService.IsHeroNameAlreadyRegistered(heroes, heroName))
            {
                if (mongoConnector.TryCreateNewRecord(ConfigurationManager.AppSettings.Get("heroesCollection"), new HeroModel(heroName)))
                {
                    // TODO - Start the game with the created hero or go to load page so the player can select which hero they want to play.
                }
                else
                {
                    DisplayError(
                        "Hero couldn't be saved.",
                        "There was an error during saving to database. Please try again."
                        );
                }
            }
            else
            {
                DisplayError(
                    "Hero already exists.",
                    $"The name \"{ heroName }\" is taken by one of your characters already. You need to pick another one."
                    );

                _menuNew.HeroName = "";
            }
        }

        private void DisplayError(string title, string msg)
        {
            var textService = new TextService();
            _menuNew.Title = title;
            _menuNew.Msg = textService.FormatErrorMsg(msg);
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
