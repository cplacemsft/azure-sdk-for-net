// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge
{
    internal class DataBoxEdgeOrderOperationSource : IOperationSource<DataBoxEdgeOrderResource>
    {
        private readonly ArmClient _client;

        internal DataBoxEdgeOrderOperationSource(ArmClient client)
        {
            _client = client;
        }

        DataBoxEdgeOrderResource IOperationSource<DataBoxEdgeOrderResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DataBoxEdgeOrderData>(response.Content);
            return new DataBoxEdgeOrderResource(_client, data);
        }

        async ValueTask<DataBoxEdgeOrderResource> IOperationSource<DataBoxEdgeOrderResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DataBoxEdgeOrderData>(response.Content);
            return await Task.FromResult(new DataBoxEdgeOrderResource(_client, data)).ConfigureAwait(false);
        }
    }
}
