// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Network
{
    internal class HubRouteTableOperationSource : IOperationSource<HubRouteTableResource>
    {
        private readonly ArmClient _client;

        internal HubRouteTableOperationSource(ArmClient client)
        {
            _client = client;
        }

        HubRouteTableResource IOperationSource<HubRouteTableResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<HubRouteTableData>(response.Content);
            return new HubRouteTableResource(_client, data);
        }

        async ValueTask<HubRouteTableResource> IOperationSource<HubRouteTableResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<HubRouteTableData>(response.Content);
            return await Task.FromResult(new HubRouteTableResource(_client, data)).ConfigureAwait(false);
        }
    }
}
