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
    [JsonConverter(typeof(DependencyReferenceConverter))]
    public partial class DependencyReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }

        internal static DependencyReference DeserializeDependencyReference(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "SelfDependencyTumblingWindowTriggerReference": return SelfDependencyTumblingWindowTriggerReference.DeserializeSelfDependencyTumblingWindowTriggerReference(element);
                    case "TriggerDependencyReference": return TriggerDependencyReference.DeserializeTriggerDependencyReference(element);
                    case "TumblingWindowTriggerDependencyReference": return TumblingWindowTriggerDependencyReference.DeserializeTumblingWindowTriggerDependencyReference(element);
                }
            }
            return UnknownDependencyReference.DeserializeUnknownDependencyReference(element);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DependencyReference FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeDependencyReference(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class DependencyReferenceConverter : JsonConverter<DependencyReference>
        {
            public override void Write(Utf8JsonWriter writer, DependencyReference model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override DependencyReference Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDependencyReference(document.RootElement);
            }
        }
    }
}
