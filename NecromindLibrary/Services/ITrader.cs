using System;

namespace NecromindLibrary.Services
{
    public interface ITrader
    {
        void GiveGold(ITrader trader, int amount);

        void RecieveGold(int amount);
    }
}