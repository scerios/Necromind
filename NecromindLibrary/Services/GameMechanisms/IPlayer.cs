using System;

namespace NecromindLibrary.Services.GameMechanisms
{
    public interface IPlayer : IFighter, IConsumer, ILevelable, ITrader, IMobile
    {
    }
}