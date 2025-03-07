// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform
{
    internal class AppPlatformServiceRegistryOperationSource : IOperationSource<AppPlatformServiceRegistryResource>
    {
        private readonly ArmClient _client;

        internal AppPlatformServiceRegistryOperationSource(ArmClient client)
        {
            _client = client;
        }

        AppPlatformServiceRegistryResource IOperationSource<AppPlatformServiceRegistryResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<AppPlatformServiceRegistryData>(response.Content);
            return new AppPlatformServiceRegistryResource(_client, data);
        }

        async ValueTask<AppPlatformServiceRegistryResource> IOperationSource<AppPlatformServiceRegistryResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<AppPlatformServiceRegistryData>(response.Content);
            return await Task.FromResult(new AppPlatformServiceRegistryResource(_client, data)).ConfigureAwait(false);
        }
    }
}
