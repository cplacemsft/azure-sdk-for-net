// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric
{
    internal class ServiceFabricClusterOperationSource : IOperationSource<ServiceFabricClusterResource>
    {
        private readonly ArmClient _client;

        internal ServiceFabricClusterOperationSource(ArmClient client)
        {
            _client = client;
        }

        ServiceFabricClusterResource IOperationSource<ServiceFabricClusterResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ServiceFabricClusterData>(response.Content);
            return new ServiceFabricClusterResource(_client, data);
        }

        async ValueTask<ServiceFabricClusterResource> IOperationSource<ServiceFabricClusterResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ServiceFabricClusterData>(response.Content);
            return await Task.FromResult(new ServiceFabricClusterResource(_client, data)).ConfigureAwait(false);
        }
    }
}
