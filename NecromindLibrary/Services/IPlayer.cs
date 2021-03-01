using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.Services
{
    public interface IPlayer : IFighter, IConsumer, ILevelable, ITrader
    {
    }
}
