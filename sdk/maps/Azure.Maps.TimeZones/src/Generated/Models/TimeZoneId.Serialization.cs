// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.TimeZones
{
    public partial class TimeZoneId
    {
        internal static TimeZoneId DeserializeTimeZoneId(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            IReadOnlyList<string> aliases = default;
            IReadOnlyList<CountryRecord> countries = default;
            TimeZoneName names = default;
            ReferenceTime referenceTime = default;
            RepresentativePoint representativePoint = default;
            IReadOnlyList<TimeTransition> timeTransitions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Aliases"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    aliases = array;
                    continue;
                }
                if (property.NameEquals("Countries"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CountryRecord> array = new List<CountryRecord>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CountryRecord.DeserializeCountryRecord(item));
                    }
                    countries = array;
                    continue;
                }
                if (property.NameEquals("Names"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    names = TimeZoneName.DeserializeTimeZoneName(property.Value);
                    continue;
                }
                if (property.NameEquals("ReferenceTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    referenceTime = ReferenceTime.DeserializeReferenceTime(property.Value);
                    continue;
                }
                if (property.NameEquals("RepresentativePoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    representativePoint = TimeZones.RepresentativePoint.DeserializeRepresentativePoint(property.Value);
                    continue;
                }
                if (property.NameEquals("TimeTransitions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TimeTransition> array = new List<TimeTransition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TimeTransition.DeserializeTimeTransition(item));
                    }
                    timeTransitions = array;
                    continue;
                }
            }
            return new TimeZoneId(
                id,
                aliases ?? new ChangeTrackingList<string>(),
                countries ?? new ChangeTrackingList<CountryRecord>(),
                names,
                referenceTime,
                representativePoint,
                timeTransitions ?? new ChangeTrackingList<TimeTransition>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TimeZoneId FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeTimeZoneId(document.RootElement);
        }
    }
}
