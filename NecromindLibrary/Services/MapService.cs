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

            _northOfCurrent = GetNorthOfCurrent();
            _westOfCurrent = GetWestOfCurrent();
            _eastOfCurrent = GetEastOfCurrent();

            SetCurrentTilesLocation();
        }

        public void MoveSouth()
        {
            _y++;
            _northOfCurrent = _current;
            _current = _southOfCurrent;

            _southOfCurrent = GetSouthOfCurrent();
            _westOfCurrent = GetWestOfCurrent();
            _eastOfCurrent = GetEastOfCurrent();

            SetCurrentTilesLocation();
        }

        public void MoveWest()
        {
            _x--;
            _eastOfCurrent = _current;
            _current = _westOfCurrent;

            _northOfCurrent = GetNorthOfCurrent();
            _southOfCurrent = GetSouthOfCurrent();
            _westOfCurrent = GetWestOfCurrent();

            SetCurrentTilesLocation();
        }

        public void MoveEast()
        {
            _x++;
            _westOfCurrent = _current;
            _current = _eastOfCurrent;

            _northOfCurrent = GetNorthOfCurrent();
            _southOfCurrent = GetSouthOfCurrent();
            _eastOfCurrent = GetEastOfCurrent();

            SetCurrentTilesLocation();
        }

        #endregion Movement

        #region Getters

        public Guid GetCurrentTilesId() =>
            _current.Id;

        public MapTileModel GetNorthOfCurrent() =>
            _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _x, _y - 1);

        public MapTileModel GetSouthOfCurrent() =>
            _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _x, _y + 1);

        public MapTileModel GetWestOfCurrent() =>
            _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _x - 1, _y);

        public MapTileModel GetEastOfCurrent() =>
            _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _x + 1, _y);

        public void GetNorthLocationOfCurrent()
        {
            _northLocationOfCurrent = _mongoConnector.GetRecordById<LocationModel>(DBConfig.LocationsCollection, _northOfCurrent.LocationId.ToString());
        }

        public void GetSouthLocationOfCurrent()
        {
            _northLocationOfCurrent = _mongoConnector.GetRecordById<LocationModel>(DBConfig.LocationsCollection, _southOfCurrent.LocationId.ToString());
        }

        public void GetWestLocationOfCurrent()
        {
            _northLocationOfCurrent = _mongoConnector.GetRecordById<LocationModel>(DBConfig.LocationsCollection, _westOfCurrent.LocationId.ToString());
        }

        public void GetEastLocationOfCurrent()
        {
            _northLocationOfCurrent = _mongoConnector.GetRecordById<LocationModel>(DBConfig.LocationsCollection, _eastOfCurrent.LocationId.ToString());
        }

        #endregion Getters

        #region Setters

        public void SetCurrentLocation(LocationModel location)
        {
            _location = location;
        }

        private void SetCurrentTilesLocation()
        {
            if (_current != null && _current.LocationId != null)
                SetCurrentLocation(_mongoConnector.GetRecordById<LocationModel>(DBConfig.LocationsCollection, _current.LocationId.ToString()));
            else
                SetCurrentLocation(null);
        }

        public void SetStartTile()
        {
            _current = _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _x, _y);
            SetCurrentLocation(_mongoConnector.GetRecordById<LocationModel>(DBConfig.LocationsCollection, _current.LocationId.ToString()));
        }

        public void SetNeighborhood()
        {
            _northOfCurrent = GetNorthOfCurrent();
            _southOfCurrent = GetSouthOfCurrent();
            _westOfCurrent = GetWestOfCurrent();
            _eastOfCurrent = GetEastOfCurrent();
        }

        public void SetNeighborhoodLocations()
        {
            GetNorthLocationOfCurrent();
            GetSouthLocationOfCurrent();
            GetWestLocationOfCurrent();
            GetEastLocationOfCurrent();
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
            return _mongoConnector.GetRecordById<LocationModel>(DBConfig.LocationsCollection, _northOfCurrent.LocationId.ToString()).IsAccessible;
        }

        public bool IsSouthOfCurrentAccessible()
        {
            return _mongoConnector.GetRecordById<LocationModel>(DBConfig.LocationsCollection, _southOfCurrent.LocationId.ToString()).IsAccessible;
        }

        public bool IsWestOfCurrentAccessible()
        {
            return _mongoConnector.GetRecordById<LocationModel>(DBConfig.LocationsCollection, _westOfCurrent.LocationId.ToString()).IsAccessible;
        }

        public bool IsEastOfCurrentAccessible()
        {
            return _mongoConnector.GetRecordById<LocationModel>(DBConfig.LocationsCollection, _eastOfCurrent.LocationId.ToString()).IsAccessible;
        }

        #endregion Checks
    }
}