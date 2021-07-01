using System;

namespace NecromindLibrary.Services.GameMechanisms
{
    public interface IPlayer : IAttacker, IDefender, IConsumer, ILevelable, ITrader, IMobile
    {
    }
}