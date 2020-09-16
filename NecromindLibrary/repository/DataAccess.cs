using Dapper;
using MySql.Data.MySqlClient;
using NecromindLibrary.helper;
using NecromindLibrary.model;
using NecromindLibrary.enums;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Configuration;
using NecromindLibrary.dto;
using System.Windows.Forms;

namespace NecromindLibrary.repository
{
    public static class DataAccess
    {
        private static readonly string databaseName = ConfigurationManager.AppSettings["databaseName"];
        private static readonly string exceptionErrorMsg = "The request couldn't be made due to the following error: ";

        /// <summary>
        /// Creates a new hero with the given name and returns the inserted ID.
        /// </summary>
        /// <param name="name">Name of the hero.</param>
        /// <returns>Returns the inserted ID as an int or 0 if failed to create.</returns>
        public static int CreateNewHero(string name)
        {
            using (IDbConnection connection = new MySqlConnection(DBConnectionHelper.GetConnectionStringByName(databaseName)))
            {
                var parameters = new { name = name };
                var sql = "INSERT INTO hero (name) VALUES (@name)";
                try
                {
                    connection.Execute(sql, parameters);
                    sql = "SELECT LAST_INSERT_ID()";
                    return connection.QuerySingle<int>(sql);
                }
                catch (MySqlException exception)
                {
                    MessageBox.Show(exceptionErrorMsg + exception.Message);
                    return 0;
                }
            }
        }

        /// <summary>
        /// Deletes a hero from the database by the hero ID.
        /// </summary>
        /// <param name="id">Id of hero.</param>
        /// <returns>True if successfully deleted. False otherwise.</returns>
        public static bool TryDeleteHeroById(int id)
        {
            using (IDbConnection connection = new MySqlConnection(DBConnectionHelper.GetConnectionStringByName(databaseName)))
            {
                var parameters = new { id = id };
                var sql = "DELETE FROM hero WHERE id = @id";
                try
                {
                    connection.Execute(sql, parameters);
                    return true;
                }
                catch (MySqlException exception)
                {
                    MessageBox.Show(exceptionErrorMsg + exception.Message);
                    return false;
                }
            }
        }

        /// <summary>
        /// Gets all the saved heroes from the database as HeroDTO. HeroDTO has Id and Name.
        /// </summary>
        /// <returns>A list of all the saved heroes as HeroDTOs.</returns>
        public static List<HeroDTO> GetAllHeroesAsDTO()
        {
            using (IDbConnection connection = new MySqlConnection(DBConnectionHelper.GetConnectionStringByName(databaseName)))
            {
                DBConnectionHelper.SetDapperMapperToModelByName(ClassType.HeroDTO);
                var sql = "SELECT id, name FROM hero";
                try
                {
                    return connection.Query<HeroDTO>(sql).ToList();
                }
                catch (MySqlException exception)
                {
                    List<HeroDTO> heroes = new List<HeroDTO>();
                    heroes.Add(new HeroDTO { Id = 0, Name = exceptionErrorMsg + exception.Message });
                    return heroes;
                }
            }
        }

        /// <summary>
        /// Gets a single hero from the database as HeroModel.
        /// </summary>
        /// <param name="id">ID of hero.</param>
        /// <returns>Returns the hero as HeroModel or an empty HeroModel if failed to connect to DB.</returns>
        public static HeroModel GetHeroById(int id)
        {
            using (IDbConnection connection = new MySqlConnection(DBConnectionHelper.GetConnectionStringByName(databaseName)))
            {
                DBConnectionHelper.SetDapperMapperToModelByName(ClassType.Hero);
                var parameters = new { id = id };
                var sql = "SELECT * FROM hero WHERE id = @id";
                try
                {
                    return connection.Query<HeroModel>(sql, parameters).First();
                }
                catch (MySqlException exception)
                {
                    MessageBox.Show(exceptionErrorMsg + exception.Message);
                    return new HeroModel();
                }
            }
        }
    }
}
