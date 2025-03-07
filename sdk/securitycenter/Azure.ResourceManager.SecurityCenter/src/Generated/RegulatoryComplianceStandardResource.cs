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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing a RegulatoryComplianceStandard along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="RegulatoryComplianceStandardResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetRegulatoryComplianceStandardResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetRegulatoryComplianceStandard method.
    /// </summary>
    public partial class RegulatoryComplianceStandardResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="RegulatoryComplianceStandardResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="regulatoryComplianceStandardName"> The regulatoryComplianceStandardName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string regulatoryComplianceStandardName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Security/regulatoryComplianceStandards/{regulatoryComplianceStandardName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _regulatoryComplianceStandardClientDiagnostics;
        private readonly RegulatoryComplianceStandardsRestOperations _regulatoryComplianceStandardRestClient;
        private readonly RegulatoryComplianceStandardData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/regulatoryComplianceStandards";

        /// <summary> Initializes a new instance of the <see cref="RegulatoryComplianceStandardResource"/> class for mocking. </summary>
        protected RegulatoryComplianceStandardResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RegulatoryComplianceStandardResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal RegulatoryComplianceStandardResource(ArmClient client, RegulatoryComplianceStandardData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="RegulatoryComplianceStandardResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal RegulatoryComplianceStandardResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _regulatoryComplianceStandardClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string regulatoryComplianceStandardApiVersion);
            _regulatoryComplianceStandardRestClient = new RegulatoryComplianceStandardsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, regulatoryComplianceStandardApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RegulatoryComplianceStandardData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of RegulatoryComplianceControlResources in the RegulatoryComplianceStandard. </summary>
        /// <returns> An object representing collection of RegulatoryComplianceControlResources and their operations over a RegulatoryComplianceControlResource. </returns>
        public virtual RegulatoryComplianceControlCollection GetRegulatoryComplianceControls()
        {
            return GetCachedClient(client => new RegulatoryComplianceControlCollection(client, Id));
        }

        /// <summary>
        /// Selected regulatory compliance control details and state
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/regulatoryComplianceStandards/{regulatoryComplianceStandardName}/regulatoryComplianceControls/{regulatoryComplianceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegulatoryComplianceControls_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RegulatoryComplianceControlResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="regulatoryComplianceControlName"> Name of the regulatory compliance control object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="regulatoryComplianceControlName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="regulatoryComplianceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<RegulatoryComplianceControlResource>> GetRegulatoryComplianceControlAsync(string regulatoryComplianceControlName, CancellationToken cancellationToken = default)
        {
            return await GetRegulatoryComplianceControls().GetAsync(regulatoryComplianceControlName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Selected regulatory compliance control details and state
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/regulatoryComplianceStandards/{regulatoryComplianceStandardName}/regulatoryComplianceControls/{regulatoryComplianceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegulatoryComplianceControls_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RegulatoryComplianceControlResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="regulatoryComplianceControlName"> Name of the regulatory compliance control object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="regulatoryComplianceControlName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="regulatoryComplianceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<RegulatoryComplianceControlResource> GetRegulatoryComplianceControl(string regulatoryComplianceControlName, CancellationToken cancellationToken = default)
        {
            return GetRegulatoryComplianceControls().Get(regulatoryComplianceControlName, cancellationToken);
        }

        /// <summary>
        /// Supported regulatory compliance details state for selected standard
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/regulatoryComplianceStandards/{regulatoryComplianceStandardName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegulatoryComplianceStandards_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RegulatoryComplianceStandardResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RegulatoryComplianceStandardResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _regulatoryComplianceStandardClientDiagnostics.CreateScope("RegulatoryComplianceStandardResource.Get");
            scope.Start();
            try
            {
                var response = await _regulatoryComplianceStandardRestClient.GetAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RegulatoryComplianceStandardResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Supported regulatory compliance details state for selected standard
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/regulatoryComplianceStandards/{regulatoryComplianceStandardName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegulatoryComplianceStandards_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RegulatoryComplianceStandardResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RegulatoryComplianceStandardResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _regulatoryComplianceStandardClientDiagnostics.CreateScope("RegulatoryComplianceStandardResource.Get");
            scope.Start();
            try
            {
                var response = _regulatoryComplianceStandardRestClient.Get(Id.SubscriptionId, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RegulatoryComplianceStandardResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
