using Necromind.Views.Menu;
using NecromindLibrary.Models;
using NecromindLibrary.Repository;
using NecromindUI.Config;

namespace Necromind.Presenters.Menu
{
    public class MenuAdminPresenter
    {
        private readonly IMenuAdmin _menuAdmin;
        private readonly MongoConnector _mongoConnector;

        public MenuAdminPresenter(IMenuAdmin menuAdmin)
        {
            _menuAdmin = menuAdmin;
            _mongoConnector = MongoConnector.GetInstance();
        }

        public bool IsPasswordCorrect()
        {
            var admins = _mongoConnector.GetAllRecords<AdminModel>(DBConfig.AdminsCollection);

            if (admins.Count == 0)
            {
                SaveAdmin();
                return true;
            }

            return BCrypt.Net.BCrypt.Verify(
                _menuAdmin.Password,
                admins[0].Password
                );
        }

        public void SaveAdmin()
        {
            _mongoConnector.TryCreateNewRecord(
                DBConfig.AdminsCollection,
                new AdminModel(BCrypt.Net.BCrypt.HashPassword(_menuAdmin.Password))
                );
        }
    }
}