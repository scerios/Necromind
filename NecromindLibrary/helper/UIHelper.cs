using NecromindLibrary.dto;
using NecromindLibrary.model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NecromindLibrary.helper
{
    public static class UIHelper
    {
        /// <summary>
        /// Checks among all the heroes if the user given name is already taken.
        /// </summary>
        /// <param name="heroes">A list of heroes as HeroDTO.</param>
        /// <returns>True if name already taken. False otherwise.</returns>
        public static bool IsNameAlreadyTaken(List<HeroDTO> heroes, TextBox newHeroName)
        {
            bool isNameAlreadyTaken = false;

            foreach (HeroDTO hero in heroes)
            {
                if (hero.Name == newHeroName.Text)
                {
                    isNameAlreadyTaken = true;
                    break;
                }
            }

            return isNameAlreadyTaken;
        }

        /// <summary>
        /// Applies custom style to rich text confirm delete.
        /// </summary>
        /// <param name="heroName">Name of the hero which is supposed to be deleted.</param>
        public static RichTextBox ApplyCustomStyleToRichTextConfirmDelete(string heroName, RichTextBox confirmDeleteText)
        {
            confirmDeleteText.Text = confirmDeleteText.Text.Replace(UIHandler.HeroNamePlaceholder, heroName);

            int startPositionOfEnter = confirmDeleteText.Text.IndexOf("ENTER");
            int startPositionOfEsc = confirmDeleteText.Text.IndexOf("ESC");

            Font font = confirmDeleteText.Font;
            FontStyle bold = FontStyle.Bold;

            confirmDeleteText.SelectAll();
            confirmDeleteText.SelectionAlignment = HorizontalAlignment.Center;
            confirmDeleteText.Select(26, 6);
            confirmDeleteText.SelectionColor = Color.FromArgb(214, 48, 49); // Red color
            confirmDeleteText.SelectionFont = new Font(font, bold);
            confirmDeleteText.Select(startPositionOfEnter, 5);
            confirmDeleteText.SelectionColor = Color.FromArgb(0, 184, 148); // Green color
            confirmDeleteText.SelectionFont = new Font(font, bold);
            confirmDeleteText.Select(startPositionOfEsc, 3);
            confirmDeleteText.SelectionColor = Color.FromArgb(253, 203, 110); // Yellow color
            confirmDeleteText.SelectionFont = new Font(font, bold);

            return confirmDeleteText;
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
        public static Button CreateButton(string text, string name, int sizeX, int sizeY, int locX, int locY, Color backColor, Color foreColor, FlatStyle style)
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
