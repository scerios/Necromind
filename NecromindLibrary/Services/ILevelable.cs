using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.Services
{
    /// <summary>
    /// Levelables can level up when their experience points reach the next-level-at goal.
    /// </summary>
    public interface ILevelable
    {
        /// <summary>
        /// Current experience points.
        /// </summary>
        int ExperiencePoints { get; }

        /// <summary>
        /// When reached, the character will level up.
        /// </summary>
        int NextLevelAt { get; }

        /// <summary>
        /// Gives some experience calculated from the level of the enemy killed.
        /// </summary>
        /// <param name="level"></param>
        void GainExperience(int level);

        /// <summary>
        /// Levels up the character and boosts some of its stats.
        /// </summary>
        void LevelUp();
    }
}
