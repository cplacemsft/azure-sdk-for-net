// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.MySql
{
    internal class MySqlServerOperationSource : IOperationSource<MySqlServerResource>
    {
        private readonly ArmClient _client;

        internal MySqlServerOperationSource(ArmClient client)
        {
            _client = client;
        }

        MySqlServerResource IOperationSource<MySqlServerResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<MySqlServerData>(response.Content);
            return new MySqlServerResource(_client, data);
        }

        async ValueTask<MySqlServerResource> IOperationSource<MySqlServerResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<MySqlServerData>(response.Content);
            return await Task.FromResult(new MySqlServerResource(_client, data)).ConfigureAwait(false);
        }
    }
}
