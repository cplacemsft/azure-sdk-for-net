// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Hci
{
    internal class HciClusterDeploymentSettingOperationSource : IOperationSource<HciClusterDeploymentSettingResource>
    {
        private readonly ArmClient _client;

        internal HciClusterDeploymentSettingOperationSource(ArmClient client)
        {
            _client = client;
        }

        HciClusterDeploymentSettingResource IOperationSource<HciClusterDeploymentSettingResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<HciClusterDeploymentSettingData>(response.Content);
            return new HciClusterDeploymentSettingResource(_client, data);
        }

        async ValueTask<HciClusterDeploymentSettingResource> IOperationSource<HciClusterDeploymentSettingResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<HciClusterDeploymentSettingData>(response.Content);
            return await Task.FromResult(new HciClusterDeploymentSettingResource(_client, data)).ConfigureAwait(false);
        }
    }
}
