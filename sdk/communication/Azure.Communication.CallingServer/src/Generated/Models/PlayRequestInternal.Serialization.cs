// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    internal partial class PlayRequestInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("playSourceInfo"u8);
            writer.WriteObjectValue(PlaySourceInfo);
            if (Optional.IsCollectionDefined(PlayTo))
            {
                writer.WritePropertyName("playTo"u8);
                writer.WriteStartArray();
                foreach (var item in PlayTo)
                {
                    writer.WriteObjectValue<CommunicationIdentifierModel>(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PlayOptions))
            {
                writer.WritePropertyName("playOptions"u8);
                writer.WriteObjectValue(PlayOptions);
            }
            if (Optional.IsDefined(OperationContext))
            {
                writer.WritePropertyName("operationContext"u8);
                writer.WriteStringValue(OperationContext);
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
