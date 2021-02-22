using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using MongoDB.Driver;
using System;
using MongoDB.Bson;

namespace NecromindLibrary.Repository
{
    public class MongoConnector : IDataConnection
    {
        private readonly MongoClient _client = new MongoClient();
        private readonly IMongoDatabase _DB;

        private static MongoConnector _instance;

        private MongoConnector()
        {
            _DB = _client.GetDatabase(ConfigurationManager.AppSettings.Get("databaseName"));
        }

        public static MongoConnector GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MongoConnector();
            }

            return _instance;
        }

        /// <summary>
        /// Creates a new record in the given collection.
        /// </summary>
        /// <typeparam name="T">Custom object.</typeparam>
        /// <param name="collectionName">Name of collection.</param>
        /// <param name="record">The object to be added.</param>
        /// <returns>True if insertion is successful. False otherwise.</returns>
        /// Alternative return: An automatically generated Guid for the record OR an empty one upon some DB error.
        public bool TryCreateNewRecord<T>(string collectionName, T record)
        {
            var collection = _DB.GetCollection<T>(collectionName);

            try
            {
                collection.InsertOne(record);
                return true;
                //return record.ToBsonDocument().GetElement("_id").Value.AsGuid.ToString();
            }
            catch (MongoException)
            {
                return false;
                //return "00000000-0000-0000-0000-000000000000";
            }
        }

        /// <summary>
        /// Deletes a record from the database by ID.
        /// </summary>
        /// <param name="id">ID of record.</param>
        /// <returns>True if successfully deleted. False otherwise.</returns>
        public bool TryDeleteRecordById<T>(string collectionName, string id)
        {
            var collection = _DB.GetCollection<T>(collectionName);
            var filter = Builders<T>.Filter.Eq("Id", new Guid(id));

            try
            {
                collection.FindOneAndDelete(filter);
                return true;
            }
            catch (MongoException)
            {
                return false;
            }
        }

        /// <summary>
        /// Gets all the records from a collection.
        /// </summary>
        /// <typeparam name="T">Custom object.</typeparam>
        /// <param name="collectionName">Name of collection.</param>
        /// <returns>A list of all records in selected collection.</returns>
        public List<T> GetAllRecords<T>(string collectionName)
        {
            var collection = _DB.GetCollection<T>(collectionName);
            return collection.Find(new BsonDocument()).ToList();
        }

        /// <summary>
        /// Gets a single record from the database by ID.
        /// </summary>
        /// <param name="id">ID of record.</param>
        /// <returns>Returns the record.</returns>
        public T GetRecordById<T>(string collectionName, string id)
        {
            var collection = _DB.GetCollection<T>(collectionName);
            var filter = Builders<T>.Filter.Eq("Id", new Guid(id));
            return collection.Find(filter).First();
        }
    }
}
