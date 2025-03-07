// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.StandbyPool
{
    internal class StandbyVirtualMachinePoolOperationSource : IOperationSource<StandbyVirtualMachinePoolResource>
    {
        private readonly ArmClient _client;

        internal StandbyVirtualMachinePoolOperationSource(ArmClient client)
        {
            _client = client;
        }

        StandbyVirtualMachinePoolResource IOperationSource<StandbyVirtualMachinePoolResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<StandbyVirtualMachinePoolData>(response.Content);
            return new StandbyVirtualMachinePoolResource(_client, data);
        }

        async ValueTask<StandbyVirtualMachinePoolResource> IOperationSource<StandbyVirtualMachinePoolResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<StandbyVirtualMachinePoolData>(response.Content);
            return await Task.FromResult(new StandbyVirtualMachinePoolResource(_client, data)).ConfigureAwait(false);
        }
    }
}
