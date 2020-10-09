using NecromindLibrary.model;
using System;
using System.Windows.Forms;

namespace NecromindLibrary.service
{
    public class GameService
    {
        private static GameService _instance;

        private UIService _UIService = UIService.GetInstance();
        private BattleService _battleService;

        // Hero's current location index in the map array.
        private int locationIndex = 0;

        public event EventHandler OnStartGame;

        // The hero which is currently being played.
        public HeroModel Hero { get; set; }
        // The current enemy which the hero fights.
        public KillableModel Enemy { get; set; }

        private GameService()
        {
        }

        /// <summary>
        /// Returns the only instance which was created due to singleton pattern.
        /// </summary>
        /// <returns>The only GameService instance.</returns>
        public static GameService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new GameService();
            }

            return _instance;
        }

        public void SetHero(HeroModel hero)
        {
            Hero = hero;
            _UIService.Labels[_UIService.HeroHealth].DataBindings.Add("Text", hero, "HealthPoints");
            _UIService.Labels[_UIService.HeroMaxHealth].DataBindings.Add("Text", hero, "HealthPointsMax");
            _UIService.Labels[_UIService.HeroDamage].DataBindings.Add("Text", hero, "Damage");
            _UIService.Labels[_UIService.HeroDefense].DataBindings.Add("Text", hero, "Defense");
            _UIService.Labels[_UIService.HeroLevel].DataBindings.Add("Text", hero, "Level");
            _UIService.Labels[_UIService.HeroXP].DataBindings.Add("Text", hero, "ExperiencePoints");
            _UIService.Labels[_UIService.HeroNextLevelAt].DataBindings.Add("Text", hero, "NextLevelAt");
            _UIService.Labels[_UIService.HeroGold].DataBindings.Add("Text", hero, "Gold");
        }

        /// <summary>
        /// Sets the hero's location to town.
        /// </summary>
        public void StartGame()
        {
            _UIService.SetUIToTown();
        }

        /// <summary>
        /// Sets the hero's location to town.
        /// </summary>
        public void MoveToTown()
        {
            _UIService.SetUIToTown();
        }

        /// <summary>
        /// Sets the hero's location to the outskirts.
        /// </summary>
        public void MoveToOutSkirts()
        {
            locationIndex = 0;
            Hero.Location = new LocationModel(LocationType.OutSkirts);

            _UIService.SetUIToOutOfTown("You are now in the outskirts.");
        }

        /// <summary>
        /// Moves the hero forward in the current area and depending on what is there an event will happen.
        /// </summary>
        public void MoveForward()
        {
            switch (Hero.Location.Map[locationIndex])
            {
                case 0:
                    _UIService.SetEventLogText("Empty area.", true, true);
                    break;

                case 1:
                    _battleService = new BattleService(Hero);

                    _UIService.SetEventLogText($"You have encountered a { _battleService.GetEnemyName() }.", true);
                    _UIService.SetUIToBattle(_battleService.GetEnemyName());

                    break;

                //case 2:
                //    UIHelper.SetEventLogText("You have found a chest.", true);
                //    break;
            }
            locationIndex++;

            if (locationIndex > 9)
            {
                _UIService.SetButtonAvailability(GetButtonByName(_UIService.BtnForward), false);
            }
        }

        public void AttackTarget()
        {
            _battleService.AttackTarget();
        }

        /// <summary>
        /// Gets the button from the UIHandler by reference name.
        /// </summary>
        /// <param name="name">Reference name of the button.</param>
        /// <returns>The button which was referenced.</returns>
        private Button GetButtonByName(string name)
        {
            return _UIService.Buttons[name];
        }
    }
}
