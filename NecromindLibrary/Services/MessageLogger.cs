using NecromindLibrary.EventArgs;
using System;
using System.Drawing;

namespace NecromindLibrary.Services
{
    public class MessageLogger
    {
        private static MessageLogger _instance;

        private MessageLogger()
        {
        }

        public event EventHandler<GameMessageEventArgs> OnMessageRaised;

        public event EventHandler<GameMessageEventArgs> OnMessageAppend;

        public static MessageLogger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MessageLogger();
            }

            return _instance;
        }

        public void RaiseMessage(string message, Color color)
        {
            OnMessageRaised?.Invoke(this, new GameMessageEventArgs(message, color));
        }

        public void AppendMessage(string message, Color color)
        {
            OnMessageAppend?.Invoke(this, new GameMessageEventArgs(message, color));
        }
    }
}