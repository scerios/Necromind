using NecromindLibrary.helper;
using NecromindLibrary.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.service
{
    public static class GameLogic
    {
        // The hero which is currently being played
        public static HeroModel Hero { get; set; }

        // Hero's current location index in the map array.
        private static int locationIndex = 0;

        private static LocationModel Town { get; set; } = new LocationModel(LocationType.Town);
        private static LocationModel OutSkirts { get; set; }
        private static LocationModel Monastery { get; set; }

        public static void StartGame()
        {
            Hero.Location = Town;
            UIHelper.SetEventLogText("You are in town.", false);
        }

        public static void MoveToOutSkirts()
        {
            locationIndex = 0;
            UIHelper.SetButtonAvailability(UIHandler.Buttons[UIHandler.BtnForward], true);
            OutSkirts = new LocationModel(LocationType.OutSkirts);
            Hero.Location = OutSkirts;
            UIHelper.SetEventLogText("You are now in the outskirts.", false);
        }

        public static void MoveForward()
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
               UIHelper.SetButtonAvailability(UIHandler.Buttons[UIHandler.BtnForward], false);
            }
        }
    }
}
