using System;
using System.Drawing;

namespace NecromindLibrary.EventArgs
{
    public class GameMessageEventArgs : System.EventArgs
    {
        public string Message { get; private set; }
        public Color Color { get; private set; }

        public GameMessageEventArgs(string message, Color color)
        {
            Message = message;
            Color = color;
        }
    }
}