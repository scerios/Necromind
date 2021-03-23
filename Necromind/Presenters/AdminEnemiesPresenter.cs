using NecromindLibrary.Models;
using NecromindLibrary.Repository;
using NecromindUI.Views;
using System;
using System.Configuration;
using System.Drawing;

namespace NecromindUI.Presenters
{
    public class AdminEnemiesPresenter
    {
        private readonly MongoConnector _mongoConnector;
        private readonly IAdminEnemies _adminEnemies;

        public AdminEnemiesPresenter(IAdminEnemies adminEnemies)
        {
            _adminEnemies = adminEnemies;
            _mongoConnector = MongoConnector.GetInstance();
        }

        private void AlertSuccess(string name)
        {
            _adminEnemies.LabEnemyAdded.Text = $"{ name } added successfully!";
            _adminEnemies.LabEnemyAdded.ForeColor = Color.FromArgb(211, 84, 0);
            _adminEnemies.LabEnemyAdded.Visible = true;
            _adminEnemies.TimHide.Start();
        }

        private void AlertFail(string name)
        {
            _adminEnemies.LabEnemyAdded.Text = $"Failed to add { name }!";
            _adminEnemies.LabEnemyAdded.ForeColor = Color.FromArgb(214, 48, 49);
            _adminEnemies.LabEnemyAdded.Visible = true;
            _adminEnemies.TimHide.Start();
        }

        public void AddEnemy()
        {
            var enemy = new EnemyModel();
            enemy.AdminSetName(_adminEnemies.EnemyName);
            enemy.AdminSetLvl(Int32.Parse(_adminEnemies.Lvl));
            enemy.AdminSetGold(Int32.Parse(_adminEnemies.Gold));
            enemy.AdminSetDmgMin(Int32.Parse(_adminEnemies.DmgMin));
            enemy.AdminSetDmgMax(Int32.Parse(_adminEnemies.DmgMax));
            enemy.AdminSetDef(Int32.Parse(_adminEnemies.Def));
            enemy.AdminSetHealth(Int32.Parse(_adminEnemies.Health));

            if (_mongoConnector.TryCreateNewRecord(ConfigurationManager.AppSettings.Get("enemiesCollection"), enemy))
            {
                AlertSuccess(enemy.Name);
            }
            else
            {
                AlertFail(enemy.Name);
            }
        }
    }
}