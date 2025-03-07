// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class JobTarget : IUtf8JsonSerializable, IJsonModel<JobTarget>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<JobTarget>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<JobTarget>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobTarget>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JobTarget)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(MembershipType))
            {
                writer.WritePropertyName("membershipType"u8);
                writer.WriteStringValue(MembershipType.Value.ToSerialString());
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(TargetType.ToString());
            if (Optional.IsDefined(ServerName))
            {
                writer.WritePropertyName("serverName"u8);
                writer.WriteStringValue(ServerName);
            }
            if (Optional.IsDefined(DatabaseName))
            {
                writer.WritePropertyName("databaseName"u8);
                writer.WriteStringValue(DatabaseName);
            }
            if (Optional.IsDefined(ElasticPoolName))
            {
                writer.WritePropertyName("elasticPoolName"u8);
                writer.WriteStringValue(ElasticPoolName);
            }
            if (Optional.IsDefined(ShardMapName))
            {
                writer.WritePropertyName("shardMapName"u8);
                writer.WriteStringValue(ShardMapName);
            }
            if (Optional.IsDefined(RefreshCredential))
            {
                writer.WritePropertyName("refreshCredential"u8);
                writer.WriteStringValue(RefreshCredential);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        JobTarget IJsonModel<JobTarget>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobTarget>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JobTarget)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeJobTarget(document.RootElement, options);
        }

        internal static JobTarget DeserializeJobTarget(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            JobTargetGroupMembershipType? membershipType = default;
            JobTargetType type = default;
            string serverName = default;
            string databaseName = default;
            string elasticPoolName = default;
            string shardMapName = default;
            string refreshCredential = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("membershipType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    membershipType = property.Value.GetString().ToJobTargetGroupMembershipType();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new JobTargetType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serverName"u8))
                {
                    serverName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("elasticPoolName"u8))
                {
                    elasticPoolName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("shardMapName"u8))
                {
                    shardMapName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("refreshCredential"u8))
                {
                    refreshCredential = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new JobTarget(
                membershipType,
                type,
                serverName,
                databaseName,
                elasticPoolName,
                shardMapName,
                refreshCredential,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MembershipType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  membershipType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MembershipType))
                {
                    builder.Append("  membershipType: ");
                    builder.AppendLine($"'{MembershipType.Value.ToSerialString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TargetType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  type: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  type: ");
                builder.AppendLine($"'{TargetType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ServerName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  serverName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ServerName))
                {
                    builder.Append("  serverName: ");
                    if (ServerName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ServerName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ServerName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DatabaseName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  databaseName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DatabaseName))
                {
                    builder.Append("  databaseName: ");
                    if (DatabaseName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DatabaseName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DatabaseName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ElasticPoolName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  elasticPoolName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ElasticPoolName))
                {
                    builder.Append("  elasticPoolName: ");
                    if (ElasticPoolName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ElasticPoolName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ElasticPoolName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ShardMapName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  shardMapName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ShardMapName))
                {
                    builder.Append("  shardMapName: ");
                    if (ShardMapName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ShardMapName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ShardMapName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RefreshCredential), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  refreshCredential: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RefreshCredential))
                {
                    builder.Append("  refreshCredential: ");
                    if (RefreshCredential.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{RefreshCredential}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{RefreshCredential}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<JobTarget>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobTarget>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(JobTarget)} does not support writing '{options.Format}' format.");
            }
        }

        JobTarget IPersistableModel<JobTarget>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobTarget>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeJobTarget(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(JobTarget)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<JobTarget>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
