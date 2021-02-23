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
        public bool IsHeroNameAlreadyRegistered(List<HeroModel> heroes, string heroName) =>
            heroes.Find(h => h.Name == heroName) != null;
    }
}
