using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NecromindLibrary.Services
{
    public static class UIService
    {
        public static Button CreateButton(
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
    }
}
