using Necromind.Views;
using NecromindLibrary.Models;
using NecromindLibrary.Repository;
using NecromindLibrary.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Necromind.Presenters
{
    public class MenuLoadPresenter
    {
        private readonly IMenuLoad _menuLoad;
        private readonly List<Button> _createdButtons = new List<Button>();

        public MenuLoadPresenter(IMenuLoad menuLoad)
        {
            _menuLoad = menuLoad;
        }

        public List<Button> GetAllHeroes(string collectionName)
        {
            var mongoConnector = MongoConnector.GetInstance();
            var heroes = mongoConnector.GetAllRecords<HeroModel>(collectionName);


            if (heroes.Count == 0)
            {
                DisplayError();
            }
            else
            {
                CreateButtonsForHeroes(heroes);
            }

            return _createdButtons;
        }

        private void DisplayError()
        {
            var textService = new TextService();
            _menuLoad.Title = "No hero found";
            _menuLoad.Msg = textService.FormatErrorMsg("You must create a hero first to be able to load them.");
            _menuLoad.IsPanVisible = true;
        }

        public void HideError()
        {
            _menuLoad.IsPanVisible = false;
            _menuLoad.Title = "";
            _menuLoad.Msg = "";
        }

        private void CreateButtonsForHeroes(List<HeroModel> heroes)
        {
            int btnLoadHeroLocX = 500;
            int btnDeleteHeroLocX = 610;
            int btnLocY = 100;

            foreach (HeroModel hero in heroes)
            {
                // Creates a button to load the hero
                Button btnLoadHero = CreateButton(
                    hero.Name,
                    "btnLoad" + hero.Name,
                    100,
                    25,
                    btnLoadHeroLocX,
                    btnLocY,
                    10,
                    Color.FromArgb(211, 84, 0), // Orange color
                    Color.FromArgb(229, 232, 232), // Soft gray-ish white color
                    FlatStyle.Flat,
                    ContentAlignment.MiddleCenter
                );

                _createdButtons.Add(btnLoadHero);

                // TODO - Add an event to button to start game with this hero.

                // Creates a button to delete the hero
                Button btnDeleteHero = CreateButton(
                    "X",
                    "btnDelete" + hero.Name,
                    25,
                    25,
                    btnDeleteHeroLocX,
                    btnLocY,
                    12,
                    Color.FromArgb(23, 32, 42), // Blue-ish color (exactly like the window background)
                    Color.FromArgb(214, 48, 49), // Red color
                    FlatStyle.Flat,
                    ContentAlignment.MiddleLeft
                );

                _createdButtons.Add(btnDeleteHero);

                // TODO - Add an event to button to delete this hero.

                btnLocY += 40;
            }
        }

        // TODO - put this in UIControl when it's eventually reworked
        private Button CreateButton(
            string text, string name,
            int sizeX, int sizeY, int locX, int locY, int fontSize,
            Color backColor, Color foreColor,
            FlatStyle style,
            ContentAlignment alignment)
        {
            Button button = new Button();
            button.Text = text;
            button.Name = name;
            button.Size = new Size(sizeX, sizeY);
            button.Location = new Point(locX, locY);
            button.BackColor = backColor;
            button.ForeColor = foreColor;
            button.FlatStyle = style;
            button.Font = new Font(ConfigurationManager.AppSettings["fontStyle"], fontSize);
            button.Anchor = AnchorStyles.None;
            button.FlatAppearance.BorderSize = 0;
            button.TextAlign = alignment;

            return button;
        }
    }
}
