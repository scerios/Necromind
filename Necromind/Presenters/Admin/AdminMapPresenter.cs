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
            SetLocationStats();
            SetMovementBtns();
        }

        public void SetSelectedLocationStats()
        {
            var selectedIndex = _adminMap.LbLocations.SelectedIndex;

            if (selectedIndex >= 0)
            {
                _mapService.SetCurrentLocation(_locations[selectedIndex]);
                SetLocationStats();
                _adminMap.BtnIsAttachEnabled = true;
            }
        }

        public void AttachLocation()
        {
            TryInitNewMapTile();

            _mapService.Current.LocationId = _mapService.Location.Id;

            EnableSaveBtn();
        }

        public void Save()
        {
            if (_mongoConnector.GetRecordById<MapTileModel>(DBConfig.MapTilesCollection, _mapService.GetCurrentTilesId().ToString()) == null)
                CreateMapTile();
            else
                UpdateMapTile();

            ClearLocationSelection();
            DisableAttachBtn();
            DisableSaveBtn();
            ToggleDelBtn();

            SetMovementBtns();
        }

        public void Delete()
        {
            if (_mongoConnector.TryDeleteRecordById<MapTileModel>(DBConfig.MapTilesCollection, _mapService.Current.Id))
            {
                AlertSuccess($"({ _mapService.X }, { _mapService.Y })", "deleted");
            }

            _mapService.DeleteMap();
            ToggleDelBtn();
            ClearLocationSelection();
            ClearEditFields();
            SetMovementBtns();
        }

        #region Movement

        public void MoveNorth()
        {
            ClearLocationSelection();
            DisableAttachBtn();
            DisableSaveBtn();

            _mapService.MoveNorth();
            _adminMap.LabY = _mapService.Y.ToString();

            ToggleDelBtn();
            SetLocationStats();
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
            SetLocationStats();
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
            SetLocationStats();
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
            SetLocationStats();
            SetMovementBtns();
        }

        #endregion Movement

        private void CreateMapTile()
        {
            string position = $"({ _mapService.X }, { _mapService.Y })";
            string modification = "created";

            _mapService.Current.X = Int32.Parse(_adminMap.LabX);
            _mapService.Current.Y = Int32.Parse(_adminMap.LabY);

            if (_mongoConnector.TryCreateNewRecord(DBConfig.MapTilesCollection, _mapService.Current))
                AlertSuccess(position, modification);
            else
                AlertFail(position, modification);
        }

        private void UpdateMapTile()
        {
            string position = $"({ _mapService.X }, { _mapService.Y })";
            string modification = "updated";

            if (_mongoConnector.TryUpsertRecord(DBConfig.MapTilesCollection, _mapService.GetCurrentTilesId(), _mapService.Current))
                AlertSuccess(position, modification);
            else
                AlertFail(position, modification);
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

        private void TryInitNewMapTile()
        {
            if (_mapService.Current == null)
                _mapService.InitCurrentAsNewTile();
        }

        private void SetNeighborhood()
        {
            _mapService.SetNeighborhood();
        }

        #region Alert

        private void AlertSuccess(string name, string modification)
        {
            _adminMap.LabMapEdit.Text = $"{ name } { modification } successfully!";
            _adminMap.LabMapEdit.ForeColor = UISettings.SuccessColor;
            _adminMap.LabMapEdit.Visible = true;
            _adminMap.TimHide.Start();
        }

        private void AlertFail(string name, string modification)
        {
            _adminMap.LabMapEdit.Text = $"Failed to { modification } { name }!";
            _adminMap.LabMapEdit.ForeColor = UISettings.ErrorColor;
            _adminMap.LabMapEdit.Visible = true;
            _adminMap.TimHide.Start();
        }

        #endregion Alert

        #region UI modifications

        private void SetLocationStats()
        {
            if (_mapService.Location != null)
            {
                _adminMap.LabLocName = _mapService.Location.Name;
                _adminMap.LabLocDescription = _mapService.Location.Description;
                _adminMap.LabIsAccessible = _mapService.Location.IsAccessible;
                _adminMap.LabIsHostile = _mapService.Location.IsHostile;
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

        #endregion UI modifications
    }
}