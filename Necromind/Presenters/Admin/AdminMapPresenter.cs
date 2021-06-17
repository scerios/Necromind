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
        private int _currentX = 0;
        private int _currentY = 0;

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
            SetCurrentTile();
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

        private void SetLocationStats()
        {
            _adminMap.LabLocName = _location.Name;
            _adminMap.LabLocDescription = _location.Description;
            _adminMap.LabIsAccessible = _location.IsAccessible;
            _adminMap.LabIsHostile = _location.IsHostile;
        }

        private void SetCurrentTile()
        {
            _adminMap.LabX = _currentX.ToString();
            _adminMap.LabY = _currentY.ToString();
            TryGetCurrentTile();
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

        private void TryGetCurrentTile()
        {
            _currentTile = _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _currentX, _currentY);
        }

        private void TryGetNorthOfCurrent()
        {
            _northOfCurrent = _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _currentX, _currentY - 1);
        }

        private void TryGetSouthOfCurrent()
        {
            _southOfCurrent = _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _currentX, _currentY + 1);
        }

        private void TryGetWestOfCurrent()
        {
            _westOfCurrent = _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _currentX - 1, _currentY);
        }

        private void TryGetEastOfCurrent()
        {
            _eastOfCurrent = _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _currentX + 1, _currentY);
        }
    }
}