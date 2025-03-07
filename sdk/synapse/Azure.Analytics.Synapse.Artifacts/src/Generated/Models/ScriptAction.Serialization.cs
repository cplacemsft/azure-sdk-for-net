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
    [JsonConverter(typeof(ScriptActionConverter))]
    public partial class ScriptAction : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("uri"u8);
            writer.WriteStringValue(Uri);
            writer.WritePropertyName("roles"u8);
            writer.WriteObjectValue<object>(Roles);
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStringValue(Parameters);
            }
            writer.WriteEndObject();
        }

        internal static ScriptAction DeserializeScriptAction(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string uri = default;
            object roles = default;
            string parameters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("uri"u8))
                {
                    uri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("roles"u8))
                {
                    roles = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    parameters = property.Value.GetString();
                    continue;
                }
            }
            return new ScriptAction(name, uri, roles, parameters);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ScriptAction FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeScriptAction(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class ScriptActionConverter : JsonConverter<ScriptAction>
        {
            public override void Write(Utf8JsonWriter writer, ScriptAction model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override ScriptAction Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeScriptAction(document.RootElement);
            }
        }
    }
}
