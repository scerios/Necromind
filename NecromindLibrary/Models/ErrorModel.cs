using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.Models
{
    public class ErrorModel
    {
        public string Title { get; }
        public string Msg { get; }

        public ErrorModel(string title, string msg)
        {
            Title = title;
            Msg = msg;
        }
    }
}
