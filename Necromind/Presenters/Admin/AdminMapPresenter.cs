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
            TryGetStartTile();
            SetCurrentTileCoordinates();
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

        public void MoveNorth()
        {
            _adminMap.LabY = (_currentTile.Y - 1).ToString();
            _southOfCurrent = _currentTile;
            _currentTile = _northOfCurrent;

            TryGetNorthOfCurrent();
            TryGetWestOfCurrent();
            TryGetEastOfCurrent();
            SetMovementBtns();
        }

        private void SetLocationStats()
        {
            _adminMap.LabLocName = _location.Name;
            _adminMap.LabLocDescription = _location.Description;
            _adminMap.LabIsAccessible = _location.IsAccessible;
            _adminMap.LabIsHostile = _location.IsHostile;
        }

        private void SetCurrentTileCoordinates()
        {
            _adminMap.LabX = _currentTile.X.ToString();
            _adminMap.LabY = _currentTile.Y.ToString();
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

        private bool TryGetTilesLocation()
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
            if (TryGetTilesLocation())
            {
                SetLocationStats();
            }
        }

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

        private void TryGetStartTile()
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
    }
}