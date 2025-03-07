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
    internal class CosmosDBTableRoleDefinitionOperationSource : IOperationSource<CosmosDBTableRoleDefinitionResource>
    {
        private readonly ArmClient _client;

        internal CosmosDBTableRoleDefinitionOperationSource(ArmClient client)
        {
            _client = client;
        }

        CosmosDBTableRoleDefinitionResource IOperationSource<CosmosDBTableRoleDefinitionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<CosmosDBTableRoleDefinitionData>(response.Content);
            return new CosmosDBTableRoleDefinitionResource(_client, data);
        }

        async ValueTask<CosmosDBTableRoleDefinitionResource> IOperationSource<CosmosDBTableRoleDefinitionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<CosmosDBTableRoleDefinitionData>(response.Content);
            return await Task.FromResult(new CosmosDBTableRoleDefinitionResource(_client, data)).ConfigureAwait(false);
        }
    }
}
