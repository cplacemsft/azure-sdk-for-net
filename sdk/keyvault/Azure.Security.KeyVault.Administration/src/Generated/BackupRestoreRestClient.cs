// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Security.KeyVault.Administration.Models;

namespace Azure.Security.KeyVault.Administration
{
    internal partial class BackupRestoreRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of BackupRestoreRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public BackupRestoreRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string apiVersion = "7.5")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateFullBackupRequest(string vaultBaseUrl, SASTokenParameter azureStorageBlobContainerUri)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(vaultBaseUrl, false);
            uri.AppendPath("/backup", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (azureStorageBlobContainerUri != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(azureStorageBlobContainerUri);
                request.Content = content;
            }
            return message;
        }

        /// <summary> Creates a full backup using a user-provided SAS token to an Azure blob storage container. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="azureStorageBlobContainerUri"> Azure blob shared access signature token pointing to a valid Azure blob container where full backup needs to be stored. This token needs to be valid for at least next 24 hours from the time of making this call. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/> is null. </exception>
        public async Task<ResponseWithHeaders<AzureSecurityKeyVaultAdministrationFullBackupHeaders>> FullBackupAsync(string vaultBaseUrl, SASTokenParameter azureStorageBlobContainerUri = null, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }

            using var message = CreateFullBackupRequest(vaultBaseUrl, azureStorageBlobContainerUri);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new AzureSecurityKeyVaultAdministrationFullBackupHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates a full backup using a user-provided SAS token to an Azure blob storage container. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="azureStorageBlobContainerUri"> Azure blob shared access signature token pointing to a valid Azure blob container where full backup needs to be stored. This token needs to be valid for at least next 24 hours from the time of making this call. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/> is null. </exception>
        public ResponseWithHeaders<AzureSecurityKeyVaultAdministrationFullBackupHeaders> FullBackup(string vaultBaseUrl, SASTokenParameter azureStorageBlobContainerUri = null, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }

            using var message = CreateFullBackupRequest(vaultBaseUrl, azureStorageBlobContainerUri);
            _pipeline.Send(message, cancellationToken);
            var headers = new AzureSecurityKeyVaultAdministrationFullBackupHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateFullBackupStatusRequest(string vaultBaseUrl, string jobId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(vaultBaseUrl, false);
            uri.AppendPath("/backup/", false);
            uri.AppendPath(jobId, true);
            uri.AppendPath("/pending", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Returns the status of full backup operation. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="jobId"> The id returned as part of the backup request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/> or <paramref name="jobId"/> is null. </exception>
        public async Task<Response<FullBackupDetailsInternal>> FullBackupStatusAsync(string vaultBaseUrl, string jobId, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }

            using var message = CreateFullBackupStatusRequest(vaultBaseUrl, jobId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FullBackupDetailsInternal value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = FullBackupDetailsInternal.DeserializeFullBackupDetailsInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns the status of full backup operation. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="jobId"> The id returned as part of the backup request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/> or <paramref name="jobId"/> is null. </exception>
        public Response<FullBackupDetailsInternal> FullBackupStatus(string vaultBaseUrl, string jobId, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }

            using var message = CreateFullBackupStatusRequest(vaultBaseUrl, jobId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FullBackupDetailsInternal value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = FullBackupDetailsInternal.DeserializeFullBackupDetailsInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateFullRestoreOperationRequest(string vaultBaseUrl, RestoreOperationParameters restoreBlobDetails)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(vaultBaseUrl, false);
            uri.AppendPath("/restore", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (restoreBlobDetails != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(restoreBlobDetails);
                request.Content = content;
            }
            return message;
        }

        /// <summary> Restores all key materials using the SAS token pointing to a previously stored Azure Blob storage backup folder. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="restoreBlobDetails"> The Azure blob SAS token pointing to a folder where the previous successful full backup was stored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/> is null. </exception>
        public async Task<ResponseWithHeaders<AzureSecurityKeyVaultAdministrationFullRestoreOperationHeaders>> FullRestoreOperationAsync(string vaultBaseUrl, RestoreOperationParameters restoreBlobDetails = null, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }

            using var message = CreateFullRestoreOperationRequest(vaultBaseUrl, restoreBlobDetails);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new AzureSecurityKeyVaultAdministrationFullRestoreOperationHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Restores all key materials using the SAS token pointing to a previously stored Azure Blob storage backup folder. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="restoreBlobDetails"> The Azure blob SAS token pointing to a folder where the previous successful full backup was stored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/> is null. </exception>
        public ResponseWithHeaders<AzureSecurityKeyVaultAdministrationFullRestoreOperationHeaders> FullRestoreOperation(string vaultBaseUrl, RestoreOperationParameters restoreBlobDetails = null, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }

            using var message = CreateFullRestoreOperationRequest(vaultBaseUrl, restoreBlobDetails);
            _pipeline.Send(message, cancellationToken);
            var headers = new AzureSecurityKeyVaultAdministrationFullRestoreOperationHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRestoreStatusRequest(string vaultBaseUrl, string jobId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(vaultBaseUrl, false);
            uri.AppendPath("/restore/", false);
            uri.AppendPath(jobId, true);
            uri.AppendPath("/pending", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Returns the status of restore operation. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="jobId"> The Job Id returned part of the restore operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/> or <paramref name="jobId"/> is null. </exception>
        public async Task<Response<RestoreDetailsInternal>> RestoreStatusAsync(string vaultBaseUrl, string jobId, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }

            using var message = CreateRestoreStatusRequest(vaultBaseUrl, jobId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RestoreDetailsInternal value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = RestoreDetailsInternal.DeserializeRestoreDetailsInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns the status of restore operation. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="jobId"> The Job Id returned part of the restore operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/> or <paramref name="jobId"/> is null. </exception>
        public Response<RestoreDetailsInternal> RestoreStatus(string vaultBaseUrl, string jobId, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }

            using var message = CreateRestoreStatusRequest(vaultBaseUrl, jobId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RestoreDetailsInternal value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = RestoreDetailsInternal.DeserializeRestoreDetailsInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateSelectiveKeyRestoreOperationRequest(string vaultBaseUrl, string keyName, SelectiveKeyRestoreOperationParameters restoreBlobDetails)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(vaultBaseUrl, false);
            uri.AppendPath("/keys/", false);
            uri.AppendPath(keyName, true);
            uri.AppendPath("/restore", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (restoreBlobDetails != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(restoreBlobDetails);
                request.Content = content;
            }
            return message;
        }

        /// <summary> Restores all key versions of a given key using user supplied SAS token pointing to a previously stored Azure Blob storage backup folder. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="keyName"> The name of the key to be restored from the user supplied backup. </param>
        /// <param name="restoreBlobDetails"> The Azure blob SAS token pointing to a folder where the previous successful full backup was stored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/> or <paramref name="keyName"/> is null. </exception>
        public async Task<ResponseWithHeaders<AzureSecurityKeyVaultAdministrationSelectiveKeyRestoreOperationHeaders>> SelectiveKeyRestoreOperationAsync(string vaultBaseUrl, string keyName, SelectiveKeyRestoreOperationParameters restoreBlobDetails = null, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (keyName == null)
            {
                throw new ArgumentNullException(nameof(keyName));
            }

            using var message = CreateSelectiveKeyRestoreOperationRequest(vaultBaseUrl, keyName, restoreBlobDetails);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new AzureSecurityKeyVaultAdministrationSelectiveKeyRestoreOperationHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Restores all key versions of a given key using user supplied SAS token pointing to a previously stored Azure Blob storage backup folder. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="keyName"> The name of the key to be restored from the user supplied backup. </param>
        /// <param name="restoreBlobDetails"> The Azure blob SAS token pointing to a folder where the previous successful full backup was stored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/> or <paramref name="keyName"/> is null. </exception>
        public ResponseWithHeaders<AzureSecurityKeyVaultAdministrationSelectiveKeyRestoreOperationHeaders> SelectiveKeyRestoreOperation(string vaultBaseUrl, string keyName, SelectiveKeyRestoreOperationParameters restoreBlobDetails = null, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (keyName == null)
            {
                throw new ArgumentNullException(nameof(keyName));
            }

            using var message = CreateSelectiveKeyRestoreOperationRequest(vaultBaseUrl, keyName, restoreBlobDetails);
            _pipeline.Send(message, cancellationToken);
            var headers = new AzureSecurityKeyVaultAdministrationSelectiveKeyRestoreOperationHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
