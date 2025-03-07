// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AcsRouterJobReceivedEventDataConverter))]
    public partial class AcsRouterJobReceivedEventData
    {
        internal static AcsRouterJobReceivedEventData DeserializeAcsRouterJobReceivedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AcsRouterJobStatus? jobStatus = default;
            string classificationPolicyId = default;
            int? priority = default;
            IReadOnlyList<AcsRouterWorkerSelector> requestedWorkerSelectors = default;
            DateTimeOffset? scheduledOn = default;
            bool unavailableForMatching = default;
            string queueId = default;
            IReadOnlyDictionary<string, string> labels = default;
            IReadOnlyDictionary<string, string> tags = default;
            string jobId = default;
            string channelReference = default;
            string channelId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobStatus = new AcsRouterJobStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("classificationPolicyId"u8))
                {
                    classificationPolicyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("priority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("requestedWorkerSelectors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AcsRouterWorkerSelector> array = new List<AcsRouterWorkerSelector>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AcsRouterWorkerSelector.DeserializeAcsRouterWorkerSelector(item));
                    }
                    requestedWorkerSelectors = array;
                    continue;
                }
                if (property.NameEquals("scheduledOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduledOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("unavailableForMatching"u8))
                {
                    unavailableForMatching = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("queueId"u8))
                {
                    queueId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("labels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    labels = dictionary;
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("jobId"u8))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelReference"u8))
                {
                    channelReference = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelId"u8))
                {
                    channelId = property.Value.GetString();
                    continue;
                }
            }
            return new AcsRouterJobReceivedEventData(
                jobId,
                channelReference,
                channelId,
                queueId,
                labels ?? new ChangeTrackingDictionary<string, string>(),
                tags ?? new ChangeTrackingDictionary<string, string>(),
                jobStatus,
                classificationPolicyId,
                priority,
                requestedWorkerSelectors ?? new ChangeTrackingList<AcsRouterWorkerSelector>(),
                scheduledOn,
                unavailableForMatching);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new AcsRouterJobReceivedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAcsRouterJobReceivedEventData(document.RootElement);
        }

        internal partial class AcsRouterJobReceivedEventDataConverter : JsonConverter<AcsRouterJobReceivedEventData>
        {
            public override void Write(Utf8JsonWriter writer, AcsRouterJobReceivedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override AcsRouterJobReceivedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsRouterJobReceivedEventData(document.RootElement);
            }
        }
    }
}
