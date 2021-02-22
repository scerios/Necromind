using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Necromind.Views
{
    public interface IConfirmDelete
    {
        bool IsConfDelPanVisible { get; set; }
        string HeroName { get; set; }
        string ConfirmName { get; set; }
    }
}
