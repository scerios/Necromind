using NecromindLibrary.Repository;
using NecromindUI.Views.Admin;
using System;

namespace NecromindUI.Presenters.Admin
{
    public class AdminMapPresenter
    {
        private readonly MongoConnector _mongoConnector;
        private readonly IAdminMap _adminMap;

        public AdminMapPresenter(IAdminMap adminMap)
        {
            _adminMap = adminMap;
            _mongoConnector = MongoConnector.GetInstance();
        }
    }
}