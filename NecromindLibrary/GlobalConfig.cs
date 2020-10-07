using NecromindLibrary.repository;

namespace NecromindLibrary
{
    public static class GlobalConfig
    {
        // The DB connection across the app.
        public static IDataConnection connection { get; private set; }

        /// <summary>
        /// Initializes the connection.
        /// </summary>
        public static void InitializeConnection() 
        {
            connection = MongoConnector.GetInstance();
        }
    }
}
