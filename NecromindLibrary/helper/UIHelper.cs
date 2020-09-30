using NecromindLibrary.service;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace NecromindLibrary.helper
{
    public class UIHelper
    {
        private UIHandler UIHandler;

        public UIHelper(UIHandler UIHandler)
        {
            this.UIHandler = UIHandler;
        }

        /// <summary>
        /// Applies custom style to rich text confirm delete.
        /// </summary>
        /// <param name="heroName">Name of the hero which is supposed to be deleted.</param>
        public RichTextBox ApplyCustomStyleToRichTextConfirmDelete(string heroName, RichTextBox confirmDeleteText)
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

        /// <summary>
        /// Sets the controls availability.
        /// </summary>
        /// <param name="controls">A list of controls which should be enabled/disabled.</param>
        /// <param name="isAvailable">True if controls should be enabled. False otherwise.</param>
        public void SetControlsAvailability(Control.ControlCollection controls, bool isAvailable)
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
        public string FormatErrorMsg(string msg)
        {
            int i = 25;

            // Adds linebreaks to the msg to display it correctly
            while (i < msg.Length - 10)
            {
                string msgPartToBreak = msg.Substring(i, 10);
                int index = msgPartToBreak.IndexOf(" ");
                index = i + index;

                char[] chars = msg.ToCharArray();
                chars[index] = '\n';
                msg = new string(chars);

                i += 25;
            }
            return msg;
        }

        /// <summary>
        /// Sets a buttons enabled property. By default the enabled color will be standard blue-ish. Optional: enabled color.
        /// </summary>
        /// <param name="button">Button which about to be set.</param>
        /// <param name="isAvailable">True if available. False otherwise.</param>
        /// <param name="color">Optional. If set this will be the enabled color.</param>
        /// <returns></returns>
        public void SetButtonAvailability(Button button, bool isAvailable, Color color = default)
        {
            button.Enabled = isAvailable;

            if (color == default)
            {
                button.BackColor = isAvailable ? Color.FromArgb(11, 84, 100) : Color.FromArgb(127, 140, 141);
            }
            else
            {
                button.BackColor = isAvailable ? color : Color.FromArgb(127, 140, 141);
            }
        }

        /// <summary>
        /// Sets the event log text.
        /// </summary>
        /// <param name="text">The text which shall be written.</param>
        /// <param name="isAppend">True if text should be appended. False if text should be replaced.</param>
        public void SetEventLogText(string text, bool isAppend)
        {
            UIHandler.RichTextBoxes[UIHandler.EventLog].Text = isAppend ? UIHandler.RichTextBoxes[UIHandler.EventLog].Text + "\n" + text : text;
        }
    }
}
