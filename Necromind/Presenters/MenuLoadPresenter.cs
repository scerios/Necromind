using NecromindUI.Views;
using NecromindLibrary.Models;
using NecromindLibrary.Repository;
using NecromindLibrary.Services;
using NecromindUI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NecromindUI.Presenters
{
    public class MenuLoadPresenter
    {
        private readonly MongoConnector _mongoConnector;
        private readonly IMenuLoad _menuLoad;
        public string HeroToDelId;

        public MenuLoadPresenter(IMenuLoad menuLoad)
        {
            _menuLoad = menuLoad;
            _mongoConnector = MongoConnector.GetInstance();
        }

        private void DisplayError()
        {
            var textService = new TextService();
            _menuLoad.Title = "No hero found";
            _menuLoad.Msg = textService.FormatErrorMsg("You must create a hero first to be able to load them.");
            _menuLoad.IsPanErrorVisible = true;
        }

        public List<HeroModel> GetAllHeroes(string collectionName)
        {
            var heroes = _mongoConnector.GetAllRecords<HeroModel>(collectionName);


            if (heroes.Count == 0)
            {
                DisplayError();
            }

            return heroes;
        }

        public void HideError()
        {
            _menuLoad.IsPanErrorVisible = false;
            _menuLoad.Title = "";
            _menuLoad.Msg = "";
        }

        public void DisplayPanConfDel(string heroName)
        {
            _menuLoad.HeroName = heroName;
            _menuLoad.IsPanConfDelVisible = true;
        }

        public void HidePanConfDel()
        {
            _menuLoad.IsPanConfDelVisible = false;
            _menuLoad.HeroName = "";
            _menuLoad.ConfirmName = "";
        }

        // TODO - put this in UIService when it's eventually reworked
        public Button CreateButton(
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
            button.Cursor = Cursors.Hand;
            button.TabStop = false;

            return button;
        }

        public void DeleteHero()
        {
            _mongoConnector.TryDeleteRecordById<HeroModel>(ConfigurationManager.AppSettings.Get("heroesCollection"), HeroToDelId);
        }

        public void ChangeBtnDelHeroAvailability()
        {
            var textService = new TextService();
            _menuLoad.IsBtnDelHeroEnabled = textService.IsGivenStringsAreEqual(_menuLoad.HeroName, _menuLoad.ConfirmName);
        }
    }
}
