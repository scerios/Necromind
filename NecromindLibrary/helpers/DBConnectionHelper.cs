using Dapper;
using NecromindLibrary.enums;
using NecromindLibrary.models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.helpers
{
    /// <summary>
    /// Collection of helper methods.
    /// </summary>
    public static class DBConnectionHelper
    {
        /// <summary>
        /// Gets the connection string by the reference name.
        /// </summary>
        /// <param name="name">Reference name of the connection string.</param>
        /// <returns>The connection string which was referenced by name.</returns>
        public static string GetConnectionStringByName(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        /// <summary>
        /// Sets the Dapper TypeMap to the specific object so class fields will be mapped correctly with their database properties correctly.
        /// eg: hit_points_max => HitPointsMax
        /// </summary>
        /// <param name="classType">Type of class which needs to be mapped.</param>
        public static void SetDapperMapperToModelByName(ClassTypes classType)
        {
            switch (classType.ToString())
            {
                case "Hero":

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

                    break;

                case "Quest":

                    SqlMapper.SetTypeMap(
                        typeof(QuestModel),
                        new CustomPropertyTypeMap(
                            typeof(QuestModel),
                            (type, columnName) =>
                            type.GetProperties().FirstOrDefault(prop =>
                            prop.GetCustomAttributes(false)
                            .OfType<ColumnAttribute>()
                            .Any(attr => attr.Name == columnName))
                            )
                        );

                    break;
            }
        }
    }
}
