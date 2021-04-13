using System;

namespace NecromindLibrary.Services
{
    public interface IMobile
    {
        int LocationX { get; }

        int LocationY { get; }

        void MoveNorth();

        void MoveSouth();

        void MoveEast();

        void MoveWest();
    }
}