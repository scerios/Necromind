using Necromind.Views;
using NecromindLibrary.model;
using NecromindLibrary.Repository;
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
        private List<Button> _createdButtons = new List<Button>();

        public MenuLoadPresenter(IMenuLoad menuLoad)
        {
            _menuLoad = menuLoad;
        }

        public List<Button> GetAllHeroes(string collectionName)
        {
            var mongoConnector = MongoConnector.GetInstance();
            List<HeroModel> Heroes = mongoConnector.GetAllRecords<HeroModel>(collectionName);

            if (Heroes.Count == 0)
            {
                // TODO - display error msg: no hero to show
            }
            else
            {
                int btnLoadHeroLocX = 480;
                int btnDeleteHeroLocX = 590;
                int btnLocY = 100;

                foreach (HeroModel hero in Heroes)
                {
                    // Creates a button to load the hero
                    Button btnLoadHero = CreateButton(
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

                    _createdButtons.Add(btnLoadHero);

                    // Creates a button to delete the hero
                    Button btnDeleteHero = CreateButton(
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

                    _createdButtons.Add(btnDeleteHero);

                    btnLocY += 40;
                }
            }

            return _createdButtons;
        }

        public Button CreateButton(string text, string name, int sizeX, int sizeY, int locX, int locY, Color backColor, Color foreColor, FlatStyle style)
        {
            Button button = new Button();
            button.Text = text;
            button.Name = name;
            button.Size = new Size(sizeX, sizeY);
            button.Location = new Point(locX, locY);
            button.BackColor = backColor;
            button.ForeColor = foreColor;
            button.FlatStyle = style;
            button.Font = new Font(ConfigurationManager.AppSettings["fontStyle"], 10);
            button.Anchor = AnchorStyles.None;
            button.FlatAppearance.BorderSize = 0;

            return button;
        }
    }
}
