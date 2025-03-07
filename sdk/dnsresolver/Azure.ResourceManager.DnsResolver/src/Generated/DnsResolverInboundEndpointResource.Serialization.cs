// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DnsResolver
{
    public partial class DnsResolverInboundEndpointResource : IJsonModel<DnsResolverInboundEndpointData>
    {
        void IJsonModel<DnsResolverInboundEndpointData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DnsResolverInboundEndpointData>)Data).Write(writer, options);

        DnsResolverInboundEndpointData IJsonModel<DnsResolverInboundEndpointData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DnsResolverInboundEndpointData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<DnsResolverInboundEndpointData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        DnsResolverInboundEndpointData IPersistableModel<DnsResolverInboundEndpointData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DnsResolverInboundEndpointData>(data, options);

        string IPersistableModel<DnsResolverInboundEndpointData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DnsResolverInboundEndpointData>)Data).GetFormatFromOptions(options);
    }
}
