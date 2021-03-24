using NecromindLibrary.Config;
using NecromindLibrary.Models;
using NecromindLibrary.Repository;
using NecromindUI.Views;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace NecromindUI.Presenters
{
    public class AdminHeroesPresenter
    {
        private readonly MongoConnector _mongoConnector;
        private readonly IAdminHeroes _adminHeroes;
        private List<HeroModel> _heroes;

        public AdminHeroesPresenter(IAdminHeroes adminHeroes)
        {
            _adminHeroes = adminHeroes;
            _mongoConnector = MongoConnector.GetInstance();
            LoadAllHeroes();
            SetupHeroesList();
        }

        public void GetSelectedHeroStats()
        {
            var hero = _heroes[_adminHeroes.Heroes.SelectedIndex];
            _adminHeroes.HeroName = hero.Name;
            _adminHeroes.Lvl = hero.Lvl.ToString();
            _adminHeroes.Gold = hero.Gold.ToString();
            _adminHeroes.DmgMin = hero.DmgMin.ToString();
            _adminHeroes.DmgMax = hero.DmgMax.ToString();
            _adminHeroes.Def = hero.Def.ToString();
            _adminHeroes.Health = hero.HealthMax.ToString();
        }

        public void EditHero()
        {
            var hero = _heroes[_adminHeroes.Heroes.SelectedIndex];
            hero.AdminSetLvl(Int32.Parse(_adminHeroes.Lvl));
            hero.AdminSetGold(Int32.Parse(_adminHeroes.Gold));
            hero.AdminSetDmgMin(Int32.Parse(_adminHeroes.DmgMin));
            hero.AdminSetDmgMax(Int32.Parse(_adminHeroes.DmgMax));
            hero.AdminSetDef(Int32.Parse(_adminHeroes.Def));
            hero.AdminSetHealth(Int32.Parse(_adminHeroes.Health));

            if (_mongoConnector.TryUpsertRecord(ConfigurationManager.AppSettings.Get("heroesCollection"), hero.Id, hero))
            {
                AlertSuccess(hero.Name);
            }
            else
            {
                AlertFail(hero.Name);
            }
        }

        private void AlertSuccess(string name)
        {
            _adminHeroes.LabHeroSaved.Text = $"{ name } saved successfully!";
            _adminHeroes.LabHeroSaved.ForeColor = UISettings.GreenColor;
            _adminHeroes.LabHeroSaved.Visible = true;
            _adminHeroes.TimHide.Start();
        }

        private void AlertFail(string name)
        {
            _adminHeroes.LabHeroSaved.Text = $"Failed to save { name }!";
            _adminHeroes.LabHeroSaved.ForeColor = UISettings.RedColor;
            _adminHeroes.LabHeroSaved.Visible = true;
            _adminHeroes.TimHide.Start();
        }

        private void LoadAllHeroes()
        {
            _heroes = _mongoConnector.GetAllRecords<HeroModel>(ConfigurationManager.AppSettings.Get("heroesCollection"));
        }

        private void SetupHeroesList()
        {
            foreach (var hero in _heroes)
            {
                _adminHeroes.Heroes.Items.Add(hero.Name);
            }
        }
    }
}