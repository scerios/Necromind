using System;

namespace NecromindLibrary.Services
{
    public static class TextService
    {
        /// <summary>
        /// Formats a string by adding linebreaks so it's shown correctly on the error panel.
        /// </summary>
        /// <param name="msg">Message of the error.</param>
        /// <returns>A formatted string.</returns>
        public static string FormatErrorMsg(string msg)
        {
            int lineLength = 25;

            return FormatMsg(lineLength, msg);
        }

        /// <summary>
        /// Formats a string by adding linebreaks so it's shown correctly on the event log.
        /// </summary>
        /// <param name="msg">Message of the event log.</param>
        /// <returns>A formatted string.</returns>
        public static string FormatEventMsg(string msg)
        {
            int lineLength = 75;

            return FormatMsg(lineLength, msg);
        }

        public static bool IsGivenStringsAreEqual(string one, string two) =>
            one.ToLower().Equals(two.ToLower());

        private static string FormatMsg(int lineLength, string msg)
        {
            int i = lineLength;

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
    }
}