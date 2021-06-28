using System;

namespace NecromindLibrary.Services.GameMechanisms
{
    public interface IMobile
    {
        int PosX { get; }

        int PosY { get; }

        void MoveNorth();

        void MoveSouth();

        void MoveEast();

        void MoveWest();
    }
}