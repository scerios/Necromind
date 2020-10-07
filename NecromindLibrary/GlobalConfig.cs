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
            // Using a MongoDB connection.
            connection = MongoConnector.GetInstance();
        }
    }
}
