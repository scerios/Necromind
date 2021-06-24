using Necromind.Views.Menu;
using NecromindLibrary.Config;
using NecromindLibrary.Models;
using NecromindLibrary.Repository;

namespace Necromind.Presenters.Menu
{
    public class MenuAdminPresenter
    {
        private readonly IMenuAdmin _menuAdmin;
        private readonly MongoConnector _mongoConnector = MongoConnector.GetInstance();

        public MenuAdminPresenter(IMenuAdmin menuAdmin)
        {
            _menuAdmin = menuAdmin;
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

        private void SaveAdmin()
        {
            _mongoConnector.TryCreateNewRecord(
                DBConfig.AdminsCollection,
                new AdminModel(BCrypt.Net.BCrypt.HashPassword(_menuAdmin.Password))
                );
        }
    }
}