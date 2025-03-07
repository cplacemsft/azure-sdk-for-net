// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.SecurityDevOps
{
    internal class AzureDevOpsProjectOperationSource : IOperationSource<AzureDevOpsProjectResource>
    {
        private readonly ArmClient _client;

        internal AzureDevOpsProjectOperationSource(ArmClient client)
        {
            _client = client;
        }

        AzureDevOpsProjectResource IOperationSource<AzureDevOpsProjectResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<AzureDevOpsProjectData>(response.Content);
            return new AzureDevOpsProjectResource(_client, data);
        }

        async ValueTask<AzureDevOpsProjectResource> IOperationSource<AzureDevOpsProjectResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<AzureDevOpsProjectData>(response.Content);
            return await Task.FromResult(new AzureDevOpsProjectResource(_client, data)).ConfigureAwait(false);
        }
    }
}
