using System;

namespace NecromindLibrary.Services.GameMechanisms
{
    public interface ITrader
    {
        void GiveGold(ITrader trader, int amount);

        void RecieveGold(int amount);
    }
}