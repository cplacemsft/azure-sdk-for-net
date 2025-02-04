// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class AcsRouterWorkerSelector
    {
        internal static AcsRouterWorkerSelector DeserializeAcsRouterWorkerSelector(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string key = default;
            AcsRouterLabelOperator? labelOperator = default;
            object labelValue = default;
            float? ttlSeconds = default;
            AcsRouterWorkerSelectorState? state = default;
            DateTimeOffset? expirationTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("labelOperator"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    labelOperator = new AcsRouterLabelOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("labelValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    labelValue = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("ttlSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ttlSeconds = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new AcsRouterWorkerSelectorState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("expirationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expirationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new AcsRouterWorkerSelector(
                key,
                labelOperator,
                labelValue,
                ttlSeconds,
                state,
                expirationTime);
        }
    }
}
