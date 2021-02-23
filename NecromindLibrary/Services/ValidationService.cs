using NecromindLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.Services
{
    public class ValidationService
    {
        /// <summary>
        /// Checks in a list of HeroModels if the given name as string is equal to any of the heroes's name inside the list.
        /// </summary>
        /// <param name="heroes">A list of HeroModels</param>
        /// <param name="heroName">The name as string to find.</param>
        /// <returns>True if given name is found. False otherwise.</returns>
        public bool IsHeroNameAlreadyRegistered(List<HeroModel> heroes, string heroName) =>
            heroes.Find(h => h.Name == heroName) != null;
    }
}
