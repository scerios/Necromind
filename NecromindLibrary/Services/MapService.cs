using NecromindLibrary.Config;
using NecromindLibrary.Models;
using NecromindLibrary.Repository;
using System;

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

        protected int _x;
        public int X => _x;

        protected int _y;
        public int Y => _y;

        public MapService()
        {
            _x = 0;
            _y = 0;

            SetStartTile();
        }

        #region Movement

        public void MoveNorth()
        {
            _y--;
            _southOfCurrent = _current;
            _current = _northOfCurrent;

            _southLocationOfCurrent = _location;
            _location = _northLocationOfCurrent;

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
            _y++;
            _northOfCurrent = _current;
            _current = _southOfCurrent;

            _northLocationOfCurrent = _location;
            _location = _southLocationOfCurrent;

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
            _x--;
            _eastOfCurrent = _current;
            _current = _westOfCurrent;

            _eastLocationOfCurrent = _location;
            _location = _westLocationOfCurrent;

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
            _x++;
            _westOfCurrent = _current;
            _current = _eastOfCurrent;

            _westLocationOfCurrent = _location;
            _location = _eastLocationOfCurrent;

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