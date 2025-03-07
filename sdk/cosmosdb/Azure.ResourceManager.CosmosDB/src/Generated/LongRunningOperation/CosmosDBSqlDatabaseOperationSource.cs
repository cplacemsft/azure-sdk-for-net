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
    internal class CosmosDBSqlDatabaseOperationSource : IOperationSource<CosmosDBSqlDatabaseResource>
    {
        private readonly ArmClient _client;

        internal CosmosDBSqlDatabaseOperationSource(ArmClient client)
        {
            _client = client;
        }

        CosmosDBSqlDatabaseResource IOperationSource<CosmosDBSqlDatabaseResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<CosmosDBSqlDatabaseData>(response.Content);
            return new CosmosDBSqlDatabaseResource(_client, data);
        }

        async ValueTask<CosmosDBSqlDatabaseResource> IOperationSource<CosmosDBSqlDatabaseResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<CosmosDBSqlDatabaseData>(response.Content);
            return await Task.FromResult(new CosmosDBSqlDatabaseResource(_client, data)).ConfigureAwait(false);
        }
    }
}
