// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning
{
    internal class MachineLearningFeatureSetContainerOperationSource : IOperationSource<MachineLearningFeatureSetContainerResource>
    {
        private readonly ArmClient _client;

        internal MachineLearningFeatureSetContainerOperationSource(ArmClient client)
        {
            _client = client;
        }

        MachineLearningFeatureSetContainerResource IOperationSource<MachineLearningFeatureSetContainerResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<MachineLearningFeatureSetContainerData>(response.Content);
            return new MachineLearningFeatureSetContainerResource(_client, data);
        }

        async ValueTask<MachineLearningFeatureSetContainerResource> IOperationSource<MachineLearningFeatureSetContainerResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<MachineLearningFeatureSetContainerData>(response.Content);
            return await Task.FromResult(new MachineLearningFeatureSetContainerResource(_client, data)).ConfigureAwait(false);
        }
    }
}
