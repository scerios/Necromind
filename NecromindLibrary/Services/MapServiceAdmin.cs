using NecromindLibrary.Config;
using NecromindLibrary.Models;
using System;

namespace NecromindLibrary.Services
{
    public class MapServiceAdmin : MapService
    {
        public void InitCurrentAsNewTile()
        {
            _current = new MapTileModel();
        }

        public void DeleteMap()
        {
            _current = null;
        }

        #region Checks

        public MapTileModel GetNorthOf(int x, int y) =>
            _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, x, y - 1);

        public MapTileModel GetSouthOf(int x, int y) =>
            _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, x, y + 1);

        public MapTileModel GetWestOf(int x, int y) =>
            _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, x - 1, y);

        public MapTileModel GetEastOf(int x, int y) =>
            _mongoConnector.GetTileByCoordinates(DBConfig.MapTilesCollection, x + 1, y);

        public bool HasNorthNeighbor(int x, int y) =>
            GetNorthOf(x, y) != null;

        public bool HasSouthNeighbor(int x, int y) =>
            GetSouthOf(x, y) != null;

        public bool HasWestNeighbor(int x, int y) =>
            GetWestOf(x, y) != null;

        public bool HasEastNeighbor(int x, int y) =>
            GetEastOf(x, y) != null;

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