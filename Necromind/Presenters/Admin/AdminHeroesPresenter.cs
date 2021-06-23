using NecromindLibrary.Config;
using NecromindLibrary.Models;
using NecromindLibrary.Repository;
using NecromindLibrary.Services;
using NecromindUI.Views.Admin;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace NecromindUI.Presenters.Admin
{
    public class AdminHeroesPresenter
    {
        private readonly IAdminHeroes _adminHeroes;
        private readonly MongoConnector _mongoConnector = MongoConnector.GetInstance();
        private readonly BindingSource _bsHeroes = new BindingSource();
        private BindingList<HeroModel> _heroes;
        private HeroModel _hero;

        public AdminHeroesPresenter(IAdminHeroes adminHeroes)
        {
            _adminHeroes = adminHeroes;
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

        public bool AreInputsValid()
        {
            int errorCount = 0;

            if (IsLvlInvalid())
            {
                errorCount++;
            }

            if (IsGoldInvalid())
            {
                errorCount++;
            }

            if (AreDmgInvalid())
            {
                errorCount++;
            }

            if (IsDefInvalid())
            {
                errorCount++;
            }

            if (IsHealthInvalid())
            {
                errorCount++;
            }

            return errorCount == 0;
        }

        #region Errors

        private bool IsLvlInvalid()
        {
            _adminHeroes.LabLvlError = !ValidationService.IsGreaterThanZero(_adminHeroes.TbLvl);

            return _adminHeroes.LabLvlError;
        }

        private bool IsGoldInvalid()
        {
            _adminHeroes.LabGoldError = !ValidationService.IsGreaterThanOrEqualToZero(_adminHeroes.TbGold);

            return _adminHeroes.LabGoldError;
        }

        private bool AreDmgInvalid()
        {
            _adminHeroes.LabDmgError = !ValidationService.IsGreaterThanZero(_adminHeroes.TbDmgMin) ||
                !ValidationService.IsFirstIsGreaterThanSecond(_adminHeroes.TbDmgMax, _adminHeroes.TbDmgMin);

            return _adminHeroes.LabDmgError;
        }

        private bool IsDefInvalid()
        {
            _adminHeroes.LabDefError = !ValidationService.IsGreaterThanOrEqualToZero(_adminHeroes.TbDef);

            return _adminHeroes.LabDefError;
        }

        private bool IsHealthInvalid()
        {
            _adminHeroes.LabHealthError = !ValidationService.IsGreaterThanZero(_adminHeroes.TbHealth);

            return _adminHeroes.LabHealthError;
        }

        #endregion Errors

        private void AlertSuccess(string name)
        {
            _adminHeroes.LabHeroEdit.Text = $"{ name } edited successfully!";
            _adminHeroes.LabHeroEdit.ForeColor = UISettings.SuccessColor;
            _adminHeroes.LabHeroEdit.Visible = true;
            _adminHeroes.TimHide.Start();
        }

        private void AlertFail(string name)
        {
            _adminHeroes.LabHeroEdit.Text = $"Failed to edit { name }!";
            _adminHeroes.LabHeroEdit.ForeColor = UISettings.ErrorColor;
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

        private void SetHeroProperties()
        {
            _hero.AdminSetLvl(_adminHeroes.TbLvl);
            _hero.AdminSetGold(_adminHeroes.TbGold);
            _hero.AdminSetDmgMin(_adminHeroes.TbDmgMin);
            _hero.AdminSetDmgMax(_adminHeroes.TbDmgMax);
            _hero.AdminSetDef(_adminHeroes.TbDef);
            _hero.AdminSetHealth(_adminHeroes.TbHealth);
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