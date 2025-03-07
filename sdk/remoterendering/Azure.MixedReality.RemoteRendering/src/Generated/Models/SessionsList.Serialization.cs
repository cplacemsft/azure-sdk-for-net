// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.MixedReality.RemoteRendering
{
    internal partial class SessionsList
    {
        internal static SessionsList DeserializeSessionsList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<RenderingSession> sessions = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sessions"u8))
                {
                    List<RenderingSession> array = new List<RenderingSession>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RenderingSession.DeserializeRenderingSession(item));
                    }
                    sessions = array;
                    continue;
                }
                if (property.NameEquals("@nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new SessionsList(sessions, nextLink);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SessionsList FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeSessionsList(document.RootElement);
        }
    }
}
