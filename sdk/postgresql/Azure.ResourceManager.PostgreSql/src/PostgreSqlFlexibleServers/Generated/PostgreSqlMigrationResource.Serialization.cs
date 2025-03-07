// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers
{
    public partial class PostgreSqlMigrationResource : IJsonModel<PostgreSqlMigrationData>
    {
        void IJsonModel<PostgreSqlMigrationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<PostgreSqlMigrationData>)Data).Write(writer, options);

        PostgreSqlMigrationData IJsonModel<PostgreSqlMigrationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<PostgreSqlMigrationData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<PostgreSqlMigrationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        PostgreSqlMigrationData IPersistableModel<PostgreSqlMigrationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<PostgreSqlMigrationData>(data, options);

        string IPersistableModel<PostgreSqlMigrationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<PostgreSqlMigrationData>)Data).GetFormatFromOptions(options);
    }
}
