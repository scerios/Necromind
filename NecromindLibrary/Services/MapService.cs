using NecromindLibrary.Config;
using NecromindLibrary.Models;
using NecromindLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NecromindLibrary.Services
{
    public class MapService
    {
        protected readonly MongoConnector _mongoConnector = MongoConnector.GetInstance();

        protected MapTileModel _current;
        public MapTileModel Current => _current;

        protected MapTileModel _northOfCurrent;
        protected MapTileModel _southOfCurrent;
        protected MapTileModel _westOfCurrent;
        protected MapTileModel _eastOfCurrent;

        protected LocationModel _location;
        public LocationModel Location => _location;

        private LocationModel _northLocationOfCurrent;
        public LocationModel NorthLocationOfCurrent => _northLocationOfCurrent;

        private LocationModel _southLocationOfCurrent;
        public LocationModel SouthLocationOfCurrent => _southLocationOfCurrent;

        private LocationModel _westLocationOfCurrent;
        public LocationModel WestLocationOfCurrent => _westLocationOfCurrent;

        private LocationModel _eastLocationOfCurrent;
        public LocationModel EastLocationOfCurrent => _eastLocationOfCurrent;

        protected readonly List<Panel> _map;

        protected int _x;
        public int X => _x;

        protected int _y;
        public int Y => _y;

        public MapService(int x, int y, List<Panel> map)
        {
            _x = x;
            _y = y;
            _map = map;

            SetStartTile();
        }

        #region Movement

        public void MoveNorth()
        {
            FadeHighLightOnCoordinate(_x, _y);

            _y--;
            _southOfCurrent = _current;
            _current = _northOfCurrent;

            _southLocationOfCurrent = _location;
            _location = _northLocationOfCurrent;

            HighlightMapByCoordinate(_x, _y);
            SetCurrentTilesLocation();

            GetNorthOfCurrent();
            GetWestOfCurrent();
            GetEastOfCurrent();

            SetNorthLocationOfCurrent();
            SetWestLocationOfCurrent();
            SetEastLocationOfCurrent();
        }

        public void MoveSouth()
        {
            FadeHighLightOnCoordinate(_x, _y);
            _y++;
            _northOfCurrent = _current;
            _current = _southOfCurrent;

            _northLocationOfCurrent = _location;
            _location = _southLocationOfCurrent;

            HighlightMapByCoordinate(_x, _y);
            SetCurrentTilesLocation();

            GetSouthOfCurrent();
            GetWestOfCurrent();
            GetEastOfCurrent();

            SetSouthLocationOfCurrent();
            SetWestLocationOfCurrent();
            SetEastLocationOfCurrent();
        }

        public void MoveWest()
        {
            FadeHighLightOnCoordinate(_x, _y);
            _x--;
            _eastOfCurrent = _current;
            _current = _westOfCurrent;

            _eastLocationOfCurrent = _location;
            _location = _westLocationOfCurrent;

            HighlightMapByCoordinate(_x, _y);
            SetCurrentTilesLocation();

            GetNorthOfCurrent();
            GetSouthOfCurrent();
            GetWestOfCurrent();

            SetNorthLocationOfCurrent();
            SetSouthLocationOfCurrent();
            SetWestLocationOfCurrent();
        }

        public void MoveEast()
        {
            FadeHighLightOnCoordinate(_x, _y);
            _x++;
            _westOfCurrent = _current;
            _current = _eastOfCurrent;

            _westLocationOfCurrent = _location;
            _location = _eastLocationOfCurrent;

            HighlightMapByCoordinate(_x, _y);
            SetCurrentTilesLocation();

            GetNorthOfCurrent();
            GetSouthOfCurrent();
            GetEastOfCurrent();

            SetNorthLocationOfCurrent();
            SetSouthLocationOfCurrent();
            SetEastLocationOfCurrent();
        }

        #endregion Movement

        #region Getters

        public Guid GetCurrentTilesId() =>
            _current.Id;

        private void GetNorthOfCurrent()
        {
            _northOfCurrent = _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _x, _y - 1);
        }

        private void GetSouthOfCurrent()
        {
            _southOfCurrent = _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _x, _y + 1);
        }

        private void GetWestOfCurrent()
        {
            _westOfCurrent = _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _x - 1, _y);
        }

        private void GetEastOfCurrent()
        {
            _eastOfCurrent = _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _x + 1, _y);
        }

        private void SetNorthLocationOfCurrent()
        {
            if (_northOfCurrent != null && _northOfCurrent.LocationId != null)
                _northLocationOfCurrent = _mongoConnector.GetRecordById<LocationModel>(DBConfig.LocationsCollection, _northOfCurrent.LocationId.ToString());
            else
                _northLocationOfCurrent = null;
        }

        private void SetSouthLocationOfCurrent()
        {
            if (_southOfCurrent != null && _southOfCurrent.LocationId != null)
                _southLocationOfCurrent = _mongoConnector.GetRecordById<LocationModel>(DBConfig.LocationsCollection, _southOfCurrent.LocationId.ToString());
            else
                _southLocationOfCurrent = null;
        }

        private void SetWestLocationOfCurrent()
        {
            if (_westOfCurrent != null && _westOfCurrent.LocationId != null)
                _westLocationOfCurrent = _mongoConnector.GetRecordById<LocationModel>(DBConfig.LocationsCollection, _westOfCurrent.LocationId.ToString());
            else
                _westLocationOfCurrent = null;
        }

        private void SetEastLocationOfCurrent()
        {
            if (_eastOfCurrent != null && _eastOfCurrent.LocationId != null)
                _eastLocationOfCurrent = _mongoConnector.GetRecordById<LocationModel>(DBConfig.LocationsCollection, _eastOfCurrent.LocationId.ToString());
            else
                _eastLocationOfCurrent = null;
        }

        #endregion Getters

        #region Setters

        public void SetCurrentLocation(LocationModel location)
        {
            _location = location;
        }

        public void SetStartTile()
        {
            _current = _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _x, _y);
            SetCurrentLocation(_mongoConnector.GetRecordById<LocationModel>(DBConfig.LocationsCollection, _current.LocationId.ToString()));
            HighlightMapByCoordinate(_x, _y);
        }

        public void SetNeighborhood()
        {
            GetNorthOfCurrent();
            GetSouthOfCurrent();
            GetWestOfCurrent();
            GetEastOfCurrent();
        }

        public void SetNeighborhoodLocations()
        {
            SetNorthLocationOfCurrent();
            SetSouthLocationOfCurrent();
            SetWestLocationOfCurrent();
            SetEastLocationOfCurrent();
        }

        private void SetCurrentTilesLocation()
        {
            if (_current != null && _current.LocationId != null)
                SetCurrentLocation(_mongoConnector.GetRecordById<LocationModel>(DBConfig.LocationsCollection, _current.LocationId.ToString()));
            else
                SetCurrentLocation(null);
        }

        private void HighlightMapByCoordinate(int x, int y)
        {
            var map = _map.Single(i => i.Name == "pan" + x + "I" + y);
            map.BorderStyle = BorderStyle.FixedSingle;
        }

        private void FadeHighLightOnCoordinate(int x, int y)
        {
            var map = _map.Single(i => i.Name == "pan" + x + "I" + y);
            map.BorderStyle = BorderStyle.None;
        }

        #endregion Setters

        #region Checks

        public bool DoesCurrentHasNorthNeighbor() =>
            _northOfCurrent != null;

        public bool DoesCurrentHasSouthNeighbor() =>
            _southOfCurrent != null;

        public bool DoesCurrentHasWestNeighbor() =>
            _westOfCurrent != null;

        public bool DoesCurrentHasEastNeighbor() =>
            _eastOfCurrent != null;

        public bool IsNorthOfCurrentAccessible()
        {
            return _northLocationOfCurrent.IsAccessible;
        }

        public bool IsSouthOfCurrentAccessible()
        {
            return _southLocationOfCurrent.IsAccessible;
        }

        public bool IsWestOfCurrentAccessible()
        {
            return _westLocationOfCurrent.IsAccessible;
        }

        public bool IsEastOfCurrentAccessible()
        {
            return _eastLocationOfCurrent.IsAccessible;
        }

        #endregion Checks
    }
}