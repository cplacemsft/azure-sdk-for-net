// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    /// <summary> Remote private endpoint details. </summary>
    public partial class RemotePrivateEndpoint
    {
        /// <summary> Initializes a new instance of RemotePrivateEndpoint. </summary>
        public RemotePrivateEndpoint()
        {
            ManualPrivateLinkServiceConnections = new ChangeTrackingList<PrivateLinkServiceConnection>();
            PrivateLinkServiceConnections = new ChangeTrackingList<PrivateLinkServiceConnection>();
            PrivateLinkServiceProxies = new ChangeTrackingList<PrivateLinkServiceProxy>();
            ConnectionDetails = new ChangeTrackingList<ConnectionDetails>();
        }

        /// <summary> Initializes a new instance of RemotePrivateEndpoint. </summary>
        /// <param name="id"> Remote endpoint resource ID. </param>
        /// <param name="location"> ARM location of the remote private endpoint. </param>
        /// <param name="immutableSubscriptionId"> Original subscription ID needed by Microsoft.Network. </param>
        /// <param name="immutableResourceId"> Original resource ID needed by Microsoft.Network. </param>
        /// <param name="vnetTrafficTag"> Virtual network traffic tag. </param>
        /// <param name="manualPrivateLinkServiceConnections"> List of private link service connections that need manual approval. </param>
        /// <param name="privateLinkServiceConnections"> List of automatically approved private link service connections. </param>
        /// <param name="privateLinkServiceProxies"> List of private link service proxies. </param>
        /// <param name="connectionDetails"> List of connection details. </param>
        internal RemotePrivateEndpoint(string id, string location, string immutableSubscriptionId, string immutableResourceId, string vnetTrafficTag, IList<PrivateLinkServiceConnection> manualPrivateLinkServiceConnections, IList<PrivateLinkServiceConnection> privateLinkServiceConnections, IList<PrivateLinkServiceProxy> privateLinkServiceProxies, IList<ConnectionDetails> connectionDetails)
        {
            Id = id;
            Location = location;
            ImmutableSubscriptionId = immutableSubscriptionId;
            ImmutableResourceId = immutableResourceId;
            VnetTrafficTag = vnetTrafficTag;
            ManualPrivateLinkServiceConnections = manualPrivateLinkServiceConnections;
            PrivateLinkServiceConnections = privateLinkServiceConnections;
            PrivateLinkServiceProxies = privateLinkServiceProxies;
            ConnectionDetails = connectionDetails;
        }

        /// <summary> Remote endpoint resource ID. </summary>
        public string Id { get; set; }
        /// <summary> ARM location of the remote private endpoint. </summary>
        public string Location { get; set; }
        /// <summary> Original subscription ID needed by Microsoft.Network. </summary>
        public string ImmutableSubscriptionId { get; set; }
        /// <summary> Original resource ID needed by Microsoft.Network. </summary>
        public string ImmutableResourceId { get; set; }
        /// <summary> Virtual network traffic tag. </summary>
        public string VnetTrafficTag { get; set; }
        /// <summary> List of private link service connections that need manual approval. </summary>
        public IList<PrivateLinkServiceConnection> ManualPrivateLinkServiceConnections { get; }
        /// <summary> List of automatically approved private link service connections. </summary>
        public IList<PrivateLinkServiceConnection> PrivateLinkServiceConnections { get; }
        /// <summary> List of private link service proxies. </summary>
        public IList<PrivateLinkServiceProxy> PrivateLinkServiceProxies { get; }
        /// <summary> List of connection details. </summary>
        public IList<ConnectionDetails> ConnectionDetails { get; }
    }
}
