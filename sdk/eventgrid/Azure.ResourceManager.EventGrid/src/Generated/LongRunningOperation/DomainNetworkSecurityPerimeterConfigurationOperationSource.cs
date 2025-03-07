// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid
{
    internal class DomainNetworkSecurityPerimeterConfigurationOperationSource : IOperationSource<DomainNetworkSecurityPerimeterConfigurationResource>
    {
        private readonly ArmClient _client;

        internal DomainNetworkSecurityPerimeterConfigurationOperationSource(ArmClient client)
        {
            _client = client;
        }

        DomainNetworkSecurityPerimeterConfigurationResource IOperationSource<DomainNetworkSecurityPerimeterConfigurationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<NetworkSecurityPerimeterConfigurationData>(response.Content);
            return new DomainNetworkSecurityPerimeterConfigurationResource(_client, data);
        }

        async ValueTask<DomainNetworkSecurityPerimeterConfigurationResource> IOperationSource<DomainNetworkSecurityPerimeterConfigurationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<NetworkSecurityPerimeterConfigurationData>(response.Content);
            return await Task.FromResult(new DomainNetworkSecurityPerimeterConfigurationResource(_client, data)).ConfigureAwait(false);
        }
    }
}
