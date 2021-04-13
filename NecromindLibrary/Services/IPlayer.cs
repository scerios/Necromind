using System;

namespace NecromindLibrary.Services
{
    public interface IPlayer : IFighter, IConsumer, ILevelable, ITrader, IMobile
    {
    }
}