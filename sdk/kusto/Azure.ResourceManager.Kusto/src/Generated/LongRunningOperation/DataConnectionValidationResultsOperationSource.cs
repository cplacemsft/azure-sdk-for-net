// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.Kusto.Models;

namespace Azure.ResourceManager.Kusto
{
    internal class DataConnectionValidationResultsOperationSource : IOperationSource<DataConnectionValidationResults>
    {
        DataConnectionValidationResults IOperationSource<DataConnectionValidationResults>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
            return DataConnectionValidationResults.DeserializeDataConnectionValidationResults(document.RootElement);
        }

        async ValueTask<DataConnectionValidationResults> IOperationSource<DataConnectionValidationResults>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
            return DataConnectionValidationResults.DeserializeDataConnectionValidationResults(document.RootElement);
        }
    }
}
