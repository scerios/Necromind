using Necromind.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Necromind.Presenters
{
    public class MenuNewPresenter
    {
        private readonly IMenuNew _menuNew;

        public MenuNewPresenter(IMenuNew menuNew)
        {
            _menuNew = menuNew;
        }
    }
}
