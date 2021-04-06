using System;
using System.Configuration;

namespace NecromindUI.Config
{
    public static class DBConfig
    {
        public static readonly string AdminsCollection = ConfigurationManager.AppSettings.Get("adminsCollection");
        public static readonly string HeroesCollection = ConfigurationManager.AppSettings.Get("heroesCollection");
        public static readonly string VendorsCollection = ConfigurationManager.AppSettings.Get("vendorsCollection");
        public static readonly string EnemiesCollection = ConfigurationManager.AppSettings.Get("enemiesCollection");
        public static readonly string LocationsCollection = ConfigurationManager.AppSettings.Get("locationsCollection");
        public static readonly string MapsCollection = ConfigurationManager.AppSettings.Get("mapsCollection");
    }
}