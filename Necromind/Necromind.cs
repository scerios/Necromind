using NecromindLibrary.dto;
using NecromindLibrary.helper;
using NecromindLibrary.model;
using NecromindLibrary.repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

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
            textBoxNewHeroName.Focus();
        }

        private void btnCreateNewHero_Click(object sender, EventArgs e)
        {
            UIHelper.CreateNewHero(panels, labels, textBoxNewHeroName, groupBoxHeroDetails);
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
            UIHelper.ShowAllLoadedHeroes(panels, labels, groupBoxHeroDetails, textBoxConfirmDelete, richTextBoxConfirmDelete);
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
