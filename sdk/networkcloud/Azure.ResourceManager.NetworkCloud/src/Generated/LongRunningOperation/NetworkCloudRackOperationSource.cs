// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud
{
    internal class NetworkCloudRackOperationSource : IOperationSource<NetworkCloudRackResource>
    {
        private readonly ArmClient _client;

        internal NetworkCloudRackOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetworkCloudRackResource IOperationSource<NetworkCloudRackResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<NetworkCloudRackData>(response.Content);
            return new NetworkCloudRackResource(_client, data);
        }

        async ValueTask<NetworkCloudRackResource> IOperationSource<NetworkCloudRackResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<NetworkCloudRackData>(response.Content);
            return await Task.FromResult(new NetworkCloudRackResource(_client, data)).ConfigureAwait(false);
        }
    }
}
