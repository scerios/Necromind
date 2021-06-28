using NecromindLibrary.Config;
using System.Drawing;
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
            button.Font = new Font(UISettings.FontStyle, fontSize);
            button.Anchor = AnchorStyles.None;
            button.FlatAppearance.BorderSize = 0;
            button.TextAlign = alignment;
            button.Cursor = Cursors.Hand;
            button.TabStop = false;

            return button;
        }

        public static Panel CreateMapPanel(int locX, int locY, int posX, int posY, Color backColor)
        {
            Panel panel = new Panel();
            panel.Name = "pan" + posX + "I" + posY;
            panel.Location = new Point(locX, locY);
            panel.BackColor = backColor;
            panel.Size = new Size(UISettings.MapTileSize, UISettings.MapTileSize);

            return panel;
        }
    }
}