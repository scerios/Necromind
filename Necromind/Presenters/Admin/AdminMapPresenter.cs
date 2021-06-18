using NecromindLibrary.Config;
using NecromindLibrary.Models;
using NecromindLibrary.Repository;
using NecromindUI.Views.Admin;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NecromindUI.Presenters.Admin
{
    public class AdminMapPresenter
    {
        #region Properties

        private readonly MongoConnector _mongoConnector;
        private readonly IAdminMap _adminMap;
        private readonly BindingSource _bsLocations = new BindingSource();
        private List<LocationModel> _locations;
        private LocationModel _location;
        private MapTileModel _currentTile;
        private MapTileModel _northOfCurrent;
        private MapTileModel _southOfCurrent;
        private MapTileModel _westOfCurrent;
        private MapTileModel _eastOfCurrent;

        #endregion Properties

        public AdminMapPresenter(IAdminMap adminMap)
        {
            _adminMap = adminMap;
            _mongoConnector = MongoConnector.GetInstance();
        }

        public void LoadData()
        {
            LoadLocations();
            BindLocations();

            ClearLocationSelection();
            ClearEditFields();

            GetStartTile();
            SetStartTileCoordinates();
            SetNeighborhood();
            TrySetCurrentLocationStats();
            SetMovementBtns();
        }

        public void SetSelectedLocationStats()
        {
            var selectedIndex = _adminMap.LbLocations.SelectedIndex;

            if (selectedIndex >= 0)
            {
                _location = _locations[selectedIndex];
                SetLocationStats();
            }
        }

        #region Movement

        public void MoveNorth()
        {
            if (_northOfCurrent == null)
                _adminMap.LabY = (_currentTile.Y - 1).ToString();
            else
                _adminMap.LabY = _northOfCurrent.Y.ToString();

            _southOfCurrent = _currentTile;
            _currentTile = _northOfCurrent;

            TryGetNorthOfCurrent();
            TryGetWestOfCurrent();
            TryGetEastOfCurrent();
            SetMovementBtns();
        }

        public void MoveSouth()
        {
            if (_southOfCurrent == null)
                _adminMap.LabY = (_currentTile.Y + 1).ToString();
            else
                _adminMap.LabY = _southOfCurrent.Y.ToString();

            _northOfCurrent = _currentTile;
            _currentTile = _southOfCurrent;

            TryGetSouthOfCurrent();
            TryGetWestOfCurrent();
            TryGetEastOfCurrent();
            SetMovementBtns();
        }

        public void MoveWest()
        {
            if (_westOfCurrent == null)
                _adminMap.LabX = (_currentTile.X - 1).ToString();
            else
                _adminMap.LabX = _westOfCurrent.X.ToString();

            _eastOfCurrent = _currentTile;
            _currentTile = _westOfCurrent;

            TryGetNorthOfCurrent();
            TryGetSouthOfCurrent();
            TryGetWestOfCurrent();
            SetMovementBtns();
        }

        public void MoveEast()
        {
            if (_eastOfCurrent == null)
                _adminMap.LabX = (_currentTile.X + 1).ToString();
            else
                _adminMap.LabX = _eastOfCurrent.X.ToString();

            _westOfCurrent = _currentTile;
            _currentTile = _eastOfCurrent;

            TryGetNorthOfCurrent();
            TryGetSouthOfCurrent();
            TryGetEastOfCurrent();
            SetMovementBtns();
        }

        #endregion Movement

        #region Setters

        private void SetLocationStats()
        {
            _adminMap.LabLocName = _location.Name;
            _adminMap.LabLocDescription = _location.Description;
            _adminMap.LabIsAccessible = _location.IsAccessible;
            _adminMap.LabIsHostile = _location.IsHostile;
        }

        private void SetStartTileCoordinates()
        {
            _adminMap.LabX = "0";
            _adminMap.LabY = "0";
        }

        private void SetNeighborhood()
        {
            TryGetNorthOfCurrent();
            TryGetSouthOfCurrent();
            TryGetWestOfCurrent();
            TryGetEastOfCurrent();
        }

        private void SetMovementBtns()
        {
            if (_currentTile == null)
            {
                _adminMap.BtnIsNorthEnabled = _northOfCurrent != null;
                _adminMap.BtnIsSouthEnabled = _southOfCurrent != null;
                _adminMap.BtnIsWestEnabled = _westOfCurrent != null;
                _adminMap.BtnIsEastEnabled = _eastOfCurrent != null;
            }
            else
            {
                _adminMap.BtnIsNorthEnabled = true;
                _adminMap.BtnIsSouthEnabled = true;
                _adminMap.BtnIsWestEnabled = true;
                _adminMap.BtnIsEastEnabled = true;
            }
        }

        private bool GetTilesLocation()
        {
            var location = _mongoConnector.GetRecordById<LocationModel>(DBConfig.LocationsCollection, _currentTile.LocationId.ToString());

            if (location != null)
            {
                _location = location;
                return true;
            }

            return false;
        }

        private void TrySetCurrentLocationStats()
        {
            if (_currentTile != null && GetTilesLocation())
                SetLocationStats();
        }

        #endregion Setters

        #region Init

        private void LoadLocations()
        {
            _locations = _mongoConnector.GetAllRecords<LocationModel>(DBConfig.LocationsCollection);
        }

        private void BindLocations()
        {
            _bsLocations.DataSource = _locations;
            _adminMap.LbLocations.DataSource = _bsLocations;
            _adminMap.LbLocations.DisplayMember = "Name";
        }

        #endregion Init

        private void ClearLocationSelection()
        {
            _adminMap.LbLocations.ClearSelected();
        }

        private void ClearEditFields()
        {
            _adminMap.LabLocName = "";
            _adminMap.LabLocDescription = "";
            _adminMap.IndicatorsOff = true;
        }

        #region Getters

        private void GetStartTile()
        {
            _currentTile = _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, 0, 0);
        }

        private void TryGetNorthOfCurrent()
        {
            if (_currentTile != null)
                _northOfCurrent = _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _currentTile.X, _currentTile.Y - 1);
        }

        private void TryGetSouthOfCurrent()
        {
            if (_currentTile != null)
                _southOfCurrent = _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _currentTile.X, _currentTile.Y + 1);
        }

        private void TryGetWestOfCurrent()
        {
            if (_currentTile != null)
                _westOfCurrent = _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _currentTile.X - 1, _currentTile.Y);
        }

        private void TryGetEastOfCurrent()
        {
            if (_currentTile != null)
                _eastOfCurrent = _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _currentTile.X + 1, _currentTile.Y);
        }

        #endregion Getters
    }
}