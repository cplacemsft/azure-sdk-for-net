// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Grafana
{
    internal class ManagedPrivateEndpointModelOperationSource : IOperationSource<ManagedPrivateEndpointModelResource>
    {
        private readonly ArmClient _client;

        internal ManagedPrivateEndpointModelOperationSource(ArmClient client)
        {
            _client = client;
        }

        ManagedPrivateEndpointModelResource IOperationSource<ManagedPrivateEndpointModelResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ManagedPrivateEndpointModelData>(response.Content);
            return new ManagedPrivateEndpointModelResource(_client, data);
        }

        async ValueTask<ManagedPrivateEndpointModelResource> IOperationSource<ManagedPrivateEndpointModelResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ManagedPrivateEndpointModelData>(response.Content);
            return await Task.FromResult(new ManagedPrivateEndpointModelResource(_client, data)).ConfigureAwait(false);
        }
    }
}
