using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Necromind.Views
{
    public interface IMenuLoad
    {
        Panel ErrorPanel { get; }
        Button BtnClose { get; }
        string ErrorTitle { get; set; }
        string ErrorMsg { get; set; }
    }
}
