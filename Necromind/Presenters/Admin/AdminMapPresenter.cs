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
        private int _locX = 0;
        private int _locY = 0;

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
            SetCurrentLocationStats();
            SetMovementBtns();
        }

        public void SetSelectedLocationStats()
        {
            var selectedIndex = _adminMap.LbLocations.SelectedIndex;

            if (selectedIndex >= 0)
            {
                _location = _locations[selectedIndex];
                SetLocationStats();
                _adminMap.BtnIsAttachEnabled = true;
            }
        }

        public void AttachLocation()
        {
            TryInitNewMapTile();

            _currentTile.LocationId = _location.Id;
            _adminMap.BtnIsSaveEnabled = true;
        }

        public void Save()
        {
            if (_mongoConnector.GetRecordById<MapTileModel>(DBConfig.MapTilesCollection, _currentTile.Id.ToString()) == null)
                CreateMapTile();
            else
                UpdateMapTile();

            SetMovementBtns();
        }

        private void CreateMapTile()
        {
            _currentTile.X = Int32.Parse(_adminMap.LabX);
            _currentTile.Y = Int32.Parse(_adminMap.LabY);

            _mongoConnector.TryCreateNewRecord(DBConfig.MapTilesCollection, _currentTile);
        }

        private void UpdateMapTile()
        {
            _mongoConnector.TryUpsertRecord(DBConfig.MapTilesCollection, _currentTile.Id, _currentTile);
        }

        #region Movement

        public void MoveNorth()
        {
            _locY--;
            _adminMap.LabY = _locY.ToString();

            _southOfCurrent = _currentTile;
            _currentTile = _northOfCurrent;

            SetCurrentLocationStats();

            GetNorthOfCurrent();
            GetWestOfCurrent();
            GetEastOfCurrent();
            SetMovementBtns();
        }

        public void MoveSouth()
        {
            _locY++;
            _adminMap.LabY = _locY.ToString();

            _northOfCurrent = _currentTile;
            _currentTile = _southOfCurrent;

            SetCurrentLocationStats();

            GetSouthOfCurrent();
            GetWestOfCurrent();
            GetEastOfCurrent();
            SetMovementBtns();
        }

        public void MoveWest()
        {
            _locX--;
            _adminMap.LabX = _locX.ToString();

            _eastOfCurrent = _currentTile;
            _currentTile = _westOfCurrent;

            SetCurrentLocationStats();

            GetNorthOfCurrent();
            GetSouthOfCurrent();
            GetWestOfCurrent();
            SetMovementBtns();
        }

        public void MoveEast()
        {
            _locX++;
            _adminMap.LabX = _locX.ToString();

            _westOfCurrent = _currentTile;
            _currentTile = _eastOfCurrent;

            SetCurrentLocationStats();

            GetNorthOfCurrent();
            GetSouthOfCurrent();
            GetEastOfCurrent();
            SetMovementBtns();
        }

        #endregion Movement

        #region Setters

        private void SetLocationStats()
        {
            if (_location != null)
            {
                _adminMap.LabLocName = _location.Name;
                _adminMap.LabLocDescription = _location.Description;
                _adminMap.LabIsAccessible = _location.IsAccessible;
                _adminMap.LabIsHostile = _location.IsHostile;
            }
            else
            {
                ClearEditFields();
            }
        }

        private void SetStartTileCoordinates()
        {
            _adminMap.LabX = _locX.ToString();
            _adminMap.LabY = _locY.ToString();
        }

        private void SetNeighborhood()
        {
            GetNorthOfCurrent();
            GetSouthOfCurrent();
            GetWestOfCurrent();
            GetEastOfCurrent();
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

        private void SetCurrentLocationStats()
        {
            if (_currentTile != null)
                GetTilesLocation();
            else
                _location = null;

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

        private void TryInitNewMapTile()
        {
            if (_currentTile == null)
                _currentTile = new MapTileModel();
        }

        #endregion Init

        private void ClearLocationSelection()
        {
            _adminMap.LbLocations.ClearSelected();
            _adminMap.BtnIsAttachEnabled = false;
        }

        private void ClearEditFields()
        {
            _adminMap.LabLocName = "";
            _adminMap.LabLocDescription = "";
            _adminMap.IndicatorsOff = true;
        }

        #region Getters

        private void GetTilesLocation()
        {
            LocationModel location = null;

            if (_currentTile.LocationId != null)
            {
                location = _mongoConnector.GetRecordById<LocationModel>(DBConfig.LocationsCollection, _currentTile.LocationId.ToString());
            }

            if (location != null)
            {
                _location = location;
            }
        }

        private void GetStartTile()
        {
            _currentTile = _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _locX, _locY);
        }

        private void GetNorthOfCurrent()
        {
            _northOfCurrent = _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _locX, _locY - 1);
        }

        private void GetSouthOfCurrent()
        {
            _southOfCurrent = _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _locX, _locY + 1);
        }

        private void GetWestOfCurrent()
        {
            _westOfCurrent = _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _locX - 1, _locY);
        }

        private void GetEastOfCurrent()
        {
            _eastOfCurrent = _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _locX + 1, _locY);
        }

        #endregion Getters
    }
}