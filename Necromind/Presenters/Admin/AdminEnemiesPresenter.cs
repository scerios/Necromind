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
    public class AdminEnemiesPresenter
    {
        private readonly string _combinedName = "CombinedName";
        private readonly MongoConnector _mongoConnector;
        private readonly IAdminEnemies _adminEnemies;
        private readonly BindingSource _bsEnemies = new BindingSource();
        private List<EnemyModel> _enemies;
        private EnemyModel _enemy;

        public AdminEnemiesPresenter(IAdminEnemies adminEnemies)
        {
            _adminEnemies = adminEnemies;
            _mongoConnector = MongoConnector.GetInstance();
        }

        public void LoadData()
        {
            LoadAllEnemies();
            BindEnemies();
        }

        public void GetSelectedEnemyStats()
        {
            var selectedIndex = _adminEnemies.LbEnemies.SelectedIndex;

            if (selectedIndex >= 0)
            {
                _enemy = _enemies[selectedIndex];
                _adminEnemies.TbEditName = _enemy.Name;
                _adminEnemies.TbEditLvl = _enemy.Lvl.ToString();
                _adminEnemies.TbEditGold = _enemy.Gold.ToString();
                _adminEnemies.TbEditDmgMin = _enemy.DmgMin.ToString();
                _adminEnemies.TbEditDmgMax = _enemy.DmgMax.ToString();
                _adminEnemies.TbEditDef = _enemy.Def.ToString();
                _adminEnemies.TbEditHealth = _enemy.HealthMax.ToString();
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

        private void LoadAllEnemies()
        {
            _enemies = _mongoConnector.GetAllRecords<EnemyModel>(DBConfig.EnemiesCollection);
        }

        private void BindEnemies()
        {
            _bsEnemies.DataSource = _enemies;
            _adminEnemies.LbEnemies.DataSource = _bsEnemies;
            _adminEnemies.LbEnemies.DisplayMember = _combinedName;
        }

        private void SetCreateEnemyProperties()
        {
            _enemy = new EnemyModel();
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

        private void AlertCreateSuccess(string msg)
        {
            _adminEnemies.LabEnemyCreate.Text = msg;
            _adminEnemies.LabEnemyCreate.ForeColor = UISettings.GreenColor;

            ShowAlert(_adminEnemies.LabEnemyCreate, _adminEnemies.TimHideCreate);
        }

        private void AlertCreateFail(string msg)
        {
            _adminEnemies.LabEnemyCreate.Text = msg;
            _adminEnemies.LabEnemyCreate.ForeColor = UISettings.RedColor;

            ShowAlert(_adminEnemies.LabEnemyCreate, _adminEnemies.TimHideCreate);
        }

        private void AlertEditSuccess(string msg)
        {
            _adminEnemies.LabEnemyEdit.Text = msg;
            _adminEnemies.LabEnemyEdit.ForeColor = UISettings.GreenColor;

            ShowAlert(_adminEnemies.LabEnemyEdit, _adminEnemies.TimHideEdit);
        }

        private void AlertEditFail(string msg)
        {
            _adminEnemies.LabEnemyEdit.Text = msg;
            _adminEnemies.LabEnemyEdit.ForeColor = UISettings.RedColor;

            ShowAlert(_adminEnemies.LabEnemyEdit, _adminEnemies.TimHideEdit);
        }

        private void ShowAlert(Label label, Timer timer)
        {
            label.Visible = true;
            timer.Start();
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
    }
}