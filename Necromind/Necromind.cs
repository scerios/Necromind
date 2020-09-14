using NecromindLibrary.dto;
using NecromindLibrary.helpers;
using NecromindLibrary.models;
using NecromindLibrary.repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NecromindUI
{
    public partial class Necromind : Form
    {
        public static Dictionary<string, Panel> Panels = new Dictionary<string, Panel>();
        public static Dictionary<string, Label> Labels = new Dictionary<string, Label>();
        private bool IsLoadButtonsLoaded = false;

        public Necromind()
        {
            // Forces Visual Studio to show error messages in english.
            if (Debugger.IsAttached) CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            InitializeComponent();
            startGame();
        }

        private void startGame()
        {
            setUpMenu();
            setLabels();
            showMainMenu();
        }

        private void setUpMenu()
        {
            Panels.Add("menu", panelMenu);
            Panels.Add("newGame", panelNewGame);
            Panels.Add("loadGame", panelLoadGame);
            Panels.Add("game", panelGame);
        }

        private void setLabels()
        {
            Labels.Add("health", labelHeroHealthValue);
            Labels.Add("gold", labelHeroGoldValue);
            Labels.Add("XP", labelHeroXPValue);
            Labels.Add("level", labelHeroLevelValue);
            Labels.Add("damage", labelHeroDamageValue);
            Labels.Add("defense", labelHeroDefenseValue);
        }

        private void showMainMenu()
        {
            Panels["menu"].BringToFront();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Panels["newGame"].BringToFront();
        }

        private void btnCreateNewHero_Click(object sender, EventArgs e)
        {
            int insertedId = DataAccess.CreateNewHero(textBoxNewHeroName.Text);
            HeroModel hero = DataAccess.GetHeroById(insertedId);
            UIHelper.SetHeroDetails(hero, Labels, groupBoxHeroDetails);
            Panels["game"].BringToFront();
            IsLoadButtonsLoaded = false;
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            if (!IsLoadButtonsLoaded)
            {
                List<HeroDTO> heroes = DataAccess.GetAllHeroesAsDTO();
                UIHelper.ShowAllLoadedHeroes(heroes, Panels, Labels, groupBoxHeroDetails);
                IsLoadButtonsLoaded = true;
            }
            Panels["loadGame"].BringToFront();
        }

        private void btnBackFromNewGame_Click(object sender, EventArgs e)
        {
            showMainMenu();
        }

        private void btnBackFromLoadGame_Click(object sender, EventArgs e)
        {
            showMainMenu();
        }

        private void btnBackFromGame_Click(object sender, EventArgs e)
        {
            showMainMenu();
            UIHelper.ResetGame(Labels, groupBoxHeroDetails);
        }
    }
}
