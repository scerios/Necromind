using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.Services
{
    public interface ITrader
    {
        void GiveGold(ITrader trader, int amount);
        void RecieveGold(int amount);
    }
}
