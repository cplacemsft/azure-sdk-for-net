// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Synapse
{
    public partial class SynapsePrivateEndpointConnectionForPrivateLinkHubResource : IJsonModel<SynapsePrivateEndpointConnectionForPrivateLinkHubData>
    {
        void IJsonModel<SynapsePrivateEndpointConnectionForPrivateLinkHubData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SynapsePrivateEndpointConnectionForPrivateLinkHubData>)Data).Write(writer, options);

        SynapsePrivateEndpointConnectionForPrivateLinkHubData IJsonModel<SynapsePrivateEndpointConnectionForPrivateLinkHubData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SynapsePrivateEndpointConnectionForPrivateLinkHubData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SynapsePrivateEndpointConnectionForPrivateLinkHubData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SynapsePrivateEndpointConnectionForPrivateLinkHubData IPersistableModel<SynapsePrivateEndpointConnectionForPrivateLinkHubData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SynapsePrivateEndpointConnectionForPrivateLinkHubData>(data, options);

        string IPersistableModel<SynapsePrivateEndpointConnectionForPrivateLinkHubData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SynapsePrivateEndpointConnectionForPrivateLinkHubData>)Data).GetFormatFromOptions(options);
    }
}
