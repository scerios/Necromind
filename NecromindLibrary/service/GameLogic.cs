using NecromindLibrary.helper;
using NecromindLibrary.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NecromindLibrary.service
{
    public class GameLogic
    {
        // The hero which is currently being played
        public static HeroModel Hero { get; set; }

        private UIHandler UIHandler;
        private UIHelper UIHelper;

        private LocationModel Town { get; set; } = new LocationModel(LocationType.Town);
        private LocationModel OutSkirts { get; set; }
        private LocationModel Monastery { get; set; }

        // Hero's current location index in the map array.
        private int locationIndex = 0;

        public GameLogic(UIHandler UIHandler, UIHelper UIHelper)
        {
            this.UIHandler = UIHandler;
            this.UIHelper = UIHelper;
        }

        /// <summary>
        /// Sets the hero's location to town and displays a message to tell this.
        /// </summary>
        public void StartGame()
        {
            Hero.Location = Town;
            UIHelper.SetEventLogText("You are in town.", false);
        }

        /// <summary>
        /// Sets the hero's location to the outskirts and displays a message to tell this.
        /// </summary>
        public void MoveToOutSkirts()
        {
            locationIndex = 0;
            OutSkirts = new LocationModel(LocationType.OutSkirts);
            Hero.Location = OutSkirts;

            UIHelper.SetButtonAvailability(GetButtonByName(UIHandler.BtnForward), true);
            UIHelper.SetEventLogText("You are now in the outskirts.", false);
        }

        /// <summary>
        /// Moves the hero forward in the current area and depending on what is there an encounter might happen.
        /// </summary>
        public void MoveForward()
        {
            switch (Hero.Location.Map[locationIndex])
            {
                case 0:
                    UIHelper.SetEventLogText("Empty area.", true);
                    break;

                case 1:
                    UIHelper.SetEventLogText("You have encountered an enemy.", true);

                    break;

                //case 2:
                //    UIHelper.SetEventLogText("You have found a chest.", true);
                //    break;
            }
            locationIndex++;

            if (locationIndex > 9)
            {
               UIHelper.SetButtonAvailability(GetButtonByName(UIHandler.BtnForward), false);
            }
        }

        /// <summary>
        /// Gets the button from the UIHandler by reference name.
        /// </summary>
        /// <param name="name">Reference name of the button.</param>
        /// <returns>The button which was referenced.</returns>
        private Button GetButtonByName(string name)
        {
            return UIHandler.Buttons[name];
        }
    }
}
