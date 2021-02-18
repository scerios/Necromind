﻿using System.Collections.Generic;

namespace NecromindLibrary.Repository
{
    public interface IDataConnection
    {
        string TryCreateNewRecord<T>(string collectionName, T record);
        bool TryDeleteRecordById<T>(string collectionName, string id);
        List<T> GetAllRecords<T>(string collectionName);
        T GetRecordById<T>(string collectionName, string id);
    }
}
