// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.Weather.Models
{
    public partial class DailyForecast
    {
        internal static DailyForecast DeserializeDailyForecast(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? date = default;
            WeatherValueRange temperature = default;
            WeatherValueRange realFeelTemperature = default;
            WeatherValueRange realFeelTemperatureShade = default;
            float? hoursOfSun = default;
            DegreeDaySummary degreeDaySummary = default;
            IReadOnlyList<AirAndPollen> airAndPollen = default;
            DailyForecastDetail day = default;
            DailyForecastDetail night = default;
            IReadOnlyList<string> sources = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("date"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    date = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("temperature"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    temperature = WeatherValueRange.DeserializeWeatherValueRange(property.Value);
                    continue;
                }
                if (property.NameEquals("realFeelTemperature"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    realFeelTemperature = WeatherValueRange.DeserializeWeatherValueRange(property.Value);
                    continue;
                }
                if (property.NameEquals("realFeelTemperatureShade"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    realFeelTemperatureShade = WeatherValueRange.DeserializeWeatherValueRange(property.Value);
                    continue;
                }
                if (property.NameEquals("hoursOfSun"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hoursOfSun = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("degreeDaySummary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    degreeDaySummary = DegreeDaySummary.DeserializeDegreeDaySummary(property.Value);
                    continue;
                }
                if (property.NameEquals("airAndPollen"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AirAndPollen> array = new List<AirAndPollen>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AirAndPollen.DeserializeAirAndPollen(item));
                    }
                    airAndPollen = array;
                    continue;
                }
                if (property.NameEquals("day"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    day = DailyForecastDetail.DeserializeDailyForecastDetail(property.Value);
                    continue;
                }
                if (property.NameEquals("night"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    night = DailyForecastDetail.DeserializeDailyForecastDetail(property.Value);
                    continue;
                }
                if (property.NameEquals("sources"u8))
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
                    sources = array;
                    continue;
                }
            }
            return new DailyForecast(
                date,
                temperature,
                realFeelTemperature,
                realFeelTemperatureShade,
                hoursOfSun,
                degreeDaySummary,
                airAndPollen ?? new ChangeTrackingList<AirAndPollen>(),
                day,
                night,
                sources ?? new ChangeTrackingList<string>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DailyForecast FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeDailyForecast(document.RootElement);
        }
    }
}
