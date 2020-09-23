using NecromindLibrary.model;
using NecromindLibrary.service;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NecromindLibrary.helper
{
    public static class UIHelper
    {
        /// <summary>
        /// Checks among all the heroes if the user given name is already taken.
        /// </summary>
        /// <param name="heroes">A list of heroes.</param>
        /// <param name="name">Name of new hero.</param>
        /// <returns>True if name is available. False otherwise.</returns>
        public static bool IsNameAvailable(List<HeroModel> heroes, string name)
        {
            bool isNameAvailable = true;

            foreach (HeroModel hero in heroes)
            {
                if (hero.Name == name)
                {
                    isNameAvailable= false;
                    break;
                }
            }

            return isNameAvailable;
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

        /// <summary>
        /// Sets the controls availability.
        /// </summary>
        /// <param name="controls">A list of controls which should be enabled/disabled.</param>
        /// <param name="isAvailable">True if controls should be enabled. False otherwise.</param>
        public static void SetControlsAvailability(Control.ControlCollection controls, bool isAvailable)
        {
            foreach (Control control in controls)
            {
                control.Enabled = isAvailable;
            }
        }

        /// <summary>
        /// Displays an error window with custom title and message.
        /// </summary>
        /// <param name="title">Title of the error window.</param>
        /// <param name="msg">Message of the error.</param>
        public static void DisplayError(string title, string msg)
        {
            int i = 30;

            // Adds linebreaks to the msg to display it correctly
            while (i < msg.Length - 10)
            {
                string msgPartToBreak = msg.Substring(i, 10);
                int index = msgPartToBreak.IndexOf(" ");
                index = i + index;

                char[] chars = msg.ToCharArray();
                chars[index] = '\n';
                msg = new string(chars);

                i += 30;
            }

            UIHandler.Labels[UIHandler.ErrorTitle].Text = title;
            UIHandler.Labels[UIHandler.ErrorMsg].Text = msg;
            UIHandler.Panels[UIHandler.Error].BringToFront();
        }
    }
}
