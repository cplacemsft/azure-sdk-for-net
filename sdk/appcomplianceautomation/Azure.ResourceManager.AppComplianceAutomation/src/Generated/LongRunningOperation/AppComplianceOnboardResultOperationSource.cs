// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.AppComplianceAutomation.Models;

namespace Azure.ResourceManager.AppComplianceAutomation
{
    internal class AppComplianceOnboardResultOperationSource : IOperationSource<AppComplianceOnboardResult>
    {
        AppComplianceOnboardResult IOperationSource<AppComplianceOnboardResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
            return AppComplianceOnboardResult.DeserializeAppComplianceOnboardResult(document.RootElement);
        }

        async ValueTask<AppComplianceOnboardResult> IOperationSource<AppComplianceOnboardResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
            return AppComplianceOnboardResult.DeserializeAppComplianceOnboardResult(document.RootElement);
        }
    }
}
