// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(LinkTableRequestTargetConverter))]
    public partial class LinkTableRequestTarget : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TableName))
            {
                writer.WritePropertyName("tableName"u8);
                writer.WriteStringValue(TableName);
            }
            if (Optional.IsDefined(SchemaName))
            {
                writer.WritePropertyName("schemaName"u8);
                writer.WriteStringValue(SchemaName);
            }
            if (Optional.IsDefined(DistributionOptions))
            {
                writer.WritePropertyName("distributionOptions"u8);
                writer.WriteObjectValue(DistributionOptions);
            }
            if (Optional.IsDefined(StructureOptions))
            {
                writer.WritePropertyName("structureOptions"u8);
                writer.WriteObjectValue(StructureOptions);
            }
            writer.WriteEndObject();
        }

        internal static LinkTableRequestTarget DeserializeLinkTableRequestTarget(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string tableName = default;
            string schemaName = default;
            LinkTableRequestTargetDistributionOptions distributionOptions = default;
            LinkTableRequestTargetStructureOptions structureOptions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tableName"u8))
                {
                    tableName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schemaName"u8))
                {
                    schemaName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("distributionOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    distributionOptions = LinkTableRequestTargetDistributionOptions.DeserializeLinkTableRequestTargetDistributionOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("structureOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    structureOptions = LinkTableRequestTargetStructureOptions.DeserializeLinkTableRequestTargetStructureOptions(property.Value);
                    continue;
                }
            }
            return new LinkTableRequestTarget(tableName, schemaName, distributionOptions, structureOptions);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static LinkTableRequestTarget FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeLinkTableRequestTarget(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class LinkTableRequestTargetConverter : JsonConverter<LinkTableRequestTarget>
        {
            public override void Write(Utf8JsonWriter writer, LinkTableRequestTarget model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override LinkTableRequestTarget Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLinkTableRequestTarget(document.RootElement);
            }
        }
    }
}
