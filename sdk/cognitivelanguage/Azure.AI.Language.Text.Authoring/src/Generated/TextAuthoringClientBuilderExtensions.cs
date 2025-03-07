// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.AI.Language.Text.Authoring;
using Azure.Core.Extensions;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="TextAnalysisAuthoringClient"/> to client builder. </summary>
    public static partial class TextAuthoringClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="TextAnalysisAuthoringClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> Supported Cognitive Services endpoint e.g., https://&lt;resource-name&gt;.api.cognitiveservices.azure.com. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        public static IAzureClientBuilder<TextAnalysisAuthoringClient, TextAnalysisAuthoringClientOptions> AddTextAnalysisAuthoringClient<TBuilder>(this TBuilder builder, Uri endpoint, AzureKeyCredential credential)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<TextAnalysisAuthoringClient, TextAnalysisAuthoringClientOptions>((options) => new TextAnalysisAuthoringClient(endpoint, credential, options));
        }

        /// <summary> Registers a <see cref="TextAnalysisAuthoringClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> Supported Cognitive Services endpoint e.g., https://&lt;resource-name&gt;.api.cognitiveservices.azure.com. </param>
        public static IAzureClientBuilder<TextAnalysisAuthoringClient, TextAnalysisAuthoringClientOptions> AddTextAnalysisAuthoringClient<TBuilder>(this TBuilder builder, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilderWithCredential
        {
            return builder.RegisterClientFactory<TextAnalysisAuthoringClient, TextAnalysisAuthoringClientOptions>((options, cred) => new TextAnalysisAuthoringClient(endpoint, cred, options));
        }

        /// <summary> Registers a <see cref="TextAnalysisAuthoringClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<TextAnalysisAuthoringClient, TextAnalysisAuthoringClientOptions> AddTextAnalysisAuthoringClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<TextAnalysisAuthoringClient, TextAnalysisAuthoringClientOptions>(configuration);
        }
    }
}
