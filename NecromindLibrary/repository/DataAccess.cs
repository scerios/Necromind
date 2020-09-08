using Dapper;
using MySql.Data.MySqlClient;
using NecromindLibrary.models;
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
            using (IDbConnection connection = new MySqlConnection(Helper.GetConnectionStringByName("Necromind")))
            {
                SqlMapper.SetTypeMap(
                    typeof(HeroModel),
                    new CustomPropertyTypeMap(
                        typeof(HeroModel),
                        (type, columnName) =>
                        type.GetProperties().FirstOrDefault(prop =>
                        prop.GetCustomAttributes(false)
                        .OfType<ColumnAttribute>()
                        .Any(attr => attr.Name == columnName))
                        )
                    );
                var sql = "SELECT * FROM hero";
                heroes = connection.Query<HeroModel>(sql).ToList();
            }

            return heroes;
        }
    }
}
