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
        public static Dictionary<string, Panel> panels = new Dictionary<string, Panel>();
        public static Dictionary<string, Label> labels = new Dictionary<string, Label>();
        private bool isLoadButtonsLoaded = false;

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
            panels.Add("menu", panelMenu);
            panels.Add("newGame", panelNewGame);
            panels.Add("loadGame", panelLoadGame);
            panels.Add("game", panelGame);
        }

        private void setLabels()
        {
            labels.Add("health", labelHeroHealthValue);
            labels.Add("gold", labelHeroGoldValue);
            labels.Add("XP", labelHeroXPValue);
            labels.Add("level", labelHeroLevelValue);
            labels.Add("damage", labelHeroDamageValue);
            labels.Add("defense", labelHeroDefenseValue);
        }

        private void showMainMenu()
        {
            panels["menu"].BringToFront();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            panels["newGame"].BringToFront();
        }

        private void btnCreateNewHero_Click(object sender, EventArgs e)
        {
            int insertedId = DataAccess.CreateNewHero(textBoxNewHeroName.Text);
            HeroModel hero = DataAccess.GetHeroById(insertedId);
            UIHelper.SetHeroDetails(hero, labels, groupBoxHeroDetails);
            panels["game"].BringToFront();
            isLoadButtonsLoaded = false;
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            if (!isLoadButtonsLoaded)
            {
                List<HeroDTO> heroes = DataAccess.GetAllHeroesAsDTO();
                UIHelper.ShowAllLoadedHeroes(heroes, panels, labels, groupBoxHeroDetails);
                isLoadButtonsLoaded = true;
            }
            panels["loadGame"].BringToFront();
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
            UIHelper.ResetGame(labels, groupBoxHeroDetails);
        }
    }
}
