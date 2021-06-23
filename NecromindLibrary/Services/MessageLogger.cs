using NecromindLibrary.EventArgs;
using System;

namespace NecromindLibrary.Services
{
    public class MessageLogger
    {
        private static MessageLogger _instance;

        private MessageLogger()
        {
        }

        public event EventHandler<GameMessageEventArgs> OnMessageRaised;

        public static MessageLogger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MessageLogger();
            }

            return _instance;
        }

        public void RaiseMessage(string message)
        {
            OnMessageRaised?.Invoke(this, new GameMessageEventArgs(message));
        }
    }
}