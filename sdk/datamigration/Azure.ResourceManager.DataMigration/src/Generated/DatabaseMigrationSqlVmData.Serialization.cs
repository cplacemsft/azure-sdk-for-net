// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataMigration.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataMigration
{
    public partial class DatabaseMigrationSqlVmData : IUtf8JsonSerializable, IJsonModel<DatabaseMigrationSqlVmData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DatabaseMigrationSqlVmData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DatabaseMigrationSqlVmData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseMigrationSqlVmData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatabaseMigrationSqlVmData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteObjectValue(Properties, options);
            }
        }

        DatabaseMigrationSqlVmData IJsonModel<DatabaseMigrationSqlVmData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseMigrationSqlVmData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatabaseMigrationSqlVmData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDatabaseMigrationSqlVmData(document.RootElement, options);
        }

        internal static DatabaseMigrationSqlVmData DeserializeDatabaseMigrationSqlVmData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DatabaseMigrationSqlVmProperties properties = default;
            ResourceIdentifier id = default;
            string name = default;
            Core.ResourceType type = default;
            SystemData systemData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = DatabaseMigrationSqlVmProperties.DeserializeDatabaseMigrationSqlVmProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new Core.ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DatabaseMigrationSqlVmData(
                id,
                name,
                type,
                systemData,
                properties,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DatabaseMigrationSqlVmData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseMigrationSqlVmData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DatabaseMigrationSqlVmData)} does not support writing '{options.Format}' format.");
            }
        }

        DatabaseMigrationSqlVmData IPersistableModel<DatabaseMigrationSqlVmData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseMigrationSqlVmData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDatabaseMigrationSqlVmData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DatabaseMigrationSqlVmData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DatabaseMigrationSqlVmData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
