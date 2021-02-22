using NecromindLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.Models
{
    public class HeroModel : BaseModel, IFighter, ILevelable
    {
        private int _dmg;
        public int Dmg
        {
            get => _dmg;

            set
            {
                _dmg = value;
            }
        }

        private int _def;
        public int Def
        {
            get => _def;

            set
            {
                _def = value;
            }
        }

        private int _healthPoints;
        public int HealthPoints
        {
            get => _healthPoints;

            set
            {
                _healthPoints = value;
            }
        }

        private int _healthPointsMax;
        public int HealthPointsMax
        {
            get => _healthPointsMax;

            set
            {
                _healthPointsMax = value;
            }
        }

        private int _experiencePoints;
        public int ExperiencePoints
        {
            get => _experiencePoints;

            set
            {
                _experiencePoints = value;
            }
        }

        private int _nextLevelAt;
        public int NextLevelAt
        {
            get => _nextLevelAt;

            set
            {
                _nextLevelAt = value;
            }
        }

        public HeroModel(string name)
        {
            Name = name;
            HealthPoints = 100;
            HealthPointsMax = 100;
            Dmg = 10;
            Def = 5;
            Level = 1;
            ExperiencePoints = 1;
            NextLevelAt = 1000;
        }

        public void Attack(IFighter enemy)
        {
            // TODO - Implement attack logic.
            throw new NotImplementedException();
        }

        public void Fortify()
        {
            // TODO - Implement defense position logic.
            throw new NotImplementedException();
        }
    }
}
