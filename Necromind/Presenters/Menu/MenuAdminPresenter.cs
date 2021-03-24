using Necromind.Views.Menu;
using NecromindLibrary.Repository;
using System.Configuration;

namespace Necromind.Presenters.Menu
{
    public class MenuAdminPresenter
    {
        private IMenuAdmin _menuAdmin;
        private MongoConnector _mongoConnector;

        public MenuAdminPresenter(IMenuAdmin menuAdmin)
        {
            _menuAdmin = menuAdmin;
            _mongoConnector = MongoConnector.GetInstance();
        }

        public bool IsPasswordCorrect()
        {
            // TODO - Store password securely.
            return _menuAdmin.Password.Equals(ConfigurationManager.AppSettings.Get("adminPassword"));
        }
    }
}