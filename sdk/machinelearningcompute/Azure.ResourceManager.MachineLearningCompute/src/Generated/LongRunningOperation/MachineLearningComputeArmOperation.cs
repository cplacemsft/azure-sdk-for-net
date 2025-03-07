// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.MachineLearningCompute
{
#pragma warning disable SA1649 // File name should match first type name
    internal class MachineLearningComputeArmOperation : ArmOperation
#pragma warning restore SA1649 // File name should match first type name
    {
        private readonly OperationInternal _operation;
        private readonly RehydrationToken? _completeRehydrationToken;
        private readonly NextLinkOperationImplementation _nextLinkOperation;
        private readonly string _operationId;

        /// <summary> Initializes a new instance of MachineLearningComputeArmOperation for mocking. </summary>
        protected MachineLearningComputeArmOperation()
        {
        }

        internal MachineLearningComputeArmOperation(Response response, RehydrationToken? rehydrationToken = null)
        {
            _operation = OperationInternal.Succeeded(response);
            _completeRehydrationToken = rehydrationToken;
            _operationId = GetOperationId(rehydrationToken);
        }

        internal MachineLearningComputeArmOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response, OperationFinalStateVia finalStateVia, bool skipApiVersionOverride = false, string apiVersionOverrideValue = null)
        {
            var nextLinkOperation = NextLinkOperationImplementation.Create(pipeline, request.Method, request.Uri.ToUri(), response, finalStateVia, skipApiVersionOverride, apiVersionOverrideValue);
            if (nextLinkOperation is NextLinkOperationImplementation nextLinkOperationValue)
            {
                _nextLinkOperation = nextLinkOperationValue;
                _operationId = _nextLinkOperation.OperationId;
            }
            else
            {
                _completeRehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(request.Method, request.Uri.ToUri(), response, finalStateVia);
                _operationId = GetOperationId(_completeRehydrationToken);
            }
            _operation = new OperationInternal(nextLinkOperation, clientDiagnostics, response, "MachineLearningComputeArmOperation", fallbackStrategy: new SequentialDelayStrategy());
        }

        private string GetOperationId(RehydrationToken? rehydrationToken)
        {
            if (rehydrationToken is null)
            {
                return null;
            }
            var lroDetails = ModelReaderWriter.Write(rehydrationToken, ModelReaderWriterOptions.Json).ToObjectFromJson<Dictionary<string, string>>();
            return lroDetails["id"];
        }
        /// <inheritdoc />
        public override string Id => _operationId ?? NextLinkOperationImplementation.NotSet;

        /// <inheritdoc />
        public override RehydrationToken? GetRehydrationToken() => _nextLinkOperation?.GetRehydrationToken() ?? _completeRehydrationToken;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.RawResponse;

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override Response WaitForCompletionResponse(CancellationToken cancellationToken = default) => _operation.WaitForCompletionResponse(cancellationToken);

        /// <inheritdoc />
        public override Response WaitForCompletionResponse(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionResponse(pollingInterval, cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> WaitForCompletionResponseAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionResponseAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> WaitForCompletionResponseAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionResponseAsync(pollingInterval, cancellationToken);
    }
}
