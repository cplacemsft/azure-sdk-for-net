// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing a collection of <see cref="CosmosDBTableRoleAssignmentResource"/> and their operations.
    /// Each <see cref="CosmosDBTableRoleAssignmentResource"/> in the collection will belong to the same instance of <see cref="CosmosDBAccountResource"/>.
    /// To get a <see cref="CosmosDBTableRoleAssignmentCollection"/> instance call the GetCosmosDBTableRoleAssignments method from an instance of <see cref="CosmosDBAccountResource"/>.
    /// </summary>
    public partial class CosmosDBTableRoleAssignmentCollection : ArmCollection, IEnumerable<CosmosDBTableRoleAssignmentResource>, IAsyncEnumerable<CosmosDBTableRoleAssignmentResource>
    {
        private readonly ClientDiagnostics _cosmosDBTableRoleAssignmentTableResourcesClientDiagnostics;
        private readonly TableResourcesRestOperations _cosmosDBTableRoleAssignmentTableResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="CosmosDBTableRoleAssignmentCollection"/> class for mocking. </summary>
        protected CosmosDBTableRoleAssignmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBTableRoleAssignmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CosmosDBTableRoleAssignmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cosmosDBTableRoleAssignmentTableResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", CosmosDBTableRoleAssignmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CosmosDBTableRoleAssignmentResource.ResourceType, out string cosmosDBTableRoleAssignmentTableResourcesApiVersion);
            _cosmosDBTableRoleAssignmentTableResourcesRestClient = new TableResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cosmosDBTableRoleAssignmentTableResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CosmosDBAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CosmosDBAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an Azure Cosmos DB Table Role Assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tableRoleAssignments/{roleAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TableResources_CreateUpdateTableRoleAssignment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBTableRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="roleAssignmentId"> The GUID for the Role Assignment. </param>
        /// <param name="data"> The properties required to create or update a Role Assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CosmosDBTableRoleAssignmentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string roleAssignmentId, CosmosDBTableRoleAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentId, nameof(roleAssignmentId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cosmosDBTableRoleAssignmentTableResourcesClientDiagnostics.CreateScope("CosmosDBTableRoleAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cosmosDBTableRoleAssignmentTableResourcesRestClient.CreateUpdateTableRoleAssignmentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleAssignmentId, data, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<CosmosDBTableRoleAssignmentResource>(new CosmosDBTableRoleAssignmentOperationSource(Client), _cosmosDBTableRoleAssignmentTableResourcesClientDiagnostics, Pipeline, _cosmosDBTableRoleAssignmentTableResourcesRestClient.CreateCreateUpdateTableRoleAssignmentRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleAssignmentId, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates an Azure Cosmos DB Table Role Assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tableRoleAssignments/{roleAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TableResources_CreateUpdateTableRoleAssignment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBTableRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="roleAssignmentId"> The GUID for the Role Assignment. </param>
        /// <param name="data"> The properties required to create or update a Role Assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CosmosDBTableRoleAssignmentResource> CreateOrUpdate(WaitUntil waitUntil, string roleAssignmentId, CosmosDBTableRoleAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentId, nameof(roleAssignmentId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cosmosDBTableRoleAssignmentTableResourcesClientDiagnostics.CreateScope("CosmosDBTableRoleAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cosmosDBTableRoleAssignmentTableResourcesRestClient.CreateUpdateTableRoleAssignment(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleAssignmentId, data, cancellationToken);
                var operation = new CosmosDBArmOperation<CosmosDBTableRoleAssignmentResource>(new CosmosDBTableRoleAssignmentOperationSource(Client), _cosmosDBTableRoleAssignmentTableResourcesClientDiagnostics, Pipeline, _cosmosDBTableRoleAssignmentTableResourcesRestClient.CreateCreateUpdateTableRoleAssignmentRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleAssignmentId, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the properties of an existing Azure Cosmos DB Table Role Assignment with the given Id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tableRoleAssignments/{roleAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TableResources_GetTableRoleAssignment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBTableRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentId"> The GUID for the Role Assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentId"/> is null. </exception>
        public virtual async Task<Response<CosmosDBTableRoleAssignmentResource>> GetAsync(string roleAssignmentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentId, nameof(roleAssignmentId));

            using var scope = _cosmosDBTableRoleAssignmentTableResourcesClientDiagnostics.CreateScope("CosmosDBTableRoleAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _cosmosDBTableRoleAssignmentTableResourcesRestClient.GetTableRoleAssignmentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleAssignmentId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBTableRoleAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the properties of an existing Azure Cosmos DB Table Role Assignment with the given Id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tableRoleAssignments/{roleAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TableResources_GetTableRoleAssignment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBTableRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentId"> The GUID for the Role Assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentId"/> is null. </exception>
        public virtual Response<CosmosDBTableRoleAssignmentResource> Get(string roleAssignmentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentId, nameof(roleAssignmentId));

            using var scope = _cosmosDBTableRoleAssignmentTableResourcesClientDiagnostics.CreateScope("CosmosDBTableRoleAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = _cosmosDBTableRoleAssignmentTableResourcesRestClient.GetTableRoleAssignment(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleAssignmentId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBTableRoleAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the list of all Azure Cosmos DB Table Role Assignments.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tableRoleAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TableResources_ListTableRoleAssignments</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBTableRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CosmosDBTableRoleAssignmentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CosmosDBTableRoleAssignmentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBTableRoleAssignmentTableResourcesRestClient.CreateListTableRoleAssignmentsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new CosmosDBTableRoleAssignmentResource(Client, CosmosDBTableRoleAssignmentData.DeserializeCosmosDBTableRoleAssignmentData(e)), _cosmosDBTableRoleAssignmentTableResourcesClientDiagnostics, Pipeline, "CosmosDBTableRoleAssignmentCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Retrieves the list of all Azure Cosmos DB Table Role Assignments.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tableRoleAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TableResources_ListTableRoleAssignments</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBTableRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CosmosDBTableRoleAssignmentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CosmosDBTableRoleAssignmentResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBTableRoleAssignmentTableResourcesRestClient.CreateListTableRoleAssignmentsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new CosmosDBTableRoleAssignmentResource(Client, CosmosDBTableRoleAssignmentData.DeserializeCosmosDBTableRoleAssignmentData(e)), _cosmosDBTableRoleAssignmentTableResourcesClientDiagnostics, Pipeline, "CosmosDBTableRoleAssignmentCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tableRoleAssignments/{roleAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TableResources_GetTableRoleAssignment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBTableRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentId"> The GUID for the Role Assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string roleAssignmentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentId, nameof(roleAssignmentId));

            using var scope = _cosmosDBTableRoleAssignmentTableResourcesClientDiagnostics.CreateScope("CosmosDBTableRoleAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cosmosDBTableRoleAssignmentTableResourcesRestClient.GetTableRoleAssignmentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleAssignmentId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tableRoleAssignments/{roleAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TableResources_GetTableRoleAssignment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBTableRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentId"> The GUID for the Role Assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentId"/> is null. </exception>
        public virtual Response<bool> Exists(string roleAssignmentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentId, nameof(roleAssignmentId));

            using var scope = _cosmosDBTableRoleAssignmentTableResourcesClientDiagnostics.CreateScope("CosmosDBTableRoleAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _cosmosDBTableRoleAssignmentTableResourcesRestClient.GetTableRoleAssignment(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleAssignmentId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tableRoleAssignments/{roleAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TableResources_GetTableRoleAssignment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBTableRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentId"> The GUID for the Role Assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentId"/> is null. </exception>
        public virtual async Task<NullableResponse<CosmosDBTableRoleAssignmentResource>> GetIfExistsAsync(string roleAssignmentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentId, nameof(roleAssignmentId));

            using var scope = _cosmosDBTableRoleAssignmentTableResourcesClientDiagnostics.CreateScope("CosmosDBTableRoleAssignmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cosmosDBTableRoleAssignmentTableResourcesRestClient.GetTableRoleAssignmentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleAssignmentId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CosmosDBTableRoleAssignmentResource>(response.GetRawResponse());
                return Response.FromValue(new CosmosDBTableRoleAssignmentResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tableRoleAssignments/{roleAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TableResources_GetTableRoleAssignment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBTableRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentId"> The GUID for the Role Assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentId"/> is null. </exception>
        public virtual NullableResponse<CosmosDBTableRoleAssignmentResource> GetIfExists(string roleAssignmentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentId, nameof(roleAssignmentId));

            using var scope = _cosmosDBTableRoleAssignmentTableResourcesClientDiagnostics.CreateScope("CosmosDBTableRoleAssignmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cosmosDBTableRoleAssignmentTableResourcesRestClient.GetTableRoleAssignment(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleAssignmentId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CosmosDBTableRoleAssignmentResource>(response.GetRawResponse());
                return Response.FromValue(new CosmosDBTableRoleAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CosmosDBTableRoleAssignmentResource> IEnumerable<CosmosDBTableRoleAssignmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CosmosDBTableRoleAssignmentResource> IAsyncEnumerable<CosmosDBTableRoleAssignmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
