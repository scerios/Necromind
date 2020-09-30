﻿using NecromindLibrary.helper;
using NecromindLibrary.model;
using NecromindLibrary.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NecromindLibrary.service
{
    public class MenuLogic
    {
        // The hero which is about to be deleted
        public static HeroModel HeroToDelete { get; private set; }

        private UIHandler UIHandler;
        private UIHelper UIHelper;
        private DataAccess DataAccess;
        private GameLogic GameLogic;

        public MenuLogic(UIHandler UIHandler, UIHelper UIHelper, DataAccess dataAccess, GameLogic gameLogic)
        {
            this.UIHandler = UIHandler;
            this.UIHelper = UIHelper;
            DataAccess = dataAccess;
            GameLogic = gameLogic;
        }

        /// <summary>
        /// Creates a new hero if the name is not already taken.
        /// </summary>
        public void CreateNewHero()
        {
            TextBox heroName = UIHandler.TextBoxes[UIHandler.NewHeroName];
            List<HeroModel> heroes = DataAccess.GetAllRecords<HeroModel>(UIHandler.HeroesCollection);

            if (heroName.Text.Length < 3)
            {
                UIHandler.DisplayError("Name too short", "Name must be at least 3 characters long");
            }
            else if (IsNameAvailable(heroes, heroName.Text))
            {
                GameLogic.Hero = new HeroModel(heroName.Text);
                Guid defaultHeroId = GameLogic.Hero.Id;

                GameLogic.Hero.Id = DataAccess.TryCreateNewRecord(UIHandler.HeroesCollection, GameLogic.Hero);

                if (defaultHeroId != GameLogic.Hero.Id)
                {
                    UIHandler.SetHeroDetails();

                    UIHandler.BringSelectedPanelToFront(UIHandler.Game);

                    GameLogic.StartGame();
                }
            }
            else
            {
                UIHandler.DisplayError("Name unavailable", $"The name: \"{ heroName.Text }\" you entered is already taken. Pick another one.");
            }

            heroName.Text = "";
        }

        /// <summary>
        /// Checks among all the heroes if the user given name is already taken.
        /// </summary>
        /// <param name="heroes">A list of heroes.</param>
        /// <param name="name">Name of new hero.</param>
        /// <returns>True if name is available. False otherwise.</returns>
        public bool IsNameAvailable(List<HeroModel> heroes, string name)
        {
            bool isNameAvailable = true;

            foreach (HeroModel hero in heroes)
            {
                if (hero.Name == name)
                {
                    isNameAvailable = false;
                    break;
                }
            }

            return isNameAvailable;
        }

        /// <summary>
        /// Deletes a hero.
        /// </summary>
        public void DeleteHero()
        {
            if (DataAccess.TryDeleteRecordById<HeroModel>(UIHandler.HeroesCollection, HeroToDelete.Id))
            {
                UIHandler.ShowAllLoadedHeroes();
                UIHandler.HideConfirmDeletePanel(HeroToDelete.Name);
            }
        }

        /// <summary>
        /// Sets the HeroToDelete HeroModel.
        /// </summary>
        /// <param name="hero">Hero which is about to be deleted.</param>
        public void SetHeroToDelete(HeroModel hero)
        {
            HeroToDelete = hero;
        }
    }
}
