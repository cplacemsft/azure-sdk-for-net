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
    internal class DataBoxEdgeUserOperationSource : IOperationSource<DataBoxEdgeUserResource>
    {
        private readonly ArmClient _client;

        internal DataBoxEdgeUserOperationSource(ArmClient client)
        {
            _client = client;
        }

        DataBoxEdgeUserResource IOperationSource<DataBoxEdgeUserResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DataBoxEdgeUserData>(response.Content);
            return new DataBoxEdgeUserResource(_client, data);
        }

        async ValueTask<DataBoxEdgeUserResource> IOperationSource<DataBoxEdgeUserResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DataBoxEdgeUserData>(response.Content);
            return await Task.FromResult(new DataBoxEdgeUserResource(_client, data)).ConfigureAwait(false);
        }
    }
}
