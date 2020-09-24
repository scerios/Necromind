﻿using NecromindLibrary.model;

namespace NecromindLibrary.service
{
    public interface IBattle
    {
        // TODO - Figure out how the battle system should work.

        /// <summary>
        /// Attacks the target KillableModel and returns the value which the target will be damaged.
        /// </summary>
        /// <param name="model">A KillableModel which will be attacked.</param>
        /// <returns>The actual damage as an int.</returns>
        int AttackTarget(KillableModel model);
    }
}