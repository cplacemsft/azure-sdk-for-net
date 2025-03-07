// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    internal class VMwareResourcePoolOperationSource : IOperationSource<VMwareResourcePoolResource>
    {
        private readonly ArmClient _client;

        internal VMwareResourcePoolOperationSource(ArmClient client)
        {
            _client = client;
        }

        VMwareResourcePoolResource IOperationSource<VMwareResourcePoolResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<VMwareResourcePoolData>(response.Content);
            return new VMwareResourcePoolResource(_client, data);
        }

        async ValueTask<VMwareResourcePoolResource> IOperationSource<VMwareResourcePoolResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<VMwareResourcePoolData>(response.Content);
            return await Task.FromResult(new VMwareResourcePoolResource(_client, data)).ConfigureAwait(false);
        }
    }
}
