// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.DnsResolver
{
    internal class DnsResolverInboundEndpointOperationSource : IOperationSource<DnsResolverInboundEndpointResource>
    {
        private readonly ArmClient _client;

        internal DnsResolverInboundEndpointOperationSource(ArmClient client)
        {
            _client = client;
        }

        DnsResolverInboundEndpointResource IOperationSource<DnsResolverInboundEndpointResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DnsResolverInboundEndpointData>(response.Content);
            return new DnsResolverInboundEndpointResource(_client, data);
        }

        async ValueTask<DnsResolverInboundEndpointResource> IOperationSource<DnsResolverInboundEndpointResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DnsResolverInboundEndpointData>(response.Content);
            return await Task.FromResult(new DnsResolverInboundEndpointResource(_client, data)).ConfigureAwait(false);
        }
    }
}
