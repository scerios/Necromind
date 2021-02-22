using Necromind.Views;
using NecromindLibrary.Models;
using NecromindLibrary.Repository;
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

        public void TryCreateHero()
        {
            var mongoConnector = MongoConnector.GetInstance();
            mongoConnector.TryCreateNewRecord("heroes", new HeroModel(_menuNew.HeroName));
        }
    }
}
