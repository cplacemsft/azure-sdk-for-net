// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class AnomalyDetectionConfigurationList
    {
        internal static AnomalyDetectionConfigurationList DeserializeAnomalyDetectionConfigurationList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<AnomalyDetectionConfiguration> value = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AnomalyDetectionConfiguration> array = new List<AnomalyDetectionConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AnomalyDetectionConfiguration.DeserializeAnomalyDetectionConfiguration(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("@nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new AnomalyDetectionConfigurationList(value ?? new ChangeTrackingList<AnomalyDetectionConfiguration>(), nextLink);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AnomalyDetectionConfigurationList FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAnomalyDetectionConfigurationList(document.RootElement);
        }
    }
}
