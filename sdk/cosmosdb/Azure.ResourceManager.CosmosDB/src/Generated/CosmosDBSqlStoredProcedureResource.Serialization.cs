// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.CosmosDB
{
    public partial class CosmosDBSqlStoredProcedureResource : IJsonModel<CosmosDBSqlStoredProcedureData>
    {
        void IJsonModel<CosmosDBSqlStoredProcedureData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<CosmosDBSqlStoredProcedureData>)Data).Write(writer, options);

        CosmosDBSqlStoredProcedureData IJsonModel<CosmosDBSqlStoredProcedureData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<CosmosDBSqlStoredProcedureData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<CosmosDBSqlStoredProcedureData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        CosmosDBSqlStoredProcedureData IPersistableModel<CosmosDBSqlStoredProcedureData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<CosmosDBSqlStoredProcedureData>(data, options);

        string IPersistableModel<CosmosDBSqlStoredProcedureData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<CosmosDBSqlStoredProcedureData>)Data).GetFormatFromOptions(options);
    }
}
