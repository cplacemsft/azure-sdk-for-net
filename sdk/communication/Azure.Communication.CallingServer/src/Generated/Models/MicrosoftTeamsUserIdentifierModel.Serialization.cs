// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Communication.CallingServer;
using Azure.Core;

namespace Azure.Communication
{
    internal partial class MicrosoftTeamsUserIdentifierModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("userId"u8);
            writer.WriteStringValue(UserId);
            if (CallingServer.Optional.IsDefined(IsAnonymous))
            {
                writer.WritePropertyName("isAnonymous"u8);
                writer.WriteBooleanValue(IsAnonymous.Value);
            }
            if (CallingServer.Optional.IsDefined(Cloud))
            {
                writer.WritePropertyName("cloud"u8);
                writer.WriteStringValue(Cloud.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static MicrosoftTeamsUserIdentifierModel DeserializeMicrosoftTeamsUserIdentifierModel(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string userId = default;
            bool? isAnonymous = default;
            CommunicationCloudEnvironmentModel? cloud = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userId"u8))
                {
                    userId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isAnonymous"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAnonymous = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cloud"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cloud = new CommunicationCloudEnvironmentModel(property.Value.GetString());
                    continue;
                }
            }
            return new MicrosoftTeamsUserIdentifierModel(userId, isAnonymous, cloud);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static MicrosoftTeamsUserIdentifierModel FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeMicrosoftTeamsUserIdentifierModel(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new CallingServer.Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
