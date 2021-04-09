using NecromindLibrary.Config;
using NecromindLibrary.Models;
using NecromindLibrary.Repository;
using NecromindUI.Config;
using NecromindUI.Views.Admin;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace NecromindUI.Presenters.Admin
{
    public class AdminHeroesPresenter
    {
        private readonly MongoConnector _mongoConnector;
        private readonly IAdminHeroes _adminHeroes;
        private readonly BindingSource _bsHeroes = new BindingSource();
        private BindingList<HeroModel> _heroes;
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
            var selectedIndex = _adminHeroes.LbHeroes.SelectedIndex;

            if (selectedIndex >= 0)
            {
                _hero = _heroes[selectedIndex];
                _adminHeroes.LabName = _hero.Name;
                _adminHeroes.TbLvl = _hero.Lvl.ToString();
                _adminHeroes.TbGold = _hero.Gold.ToString();
                _adminHeroes.TbDmgMin = _hero.DmgMin.ToString();
                _adminHeroes.TbDmgMax = _hero.DmgMax.ToString();
                _adminHeroes.TbDef = _hero.Def.ToString();
                _adminHeroes.TbHealth = _hero.HealthMax.ToString();
            }
        }

        public void EditHero()
        {
            SetHeroProperties();

            if (_mongoConnector.TryUpsertRecord(DBConfig.HeroesCollection, _hero.Id, _hero))
            {
                UpdateUIAfterEdit();
            }
            else
            {
                AlertFail(_hero.Name);
            }
        }

        private void SetHeroProperties()
        {
            _hero.AdminSetLvl(_adminHeroes.TbLvl);
            _hero.AdminSetGold(_adminHeroes.TbGold);
            _hero.AdminSetDmgMin(_adminHeroes.TbDmgMin);
            _hero.AdminSetDmgMax(_adminHeroes.TbDmgMax);
            _hero.AdminSetDef(_adminHeroes.TbDef);
            _hero.AdminSetHealth(_adminHeroes.TbHealth);
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
            _heroes = new BindingList<HeroModel>(_mongoConnector.GetAllRecords<HeroModel>(DBConfig.HeroesCollection));
        }

        private void BindHeroes()
        {
            _bsHeroes.DataSource = _heroes;
            _adminHeroes.LbHeroes.DataSource = _bsHeroes;
            _adminHeroes.LbHeroes.DisplayMember = "Name";
        }

        private void ClearEditFields()
        {
            _adminHeroes.LabName = "";
            _adminHeroes.TbLvl = "";
            _adminHeroes.TbGold = "";
            _adminHeroes.TbDmgMin = "";
            _adminHeroes.TbDmgMax = "";
            _adminHeroes.TbDef = "";
            _adminHeroes.TbHealth = "";
        }

        private void UpdateUIAfterEdit()
        {
            AlertSuccess(_hero.Name);
            _bsHeroes.ResetBindings(false);
            _adminHeroes.LbHeroes.ClearSelected();
            ClearEditFields();
        }
    }
}