// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.AppConfiguration
{
    internal class AppConfigurationSnapshotOperationSource : IOperationSource<AppConfigurationSnapshotResource>
    {
        private readonly ArmClient _client;

        internal AppConfigurationSnapshotOperationSource(ArmClient client)
        {
            _client = client;
        }

        AppConfigurationSnapshotResource IOperationSource<AppConfigurationSnapshotResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<AppConfigurationSnapshotData>(response.Content);
            return new AppConfigurationSnapshotResource(_client, data);
        }

        async ValueTask<AppConfigurationSnapshotResource> IOperationSource<AppConfigurationSnapshotResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<AppConfigurationSnapshotData>(response.Content);
            return await Task.FromResult(new AppConfigurationSnapshotResource(_client, data)).ConfigureAwait(false);
        }
    }
}
