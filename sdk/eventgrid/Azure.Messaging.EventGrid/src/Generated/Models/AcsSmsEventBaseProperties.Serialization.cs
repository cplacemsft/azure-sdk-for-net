// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class AcsSmsEventBaseProperties
    {
        internal static AcsSmsEventBaseProperties DeserializeAcsSmsEventBaseProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string messageId = default;
            string @from = default;
            string to = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("messageId"u8))
                {
                    messageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("from"u8))
                {
                    @from = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("to"u8))
                {
                    to = property.Value.GetString();
                    continue;
                }
            }
            return new AcsSmsEventBaseProperties(messageId, @from, to);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AcsSmsEventBaseProperties FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAcsSmsEventBaseProperties(document.RootElement);
        }
    }
}
