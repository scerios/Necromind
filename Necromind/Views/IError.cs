using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Necromind.Views
{
    public interface IError
    {
        bool IsErrorPanVisible { get; set; }
        string Title { get; set; }
        string Msg { get; set; }
    }
}
