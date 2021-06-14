using NecromindLibrary.Config;
using NecromindLibrary.Models;
using NecromindLibrary.Repository;
using NecromindLibrary.Services;
using NecromindUI.Views.Menu;
using System;

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

        public bool TryCreateHero()
        {
            if (IsHeroNameValid())
            {
                if (IsHeroNameAvailable())
                {
                    if (IsHeroCreated())
                    {
                        return true;
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
                        $"The name \"{ _menuNew.HeroName }\" is taken by one of your characters already. You need to pick another one."
                        );

                    _menuNew.HeroName = "";
                }
            }
            else
            {
                DisplayError(
                    "Invalid hero name.",
                    "First character cannot be a digit or special character. Hero's name must be at least 3 characters long and cannot exceed 16 characters."
                    );
            }

            return false;
        }

        public void HideError()
        {
            _menuNew.IsPanErrorVisible = false;
            _menuNew.Title = "";
            _menuNew.Msg = "";
        }

        private bool IsHeroNameAvailable()
        {
            var heroes = _connector.GetAllRecords<HeroModel>(DBConfig.HeroesCollection);

            return !ValidationService.IsHeroNameAlreadyRegistered(heroes, _menuNew.HeroName);
        }

        private bool IsHeroCreated() =>
            _connector.TryCreateNewRecord(DBConfig.HeroesCollection, new HeroModel(_menuNew.HeroName));

        private bool IsHeroNameValid() =>
            ValidationService.IsValidName(_menuNew.HeroName);

        private void DisplayError(string title, string msg)
        {
            _menuNew.Title = title;
            _menuNew.Msg = TextService.FormatErrorMsg(msg);
            _menuNew.IsPanErrorVisible = true;
        }
    }
}