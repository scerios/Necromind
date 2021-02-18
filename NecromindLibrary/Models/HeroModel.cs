using System.Collections.Generic;

namespace NecromindLibrary.model
{
    /// <summary>
    /// Represents a Hero.
    /// </summary>
    public class HeroModel : KillableModel
    {
        /// <summary>
        /// How much experience points the hero currently has.
        /// </summary>
        private int _experiencePoints;
        public int ExperiencePoints
        {
            get => _experiencePoints;
            set
            {
                _experiencePoints = value;
                OnPropertyChanged("ExperiencePoints");
            }
        }

        /// <summary>
        /// At how much experience points is the next level.
        /// </summary>
        private int _nextLevelAt;
        public int NextLevelAt
        {
            get => _nextLevelAt;
            set
            {
                _nextLevelAt = value;
                OnPropertyChanged("NextLevelAt");
            }
        }

        /// <summary>
        /// A list of active quests.
        /// </summary>
        public List<QuestModel> ActiveQuests { get; set; }

        /// <summary>
        /// A list of completed quests.
        /// </summary>
        public List<QuestModel> CompletedQuests { get; set; }

        /// <summary>
        /// A weapon currently equipped.
        /// </summary>
        public WeaponModel Weapon { get; set; }

        /// <summary>
        /// An armor currently equipped.
        /// </summary>
        public ArmorModel Armor { get; set; }

        /// <summary>
        /// The actual location where the hero currently are.
        /// </summary>
        public LocationModel Location { get; set; }

        public HeroModel()
        {

        }

        /// <summary>
        /// Creates a new hero with the given name and default values.
        /// </summary>
        /// <param name="name">Name of the hero.</param>
        public HeroModel(string name)
        {
            Name = name;
            HealthPoints = 100;
            HealthPointsMax = 100;
            Damage = 10;
            Defense = 5;
            Level = 1;
            ExperiencePoints = 1;
            NextLevelAt = 1000;
            Armor = null;
            Weapon = null;
            ActiveQuests = null;
            CompletedQuests = null;
            Inventory = null;
        }
    }
}
