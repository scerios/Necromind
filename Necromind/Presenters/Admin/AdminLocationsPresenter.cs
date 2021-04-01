using NecromindLibrary.Config;
using NecromindLibrary.Models;
using NecromindLibrary.Repository;
using NecromindUI.Config;
using NecromindUI.Views.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NecromindUI.Presenters.Admin
{
    public class AdminLocationsPresenter
    {
        private readonly string _combinedName = "CombinedName";
        private readonly MongoConnector _mongoConnector;
        private readonly IAdminLocations _adminLocations;
        private readonly BindingSource _bsLocations = new BindingSource();
        private readonly BindingSource _bsCreateEnemies = new BindingSource();
        private readonly BindingSource _bsCreateAddedEnemies = new BindingSource();
        private readonly BindingSource _bsEditEnemies = new BindingSource();
        private readonly BindingSource _bsEditAddedEnemies = new BindingSource();
        private List<LocationModel> _locations;
        private List<EnemyModel> _enemies;
        private List<EnemyModel> _createEnemies;
        private readonly List<EnemyModel> _createAddedEnemies = new List<EnemyModel>();
        private List<EnemyModel> _editEnemies = new List<EnemyModel>();
        private List<EnemyModel> _editAddedEnemies = new List<EnemyModel>();
        private List<Guid> _enemyIds;
        private LocationModel _location;

        public AdminLocationsPresenter(IAdminLocations adminLocations)
        {
            _adminLocations = adminLocations;
            _mongoConnector = MongoConnector.GetInstance();
        }

        public void LoadData()
        {
            LoadAllLocations();
            LoadAllEnemies();
            BindAllLists();
            ClearLocationSelection();
            ClearEditFields();
        }

        public void GetSelectedLocationStats()
        {
            var selectedIndex = _adminLocations.Locations.SelectedIndex;

            if (selectedIndex >= 0)
            {
                _location = _locations[selectedIndex];
                _adminLocations.EditName = _location.Name;
                _adminLocations.EditDescription = _location.Description;
                _adminLocations.CbEditIsHostile = _location.IsHostile;
                LoadSelectedEnemies();
                ClearEditSelections();
            }
        }

        public void CreateLocation()
        {
            SetCreateLocationProperties();

            if (_mongoConnector.TryCreateNewRecord(DBConfig.LocationsCollection, _location))
            {
                UpdateUIAfterCreate();
            }
            else
            {
                AlertCreateFail($"Failed to create { _location.Name }!");
            }
        }

        public void EditLocation()
        {
            SetEditLocationProperties();

            if (_mongoConnector.TryUpsertRecord(DBConfig.LocationsCollection, _location.Id, _location))
            {
                UpdateUIAfterEdit();
            }
            else
            {
                AlertEditFail($"Failed to edit { _location.Name }!");
            }
        }

        public void DeleteLocation()
        {
            if (_mongoConnector.TryDeleteRecordById<LocationModel>(DBConfig.LocationsCollection, _location.Id))
            {
                UpdateUIAfterDelete();
            }
            else
            {
                AlertEditFail($"Failed to delete { _location.Name }!");
            }
        }

        public void CreateAdd()
        {
            var enemy = (EnemyModel)_adminLocations.CreateEnemies.SelectedItem;

            _createEnemies.Remove(enemy);
            _bsCreateEnemies.ResetBindings(false);
            _createAddedEnemies.Add(enemy);
            _bsCreateAddedEnemies.ResetBindings(false);

            ClearCreateSelections();
        }

        public void CreateRemove()
        {
            var enemy = (EnemyModel)_adminLocations.CreateAddedEnemies.SelectedItem;

            _createAddedEnemies.Remove(enemy);
            _bsCreateAddedEnemies.ResetBindings(false);
            _createEnemies.Add(enemy);
            _bsCreateEnemies.ResetBindings(false);

            ClearCreateSelections();
        }

        public void EditAdd()
        {
            var enemy = (EnemyModel)_adminLocations.EditEnemies.SelectedItem;

            _editEnemies.Remove(enemy);
            _bsEditEnemies.ResetBindings(false);
            _editAddedEnemies.Add(enemy);
            _bsEditAddedEnemies.ResetBindings(false);

            ClearEditSelections();
        }

        public void EditRemove()
        {
            var enemy = (EnemyModel)_adminLocations.EditAddedEnemies.SelectedItem;

            _editAddedEnemies.Remove(enemy);
            _bsEditAddedEnemies.ResetBindings(false);
            _editEnemies.Add(enemy);
            _bsEditEnemies.ResetBindings(false);

            ClearEditSelections();
        }

        private void BindAllLists()
        {
            BindLocations();
            BindCreateEnemies();
            BindCreateEnemiesAdded();
            BindEditEnemies();
            BindEditEnemiesAdded();

            ClearCreateSelections();
            ClearEditSelections();
        }

        private void BindLocations()
        {
            _bsLocations.DataSource = _locations;
            _adminLocations.Locations.DataSource = _bsLocations;
            _adminLocations.Locations.DisplayMember = "Name";
        }

        private void BindCreateEnemies()
        {
            _createEnemies = _enemies;
            _bsCreateEnemies.DataSource = _createEnemies;
            _adminLocations.CreateEnemies.DataSource = _bsCreateEnemies;
            _adminLocations.CreateEnemies.DisplayMember = _combinedName;
        }

        private void BindCreateEnemiesAdded()
        {
            _bsCreateAddedEnemies.DataSource = _createAddedEnemies;
            _adminLocations.CreateAddedEnemies.DataSource = _bsCreateAddedEnemies;
            _adminLocations.CreateAddedEnemies.DisplayMember = _combinedName;
        }

        private void BindEditEnemies()
        {
            _bsEditEnemies.DataSource = _editEnemies;
            _adminLocations.EditEnemies.DataSource = _bsEditEnemies;
            _adminLocations.EditEnemies.DisplayMember = _combinedName;
        }

        private void BindEditEnemiesAdded()
        {
            _bsEditAddedEnemies.DataSource = _editAddedEnemies;
            _adminLocations.EditAddedEnemies.DataSource = _bsEditAddedEnemies;
            _adminLocations.EditAddedEnemies.DisplayMember = _combinedName;
        }

        private void LoadAllLocations()
        {
            _locations = _mongoConnector.GetAllRecords<LocationModel>(DBConfig.LocationsCollection);
        }

        private void LoadAllEnemies()
        {
            _enemies = _mongoConnector.GetAllRecords<EnemyModel>(DBConfig.EnemiesCollection);
        }

        private void LoadSelectedEnemies()
        {
            _enemyIds = _location.Enemies;
            HashSet<Guid> enemyIds = new HashSet<Guid>(_enemies.Select(i => i.Id));

            SetEditAddedEnemies();

            SetEditEnemiesBy(enemyIds.Where(i => !_enemyIds.Contains(i)));
        }

        private void ClearLocationSelection()
        {
            _adminLocations.Locations.ClearSelected();
        }

        private void ClearCreateSelections()
        {
            _adminLocations.CreateEnemies.ClearSelected();
            _adminLocations.CreateAddedEnemies.ClearSelected();
        }

        private void ClearEditSelections()
        {
            _adminLocations.EditEnemies.ClearSelected();
            _adminLocations.EditAddedEnemies.ClearSelected();
        }

        private void ClearCreateFields()
        {
            _adminLocations.CreateName = "";
            _adminLocations.CreateDescription = "";
            _adminLocations.CbCreateIsHostile = false;
        }

        private void ClearEditFields()
        {
            _adminLocations.EditName = "";
            _adminLocations.EditDescription = "";
            _adminLocations.CbEditIsHostile = false;
        }

        private void AlertCreateSuccess(string msg)
        {
            _adminLocations.LabLocationAdd.Text = msg;
            _adminLocations.LabLocationAdd.ForeColor = UISettings.GreenColor;

            ShowAlert(_adminLocations.LabLocationAdd, _adminLocations.TimHideAdd);
        }

        private void AlertCreateFail(string msg)
        {
            _adminLocations.LabLocationAdd.Text = msg;
            _adminLocations.LabLocationAdd.ForeColor = UISettings.RedColor;

            ShowAlert(_adminLocations.LabLocationAdd, _adminLocations.TimHideAdd);
        }

        private void AlertEditSuccess(string msg)
        {
            _adminLocations.LabLocationEdit.Text = msg;
            _adminLocations.LabLocationEdit.ForeColor = UISettings.GreenColor;

            ShowAlert(_adminLocations.LabLocationEdit, _adminLocations.TimHideEdit);
        }

        private void AlertEditFail(string msg)
        {
            _adminLocations.LabLocationEdit.Text = msg;
            _adminLocations.LabLocationEdit.ForeColor = UISettings.RedColor;

            ShowAlert(_adminLocations.LabLocationEdit, _adminLocations.TimHideEdit);
        }

        private void ShowAlert(Label label, Timer timer)
        {
            label.Visible = true;
            timer.Start();
        }

        private void AddEnemiesToLocation(List<EnemyModel> enemies)
        {
            foreach (var enemy in enemies)
            {
                _location.Enemies.Add(enemy.Id);
            }
        }

        private void SetEditAddedEnemies()
        {
            _editAddedEnemies.Clear();

            foreach (var id in _enemyIds)
            {
                _editAddedEnemies.Add(_mongoConnector.GetRecordById<EnemyModel>(DBConfig.EnemiesCollection, id.ToString()));
            }

            _bsEditAddedEnemies.ResetBindings(false);
        }

        private void SetEditEnemiesBy(IEnumerable<Guid> unmatchedIds)
        {
            _editEnemies.Clear();

            foreach (var id in unmatchedIds)
            {
                _editEnemies.Add(_mongoConnector.GetRecordById<EnemyModel>(DBConfig.EnemiesCollection, id.ToString()));
            }

            _bsEditEnemies.ResetBindings(false);
        }

        private void SetCreateLocationProperties()
        {
            _location = new LocationModel();
            _location.Name = _adminLocations.CreateName;
            _location.Description = _adminLocations.CreateDescription;
            _location.IsHostile = _adminLocations.CbCreateIsHostile;

            AddEnemiesToLocation(_createAddedEnemies);
        }

        private void SetEditLocationProperties()
        {
            _location.Name = _adminLocations.EditName;
            _location.Description = _adminLocations.EditDescription;
            _location.IsHostile = _adminLocations.CbEditIsHostile;

            _location.Enemies.Clear();

            foreach (var enemy in _editAddedEnemies)
            {
                _location.Enemies.Add(enemy.Id);
            }
        }

        private void UpdateUIAfterCreate()
        {
            AlertCreateSuccess($"{ _location.Name } created successfully!");

            _locations.Add(_location);
            _bsLocations.ResetBindings(false);

            foreach (var enemy in _createAddedEnemies)
            {
                _createEnemies.Add(enemy);
            }
            _bsCreateEnemies.ResetBindings(false);

            _createAddedEnemies.Clear();
            _bsCreateAddedEnemies.ResetBindings(false);

            ClearCreateFields();
            ClearCreateSelections();
        }

        private void UpdateUIAfterEdit()
        {
            AlertEditSuccess($"{ _location.Name } edited successfully!");

            _locations[_adminLocations.Locations.SelectedIndex].Name = _location.Name;
            _bsLocations.ResetBindings(false);

            ClearEditFields();
        }

        private void UpdateUIAfterDelete()
        {
            AlertEditSuccess($"{ _location.Name } deleted successfully!");

            _locations.Remove(_location);
            _bsLocations.ResetBindings(false);

            ClearEditFields();
        }
    }
}