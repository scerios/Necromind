using NecromindLibrary.Models;
using NecromindLibrary.Repository;
using NecromindLibrary.Services;
using NecromindUI.Views.Menu;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace NecromindUI.Presenters.Menu
{
    public class MenuLoadPresenter
    {
        private readonly MongoConnector _mongoConnector;
        private readonly IMenuLoad _menuLoad;
        public Guid HeroToDelId;

        public MenuLoadPresenter(IMenuLoad menuLoad)
        {
            _menuLoad = menuLoad;
            _mongoConnector = MongoConnector.GetInstance();
        }

        public List<HeroModel> GetAllHeroes(string collectionName)
        {
            var heroes = _mongoConnector.GetAllRecords<HeroModel>(collectionName);

            if (heroes.Count == 0)
            {
                DisplayError();
            }

            return heroes;
        }

        public void HideError()
        {
            _menuLoad.IsPanErrorVisible = false;
            _menuLoad.Title = "";
            _menuLoad.Msg = "";
        }

        public void DisplayPanConfDel(string heroName)
        {
            _menuLoad.HeroName = heroName;
            _menuLoad.IsPanConfDelVisible = true;
        }

        public void HidePanConfDel()
        {
            _menuLoad.IsPanConfDelVisible = false;
            _menuLoad.HeroName = "";
            _menuLoad.ConfirmName = "";
        }

        public void DeleteHero()
        {
            _mongoConnector.TryDeleteRecordById<HeroModel>(ConfigurationManager.AppSettings.Get("heroesCollection"), HeroToDelId);
        }

        public void ChangeBtnDelHeroAvailability()
        {
            _menuLoad.IsBtnDelHeroEnabled = TextService.IsGivenStringsAreEqual(_menuLoad.HeroName, _menuLoad.ConfirmName);
        }

        private void DisplayError()
        {
            _menuLoad.Title = "No hero found";
            _menuLoad.Msg = TextService.FormatErrorMsg("You must create a hero first to be able to load them.");
            _menuLoad.IsPanErrorVisible = true;
        }
    }
}