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

namespace Azure.ResourceManager.AgFoodPlatform
{
    /// <summary>
    /// A class representing a collection of <see cref="AgFoodPlatformPrivateLinkResource"/> and their operations.
    /// Each <see cref="AgFoodPlatformPrivateLinkResource"/> in the collection will belong to the same instance of <see cref="FarmBeatResource"/>.
    /// To get an <see cref="AgFoodPlatformPrivateLinkResourceCollection"/> instance call the GetAgFoodPlatformPrivateLinkResources method from an instance of <see cref="FarmBeatResource"/>.
    /// </summary>
    public partial class AgFoodPlatformPrivateLinkResourceCollection : ArmCollection, IEnumerable<AgFoodPlatformPrivateLinkResource>, IAsyncEnumerable<AgFoodPlatformPrivateLinkResource>
    {
        private readonly ClientDiagnostics _agFoodPlatformPrivateLinkResourcePrivateLinkResourcesClientDiagnostics;
        private readonly PrivateLinkResourcesRestOperations _agFoodPlatformPrivateLinkResourcePrivateLinkResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="AgFoodPlatformPrivateLinkResourceCollection"/> class for mocking. </summary>
        protected AgFoodPlatformPrivateLinkResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AgFoodPlatformPrivateLinkResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AgFoodPlatformPrivateLinkResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _agFoodPlatformPrivateLinkResourcePrivateLinkResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AgFoodPlatform", AgFoodPlatformPrivateLinkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AgFoodPlatformPrivateLinkResource.ResourceType, out string agFoodPlatformPrivateLinkResourcePrivateLinkResourcesApiVersion);
            _agFoodPlatformPrivateLinkResourcePrivateLinkResourcesRestClient = new PrivateLinkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, agFoodPlatformPrivateLinkResourcePrivateLinkResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != FarmBeatResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, FarmBeatResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get Private link resource object.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AgFoodPlatform/farmBeats/{farmBeatsResourceName}/privateLinkResources/{subResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AgFoodPlatformPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subResourceName"> Sub resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subResourceName"/> is null. </exception>
        public virtual async Task<Response<AgFoodPlatformPrivateLinkResource>> GetAsync(string subResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subResourceName, nameof(subResourceName));

            using var scope = _agFoodPlatformPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("AgFoodPlatformPrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _agFoodPlatformPrivateLinkResourcePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, subResourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AgFoodPlatformPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Private link resource object.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AgFoodPlatform/farmBeats/{farmBeatsResourceName}/privateLinkResources/{subResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AgFoodPlatformPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subResourceName"> Sub resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subResourceName"/> is null. </exception>
        public virtual Response<AgFoodPlatformPrivateLinkResource> Get(string subResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subResourceName, nameof(subResourceName));

            using var scope = _agFoodPlatformPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("AgFoodPlatformPrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _agFoodPlatformPrivateLinkResourcePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, subResourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AgFoodPlatformPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get list of Private link resources.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AgFoodPlatform/farmBeats/{farmBeatsResourceName}/privateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_ListByResource</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AgFoodPlatformPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AgFoodPlatformPrivateLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AgFoodPlatformPrivateLinkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _agFoodPlatformPrivateLinkResourcePrivateLinkResourcesRestClient.CreateListByResourceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new AgFoodPlatformPrivateLinkResource(Client, AgFoodPlatformPrivateLinkResourceData.DeserializeAgFoodPlatformPrivateLinkResourceData(e)), _agFoodPlatformPrivateLinkResourcePrivateLinkResourcesClientDiagnostics, Pipeline, "AgFoodPlatformPrivateLinkResourceCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get list of Private link resources.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AgFoodPlatform/farmBeats/{farmBeatsResourceName}/privateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_ListByResource</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AgFoodPlatformPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AgFoodPlatformPrivateLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AgFoodPlatformPrivateLinkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _agFoodPlatformPrivateLinkResourcePrivateLinkResourcesRestClient.CreateListByResourceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new AgFoodPlatformPrivateLinkResource(Client, AgFoodPlatformPrivateLinkResourceData.DeserializeAgFoodPlatformPrivateLinkResourceData(e)), _agFoodPlatformPrivateLinkResourcePrivateLinkResourcesClientDiagnostics, Pipeline, "AgFoodPlatformPrivateLinkResourceCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AgFoodPlatform/farmBeats/{farmBeatsResourceName}/privateLinkResources/{subResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AgFoodPlatformPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subResourceName"> Sub resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subResourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string subResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subResourceName, nameof(subResourceName));

            using var scope = _agFoodPlatformPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("AgFoodPlatformPrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _agFoodPlatformPrivateLinkResourcePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, subResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AgFoodPlatform/farmBeats/{farmBeatsResourceName}/privateLinkResources/{subResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AgFoodPlatformPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subResourceName"> Sub resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subResourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string subResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subResourceName, nameof(subResourceName));

            using var scope = _agFoodPlatformPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("AgFoodPlatformPrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _agFoodPlatformPrivateLinkResourcePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, subResourceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AgFoodPlatform/farmBeats/{farmBeatsResourceName}/privateLinkResources/{subResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AgFoodPlatformPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subResourceName"> Sub resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subResourceName"/> is null. </exception>
        public virtual async Task<NullableResponse<AgFoodPlatformPrivateLinkResource>> GetIfExistsAsync(string subResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subResourceName, nameof(subResourceName));

            using var scope = _agFoodPlatformPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("AgFoodPlatformPrivateLinkResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _agFoodPlatformPrivateLinkResourcePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, subResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AgFoodPlatformPrivateLinkResource>(response.GetRawResponse());
                return Response.FromValue(new AgFoodPlatformPrivateLinkResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AgFoodPlatform/farmBeats/{farmBeatsResourceName}/privateLinkResources/{subResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AgFoodPlatformPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subResourceName"> Sub resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subResourceName"/> is null. </exception>
        public virtual NullableResponse<AgFoodPlatformPrivateLinkResource> GetIfExists(string subResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subResourceName, nameof(subResourceName));

            using var scope = _agFoodPlatformPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("AgFoodPlatformPrivateLinkResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _agFoodPlatformPrivateLinkResourcePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, subResourceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AgFoodPlatformPrivateLinkResource>(response.GetRawResponse());
                return Response.FromValue(new AgFoodPlatformPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AgFoodPlatformPrivateLinkResource> IEnumerable<AgFoodPlatformPrivateLinkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AgFoodPlatformPrivateLinkResource> IAsyncEnumerable<AgFoodPlatformPrivateLinkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
