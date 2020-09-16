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
using System.Windows.Forms.VisualStyles;

namespace NecromindUI
{
    public partial class Necromind : Form
    {
        public static Dictionary<string, Panel> panels = new Dictionary<string, Panel>();
        public static Dictionary<string, Label> labels = new Dictionary<string, Label>();

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
            panels.Add("confirmDelete", panelConfirmDelete);
        }

        private void setLabels()
        {
            labels.Add("heroHealth", labelHeroHealthValue);
            labels.Add("heroGold", labelHeroGoldValue);
            labels.Add("heroXP", labelHeroXPValue);
            labels.Add("heroLevel", labelHeroLevelValue);
            labels.Add("heroDamage", labelHeroDamageValue);
            labels.Add("heroDefense", labelHeroDefenseValue);
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

            if (insertedId > 0)
            {
                HeroModel hero = DataAccess.GetHeroById(insertedId);
                UIHelper.SetHeroDetails(hero, labels, groupBoxHeroDetails);

                textBoxNewHeroName.Text = "";
                panels["game"].BringToFront();
            } 
            else
            {
                showMainMenu();
            }
        }

        private void textBoxNewHeroName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If ENTER is pressed
            if (e.KeyChar == (char)13)
            {
                btnCreateNewHero_Click(sender, new EventArgs());
            }
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            List<HeroDTO> heroes = DataAccess.GetAllHeroesAsDTO();
            if (heroes.Count == 0)
            {
                MessageBox.Show("There's no hero yet to load. Create a new one first!");
            }
            else if (heroes.Count() == 1 && heroes.First().Id == 0) // Failed to connect to DB
            {
                MessageBox.Show(heroes.First().Name);
            }
            else
            {
                UIHelper.ShowAllLoadedHeroes(heroes, panels, labels, groupBoxHeroDetails, textBoxConfirmDelete, richTextBoxConfirmDelete);
                panels["loadGame"].BringToFront();
            }
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
