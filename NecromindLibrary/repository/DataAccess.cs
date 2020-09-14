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
using System.CodeDom;
using System.Configuration;
using NecromindLibrary.dto;

namespace NecromindLibrary.repository
{
    public static class DataAccess
    {
        private static string databaseName = ConfigurationManager.AppSettings["databaseName"];

        /// <summary>
        /// Gets all the saved heroes from the database as HeroDTO so the load saved hero buttons can be created.
        /// </summary>
        /// <returns>A list of all the saved heroes as HeroDTOs.</returns>
        public static List<HeroDTO> GetAllHeroesAsDTO()
        {
            using (IDbConnection connection = new MySqlConnection(DBConnectionHelper.GetConnectionStringByName(databaseName)))
            {
                DBConnectionHelper.SetDapperMapperToModelByName(ClassType.HeroDTO);
                var sql = "SELECT id, name FROM hero";
                return connection.Query<HeroDTO>(sql).ToList();
            }
        }

        /// <summary>
        /// Gets a single hero from the database as HeroModel.
        /// </summary>
        /// <param name="id">ID of hero.</param>
        /// <returns>Returns the hero as HeroModel.</returns>
        public static HeroModel GetHeroById(int id)
        {
            using (IDbConnection connection = new MySqlConnection(DBConnectionHelper.GetConnectionStringByName(databaseName)))
            {
                DBConnectionHelper.SetDapperMapperToModelByName(ClassType.Hero);
                var parameters = new { id = id };
                var sql = "SELECT * FROM hero WHERE id = @id";
                return connection.Query<HeroModel>(sql, parameters).First();
            }
        }
    }
}
