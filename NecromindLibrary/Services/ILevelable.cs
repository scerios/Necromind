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
        int ExperiencePoints { get; set; }

        /// <summary>
        /// When reached, the character will level up.
        /// </summary>
        int NextLevelAt { get; set; }
    }
}
