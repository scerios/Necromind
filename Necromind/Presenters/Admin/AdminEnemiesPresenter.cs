using NecromindLibrary.Config;
using NecromindLibrary.Models;
using NecromindLibrary.Repository;
using NecromindLibrary.Services;
using NecromindUI.Views.Admin;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NecromindUI.Presenters.Admin
{
    public class AdminEnemiesPresenter
    {
        private readonly IAdminEnemies _adminEnemies;
        private readonly string _listboxDisplayMember = "CombinedName";
        private readonly MongoConnector _mongoConnector = MongoConnector.GetInstance();
        private readonly BindingSource _bsEnemies = new BindingSource();
        private List<EnemyAdminModel> _enemies;
        private EnemyAdminModel _enemy;

        public AdminEnemiesPresenter(IAdminEnemies adminEnemies)
        {
            _adminEnemies = adminEnemies;
        }

        public void LoadData()
        {
            LoadEnemies();
            BindEnemies();
        }

        public void SetSelectedEnemyStats()
        {
            var selectedIndex = _adminEnemies.LbEnemies.SelectedIndex;

            if (selectedIndex >= 0)
            {
                EnableModifyBtns();

                _enemy = _enemies[selectedIndex];
                _adminEnemies.TbEditName = _enemy.Name;
                _adminEnemies.TbEditLvl = _enemy.Lvl.ToString();
                _adminEnemies.TbEditGold = _enemy.Gold.ToString();
                _adminEnemies.TbEditDmgMin = _enemy.DmgMin.ToString();
                _adminEnemies.TbEditDmgMax = _enemy.DmgMax.ToString();
                _adminEnemies.TbEditDef = _enemy.Def.ToString();
                _adminEnemies.TbEditHealth = _enemy.HealthMax.ToString();
            }
            else
            {
                DisableModifyBtns();
            }
        }

        public void CreateEnemy()
        {
            SetCreateEnemyProperties();

            if (_mongoConnector.TryCreateNewRecord(DBConfig.EnemiesCollection, _enemy))
            {
                UpdateUIAfterCreate();
            }
            else
            {
                AlertCreateFail($"Failed to create { _enemy.Name }!");
            }
        }

        public void EditEnemy()
        {
            SetEditEnemyProperties();

            if (_mongoConnector.TryUpsertRecord(DBConfig.EnemiesCollection, _enemy.Id, _enemy))
            {
                UpdateUIAfterEdit();
            }
            else
            {
                AlertEditFail($"Failed to edit { _enemy.Name }!");
            }
        }

        public void DeleteEnemy()
        {
            if (_mongoConnector.TryDeleteRecordById<EnemyModel>(DBConfig.EnemiesCollection, _enemy.Id))
            {
                AlertEditSuccess($"{ _enemy.Name } deleted successfully!");
                _adminEnemies.LbEnemies.Items.Remove(_enemy.Name);
                _bsEnemies.Remove(_enemy);
                ClearEditFields();
            }
            else
            {
                AlertEditFail($"Failed to delete { _enemy.Name }!");
            }
        }

        public bool AreCInputsValid()
        {
            int errorCount = 0;

            if (IsNameCInvalid())
            {
                errorCount++;
            }

            if (IsLvlCInvalid())
            {
                errorCount++;
            }

            if (IsGoldCInvalid())
            {
                errorCount++;
            }

            if (AreDmgCInvalid())
            {
                errorCount++;
            }

            if (IsDefCInvalid())
            {
                errorCount++;
            }

            if (IsHealthCInvalid())
            {
                errorCount++;
            }

            return errorCount == 0;
        }

        public bool AreMInputsValid()
        {
            int errorCount = 0;

            if (IsNameMInvalid())
            {
                errorCount++;
            }

            if (IsLvlMInvalid())
            {
                errorCount++;
            }

            if (IsGoldMInvalid())
            {
                errorCount++;
            }

            if (AreDmgMInvalid())
            {
                errorCount++;
            }

            if (IsDefMInvalid())
            {
                errorCount++;
            }

            if (IsHealthMInvalid())
            {
                errorCount++;
            }

            return errorCount == 0;
        }

        #region Create errors

        private bool IsNameCInvalid()
        {
            _adminEnemies.LabNameCError = !ValidationService.IsValidName(_adminEnemies.TbCreateName);

            return _adminEnemies.LabNameCError;
        }

        private bool IsLvlCInvalid()
        {
            _adminEnemies.LabLvlCError = !ValidationService.IsGreaterThanZero(_adminEnemies.TbCreateLvl);

            return _adminEnemies.LabLvlCError;
        }

        private bool IsGoldCInvalid()
        {
            _adminEnemies.LabGoldCError = !ValidationService.IsGreaterThanOrEqualToZero(_adminEnemies.TbCreateGold);

            return _adminEnemies.LabGoldCError;
        }

        private bool AreDmgCInvalid()
        {
            _adminEnemies.LabDmgCError = !ValidationService.IsGreaterThanZero(_adminEnemies.TbCreateDmgMin) ||
                !ValidationService.IsFirstIsGreaterThanSecond(_adminEnemies.TbCreateDmgMax, _adminEnemies.TbCreateDmgMin);

            return _adminEnemies.LabDmgCError;
        }

        private bool IsDefCInvalid()
        {
            _adminEnemies.LabDefCError = !ValidationService.IsGreaterThanOrEqualToZero(_adminEnemies.TbCreateDef);

            return _adminEnemies.LabDefCError;
        }

        private bool IsHealthCInvalid()
        {
            _adminEnemies.LabHealthCError = !ValidationService.IsGreaterThanZero(_adminEnemies.TbCreateHealth);

            return _adminEnemies.LabHealthCError;
        }

        #endregion Create errors

        #region Modify errors

        private bool IsNameMInvalid()
        {
            _adminEnemies.LabNameMError = !ValidationService.IsValidName(_adminEnemies.TbEditName);

            return _adminEnemies.LabNameMError;
        }

        private bool IsLvlMInvalid()
        {
            _adminEnemies.LabLvlMError = !ValidationService.IsGreaterThanZero(_adminEnemies.TbEditLvl);

            return _adminEnemies.LabLvlMError;
        }

        private bool IsGoldMInvalid()
        {
            _adminEnemies.LabGoldMError = !ValidationService.IsGreaterThanOrEqualToZero(_adminEnemies.TbEditGold);

            return _adminEnemies.LabGoldMError;
        }

        private bool AreDmgMInvalid()
        {
            _adminEnemies.LabDmgMError = !ValidationService.IsGreaterThanZero(_adminEnemies.TbEditDmgMin) ||
                !ValidationService.IsFirstIsGreaterThanSecond(_adminEnemies.TbEditDmgMax, _adminEnemies.TbEditDmgMin);

            return _adminEnemies.LabDmgMError;
        }

        private bool IsDefMInvalid()
        {
            _adminEnemies.LabDefMError = !ValidationService.IsGreaterThanOrEqualToZero(_adminEnemies.TbEditDef);

            return _adminEnemies.LabDefMError;
        }

        private bool IsHealthMInvalid()
        {
            _adminEnemies.LabHealthMError = !ValidationService.IsGreaterThanZero(_adminEnemies.TbEditHealth);

            return _adminEnemies.LabHealthMError;
        }

        #endregion Modify errors

        private void LoadEnemies()
        {
            _enemies = _mongoConnector.GetAllRecords<EnemyAdminModel>(DBConfig.EnemiesCollection);
        }

        private void BindEnemies()
        {
            _bsEnemies.DataSource = _enemies;
            _adminEnemies.LbEnemies.DataSource = _bsEnemies;
            _adminEnemies.LbEnemies.DisplayMember = _listboxDisplayMember;
        }

        #region Alerts

        private void AlertCreateSuccess(string msg)
        {
            _adminEnemies.LabEnemyCreate.Text = msg;
            _adminEnemies.LabEnemyCreate.ForeColor = UISettings.SuccessColor;

            ShowAlert(_adminEnemies.LabEnemyCreate, _adminEnemies.TimHideCreate);
        }

        private void AlertCreateFail(string msg)
        {
            _adminEnemies.LabEnemyCreate.Text = msg;
            _adminEnemies.LabEnemyCreate.ForeColor = UISettings.ErrorColor;

            ShowAlert(_adminEnemies.LabEnemyCreate, _adminEnemies.TimHideCreate);
        }

        private void AlertEditSuccess(string msg)
        {
            _adminEnemies.LabEnemyEdit.Text = msg;
            _adminEnemies.LabEnemyEdit.ForeColor = UISettings.SuccessColor;

            ShowAlert(_adminEnemies.LabEnemyEdit, _adminEnemies.TimHideEdit);
        }

        private void AlertEditFail(string msg)
        {
            _adminEnemies.LabEnemyEdit.Text = msg;
            _adminEnemies.LabEnemyEdit.ForeColor = UISettings.ErrorColor;

            ShowAlert(_adminEnemies.LabEnemyEdit, _adminEnemies.TimHideEdit);
        }

        private void ShowAlert(Label label, Timer timer)
        {
            label.Visible = true;
            timer.Start();
        }

        #endregion Alerts

        #region UI modifications

        private void SetCreateEnemyProperties()
        {
            _enemy = new EnemyAdminModel();
            _enemy.AdminSetName(_adminEnemies.TbCreateName);
            _enemy.AdminSetLvl(_adminEnemies.TbCreateLvl);
            _enemy.AdminSetGold(_adminEnemies.TbCreateGold);
            _enemy.AdminSetDmgMin(_adminEnemies.TbCreateDmgMin);
            _enemy.AdminSetDmgMax(_adminEnemies.TbCreateDmgMax);
            _enemy.AdminSetDef(_adminEnemies.TbCreateDef);
            _enemy.AdminSetHealth(_adminEnemies.TbCreateHealth);
            _enemy.AdminSetCombinedName();
        }

        private void SetEditEnemyProperties()
        {
            _enemy.AdminSetName(_adminEnemies.TbEditName);
            _enemy.AdminSetLvl(_adminEnemies.TbEditLvl);
            _enemy.AdminSetGold(_adminEnemies.TbEditGold);
            _enemy.AdminSetDmgMin(_adminEnemies.TbEditDmgMin);
            _enemy.AdminSetDmgMax(_adminEnemies.TbEditDmgMax);
            _enemy.AdminSetDef(_adminEnemies.TbEditDef);
            _enemy.AdminSetHealth(_adminEnemies.TbEditHealth);
            _enemy.AdminSetCombinedName();
        }

        private void ClearAddFields()
        {
            _adminEnemies.TbCreateName = "";
            _adminEnemies.TbCreateLvl = "";
            _adminEnemies.TbCreateGold = "";
            _adminEnemies.TbCreateDmgMin = "";
            _adminEnemies.TbCreateDmgMax = "";
            _adminEnemies.TbCreateDef = "";
            _adminEnemies.TbCreateHealth = "";
        }

        private void ClearEditFields()
        {
            _adminEnemies.TbEditName = "";
            _adminEnemies.TbEditLvl = "";
            _adminEnemies.TbEditGold = "";
            _adminEnemies.TbEditDmgMin = "";
            _adminEnemies.TbEditDmgMax = "";
            _adminEnemies.TbEditDef = "";
            _adminEnemies.TbEditHealth = "";
        }

        private void UpdateUIAfterCreate()
        {
            AlertCreateSuccess($"{ _enemy.Name } created successfully!");

            _enemies.Add(_enemy);
            _bsEnemies.ResetBindings(false);

            ClearAddFields();
        }

        private void UpdateUIAfterEdit()
        {
            AlertEditSuccess($"{ _enemy.Name } edited successfully!");

            _enemies[_adminEnemies.LbEnemies.SelectedIndex].AdminSetCombinedName();
            _bsEnemies.ResetBindings(false);
            _adminEnemies.LbEnemies.ClearSelected();

            ClearEditFields();
        }

        private void EnableModifyBtns()
        {
            _adminEnemies.BtnEditIsEnabled = true;
            _adminEnemies.BtnDelIsEnabled = true;
        }

        private void DisableModifyBtns()
        {
            _adminEnemies.BtnEditIsEnabled = false;
            _adminEnemies.BtnDelIsEnabled = false;
        }

        #endregion UI modifications
    }
}