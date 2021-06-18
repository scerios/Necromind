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
        private int _x = 0;
        private int _y = 0;

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

        private bool HasNorthNeighbor(int x, int y)
        {
            return GetNorthOf(x, y) != null;
        }

        private bool HasSouthNeighbor(int x, int y)
        {
            return GetSouthOf(x, y) != null;
        }

        private bool HasWestNeighbor(int x, int y)
        {
            return GetWestOf(x, y) != null;
        }

        private bool HasEastNeighbor(int x, int y)
        {
            return GetEastOf(x, y) != null;
        }

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
            _currentTile = _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _x, _y);
        }

        private MapTileModel GetNorthOf(int locX, int locY)
        {
            return _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, locX, locY - 1);
        }

        private MapTileModel GetSouthOf(int locX, int locY)
        {
            return _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, locX, locY + 1);
        }

        private MapTileModel GetWestOf(int locX, int locY)
        {
            return _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, locX - 1, locY);
        }

        private MapTileModel GetEastOf(int locX, int locY)
        {
            return _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, locX + 1, locY);
        }

        #endregion Getters

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
            _adminMap.LabX = _x.ToString();
            _adminMap.LabY = _y.ToString();
        }

        private void SetNeighborhood()
        {
            _northOfCurrent = GetNorthOf(_x, _y);
            _southOfCurrent = GetSouthOf(_x, _y);
            _westOfCurrent = GetWestOf(_x, _y);
            _eastOfCurrent = GetEastOf(_x, _y);
        }

        private void SetMovementBtns()
        {
            if (_currentTile == null)
            {
                _adminMap.BtnIsNorthEnabled = HasNorthNeighbor(_x, _y) || (HasNorthNeighbor(_x, _y - 1) || HasWestNeighbor(_x, _y - 1) || HasEastNeighbor(_x, _y - 1));
                _adminMap.BtnIsSouthEnabled = HasSouthNeighbor(_x, _y) || (HasSouthNeighbor(_x, _y + 1) || HasWestNeighbor(_x, _y + 1) || HasEastNeighbor(_x, _y + 1));
                _adminMap.BtnIsWestEnabled = HasWestNeighbor(_x, _y) || (HasWestNeighbor(_x - 1, _y) || HasNorthNeighbor(_x - 1, _y) || HasSouthNeighbor(_x - 1, _y));
                _adminMap.BtnIsEastEnabled = HasEastNeighbor(_x, _y) || (HasEastNeighbor(_x + 1, _y) || HasNorthNeighbor(_x + 1, _y) || HasSouthNeighbor(_x + 1, _y));
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

        #region Movement

        public void MoveNorth()
        {
            _y--;
            _adminMap.LabY = _y.ToString();

            _southOfCurrent = _currentTile;
            _currentTile = _northOfCurrent;

            SetCurrentLocationStats();

            _northOfCurrent = GetNorthOf(_x, _y);
            _westOfCurrent = GetWestOf(_x, _y);
            _eastOfCurrent = GetEastOf(_x, _y);
            SetMovementBtns();
        }

        public void MoveSouth()
        {
            _y++;
            _adminMap.LabY = _y.ToString();

            _northOfCurrent = _currentTile;
            _currentTile = _southOfCurrent;

            SetCurrentLocationStats();

            _southOfCurrent = GetSouthOf(_x, _y);
            _westOfCurrent = GetWestOf(_x, _y);
            _eastOfCurrent = GetEastOf(_x, _y);
            SetMovementBtns();
        }

        public void MoveWest()
        {
            _x--;
            _adminMap.LabX = _x.ToString();

            _eastOfCurrent = _currentTile;
            _currentTile = _westOfCurrent;

            SetCurrentLocationStats();

            _northOfCurrent = GetNorthOf(_x, _y);
            _southOfCurrent = GetSouthOf(_x, _y);
            _westOfCurrent = GetWestOf(_x, _y);
            SetMovementBtns();
        }

        public void MoveEast()
        {
            _x++;
            _adminMap.LabX = _x.ToString();

            _westOfCurrent = _currentTile;
            _currentTile = _eastOfCurrent;

            SetCurrentLocationStats();

            _northOfCurrent = GetNorthOf(_x, _y);
            _southOfCurrent = GetSouthOf(_x, _y);
            _eastOfCurrent = GetEastOf(_x, _y);
            SetMovementBtns();
        }

        #endregion Movement

        #region Clear

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

        #endregion Clear
    }
}