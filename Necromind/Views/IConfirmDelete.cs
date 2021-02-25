using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindUI.Views
{
    public interface IConfirmDelete
    {
        bool IsPanConfDelVisible { get; set; }
        string HeroName { get; set; }
        string ConfirmName { get; set; }
        bool IsBtnDelHeroEnabled { get; set; }
    }
}
