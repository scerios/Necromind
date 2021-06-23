using NecromindLibrary.Config;
using NecromindLibrary.Models;
using NecromindLibrary.Repository;
using NecromindLibrary.Services;
using NecromindUI.Views.Admin;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NecromindUI.Presenters.Admin
{
    public class AdminMapPresenter
    {
        #region Properties

        private readonly IAdminMap _adminMap;
        private readonly MongoConnector _mongoConnector = MongoConnector.GetInstance();
        private readonly BindingSource _bsLocations = new BindingSource();
        private readonly MapServiceAdmin _mapService = new MapServiceAdmin();
        private List<LocationModel> _locations;
        private LocationModel _location;

        #endregion Properties

        public AdminMapPresenter(IAdminMap adminMap)
        {
            _adminMap = adminMap;
        }

        public void LoadData()
        {
            LoadLocations();
            BindLocations();

            ClearLocationSelection();
            ClearEditFields();

            SetCoordinates();
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

            _mapService.Current.LocationId = _location.Id;

            EnableSaveBtn();
        }

        public void Save()
        {
            if (_mongoConnector.GetRecordById<MapTileModel>(DBConfig.MapTilesCollection, _mapService.GetCurrentTilesId().ToString()) == null)
                CreateMapTile();
            else
                UpdateMapTile();

            SetMovementBtns();
        }

        public void Delete()
        {
            _mongoConnector.TryDeleteRecordById<MapTileModel>(DBConfig.MapTilesCollection, _mapService.Current.Id);

            _mapService.DeleteMap();
            ToggleDelBtn();
            ClearLocationSelection();
            ClearEditFields();
            SetMovementBtns();
        }

        private void CreateMapTile()
        {
            _mapService.Current.X = Int32.Parse(_adminMap.LabX);
            _mapService.Current.Y = Int32.Parse(_adminMap.LabY);

            _mongoConnector.TryCreateNewRecord(DBConfig.MapTilesCollection, _mapService.Current);
        }

        private void UpdateMapTile()
        {
            _mongoConnector.TryUpsertRecord(DBConfig.MapTilesCollection, _mapService.GetCurrentTilesId(), _mapService.Current);
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

        #endregion Init

        private void TryGetCurrentTilesLocation()
        {
            LocationModel location = null;

            if (_mapService.Current.LocationId != null)
            {
                location = _mongoConnector.GetRecordById<LocationModel>(DBConfig.LocationsCollection, _mapService.Current.LocationId.ToString());
            }

            if (location != null)
            {
                _location = location;
            }
        }

        private void TryInitNewMapTile()
        {
            if (_mapService.Current == null)
                _mapService.InitCurrentAsNewTile();
        }

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

        private void SetCoordinates()
        {
            _adminMap.LabX = _mapService.X.ToString();
            _adminMap.LabY = _mapService.Y.ToString();
        }

        private void SetNeighborhood()
        {
            _mapService.SetNeighborhood();
        }

        private void SetMovementBtns()
        {
            if (_mapService.Current == null)
            {
                _adminMap.BtnIsNorthEnabled = _mapService.DoesCurrentHasNorthNeighbor() || _mapService.DoesNorthOfCurrentHasOtherNeighbor();
                _adminMap.BtnIsSouthEnabled = _mapService.DoesCurrentHasSouthNeighbor() || _mapService.DoesSouthOfCurrentHasOtherNeighbor();
                _adminMap.BtnIsWestEnabled = _mapService.DoesCurrentHasWestNeighbor() || _mapService.DoesWestOfCurrentHasOtherNeighbor();
                _adminMap.BtnIsEastEnabled = _mapService.DoesCurrentHasEastNeighbor() || _mapService.DoesEastOfCurrentHasOtherNeighbor();
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
            if (_mapService.Current != null)
                TryGetCurrentTilesLocation();
            else
                _location = null;

            SetLocationStats();
        }

        private void EnableSaveBtn()
        {
            _adminMap.BtnIsSaveEnabled = true;
        }

        private void DisableSaveBtn()
        {
            _adminMap.BtnIsSaveEnabled = false;
        }

        private void DisableAttachBtn()
        {
            _adminMap.BtnIsAttachEnabled = false;
        }

        private void ToggleDelBtn()
        {
            if (_mapService.Current != null)
                _adminMap.BtnIsDelEnabled = true;
            else
                _adminMap.BtnIsDelEnabled = false;
        }

        #endregion Setters

        #region Movement

        public void MoveNorth()
        {
            ClearLocationSelection();
            DisableAttachBtn();
            DisableSaveBtn();

            _mapService.MoveNorth();
            _adminMap.LabY = _mapService.Y.ToString();

            ToggleDelBtn();
            SetCurrentLocationStats();
            SetMovementBtns();
        }

        public void MoveSouth()
        {
            ClearLocationSelection();
            DisableAttachBtn();
            DisableSaveBtn();

            _mapService.MoveSouth();
            _adminMap.LabY = _mapService.Y.ToString();

            ToggleDelBtn();
            SetCurrentLocationStats();
            SetMovementBtns();
        }

        public void MoveWest()
        {
            ClearLocationSelection();
            DisableAttachBtn();
            DisableSaveBtn();

            _mapService.MoveWest();
            _adminMap.LabX = _mapService.X.ToString();

            ToggleDelBtn();
            SetCurrentLocationStats();
            SetMovementBtns();
        }

        public void MoveEast()
        {
            ClearLocationSelection();
            DisableAttachBtn();
            DisableSaveBtn();

            _mapService.MoveEast();
            _adminMap.LabX = _mapService.X.ToString();

            ToggleDelBtn();
            SetCurrentLocationStats();
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