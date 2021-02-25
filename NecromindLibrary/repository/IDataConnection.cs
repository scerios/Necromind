using System;
using System.Collections.Generic;

namespace NecromindLibrary.Repository
{
    public interface IDataConnection
    {
        bool TryCreateNewRecord<T>(string collectionName, T record);
        bool TryUpsertRecord<T>(string collectionName, Guid id, T record);
        bool TryDeleteRecordById<T>(string collectionName, Guid id);
        List<T> GetAllRecords<T>(string collectionName);
        T GetRecordById<T>(string collectionName, string id);
    }
}
