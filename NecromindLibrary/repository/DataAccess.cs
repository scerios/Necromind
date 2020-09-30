﻿using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using MongoDB.Driver;
using System;
using MongoDB.Bson;
using NecromindLibrary.helper;
using NecromindLibrary.service;

namespace NecromindLibrary.repository
{
    public class DataAccess
    {
        private UIHandler UIHandler;
        private UIHelper UIHelper;

        // DB error title
        private readonly string DBError = "Database error";

        // Client and database to use MongoDB
        private readonly MongoClient Client = new MongoClient();
        private readonly IMongoDatabase DB;

        public DataAccess(UIHandler UIHandler, UIHelper UIHelper)
        {
            this.UIHandler = UIHandler;
            this.UIHelper = UIHelper;
            DB = Client.GetDatabase(ConfigurationManager.AppSettings["databaseName"]);
        }

        /// <summary>
        /// Creates a new record in the given collection.
        /// </summary>
        /// <typeparam name="T">Custom object.</typeparam>
        /// <param name="collectionName">Name of collection.</param>
        /// <param name="record">The object to be added.</param>
        /// <returns>An automatically generated Guid for the record OR an empty one upon some DB error.</returns>
        public Guid TryCreateNewRecord<T>(string collectionName, T record)
        {
            var collection = DB.GetCollection<T>(collectionName);

            try
            {
                collection.InsertOne(record);
                return record.ToBsonDocument().GetElement("_id").Value.AsGuid;
            }
            catch (MongoException e)
            {
                UIHandler.DisplayError(DBError, e.Message);
                return new Guid();
            }
        }

        /// <summary>
        /// Deletes a record from the database by ID.
        /// </summary>
        /// <param name="id">ID of record.</param>
        /// <returns>True if successfully deleted. False otherwise.</returns>
        public bool TryDeleteRecordById<T>(string collectionName, Guid id)
        {
            var collection = DB.GetCollection<T>(collectionName);
            var filter = Builders<T>.Filter.Eq("Id", id);

            try
            {
                collection.FindOneAndDelete(filter);
                return true;
            }
            catch (MongoException e)
            {
                UIHandler.DisplayError(DBError, e.Message);
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
            var collection = DB.GetCollection<T>(collectionName);
            return collection.Find(new BsonDocument()).ToList();
        }

        /// <summary>
        /// Gets a single record from the database by ID.
        /// </summary>
        /// <param name="id">ID of record.</param>
        /// <returns>Returns the record.</returns>
        public T GetRecordById<T>(string collectionName, Guid id)
        {
            var collection = DB.GetCollection<T>(collectionName);
            var filter = Builders<T>.Filter.Eq("Id", id);
            return collection.Find(filter).First();
        }
    }
}
