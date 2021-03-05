using NecromindLibrary.Models;
using NecromindLibrary.Repository;
using NecromindUI.Views;
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
            GetAllHeroes();
            SetupHeroesList();
        }

        private void GetAllHeroes()
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

        public void GetSelectedHeroStats()
        {
            var hero = _heroes[_adminHeroes.Heroes.SelectedIndex];
            _adminHeroes.HeroName = hero.Name;
            _adminHeroes.Lvl = hero.Lvl.ToString();
            _adminHeroes.Gold = hero.Gold.ToString();
            _adminHeroes.Dmg = hero.Dmg.ToString();
            _adminHeroes.Def = hero.Def.ToString();
            _adminHeroes.Health = hero.HealthMax.ToString();
        }
    }
}