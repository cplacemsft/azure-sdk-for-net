// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Redis
{
    internal class RedisCacheAccessPolicyAssignmentOperationSource : IOperationSource<RedisCacheAccessPolicyAssignmentResource>
    {
        private readonly ArmClient _client;

        internal RedisCacheAccessPolicyAssignmentOperationSource(ArmClient client)
        {
            _client = client;
        }

        RedisCacheAccessPolicyAssignmentResource IOperationSource<RedisCacheAccessPolicyAssignmentResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<RedisCacheAccessPolicyAssignmentData>(response.Content);
            return new RedisCacheAccessPolicyAssignmentResource(_client, data);
        }

        async ValueTask<RedisCacheAccessPolicyAssignmentResource> IOperationSource<RedisCacheAccessPolicyAssignmentResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<RedisCacheAccessPolicyAssignmentData>(response.Content);
            return await Task.FromResult(new RedisCacheAccessPolicyAssignmentResource(_client, data)).ConfigureAwait(false);
        }
    }
}
