using Necromind.Views;
using NecromindLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Necromind.Presenters
{
    public class MenuLoadPresenter
    {
        private readonly IMenuLoad _menuLoad;

        public MenuLoadPresenter(IMenuLoad menuLoad)
        {
            _menuLoad = menuLoad;
        }

        public List<T> GetAllHeroes<T>(string collectionName)
        {
            var mongoConnector = MongoConnector.GetInstance();

            return mongoConnector.GetAllRecords<T>(collectionName);
        }
    }
}
