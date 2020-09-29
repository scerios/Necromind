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
        }

        public static void MoveToOutSkirts()
        {
            OutSkirts = new LocationModel(LocationType.OutSkirts);
            Hero.Location = OutSkirts;
            UIHandler.RichTextBoxes[UIHandler.EventLog].Text = "You are now in the outskirts.";
        }

        public static void MoveForward()
        {
            switch (Hero.Location.Map[locationIndex])
            {
                case 0:
                    UIHandler.RichTextBoxes[UIHandler.EventLog].Text = UIHandler.RichTextBoxes[UIHandler.EventLog].Text + "\n" + "Empty area";
                    break;

                case 1:
                    UIHandler.RichTextBoxes[UIHandler.EventLog].Text = UIHandler.RichTextBoxes[UIHandler.EventLog].Text + "\n" + "You have encountered an enemy";
                    break;

                case 2:
                    UIHandler.RichTextBoxes[UIHandler.EventLog].Text = UIHandler.RichTextBoxes[UIHandler.EventLog].Text + "\n" + "You have found a chest";
                    break;
            }
            locationIndex++;

            if (locationIndex > 9)
            {
               UIHelper.SetButtonAvailability(UIHandler.Buttons[UIHandler.BtnForward], false);
            }
        }
    }
}
