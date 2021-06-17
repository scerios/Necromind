using MongoDB.Bson;
using MongoDB.Driver;
using NecromindLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

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
        /// Tries to creates a new record in the given collection.
        /// </summary>
        /// <typeparam name="T">Custom type.</typeparam>
        /// <param name="collectionName">Name of collection.</param>
        /// <param name="record">The object to be added.</param>
        /// <returns>True if insertion is successful. False otherwise.</returns>
        public bool TryCreateNewRecord<T>(string collectionName, T record)
        {
            var collection = _DB.GetCollection<T>(collectionName);

            try
            {
                collection.InsertOne(record);
                return true;
            }
            catch (MongoException)
            {
                return false;
            }
        }

        /// <summary>
        /// Tries to upsert a record by ID in the given collection.
        /// </summary>
        /// <typeparam name="T">Custom type.</typeparam>
        /// <param name="collectionName">Name of collection.</param>
        /// <param name="id">ID of the record.</param>
        /// <param name="record">The object to be updated</param>
        /// <returns>True if upsertion is successfull. False otherwise.</returns>
        public bool TryUpsertRecord<T>(string collectionName, Guid id, T record)
        {
            var collection = _DB.GetCollection<T>(collectionName);
            var filter = Builders<T>.Filter.Eq("Id", id);

            try
            {
                collection.ReplaceOne(filter, record);
                return true;
            }
            catch (MongoException)
            {
                return false;
            }
        }

        /// <summary>
        /// Tries to delete a record by ID in the given collection.
        /// </summary>
        /// <param name="collectionName">Name of collection.</param>
        /// <param name="id">ID of record.</param>
        /// <returns>True if successfully deleted. False otherwise.</returns>
        public bool TryDeleteRecordById<T>(string collectionName, Guid id)
        {
            var collection = _DB.GetCollection<T>(collectionName);
            var filter = Builders<T>.Filter.Eq("Id", id);

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
        /// <typeparam name="T">Custom type.</typeparam>
        /// <param name="collectionName">Name of collection.</param>
        /// <returns>A list of all records in selected collection.</returns>
        public List<T> GetAllRecords<T>(string collectionName)
        {
            var collection = _DB.GetCollection<T>(collectionName);
            return collection.Find(new BsonDocument()).ToList();
        }

        /// <summary>
        /// Gets a single record from the collection by ID.
        /// </summary>
        /// <param name="collectionName">ID of record.</param>
        /// <param name="id">ID of record.</param>
        /// <returns>Returns the record.</returns>
        public T GetRecordById<T>(string collectionName, string id)
        {
            var collection = _DB.GetCollection<T>(collectionName);
            var filter = Builders<T>.Filter.Eq("Id", new Guid(id));
            return collection.Find(filter).First();
        }

        /// <summary>
        /// Gets a single map tile by its coordinates on X and Y axes.
        /// </summary>
        /// <param name="collectionName">Name of collection.</param>
        /// <param name="x">Coordinate on X axis.</param>
        /// <param name="y">Coordinate on Y axis.</param>
        /// <returns>Map tile on given axes.</returns>
        public MapTileModel GetTileByCoordinates(string collectionName, int x, int y)
        {
            var collection = _DB.GetCollection<MapTileModel>(collectionName);
            var builder = Builders<MapTileModel>.Filter;
            var filter = builder.And(builder.Eq("X", x), builder.Eq("Y", y));
            return collection.Find(filter).FirstOrDefault();
        }
    }
}