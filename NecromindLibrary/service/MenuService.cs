﻿using NecromindLibrary.model;
using NecromindLibrary.repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace NecromindLibrary.service
{
    public class MenuService
    {
        private UIService _UIService;
        private IDataAccess _dataAccess;
        private GameService _gameLogic;

        // The hero which is about to be deleted
        public static HeroModel HeroToDelete { get; private set; }

        // List of dynamically created buttons while loading saved heroes
        private List<Button> CreatedButtons = new List<Button>();

        // Collection name to store heroes.
        public readonly string HeroesCollection = ConfigurationManager.AppSettings["heroesCollection"];

        public static MenuService Instance { get; } = new MenuService(MongoDBAccess.Instance);

        private MenuService(IDataAccess dataAccess)
        {
            _UIService = UIService.Instance;
            _dataAccess = dataAccess;
            _gameLogic = GameService.Instance;
        }

        /// <summary>
        /// Creates 2 buttons for each saved heroes and adds events to load or delete any of them. 
        /// </summary>
        public void ShowAllLoadedHeroes()
        {
            foreach (Button button in CreatedButtons)
            {
                _UIService.Panels[_UIService.LoadGame].Controls.Remove(button);
            }

            List<HeroModel> Heroes = _dataAccess.GetAllRecords<HeroModel>(HeroesCollection);

            if (Heroes.Count == 0)
            {
                _UIService.BringPanelToFront(_UIService.Menu);
                _UIService.DisplayError("Nothing to load.", "There's no hero yet to load. Create a new one first!");
            }
            else
            {
                int btnLoadHeroLocX = 480;
                int btnDeleteHeroLocX = 590;
                int btnLocY = 100;

                foreach (HeroModel hero in Heroes)
                {
                    // Creates a button to load the hero
                    Button btnLoadHero = _UIService.CreateButton(
                        hero.Name,
                        "btnLoad" + hero.Name,
                        100,
                        25,
                        btnLoadHeroLocX,
                        btnLocY,
                        Color.FromArgb(211, 84, 0), // Orange color
                        Color.FromArgb(229, 232, 232), // Soft gray-ish white color
                        FlatStyle.Flat
                    );

                    CreatedButtons.Add(btnLoadHero);

                    btnLoadHero.Click += (s, ev) =>
                    {
                        LoadHeroByIdBtn(hero.Id);
                    };

                    _UIService.Panels[_UIService.LoadGame].Controls.Add(btnLoadHero);

                    // Creates a button to delete the hero
                    Button btnDeleteHero = _UIService.CreateButton(
                        "X",
                        "btnDelete" + hero.Name,
                        25,
                        25,
                        btnDeleteHeroLocX,
                        btnLocY,
                        Color.FromArgb(23, 32, 42), // Blue-ish color (exactly like the window background)
                        Color.FromArgb(214, 48, 49), // Red color
                        FlatStyle.Flat
                    );

                    CreatedButtons.Add(btnDeleteHero);

                    btnDeleteHero.Click += (s, ev) =>
                    {
                        MenuService.SetHeroToDelete(hero);
                        DeleteHeroByIdBtn(hero);
                    };

                    btnLocY += 40;

                    _UIService.Panels[_UIService.LoadGame].Controls.Add(btnDeleteHero);
                }

                _UIService.BringPanelToFront(_UIService.LoadGame);
            }
        }

        /// <summary>
        /// Gets all the information from the database of a single hero by its ID, sets all the needed labels in the game panel and brings the game panel to the front.
        /// </summary>
        /// <param name="id">ID of hero.</param>
        private void LoadHeroByIdBtn(Guid id)
        {
            GameService.Hero = _dataAccess.GetRecordById<HeroModel>(HeroesCollection, id.ToString());
            _UIService.SetHeroDetails();
            _UIService.BringPanelToFront(_UIService.Game);
            _gameLogic.StartGame();
        }

        /// <summary>
        /// Deletes a hero by ID then reloads the loadGame panel.
        /// </summary>
        /// <param name="hero">A hero.</param>
        private void DeleteHeroByIdBtn(HeroModel hero)
        {
            TextBox heroName = _UIService.TextBoxes[_UIService.DeleteHeroName];

            _UIService.SetControlsAvailability(_UIService.Panels[_UIService.LoadGame].Controls, false);

            _UIService.RichTextBoxes[_UIService.ConfirmDeleteText] = _UIService.ApplyCustomStyleToRichTextConfirmDelete(hero.Name, _UIService.RichTextBoxes[_UIService.ConfirmDeleteText]);
            heroName.Focus();

            _UIService.BringPanelToFront(_UIService.ConfirmDelete);

            heroName.KeyUp += (s, ev) =>
            {
                _UIService.Buttons[_UIService.BtnDeleteHero].Enabled = heroName.Text == hero.Name;
            };

            heroName.KeyDown += (s, ev) =>
            {
                switch (ev.KeyCode)
                {
                    case Keys.Enter: // If ENTER is pressed

                        if (_UIService.Buttons[_UIService.BtnDeleteHero].Enabled)
                        {
                            if (_dataAccess.TryDeleteRecordById<HeroModel>(HeroesCollection, hero.Id.ToString()))
                            {
                                foreach (Button createdButton in CreatedButtons)
                                {
                                    _UIService.Panels[_UIService.LoadGame].Controls.Remove(createdButton);
                                }

                                ShowAllLoadedHeroes();
                                _UIService.HideConfirmDeletePanel(hero.Name);
                            }
                        }
                        else
                        {
                            ev.SuppressKeyPress = true;
                        }

                        break;

                    case Keys.Escape: // If ESCAPE is pressed

                        _UIService.HideConfirmDeletePanel(hero.Name);

                        break;
                }
            };
        }

        /// <summary>
        /// Creates a new hero if the name is not already taken.
        /// </summary>
        public void CreateNewHero()
        {
            TextBox heroName = _UIService.TextBoxes[_UIService.NewHeroName];
            List<HeroModel> heroes = _dataAccess.GetAllRecords<HeroModel>(HeroesCollection);

            if (heroName.Text.Length < 3)
            {
                _UIService.DisplayError("Name too short", "Name must be at least 3 characters long");
            }
            else if (IsNameAvailable(heroes, heroName.Text))
            {
                GameService.Hero = new HeroModel(heroName.Text);
                Guid defaultHeroId = GameService.Hero.Id;

                GameService.Hero.Id = new Guid(_dataAccess.TryCreateNewRecord(HeroesCollection, GameService.Hero));

                if (defaultHeroId != GameService.Hero.Id)
                {
                    _UIService.SetHeroDetails();

                    _UIService.BringPanelToFront(_UIService.Game);

                    _gameLogic.StartGame();
                }
            }
            else
            {
                _UIService.DisplayError("Name unavailable", $"The name: \"{ heroName.Text }\" you entered is already taken. Pick another one.");
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
            if (_dataAccess.TryDeleteRecordById<HeroModel>(HeroesCollection, HeroToDelete.Id.ToString()))
            {
                ShowAllLoadedHeroes();
                _UIService.HideConfirmDeletePanel(HeroToDelete.Name);
            }
        }

        /// <summary>
        /// Sets the HeroToDelete HeroModel.
        /// </summary>
        /// <param name="hero">Hero which is about to be deleted.</param>
        public static void SetHeroToDelete(HeroModel hero)
        {
            HeroToDelete = hero;
        }
    }
}
