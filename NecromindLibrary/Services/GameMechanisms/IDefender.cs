using System;

namespace NecromindLibrary.Services.GameMechanisms
{
    public interface IDefender
    {
        event EventHandler OnRested;

        /// <summary>
        /// Setup a defensive stance and by raising awareness it gives extra Def.
        /// </summary>
        int Fortify();

        /// <summary>
        /// Ends the defensive stance and restores original Def.
        /// </summary>
        void EndFortification();

        /// <summary>
        /// By becoming rested, hero can gain the defensive stance once again.
        /// </summary>
        void BecomeRested();
    }
}