using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NecromindLibrary.Services
{
    public class TextService
    {
        /// <summary>
        /// Formats a string by adding linebreaks so it's shown correctly on the error panel.
        /// </summary>
        /// <param name="msg">Message of the error.</param>
        /// <returns>A formatted string.</returns>
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
    }
}
