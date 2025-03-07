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
    [JsonConverter(typeof(LinkConnectionTargetDatabaseConverter))]
    public partial class LinkConnectionTargetDatabase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LinkedService))
            {
                writer.WritePropertyName("linkedService"u8);
                writer.WriteObjectValue(LinkedService);
            }
            if (Optional.IsDefined(TypeProperties))
            {
                writer.WritePropertyName("typeProperties"u8);
                writer.WriteObjectValue(TypeProperties);
            }
            writer.WriteEndObject();
        }

        internal static LinkConnectionTargetDatabase DeserializeLinkConnectionTargetDatabase(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LinkedServiceReference linkedService = default;
            LinkConnectionTargetDatabaseTypeProperties typeProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkedService = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    typeProperties = LinkConnectionTargetDatabaseTypeProperties.DeserializeLinkConnectionTargetDatabaseTypeProperties(property.Value);
                    continue;
                }
            }
            return new LinkConnectionTargetDatabase(linkedService, typeProperties);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static LinkConnectionTargetDatabase FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeLinkConnectionTargetDatabase(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class LinkConnectionTargetDatabaseConverter : JsonConverter<LinkConnectionTargetDatabase>
        {
            public override void Write(Utf8JsonWriter writer, LinkConnectionTargetDatabase model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override LinkConnectionTargetDatabase Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLinkConnectionTargetDatabase(document.RootElement);
            }
        }
    }
}
