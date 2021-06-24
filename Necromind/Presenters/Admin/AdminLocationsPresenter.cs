using NecromindLibrary.Config;
using NecromindLibrary.Models;
using NecromindLibrary.Repository;
using NecromindLibrary.Services;
using NecromindUI.Views.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NecromindUI.Presenters.Admin
{
    public class AdminLocationsPresenter
    {
        #region Properties

        private readonly string _listboxDisplayMember = "CombinedName";
        private readonly IAdminLocations _adminLocations;
        private readonly MongoConnector _mongoConnector = MongoConnector.GetInstance();
        private readonly BindingSource _bsLocations = new BindingSource();
        private readonly BindingSource _bsCreateEnemies = new BindingSource();
        private readonly BindingSource _bsCreateAddedEnemies = new BindingSource();
        private readonly BindingSource _bsEditEnemies = new BindingSource();
        private readonly BindingSource _bsEditAddedEnemies = new BindingSource();
        private List<LocationModel> _locations;
        private List<EnemyModel> _enemies;
        private List<EnemyModel> _createEnemies;
        private List<EnemyModel> _createAddedEnemies = new List<EnemyModel>();
        private List<EnemyModel> _editEnemies = new List<EnemyModel>();
        private List<EnemyModel> _editAddedEnemies = new List<EnemyModel>();
        private List<Guid> _enemyIds;
        private LocationModel _location;

        #endregion Properties

        public AdminLocationsPresenter(IAdminLocations adminLocations)
        {
            _adminLocations = adminLocations;
        }

        public void LoadData()
        {
            LoadLocations();
            LoadEnemies();
            BindLists();
            ClearLocationSelection();
            ClearEditFields();
        }

        public void SetSelectedLocationStats()
        {
            var selectedIndex = _adminLocations.LbLocations.SelectedIndex;

            if (selectedIndex >= 0)
            {
                _location = _locations[selectedIndex];
                _adminLocations.TbEditName = _location.Name;
                _adminLocations.TbEditDescription = _location.Description;
                _adminLocations.CbEditIsHostile = _location.IsHostile;
                _adminLocations.CbEditIsAccessible = _location.IsAccessible;
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
                ClearLocation();
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
                ClearLocation();
            }
            else
            {
                AlertEditFail($"Failed to delete { _location.Name }!");
            }
        }

        #region Enemy handling

        public void CreateAdd()
        {
            var enemy = (EnemyModel)_adminLocations.LbCreateEnemies.SelectedItem;

            _createEnemies.Remove(enemy);
            _bsCreateEnemies.ResetBindings(false);
            _createAddedEnemies.Add(enemy);
            _bsCreateAddedEnemies.ResetBindings(false);

            ClearCreateSelections();
        }

        public void CreateRemove()
        {
            var enemy = (EnemyModel)_adminLocations.LbCreateAddedEnemies.SelectedItem;

            _createAddedEnemies.Remove(enemy);
            _bsCreateAddedEnemies.ResetBindings(false);
            _createEnemies.Add(enemy);
            _bsCreateEnemies.ResetBindings(false);

            ClearCreateSelections();
        }

        public void EditAdd()
        {
            var enemy = (EnemyModel)_adminLocations.LbEditEnemies.SelectedItem;

            _editEnemies.Remove(enemy);
            _bsEditEnemies.ResetBindings(false);
            _editAddedEnemies.Add(enemy);
            _bsEditAddedEnemies.ResetBindings(false);

            ClearEditSelections();
        }

        public void EditRemove()
        {
            var enemy = (EnemyModel)_adminLocations.LbEditAddedEnemies.SelectedItem;

            _editAddedEnemies.Remove(enemy);
            _bsEditAddedEnemies.ResetBindings(false);
            _editEnemies.Add(enemy);
            _bsEditEnemies.ResetBindings(false);

            ClearEditSelections();
        }

        #endregion Enemy handling

        public bool AreCreateFieldsValid()
        {
            _adminLocations.LabNameCError = !ValidationService.IsValidName(_adminLocations.TbCreateName);
            return !_adminLocations.LabNameCError;
        }

        public bool AreEditFieldsValid()
        {
            _adminLocations.LabNameMError = !ValidationService.IsValidName(_adminLocations.TbEditName);
            return !_adminLocations.LabNameMError;
        }

        public bool IsLocationSelected() =>
            _location != null;

        #region Resource binding

        private void BindLists()
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
            _adminLocations.LbLocations.DataSource = _bsLocations;
            _adminLocations.LbLocations.DisplayMember = "Name";
        }

        private void BindCreateEnemies()
        {
            _createEnemies = _enemies;
            _bsCreateEnemies.DataSource = _createEnemies;
            _adminLocations.LbCreateEnemies.DataSource = _bsCreateEnemies;
            _adminLocations.LbCreateEnemies.DisplayMember = _listboxDisplayMember;
        }

        private void BindCreateEnemiesAdded()
        {
            _bsCreateAddedEnemies.DataSource = _createAddedEnemies;
            _adminLocations.LbCreateAddedEnemies.DataSource = _bsCreateAddedEnemies;
            _adminLocations.LbCreateAddedEnemies.DisplayMember = _listboxDisplayMember;
        }

        private void BindEditEnemies()
        {
            _bsEditEnemies.DataSource = _editEnemies;
            _adminLocations.LbEditEnemies.DataSource = _bsEditEnemies;
            _adminLocations.LbEditEnemies.DisplayMember = _listboxDisplayMember;
        }

        private void BindEditEnemiesAdded()
        {
            _bsEditAddedEnemies.DataSource = _editAddedEnemies;
            _adminLocations.LbEditAddedEnemies.DataSource = _bsEditAddedEnemies;
            _adminLocations.LbEditAddedEnemies.DisplayMember = _listboxDisplayMember;
        }

        #endregion Resource binding

        #region Loads

        private void LoadLocations()
        {
            _locations = _mongoConnector.GetAllRecords<LocationModel>(DBConfig.LocationsCollection);
        }

        private void LoadEnemies()
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

        #endregion Loads

        #region Clears

        private void ClearLocation()
        {
            _location = null;
        }

        private void ClearLocationSelection()
        {
            _adminLocations.LbLocations.ClearSelected();
        }

        private void ClearCreateSelections()
        {
            _adminLocations.LbCreateEnemies.ClearSelected();
            _adminLocations.LbCreateAddedEnemies.ClearSelected();
        }

        private void ClearEditSelections()
        {
            _adminLocations.LbEditEnemies.ClearSelected();
            _adminLocations.LbEditAddedEnemies.ClearSelected();
        }

        #endregion Clears

        #region Alerts

        private void AlertCreateSuccess(string msg)
        {
            _adminLocations.LabLocationAdd.Text = msg;
            _adminLocations.LabLocationAdd.ForeColor = UISettings.SuccessColor;

            ShowAlert(_adminLocations.LabLocationAdd, _adminLocations.TimHideAdd);
        }

        private void AlertCreateFail(string msg)
        {
            _adminLocations.LabLocationAdd.Text = msg;
            _adminLocations.LabLocationAdd.ForeColor = UISettings.ErrorColor;

            ShowAlert(_adminLocations.LabLocationAdd, _adminLocations.TimHideAdd);
        }

        private void AlertEditSuccess(string msg)
        {
            _adminLocations.LabLocationEdit.Text = msg;
            _adminLocations.LabLocationEdit.ForeColor = UISettings.SuccessColor;

            ShowAlert(_adminLocations.LabLocationEdit, _adminLocations.TimHideEdit);
        }

        private void AlertEditFail(string msg)
        {
            _adminLocations.LabLocationEdit.Text = msg;
            _adminLocations.LabLocationEdit.ForeColor = UISettings.ErrorColor;

            ShowAlert(_adminLocations.LabLocationEdit, _adminLocations.TimHideEdit);
        }

        private void ShowAlert(Label label, Timer timer)
        {
            label.Visible = true;
            timer.Start();
        }

        #endregion Alerts

        private void AddEnemiesToLocation(List<EnemyModel> enemies)
        {
            foreach (var enemy in enemies)
            {
                _location.Enemies.Add(enemy.Id);
            }
        }

        #region Setters

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
            _location.Name = _adminLocations.TbCreateName;
            _location.Description = _adminLocations.TbCreateDescription;
            _location.IsHostile = _adminLocations.CbCreateIsHostile;
            _location.IsAccessible = _adminLocations.CbCreateIsAccessible;

            AddEnemiesToLocation(_createAddedEnemies);
        }

        private void SetEditLocationProperties()
        {
            _location.Name = _adminLocations.TbEditName;
            _location.Description = _adminLocations.TbEditDescription;
            _location.IsHostile = _adminLocations.CbEditIsHostile;
            _location.IsAccessible = _adminLocations.CbEditIsAccessible;

            _location.Enemies.Clear();

            foreach (var enemy in _editAddedEnemies)
            {
                _location.Enemies.Add(enemy.Id);
            }
        }

        #endregion Setters

        #region UI modifications

        private void ClearCreateFields()
        {
            _adminLocations.TbCreateName = "";
            _adminLocations.TbCreateDescription = "";
            _adminLocations.CbCreateIsHostile = false;
            _adminLocations.CbCreateIsAccessible = false;
        }

        private void ClearEditFields()
        {
            _adminLocations.TbEditName = "";
            _adminLocations.TbEditDescription = "";
            _adminLocations.CbEditIsHostile = false;
            _adminLocations.CbEditIsAccessible = false;
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

            _locations[_adminLocations.LbLocations.SelectedIndex].Name = _location.Name;
            _bsLocations.ResetBindings(false);

            ClearEditFields();
            ClearLocationSelection();
        }

        private void UpdateUIAfterDelete()
        {
            AlertEditSuccess($"{ _location.Name } deleted successfully!");

            _locations.Remove(_location);
            _bsLocations.ResetBindings(false);

            ClearEditFields();
            ClearLocationSelection();
        }

        #endregion UI modifications
    }
}