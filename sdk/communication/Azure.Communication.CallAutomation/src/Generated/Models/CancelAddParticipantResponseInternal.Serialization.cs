// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Communication.CallAutomation
{
    internal partial class CancelAddParticipantResponseInternal
    {
        internal static CancelAddParticipantResponseInternal DeserializeCancelAddParticipantResponseInternal(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string invitationId = default;
            string operationContext = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("invitationId"u8))
                {
                    invitationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationContext"u8))
                {
                    operationContext = property.Value.GetString();
                    continue;
                }
            }
            return new CancelAddParticipantResponseInternal(invitationId, operationContext);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static CancelAddParticipantResponseInternal FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeCancelAddParticipantResponseInternal(document.RootElement);
        }
    }
}
