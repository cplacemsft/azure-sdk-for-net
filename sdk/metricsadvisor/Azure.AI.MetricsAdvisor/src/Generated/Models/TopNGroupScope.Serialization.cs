// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class TopNGroupScope : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("top"u8);
            writer.WriteNumberValue(Top);
            writer.WritePropertyName("period"u8);
            writer.WriteNumberValue(Period);
            writer.WritePropertyName("minTopCount"u8);
            writer.WriteNumberValue(MinimumTopCount);
            writer.WriteEndObject();
        }

        internal static TopNGroupScope DeserializeTopNGroupScope(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int top = default;
            int period = default;
            int minTopCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("top"u8))
                {
                    top = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("period"u8))
                {
                    period = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minTopCount"u8))
                {
                    minTopCount = property.Value.GetInt32();
                    continue;
                }
            }
            return new TopNGroupScope(top, period, minTopCount);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TopNGroupScope FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeTopNGroupScope(document.RootElement);
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
