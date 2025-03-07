// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the FirewallPolicyDraft data model.
    /// FirewallPolicy Resource.
    /// </summary>
    public partial class FirewallPolicyDraftData : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="FirewallPolicyDraftData"/>. </summary>
        public FirewallPolicyDraftData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FirewallPolicyDraftData"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="basePolicy"> The parent firewall policy from which rules are inherited. </param>
        /// <param name="threatIntelMode"> The operation mode for Threat Intelligence. </param>
        /// <param name="threatIntelWhitelist"> ThreatIntel Whitelist for Firewall Policy. </param>
        /// <param name="insights"> Insights on Firewall Policy. </param>
        /// <param name="snat"> The private IP addresses/IP ranges to which traffic will not be SNAT. </param>
        /// <param name="sql"> SQL Settings definition. </param>
        /// <param name="dnsSettings"> DNS Proxy Settings definition. </param>
        /// <param name="explicitProxy"> Explicit Proxy Settings definition. </param>
        /// <param name="intrusionDetection"> The configuration for Intrusion detection. </param>
        internal FirewallPolicyDraftData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, WritableSubResource basePolicy, AzureFirewallThreatIntelMode? threatIntelMode, FirewallPolicyThreatIntelWhitelist threatIntelWhitelist, FirewallPolicyInsights insights, FirewallPolicySnat snat, FirewallPolicySQL sql, DnsSettings dnsSettings, FirewallPolicyExplicitProxy explicitProxy, FirewallPolicyIntrusionDetection intrusionDetection) : base(id, name, resourceType, location, tags, serializedAdditionalRawData)
        {
            BasePolicy = basePolicy;
            ThreatIntelMode = threatIntelMode;
            ThreatIntelWhitelist = threatIntelWhitelist;
            Insights = insights;
            Snat = snat;
            Sql = sql;
            DnsSettings = dnsSettings;
            ExplicitProxy = explicitProxy;
            IntrusionDetection = intrusionDetection;
        }

        /// <summary> The parent firewall policy from which rules are inherited. </summary>
        internal WritableSubResource BasePolicy { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier BasePolicyId
        {
            get => BasePolicy is null ? default : BasePolicy.Id;
            set
            {
                if (BasePolicy is null)
                    BasePolicy = new WritableSubResource();
                BasePolicy.Id = value;
            }
        }

        /// <summary> The operation mode for Threat Intelligence. </summary>
        public AzureFirewallThreatIntelMode? ThreatIntelMode { get; set; }
        /// <summary> ThreatIntel Whitelist for Firewall Policy. </summary>
        public FirewallPolicyThreatIntelWhitelist ThreatIntelWhitelist { get; set; }
        /// <summary> Insights on Firewall Policy. </summary>
        public FirewallPolicyInsights Insights { get; set; }
        /// <summary> The private IP addresses/IP ranges to which traffic will not be SNAT. </summary>
        public FirewallPolicySnat Snat { get; set; }
        /// <summary> SQL Settings definition. </summary>
        internal FirewallPolicySQL Sql { get; set; }
        /// <summary> A flag to indicate if SQL Redirect traffic filtering is enabled. Turning on the flag requires no rule using port 11000-11999. </summary>
        public bool? AllowSqlRedirect
        {
            get => Sql is null ? default : Sql.AllowSqlRedirect;
            set
            {
                if (Sql is null)
                    Sql = new FirewallPolicySQL();
                Sql.AllowSqlRedirect = value;
            }
        }

        /// <summary> DNS Proxy Settings definition. </summary>
        public DnsSettings DnsSettings { get; set; }
        /// <summary> Explicit Proxy Settings definition. </summary>
        public FirewallPolicyExplicitProxy ExplicitProxy { get; set; }
        /// <summary> The configuration for Intrusion detection. </summary>
        public FirewallPolicyIntrusionDetection IntrusionDetection { get; set; }
    }
}
