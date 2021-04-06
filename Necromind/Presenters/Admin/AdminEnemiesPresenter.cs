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
            var selectedIndex = _adminEnemies.Enemies.SelectedIndex;

            if (selectedIndex >= 0)
            {
                _enemy = _enemies[selectedIndex];
                _adminEnemies.EditName = _enemy.Name;
                _adminEnemies.EditLvl = _enemy.Lvl.ToString();
                _adminEnemies.EditGold = _enemy.Gold.ToString();
                _adminEnemies.EditDmgMin = _enemy.DmgMin.ToString();
                _adminEnemies.EditDmgMax = _enemy.DmgMax.ToString();
                _adminEnemies.EditDef = _enemy.Def.ToString();
                _adminEnemies.EditHealth = _enemy.HealthMax.ToString();
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
            var _enemy = _enemies[_adminEnemies.Enemies.SelectedIndex];

            if (_mongoConnector.TryDeleteRecordById<EnemyModel>(DBConfig.EnemiesCollection, _enemy.Id))
            {
                AlertEditSuccess($"{ _enemy.Name } deleted successfully!");
                _adminEnemies.Enemies.Items.Remove(_enemy.Name);
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
            _adminEnemies.Enemies.DataSource = _bsEnemies;
            _adminEnemies.Enemies.DisplayMember = _combinedName;
        }

        private void SetCreateEnemyProperties()
        {
            _enemy = new EnemyModel();
            _enemy.AdminSetName(_adminEnemies.CreateName);
            _enemy.AdminSetLvl(_adminEnemies.CreateLvl);
            _enemy.AdminSetGold(_adminEnemies.CreateGold);
            _enemy.AdminSetDmgMin(_adminEnemies.CreateDmgMin);
            _enemy.AdminSetDmgMax(_adminEnemies.CreateDmgMax);
            _enemy.AdminSetDef(_adminEnemies.CreateDef);
            _enemy.AdminSetHealth(_adminEnemies.CreateHealth);
            _enemy.AdminSetCombinedName();
        }

        private void SetEditEnemyProperties()
        {
            _enemy.AdminSetName(_adminEnemies.EditName);
            _enemy.AdminSetLvl(_adminEnemies.EditLvl);
            _enemy.AdminSetGold(_adminEnemies.EditGold);
            _enemy.AdminSetDmgMin(_adminEnemies.EditDmgMin);
            _enemy.AdminSetDmgMax(_adminEnemies.EditDmgMax);
            _enemy.AdminSetDef(_adminEnemies.EditDef);
            _enemy.AdminSetHealth(_adminEnemies.EditHealth);
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
            _adminEnemies.CreateName = "";
            _adminEnemies.CreateLvl = "";
            _adminEnemies.CreateGold = "";
            _adminEnemies.CreateDmgMin = "";
            _adminEnemies.CreateDmgMax = "";
            _adminEnemies.CreateDef = "";
            _adminEnemies.CreateHealth = "";
        }

        private void ClearEditFields()
        {
            _adminEnemies.EditName = "";
            _adminEnemies.EditLvl = "";
            _adminEnemies.EditGold = "";
            _adminEnemies.EditDmgMin = "";
            _adminEnemies.EditDmgMax = "";
            _adminEnemies.EditDef = "";
            _adminEnemies.EditHealth = "";
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

            _enemies[_adminEnemies.Enemies.SelectedIndex].AdminSetCombinedName();
            _bsEnemies.ResetBindings(false);
            _adminEnemies.Enemies.ClearSelected();

            ClearEditFields();
        }
    }
}