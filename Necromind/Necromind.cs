using NecromindLibrary.service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;

namespace NecromindUI
{
    public partial class Necromind : Form
    {
        private static Dictionary<string, Panel> Panels = new Dictionary<string, Panel>();
        private static Dictionary<string, Label> Labels = new Dictionary<string, Label>();
        private static Dictionary<string, TextBox> TextBoxes = new Dictionary<string, TextBox>();
        private static Dictionary<string, GroupBox> GroupBoxes = new Dictionary<string, GroupBox>();

        public Necromind()
        {
            // Forces Visual Studio to show error messages in english.
            if (Debugger.IsAttached) CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            InitializeComponent();
            startGame();
        }

        private void startGame()
        {
            setPanels();
            setLabels();
            setTextBoxes();
            setGroupBoxes();
            sendAllUIToLibrary();
            showMainMenu();
        }

        private void setPanels()
        {
            Panels.Add("menu", panelMenu);
            Panels.Add("newGame", panelNewGame);
            Panels.Add("loadGame", panelLoadGame);
            Panels.Add("game", panelGame);
            Panels.Add("confirmDelete", panelConfirmDelete);
        }

        private void setLabels()
        {
            Labels.Add("heroHealth", labelHeroHealthValue);
            Labels.Add("heroGold", labelHeroGoldValue);
            Labels.Add("heroXP", labelHeroXPValue);
            Labels.Add("heroLevel", labelHeroLevelValue);
            Labels.Add("heroDamage", labelHeroDamageValue);
            Labels.Add("heroDefense", labelHeroDefenseValue);
        }

        private void setTextBoxes()
        {
            TextBoxes.Add("newHeroName", textBoxNewHeroName);
            TextBoxes.Add("deleteHeroName", textBoxDeleteHeroName);
        }

        private void setGroupBoxes()
        {
            GroupBoxes.Add("heroDetails", groupBoxHeroDetails);
            GroupBoxes.Add("heroItems", groupBoxHeroItems);
            GroupBoxes.Add("characterDetails", groupBoxCharacterDetails);
            GroupBoxes.Add("characterItems", groupBoxCharacterItems);
        }

        private void sendAllUIToLibrary()
        {
            UIHandler.TakeAllUI(Panels, Labels, TextBoxes, GroupBoxes, richTextBoxConfirmDelete);
        }

        private void showMainMenu()
        {
            Panels["menu"].BringToFront();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Panels["newGame"].BringToFront();
            textBoxNewHeroName.Focus();
        }

        private void btnCreateNewHero_Click(object sender, EventArgs e)
        {
            UIHandler.CreateNewHero();
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
            UIHandler.ShowAllLoadedHeroes();
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
            UIHandler.ResetGame();
        }
    }
}
