using NecromindLibrary.Config;
using NecromindLibrary.Models;
using NecromindLibrary.Repository;
using NecromindUI.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace NecromindUI.Presenters
{
    public class AdminEnemiesPresenter
    {
        private readonly MongoConnector _mongoConnector;
        private readonly IAdminEnemies _adminEnemies;
        private List<EnemyModel> _enemies;

        public AdminEnemiesPresenter(IAdminEnemies adminEnemies)
        {
            _adminEnemies = adminEnemies;
            _mongoConnector = MongoConnector.GetInstance();
            LoadAllEnemies();
            SetupEnemiesList();
        }

        public void GetSelectedEnemyStats()
        {
            if (_adminEnemies.Enemies.SelectedIndex >= 0)
            {
                var enemy = _enemies[_adminEnemies.Enemies.SelectedIndex];
                _adminEnemies.EditEnemyName = enemy.Name;
                _adminEnemies.EditLvl = enemy.Lvl.ToString();
                _adminEnemies.EditGold = enemy.Gold.ToString();
                _adminEnemies.EditDmgMin = enemy.DmgMin.ToString();
                _adminEnemies.EditDmgMax = enemy.DmgMax.ToString();
                _adminEnemies.EditDef = enemy.Def.ToString();
                _adminEnemies.EditHealth = enemy.HealthMax.ToString();
            }
        }

        public void AddEnemy()
        {
            var enemy = new EnemyModel();
            enemy.AdminSetName(_adminEnemies.AddEnemyName);
            enemy.AdminSetLvl(Int32.Parse(_adminEnemies.AddLvl));
            enemy.AdminSetGold(Int32.Parse(_adminEnemies.AddGold));
            enemy.AdminSetDmgMin(Int32.Parse(_adminEnemies.AddDmgMin));
            enemy.AdminSetDmgMax(Int32.Parse(_adminEnemies.AddDmgMax));
            enemy.AdminSetDef(Int32.Parse(_adminEnemies.AddDef));
            enemy.AdminSetHealth(Int32.Parse(_adminEnemies.AddHealth));

            if (_mongoConnector.TryCreateNewRecord(ConfigurationManager.AppSettings.Get("enemiesCollection"), enemy))
            {
                AlertAddSuccess($"{ enemy.Name } added successfully!");
                _enemies.Add(enemy);
                _adminEnemies.Enemies.Items.Add(enemy.Name);
                ClearAddFields();
            }
            else
            {
                AlertAddFail($"Failed to add { enemy.Name }!");
            }
        }

        public void EditEnemy()
        {
            var selectedIndex = _adminEnemies.Enemies.SelectedIndex;
            var enemy = _enemies[selectedIndex];
            enemy.AdminSetName(_adminEnemies.EditEnemyName);
            enemy.AdminSetLvl(Int32.Parse(_adminEnemies.EditLvl));
            enemy.AdminSetGold(Int32.Parse(_adminEnemies.EditGold));
            enemy.AdminSetDmgMin(Int32.Parse(_adminEnemies.EditDmgMin));
            enemy.AdminSetDmgMax(Int32.Parse(_adminEnemies.EditDmgMax));
            enemy.AdminSetDef(Int32.Parse(_adminEnemies.EditDef));
            enemy.AdminSetHealth(Int32.Parse(_adminEnemies.EditHealth));

            if (_mongoConnector.TryUpsertRecord(ConfigurationManager.AppSettings.Get("enemiesCollection"), enemy.Id, enemy))
            {
                AlertEditSuccess($"{ enemy.Name } edited successfully!");
                _adminEnemies.Enemies.ClearSelected();
                _adminEnemies.Enemies.Items[selectedIndex] = enemy.Name;
                ClearEditFields();
            }
            else
            {
                AlertEditFail($"Failed to edit { enemy.Name }!");
            }
        }

        public void DeleteEnemy()
        {
            var enemy = _enemies[_adminEnemies.Enemies.SelectedIndex];

            if (_mongoConnector.TryDeleteRecordById<EnemyModel>(ConfigurationManager.AppSettings.Get("enemiesCollection"), enemy.Id))
            {
                AlertEditSuccess($"{ enemy.Name } deleted successfully!");
                _adminEnemies.Enemies.Items.Remove(enemy.Name);
                ClearEditFields();
            }
            else
            {
                AlertEditFail($"Failed to delete { enemy.Name }!");
            }
        }

        private void LoadAllEnemies()
        {
            _enemies = _mongoConnector.GetAllRecords<EnemyModel>(ConfigurationManager.AppSettings.Get("enemiesCollection"));
        }

        private void SetupEnemiesList()
        {
            foreach (var enemy in _enemies)
            {
                _adminEnemies.Enemies.Items.Add(enemy.Name);
            }
        }

        private void AlertAddSuccess(string msg)
        {
            _adminEnemies.LabEnemyAdd.Text = msg;
            _adminEnemies.LabEnemyAdd.ForeColor = UISettings.GreenColor;

            ShowAlert(_adminEnemies.LabEnemyAdd, _adminEnemies.TimHideAdd);
        }

        private void AlertAddFail(string msg)
        {
            _adminEnemies.LabEnemyAdd.Text = msg;
            _adminEnemies.LabEnemyAdd.ForeColor = UISettings.RedColor;

            ShowAlert(_adminEnemies.LabEnemyAdd, _adminEnemies.TimHideAdd);
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
            _adminEnemies.AddEnemyName = "";
            _adminEnemies.AddLvl = "";
            _adminEnemies.AddGold = "";
            _adminEnemies.AddDmgMin = "";
            _adminEnemies.AddDmgMax = "";
            _adminEnemies.AddDef = "";
            _adminEnemies.AddHealth = "";
        }

        private void ClearEditFields()
        {
            _adminEnemies.EditEnemyName = "";
            _adminEnemies.EditLvl = "";
            _adminEnemies.EditGold = "";
            _adminEnemies.EditDmgMin = "";
            _adminEnemies.EditDmgMax = "";
            _adminEnemies.EditDef = "";
            _adminEnemies.EditHealth = "";
        }
    }
}