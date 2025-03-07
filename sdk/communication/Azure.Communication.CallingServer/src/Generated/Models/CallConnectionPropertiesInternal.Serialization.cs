// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Communication.CallingServer
{
    internal partial class CallConnectionPropertiesInternal
    {
        internal static CallConnectionPropertiesInternal DeserializeCallConnectionPropertiesInternal(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string callConnectionId = default;
            string serverCallId = default;
            CallSourceInternal source = default;
            IReadOnlyList<CommunicationIdentifierModel> targets = default;
            CallConnectionState? callConnectionState = default;
            string subject = default;
            string callbackUri = default;
            string mediaSubscriptionId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("callConnectionId"u8))
                {
                    callConnectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverCallId"u8))
                {
                    serverCallId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    source = CallSourceInternal.DeserializeCallSourceInternal(property.Value);
                    continue;
                }
                if (property.NameEquals("targets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CommunicationIdentifierModel> array = new List<CommunicationIdentifierModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(item));
                    }
                    targets = array;
                    continue;
                }
                if (property.NameEquals("callConnectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    callConnectionState = new CallConnectionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subject"u8))
                {
                    subject = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("callbackUri"u8))
                {
                    callbackUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mediaSubscriptionId"u8))
                {
                    mediaSubscriptionId = property.Value.GetString();
                    continue;
                }
            }
            return new CallConnectionPropertiesInternal(
                callConnectionId,
                serverCallId,
                source,
                targets ?? new ChangeTrackingList<CommunicationIdentifierModel>(),
                callConnectionState,
                subject,
                callbackUri,
                mediaSubscriptionId);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static CallConnectionPropertiesInternal FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeCallConnectionPropertiesInternal(document.RootElement);
        }
    }
}
