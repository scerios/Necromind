using NecromindLibrary.Config;
using NecromindLibrary.Models;
using NecromindLibrary.Repository;
using System;

namespace NecromindLibrary.Services
{
    public class MapService
    {
        private readonly MongoConnector _mongoConnector = MongoConnector.GetInstance();
        private MapTileModel _current;

        public MapTileModel Current => _current;

        private MapTileModel _northOfCurrent;
        private MapTileModel _southOfCurrent;
        private MapTileModel _westOfCurrent;
        private MapTileModel _eastOfCurrent;

        private int _x;
        public int X => _x;

        private int _y;
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
        }

        public void MoveSouth()
        {
            _y++;
            _northOfCurrent = _current;
            _current = _southOfCurrent;

            _southOfCurrent = GetSouthOfCurrent();
            _westOfCurrent = GetWestOfCurrent();
            _eastOfCurrent = GetEastOfCurrent();
        }

        public void MoveWest()
        {
            _x--;
            _eastOfCurrent = _current;
            _current = _westOfCurrent;

            _northOfCurrent = GetNorthOfCurrent();
            _southOfCurrent = GetSouthOfCurrent();
            _westOfCurrent = GetWestOfCurrent();
        }

        public void MoveEast()
        {
            _x++;
            _westOfCurrent = _current;
            _current = _eastOfCurrent;

            _northOfCurrent = GetNorthOfCurrent();
            _southOfCurrent = GetSouthOfCurrent();
            _eastOfCurrent = GetEastOfCurrent();
        }

        #endregion Movement

        #region Getters

        public Guid GetCurrentTilesId() =>
            _current.Id;

        public MapTileModel GetNorthOf(int x, int y) =>
            _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, x, y - 1);

        public MapTileModel GetSouthOf(int x, int y) =>
            _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, x, y + 1);

        public MapTileModel GetWestOf(int x, int y) =>
            _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, x - 1, y);

        public MapTileModel GetEastOf(int x, int y) =>
            _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, x + 1, y);

        public MapTileModel GetNorthOfCurrent() =>
            _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _x, _y - 1);

        public MapTileModel GetSouthOfCurrent() =>
            _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _x, _y + 1);

        public MapTileModel GetWestOfCurrent() =>
            _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _x - 1, _y);

        public MapTileModel GetEastOfCurrent() =>
            _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _x + 1, _y);

        #endregion Getters

        #region Setters

        public void SetStartTile()
        {
            _current = _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, _x, _y);
        }

        public void SetNeighborhood()
        {
            _northOfCurrent = GetNorthOfCurrent();
            _southOfCurrent = GetSouthOfCurrent();
            _westOfCurrent = GetWestOfCurrent();
            _eastOfCurrent = GetEastOfCurrent();
        }

        public void InitCurrentAsNewTile()
        {
            _current = new MapTileModel();
        }

        #endregion Setters

        #region Checks

        public bool HasNorthNeighbor(int x, int y) =>
            GetNorthOf(x, y) != null;

        public bool HasSouthNeighbor(int x, int y) =>
            GetSouthOf(x, y) != null;

        public bool HasWestNeighbor(int x, int y) =>
            GetWestOf(x, y) != null;

        public bool HasEastNeighbor(int x, int y) =>
            GetEastOf(x, y) != null;

        public bool DoesCurrentHasNorthNeighbor() =>
            GetNorthOfCurrent() != null;

        public bool DoesCurrentHasSouthNeighbor() =>
            GetSouthOfCurrent() != null;

        public bool DoesCurrentHasWestNeighbor() =>
            GetWestOfCurrent() != null;

        public bool DoesCurrentHasEastNeighbor() =>
            GetEastOfCurrent() != null;

        public bool DoesNorthOfCurrentHasOtherNeighbor() =>
            HasNorthNeighbor(_x, _y - 1) || HasWestNeighbor(_x, _y - 1) || HasEastNeighbor(_x, _y - 1);

        public bool DoesSouthOfCurrentHasOtherNeighbor() =>
            HasSouthNeighbor(_x, _y + 1) || HasWestNeighbor(_x, _y + 1) || HasEastNeighbor(_x, _y + 1);

        public bool DoesWestOfCurrentHasOtherNeighbor() =>
            HasWestNeighbor(_x - 1, _y) || HasNorthNeighbor(_x - 1, _y) || HasSouthNeighbor(_x - 1, _y);

        public bool DoesEastOfCurrentHasOtherNeighbor() =>
            HasEastNeighbor(_x + 1, _y) || HasNorthNeighbor(_x + 1, _y) || HasSouthNeighbor(_x + 1, _y);

        #endregion Checks
    }
}