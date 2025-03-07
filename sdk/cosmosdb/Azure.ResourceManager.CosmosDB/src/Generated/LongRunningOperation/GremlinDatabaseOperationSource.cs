// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB
{
    internal class GremlinDatabaseOperationSource : IOperationSource<GremlinDatabaseResource>
    {
        private readonly ArmClient _client;

        internal GremlinDatabaseOperationSource(ArmClient client)
        {
            _client = client;
        }

        GremlinDatabaseResource IOperationSource<GremlinDatabaseResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<GremlinDatabaseData>(response.Content);
            return new GremlinDatabaseResource(_client, data);
        }

        async ValueTask<GremlinDatabaseResource> IOperationSource<GremlinDatabaseResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<GremlinDatabaseData>(response.Content);
            return await Task.FromResult(new GremlinDatabaseResource(_client, data)).ConfigureAwait(false);
        }
    }
}
