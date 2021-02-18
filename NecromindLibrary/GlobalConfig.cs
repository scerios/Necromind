using NecromindLibrary.Repository;

namespace NecromindLibrary
{
    public static class GlobalConfig
    {
        // The DB connection across the app.
        public static IDataConnection Connection { get; private set; }

        /// <summary>
        /// Initializes the connection.
        /// </summary>
        public static void InitializeConnection()
        {
            // Using a MongoDB connection.
            Connection = MongoConnector.GetInstance();
        }
    }
}
