// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(EventHubCaptureFileCreatedEventDataConverter))]
    public partial class EventHubCaptureFileCreatedEventData
    {
        internal static EventHubCaptureFileCreatedEventData DeserializeEventHubCaptureFileCreatedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string fileUrl = default;
            string fileType = default;
            string partitionId = default;
            int? sizeInBytes = default;
            int? eventCount = default;
            int? firstSequenceNumber = default;
            int? lastSequenceNumber = default;
            DateTimeOffset? firstEnqueueTime = default;
            DateTimeOffset? lastEnqueueTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fileUrl"u8))
                {
                    fileUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fileType"u8))
                {
                    fileType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("partitionId"u8))
                {
                    partitionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sizeInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sizeInBytes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("eventCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("firstSequenceNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firstSequenceNumber = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("lastSequenceNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSequenceNumber = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("firstEnqueueTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firstEnqueueTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastEnqueueTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastEnqueueTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new EventHubCaptureFileCreatedEventData(
                fileUrl,
                fileType,
                partitionId,
                sizeInBytes,
                eventCount,
                firstSequenceNumber,
                lastSequenceNumber,
                firstEnqueueTime,
                lastEnqueueTime);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static EventHubCaptureFileCreatedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeEventHubCaptureFileCreatedEventData(document.RootElement);
        }

        internal partial class EventHubCaptureFileCreatedEventDataConverter : JsonConverter<EventHubCaptureFileCreatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, EventHubCaptureFileCreatedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override EventHubCaptureFileCreatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventHubCaptureFileCreatedEventData(document.RootElement);
            }
        }
    }
}
