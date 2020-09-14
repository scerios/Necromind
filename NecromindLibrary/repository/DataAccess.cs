using Dapper;
using MySql.Data.MySqlClient;
using NecromindLibrary.helpers;
using NecromindLibrary.models;
using NecromindLibrary.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.repository
{
    public static class DataAccess
    {
        public static List<HeroModel> GetAllSavedHeroes()
        {
            List<HeroModel> heroes = new List<HeroModel>();
            using (IDbConnection connection = new MySqlConnection(DBConnectionHelper.GetConnectionStringByName("Necromind")))
            {
                DBConnectionHelper.SetDapperMapperToModelByName(ClassType.Hero);
                var sql = "SELECT * FROM hero";
                heroes = connection.Query<HeroModel>(sql).ToList();
            }

            return heroes;
        }

        public static List<QuestModel> GetQuestForHeroById(int heroId, string questIds)
        {
            List<QuestModel> quests = new List<QuestModel>();
            using (IDbConnection connection = new MySqlConnection(DBConnectionHelper.GetConnectionStringByName("Necromind")))
            {
                DBConnectionHelper.SetDapperMapperToModelByName(ClassType.Quest);
                var sql = $"SELECT * FROM quest WHERE id IN ({ questIds })";
                quests = connection.Query<QuestModel>(sql).ToList();
            }

            return quests;
        }
    }
}
