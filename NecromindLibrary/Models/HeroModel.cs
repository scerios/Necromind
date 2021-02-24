using NecromindLibrary.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.Models
{
    public class HeroModel : BaseModel, IPlayer
    {
        public int Dmg { get; private set; }

        public int Def { get; private set; }

        public int HealthPoints { get; private set; }

        public int HealthPointsMax { get; private set; }

        public int ExperiencePoints { get; private set; }

        public int NextLevelAt { get; private set; }

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

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Attack(IFighter enemy)
        {
            enemy.TakeDmg(Dmg - enemy.Def);
        }

        public void TakeDmg(int amount)
        {
            HealthPoints -= amount;
            if (HealthPoints < 1)
            {
                Die();
            }
        }

        public void Die()
        {
            // TODO - Implement die logic.
            throw new NotImplementedException();
        }

        public void Heal(int amount)
        {
            if (HealthPoints + amount < HealthPointsMax)
            {
                HealthPoints += amount;
            }
            else
            {
                FullyHeal();
            }

        }

        public void FullyHeal()
        {
            HealthPoints = HealthPointsMax;
        }

        public void GainExperience(int level)
        {
            ExperiencePoints += level * 10;

            if (ExperiencePoints >= NextLevelAt)
            {
                LevelUp();
            }
        }

        public void LevelUp()
        {
            Level++;
            Dmg += 10;
            Def += 2;
            HealthPointsMax += 20;
            FullyHeal();
            NextLevelAt += Level * 1000;
        }
    }
}
