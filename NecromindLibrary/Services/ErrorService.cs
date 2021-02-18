using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NecromindLibrary.Services
{
    public class ErrorService
    {
        public ErrorService()
        {

        }
        /// <summary>
        /// Displays an error window with custom title and message. Also formats the message to add linebreaks.
        /// </summary>
        /// <param name="title">Title of the error.</param>
        /// <param name="msg">Message of the error.</param>
        public void DisplayError(string title, string msg)
        {
            //Labels[ErrorTitle].Text = title;
            //Labels[ErrorMsg].Text = FormatErrorMsg(msg);
            //BringPanelToFront(Error);
        }

        /// <summary>
        /// Displays an error window with custom title and message.
        /// </summary>
        /// <param name="title">Title of the error window.</param>
        /// <param name="msg">Message of the error.</param>
        private string FormatErrorMsg(string msg)
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
