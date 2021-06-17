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

        private MapTileModel TryGetCurrentTile()
        {
            return _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _currentX, _currentY);
        }

        private MapTileModel TryGetNorthOfCurrent()
        {
            return _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _currentX, _currentY - 1);
        }

        private MapTileModel TryGetSouthOfCurrent()
        {
            return _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _currentX, _currentY + 1);
        }

        private MapTileModel TryGetWestOfCurrent()
        {
            return _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _currentX - 1, _currentY);
        }

        private MapTileModel TryGetEastOfCurrent()
        {
            return _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _currentX + 1, _currentY);
        }
    }
}