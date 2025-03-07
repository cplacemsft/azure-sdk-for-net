// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Batch
{
    internal class BatchAccountOperationSource : IOperationSource<BatchAccountResource>
    {
        private readonly ArmClient _client;

        internal BatchAccountOperationSource(ArmClient client)
        {
            _client = client;
        }

        BatchAccountResource IOperationSource<BatchAccountResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<BatchAccountData>(response.Content);
            return new BatchAccountResource(_client, data);
        }

        async ValueTask<BatchAccountResource> IOperationSource<BatchAccountResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<BatchAccountData>(response.Content);
            return await Task.FromResult(new BatchAccountResource(_client, data)).ConfigureAwait(false);
        }
    }
}
