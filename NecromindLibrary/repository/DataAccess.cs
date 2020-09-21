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
    // TODO - Convert all DataAccess to noSQL, probably mongoDB
    public static class DataAccess
    {
        private static readonly string databaseName = ConfigurationManager.AppSettings["databaseName"];

        /// <summary>
        /// Creates a new hero with the given name and returns the inserted ID.
        /// </summary>
        /// <param name="name">Name of the hero.</param>
        /// <returns>Returns the inserted ID as an int or 0 if failed to create.</returns>
        public static int CreateNewHero(string name)
        {
            using (IDbConnection connection = new MySqlConnection(DBConnectionHelper.GetConnectionStringByName(databaseName)))
            {
                var parameters = new { name };
                var sql = "INSERT INTO hero (name) VALUES (@name)";
                try
                {
                    connection.Execute(sql, parameters);
                    sql = "SELECT LAST_INSERT_ID()";
                    return connection.QuerySingle<int>(sql);
                }
                catch (MySqlException exception)
                {
                    UIHelper.DisplayError("Connection error", exception.Message);
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
                var parameters = new { id };
                var sql = "DELETE FROM hero WHERE id = @id";
                try
                {
                    connection.Execute(sql, parameters);
                    return true;
                }
                catch (MySqlException exception)
                {
                    UIHelper.DisplayError("Connection error", exception.Message);
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
                    heroes.Add(new HeroDTO { Id = 0 , Name = exception.Message });
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
                var parameters = new { id };
                var sql = "" +
                    "SELECT h.*, " +
                    "a.id, a.name, a.buy_price AS BuyPrice, a.sell_price AS SellPrice, a.is_sellable AS IsSellable, a.defense, " +
                    "w.id, w.name, w.buy_price AS BuyPrice, w.sell_price AS SellPrice, w.is_sellable AS IsSellable, w.damage " +
                    "FROM hero h " +
                    "LEFT JOIN armor a " +
                    "ON h.armor_id = a.id " +
                    "LEFT JOIN weapon w " +
                    "ON h.weapon_id = w.id " +
                    "WHERE h.id = @id"
                    ;
                try
                {
                    var data = connection.Query<HeroModel, ArmorModel, WeaponModel, HeroModel>(sql, (hero, armor, weapon) => 
                    {
                        hero.Armor = armor;
                        hero.Weapon = weapon;
                        return hero;
                    }, parameters, splitOn: "armor_id, weapon_id");

                    return data.First();
                }
                catch (MySqlException exception)
                {
                    UIHelper.DisplayError("Connection error", exception.Message);
                    return new HeroModel();
                }
            }
        }
    }
}
