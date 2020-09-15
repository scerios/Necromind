﻿using NecromindLibrary.dto;
using NecromindLibrary.models;
using NecromindLibrary.repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NecromindLibrary.helpers
{
    /// <summary>
    /// Collection of UI handler helper methods.
    /// </summary>
    public static class UIHelper
    {
        private static List<Button> createdButtons = new List<Button>();
        private static List<HeroDTO> heroesAsDTO;

        /// <summary>
        /// Resets the game panel to the original values.
        /// </summary>
        /// <param name="labels">A dictionary of labels.</param>
        /// <param name="heroDetails">A group box of hero details.</param>
        public static void ResetGame(Dictionary<string, Label> labels, GroupBox heroDetails)
        {
            heroDetails.Text = "{HERO}'s Details";
            labels["health"].Text = "";
            labels["gold"].Text = "";
            labels["XP"].Text = "";
            labels["level"].Text = "";
            labels["damage"].Text = "";
            labels["defense"].Text = "";
        }

        /// <summary>
        /// Creates a button for each saved heroes and adds an event to load any of them upon click event. 
        /// </summary>
        /// <param name="heroes">A list of HeroDTOs.</param>
        /// <param name="panels">A dictionary of panels.</param>
        /// <param name="labels">A dictionary of labels.</param>
        /// <param name="heroDetails">A group box of hero details.</param>
        public static void ShowAllLoadedHeroes(List<HeroDTO> heroes, Dictionary<string, Panel> panels, Dictionary<string, Label> labels, 
                                                GroupBox heroDetails, TextBox textBoxConfirmDelete, RichTextBox richTextBoxConfirmDelete)
        {
            heroesAsDTO = heroes;
            int btnLoadHeroLocX = 430;
            int btnDeleteHeroLocX = 540;
            int btnLocY = 100;

            foreach (HeroDTO hero in heroes)
            {
                // Orange background color
                Color btnLoadHeroColor = new Color();
                btnLoadHeroColor = Color.FromArgb(211, 84, 0);

                // Soft gray-ish white color
                Color btnLoadHeroTextColor = new Color();
                btnLoadHeroTextColor = Color.FromArgb(229, 232, 232);

                Button btnLoadHero = CreateButton(
                    hero.Name,
                    "btnLoad" + hero.Name,
                    100,
                    25,
                    btnLoadHeroLocX,
                    btnLocY,
                    btnLoadHeroColor,
                    btnLoadHeroTextColor,
                    FlatStyle.Flat
                );

                createdButtons.Add(btnLoadHero);

                btnLoadHero.Click += (s, ev) =>
                {
                    LoadHeroByIdBtn(hero.Id, panels, labels, heroDetails);
                };

                panels["loadGame"].Controls.Add(btnLoadHero);

                // Blue-ish color (exactly like the window background)
                Color btnDeleteHeroColor = new Color();
                btnDeleteHeroColor = Color.FromArgb(23, 32, 42);

                // Red color
                Color btnDeleteHeroTextColor = new Color();
                btnDeleteHeroTextColor = Color.FromArgb(214, 48, 49);

                Button btnDeleteHero = CreateButton(
                    "X",
                    "btnDelete" + hero.Name,
                    25,
                    25,
                    btnDeleteHeroLocX,
                    btnLocY,
                    btnDeleteHeroColor,
                    btnDeleteHeroTextColor,
                    FlatStyle.Flat
                );

                createdButtons.Add(btnDeleteHero);

                btnDeleteHero.Click += (s, ev) =>
                {
                    DeleteHeroByIdBtn(hero, panels, labels, heroDetails, textBoxConfirmDelete, richTextBoxConfirmDelete);
                };

                btnLocY += 40;

                panels["loadGame"].Controls.Add(btnDeleteHero);
            }
        }

        /// <summary>
        /// Gets all the information from the database of a single hero by its ID, sets all the needed labels in the game panel and brings the game panel to the front.
        /// </summary>
        /// <param name="id">ID of hero.</param>
        /// <param name="panels">A dictionary of panels.</param>
        /// <param name="labels">A dictionary of labels.</param>
        /// <param name="heroDetails">A group box of hero details.</param>
        private static void LoadHeroByIdBtn(int id, Dictionary<string, Panel> panels, Dictionary<string, Label> labels, GroupBox heroDetails)
        {
            HeroModel hero = DataAccess.GetHeroById(id);
            SetHeroDetails(hero, labels, heroDetails);
            panels["game"].BringToFront();
        }

        /// <summary>
        /// Deletes a hero by ID then reloads the loadGame panel.
        /// </summary>
        /// <param name="hero">A hero as HeroDTO.</param>
        /// <param name="panels">A dictionary of panels.</param>
        /// <param name="labels">A dictionary of labels.</param>
        /// <param name="heroDetails">A group box of hero details.</param>
        private static void DeleteHeroByIdBtn(HeroDTO hero, Dictionary<string, Panel> panels, Dictionary<string, Label> labels,
                                                GroupBox heroDetails, TextBox textBoxConfirmDelete, RichTextBox richTextBoxConfirmDelete)
        {
            foreach (Control control in panels["loadGame"].Controls)
            {
                control.Enabled = false;
            }

            richTextBoxConfirmDelete.Text = richTextBoxConfirmDelete.Text.Replace("{HERO}", hero.Name);
            richTextBoxConfirmDelete.SelectAll();
            richTextBoxConfirmDelete.SelectionAlignment = HorizontalAlignment.Center;
            richTextBoxConfirmDelete.Select(26, 6);
            richTextBoxConfirmDelete.SelectionColor = Color.FromArgb(214, 48, 49);
            textBoxConfirmDelete.Focus();
            panels["confirmDelete"].BringToFront();

            textBoxConfirmDelete.KeyPress += (s, ev) =>
            {
                if (ev.KeyChar == (char)13)
                {
                    if (textBoxConfirmDelete.Text == hero.Name)
                    {
                        heroesAsDTO.Remove(hero);
                        DataAccess.DeleteHeroById(hero.Id);

                        foreach (Button createdButton in createdButtons)
                        {
                            panels["loadGame"].Controls.Remove(createdButton);
                        }

                        foreach (Control control in panels["loadGame"].Controls)
                        {
                            control.Enabled = true;
                        }

                        ShowAllLoadedHeroes(heroesAsDTO, panels, labels, heroDetails, textBoxConfirmDelete, richTextBoxConfirmDelete);
                        panels["confirmDelete"].SendToBack();
                        richTextBoxConfirmDelete.Text = richTextBoxConfirmDelete.Text.Replace(hero.Name, "{HERO}");
                    }
                }

                if (ev.KeyChar == (char)27)
                {
                    foreach (Control control in panels["loadGame"].Controls)
                    {
                        control.Enabled = true;
                    }

                    panels["confirmDelete"].SendToBack();
                    richTextBoxConfirmDelete.Text = richTextBoxConfirmDelete.Text.Replace(hero.Name, "{HERO}");
                }
            };
        }

        /// <summary>
        /// Creates a button with custom style.
        /// </summary>
        /// <param name="text">Text to show</param>
        /// <param name="name">Name of the button</param>
        /// <param name="sizeX">Size of axis X</param>
        /// <param name="sizeY">Size of axis Y</param>
        /// <param name="locX">Location on axis X</param>
        /// <param name="locY">Location on axis Y</param>
        /// <param name="backColor">Background color</param>
        /// <param name="foreColor">Text color</param>
        /// <param name="style">Button style</param>
        /// <returns></returns>
        private static Button CreateButton(string text, string name, int sizeX, int sizeY, int locX, int locY, Color backColor, Color foreColor, FlatStyle style)
        {
            Button button = new Button();
            button.Text = text;
            button.Name = name;
            button.Size = new Size(sizeX, sizeY);
            button.Location = new Point(locX, locY);
            button.BackColor = backColor;
            button.ForeColor = foreColor;
            button.FlatStyle = style;
            button.Font = new Font("Courier New", 10);
            button.Anchor = AnchorStyles.None;
            button.FlatAppearance.BorderSize = 0;

            return button;
        }

        /// <summary>
        /// Sets all the labels and the hero details (group box) text to the current hero's values.
        /// </summary>
        /// <param name="hero">A hero model.</param>
        /// <param name="labels">A dictionary of labels.</param>
        /// <param name="heroDetails">A group box of hero details.</param>
        public static void SetHeroDetails(HeroModel hero, Dictionary<string, Label> labels, GroupBox heroDetails)
        {
            if (hero.Name.EndsWith("s") || hero.Name.EndsWith("S"))
            {
                heroDetails.Text = heroDetails.Text.Replace("{HERO}'s", hero.Name + "'");
            } 
            else
            {
                heroDetails.Text = heroDetails.Text.Replace("{HERO}", hero.Name);
            }
            
            labels["health"].Text = hero.HitPointsMax.ToString() + " / " + hero.HitPoints.ToString();
            labels["gold"].Text = hero.Gold.ToString();
            labels["XP"].Text = hero.ExperiencePoints.ToString() + " / " + hero.NextLevelAt.ToString();
            labels["level"].Text = hero.Level.ToString();
            labels["damage"].Text = hero.Damage.ToString();
            labels["defense"].Text = hero.Defense.ToString();
        }
    }
}
