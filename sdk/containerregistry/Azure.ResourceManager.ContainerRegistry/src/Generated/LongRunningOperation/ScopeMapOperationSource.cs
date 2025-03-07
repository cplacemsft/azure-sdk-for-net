// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry
{
    internal class ScopeMapOperationSource : IOperationSource<ScopeMapResource>
    {
        private readonly ArmClient _client;

        internal ScopeMapOperationSource(ArmClient client)
        {
            _client = client;
        }

        ScopeMapResource IOperationSource<ScopeMapResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ScopeMapData>(response.Content);
            return new ScopeMapResource(_client, data);
        }

        async ValueTask<ScopeMapResource> IOperationSource<ScopeMapResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ScopeMapData>(response.Content);
            return await Task.FromResult(new ScopeMapResource(_client, data)).ConfigureAwait(false);
        }
    }
}
