using NecromindLibrary.Config;
using NecromindLibrary.Models;
using NecromindLibrary.Repository;
using NecromindUI.Config;
using NecromindUI.Views.Admin;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NecromindUI.Presenters.Admin
{
    public class AdminHeroesPresenter
    {
        private readonly MongoConnector _mongoConnector;
        private readonly IAdminHeroes _adminHeroes;
        private readonly BindingSource _bsHeroes = new BindingSource();
        private List<HeroModel> _heroes;
        private HeroModel _hero;

        public AdminHeroesPresenter(IAdminHeroes adminHeroes)
        {
            _adminHeroes = adminHeroes;
            _mongoConnector = MongoConnector.GetInstance();
        }

        public void LoadData()
        {
            LoadAllHeroes();
            BindHeroes();
        }

        public void GetSelectedHeroStats()
        {
            var selectedIndex = _adminHeroes.Heroes.SelectedIndex;

            if (selectedIndex >= 0)
            {
                _hero = _heroes[selectedIndex];
                _adminHeroes.HeroName = _hero.Name;
                _adminHeroes.Lvl = _hero.Lvl.ToString();
                _adminHeroes.Gold = _hero.Gold.ToString();
                _adminHeroes.DmgMin = _hero.DmgMin.ToString();
                _adminHeroes.DmgMax = _hero.DmgMax.ToString();
                _adminHeroes.Def = _hero.Def.ToString();
                _adminHeroes.Health = _hero.HealthMax.ToString();
            }
        }

        public void EditHero()
        {
            _hero = _heroes[_adminHeroes.Heroes.SelectedIndex];
            _hero.AdminSetLvl(Int32.Parse(_adminHeroes.Lvl));
            _hero.AdminSetGold(Int32.Parse(_adminHeroes.Gold));
            _hero.AdminSetDmgMin(Int32.Parse(_adminHeroes.DmgMin));
            _hero.AdminSetDmgMax(Int32.Parse(_adminHeroes.DmgMax));
            _hero.AdminSetDef(Int32.Parse(_adminHeroes.Def));
            _hero.AdminSetHealth(Int32.Parse(_adminHeroes.Health));

            if (_mongoConnector.TryUpsertRecord(DBConfig.HeroesCollection, _hero.Id, _hero))
            {
                UpdateUIAfterEdit();
            }
            else
            {
                AlertFail(_hero.Name);
            }
        }

        private void AlertSuccess(string name)
        {
            _adminHeroes.LabHeroEdit.Text = $"{ name } edited successfully!";
            _adminHeroes.LabHeroEdit.ForeColor = UISettings.GreenColor;
            _adminHeroes.LabHeroEdit.Visible = true;
            _adminHeroes.TimHide.Start();
        }

        private void AlertFail(string name)
        {
            _adminHeroes.LabHeroEdit.Text = $"Failed to edit { name }!";
            _adminHeroes.LabHeroEdit.ForeColor = UISettings.RedColor;
            _adminHeroes.LabHeroEdit.Visible = true;
            _adminHeroes.TimHide.Start();
        }

        private void LoadAllHeroes()
        {
            _heroes = _mongoConnector.GetAllRecords<HeroModel>(DBConfig.HeroesCollection);
        }

        private void BindHeroes()
        {
            _bsHeroes.DataSource = _heroes;
            _adminHeroes.Heroes.DataSource = _bsHeroes;
            _adminHeroes.Heroes.DisplayMember = "Name";
        }

        private void ClearEditFields()
        {
            _adminHeroes.HeroName = "";
            _adminHeroes.Lvl = "";
            _adminHeroes.Gold = "";
            _adminHeroes.DmgMin = "";
            _adminHeroes.DmgMax = "";
            _adminHeroes.Def = "";
            _adminHeroes.Health = "";
        }

        private void UpdateUIAfterEdit()
        {
            AlertSuccess(_hero.Name);
            _bsHeroes.ResetBindings(false);
            _adminHeroes.Heroes.ClearSelected();
            ClearEditFields();
        }
    }
}