using NecromindLibrary.model;
using System.Windows.Forms;

namespace NecromindLibrary.service
{
    public class GameService
    {
        private UIService _UIService;

        private static GameService _instance;

        private LocationModel Town { get; set; } = new LocationModel(LocationType.Town);
        private LocationModel OutSkirts { get; set; }
        private LocationModel Monastery { get; set; }

        // Hero's current location index in the map array.
        private int locationIndex = 0;

        // The hero which is currently being played.
        public static HeroModel Hero { get; private set; }
        // The current enemy which the hero fights.
        public static KillableModel Enemy { get; private set; }

        private GameService()
        {
            _UIService = UIService.GetInstance();
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

        public static void SetHero(HeroModel hero)
        {
            Hero = hero;
        }

        /// <summary>
        /// Sets the hero's location to town.
        /// </summary>
        public void StartGame()
        {
            Hero.Location = Town;
            _UIService.SetUIToTown();
        }

        /// <summary>
        /// Sets the hero's location to town.
        /// </summary>
        public void MoveToTown()
        {
            Hero.Location = Town;
            _UIService.SetUIToTown();
        }

        /// <summary>
        /// Sets the hero's location to the outskirts.
        /// </summary>
        public void MoveToOutSkirts()
        {
            locationIndex = 0;
            OutSkirts = new LocationModel(LocationType.OutSkirts);
            Hero.Location = OutSkirts;

            _UIService.SetUIToOutOfTown("You are now in the outskirts.");
        }

        /// <summary>
        /// Moves the hero forward in the current area and depending on what is there an encounter might happen.
        /// </summary>
        public void MoveForward()
        {
            switch (Hero.Location.Map[locationIndex])
            {
                case 0:
                    _UIService.SetEventLogText("Empty area.", true);
                    break;

                case 1:
                    _UIService.SetEventLogText("You have encountered an enemy.", true);

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
