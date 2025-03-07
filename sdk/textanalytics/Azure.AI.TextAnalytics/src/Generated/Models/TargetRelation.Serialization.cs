// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class TargetRelation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("relationType"u8);
            writer.WriteStringValue(RelationType.ToSerialString());
            writer.WritePropertyName("ref"u8);
            writer.WriteStringValue(Ref);
            writer.WriteEndObject();
        }

        internal static TargetRelation DeserializeTargetRelation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TargetRelationType relationType = default;
            string @ref = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("relationType"u8))
                {
                    relationType = property.Value.GetString().ToTargetRelationType();
                    continue;
                }
                if (property.NameEquals("ref"u8))
                {
                    @ref = property.Value.GetString();
                    continue;
                }
            }
            return new TargetRelation(relationType, @ref);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TargetRelation FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeTargetRelation(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
