// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    /// <summary>
    /// A class representing a collection of <see cref="StorageAccountMigrationResource"/> and their operations.
    /// Each <see cref="StorageAccountMigrationResource"/> in the collection will belong to the same instance of <see cref="StorageAccountResource"/>.
    /// To get a <see cref="StorageAccountMigrationCollection"/> instance call the GetStorageAccountMigrations method from an instance of <see cref="StorageAccountResource"/>.
    /// </summary>
    public partial class StorageAccountMigrationCollection : ArmCollection
    {
        private readonly ClientDiagnostics _storageAccountMigrationStorageAccountsClientDiagnostics;
        private readonly StorageAccountsRestOperations _storageAccountMigrationStorageAccountsRestClient;

        /// <summary> Initializes a new instance of the <see cref="StorageAccountMigrationCollection"/> class for mocking. </summary>
        protected StorageAccountMigrationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StorageAccountMigrationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StorageAccountMigrationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _storageAccountMigrationStorageAccountsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Storage", StorageAccountMigrationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StorageAccountMigrationResource.ResourceType, out string storageAccountMigrationStorageAccountsApiVersion);
            _storageAccountMigrationStorageAccountsRestClient = new StorageAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, storageAccountMigrationStorageAccountsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StorageAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StorageAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the status of the ongoing migration for the specified storage account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/accountMigrations/{migrationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_GetCustomerInitiatedMigration</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageAccountMigrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="migrationName"> The name of the Storage Account Migration. It should always be 'default'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<StorageAccountMigrationResource>> GetAsync(StorageAccountMigrationName migrationName, CancellationToken cancellationToken = default)
        {
            using var scope = _storageAccountMigrationStorageAccountsClientDiagnostics.CreateScope("StorageAccountMigrationCollection.Get");
            scope.Start();
            try
            {
                var response = await _storageAccountMigrationStorageAccountsRestClient.GetCustomerInitiatedMigrationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, migrationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageAccountMigrationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the status of the ongoing migration for the specified storage account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/accountMigrations/{migrationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_GetCustomerInitiatedMigration</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageAccountMigrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="migrationName"> The name of the Storage Account Migration. It should always be 'default'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StorageAccountMigrationResource> Get(StorageAccountMigrationName migrationName, CancellationToken cancellationToken = default)
        {
            using var scope = _storageAccountMigrationStorageAccountsClientDiagnostics.CreateScope("StorageAccountMigrationCollection.Get");
            scope.Start();
            try
            {
                var response = _storageAccountMigrationStorageAccountsRestClient.GetCustomerInitiatedMigration(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, migrationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageAccountMigrationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/accountMigrations/{migrationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_GetCustomerInitiatedMigration</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageAccountMigrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="migrationName"> The name of the Storage Account Migration. It should always be 'default'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(StorageAccountMigrationName migrationName, CancellationToken cancellationToken = default)
        {
            using var scope = _storageAccountMigrationStorageAccountsClientDiagnostics.CreateScope("StorageAccountMigrationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _storageAccountMigrationStorageAccountsRestClient.GetCustomerInitiatedMigrationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, migrationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/accountMigrations/{migrationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_GetCustomerInitiatedMigration</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageAccountMigrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="migrationName"> The name of the Storage Account Migration. It should always be 'default'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(StorageAccountMigrationName migrationName, CancellationToken cancellationToken = default)
        {
            using var scope = _storageAccountMigrationStorageAccountsClientDiagnostics.CreateScope("StorageAccountMigrationCollection.Exists");
            scope.Start();
            try
            {
                var response = _storageAccountMigrationStorageAccountsRestClient.GetCustomerInitiatedMigration(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, migrationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/accountMigrations/{migrationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_GetCustomerInitiatedMigration</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageAccountMigrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="migrationName"> The name of the Storage Account Migration. It should always be 'default'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<StorageAccountMigrationResource>> GetIfExistsAsync(StorageAccountMigrationName migrationName, CancellationToken cancellationToken = default)
        {
            using var scope = _storageAccountMigrationStorageAccountsClientDiagnostics.CreateScope("StorageAccountMigrationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _storageAccountMigrationStorageAccountsRestClient.GetCustomerInitiatedMigrationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, migrationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<StorageAccountMigrationResource>(response.GetRawResponse());
                return Response.FromValue(new StorageAccountMigrationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/accountMigrations/{migrationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_GetCustomerInitiatedMigration</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageAccountMigrationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="migrationName"> The name of the Storage Account Migration. It should always be 'default'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<StorageAccountMigrationResource> GetIfExists(StorageAccountMigrationName migrationName, CancellationToken cancellationToken = default)
        {
            using var scope = _storageAccountMigrationStorageAccountsClientDiagnostics.CreateScope("StorageAccountMigrationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _storageAccountMigrationStorageAccountsRestClient.GetCustomerInitiatedMigration(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, migrationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<StorageAccountMigrationResource>(response.GetRawResponse());
                return Response.FromValue(new StorageAccountMigrationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
