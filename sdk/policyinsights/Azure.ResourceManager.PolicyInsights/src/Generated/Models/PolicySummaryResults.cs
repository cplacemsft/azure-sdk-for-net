// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> Compliance summary on a particular summary level. </summary>
    public partial class PolicySummaryResults
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PolicySummaryResults"/>. </summary>
        internal PolicySummaryResults()
        {
            ResourceDetails = new ChangeTrackingList<ComplianceDetail>();
            PolicyDetails = new ChangeTrackingList<ComplianceDetail>();
            PolicyGroupDetails = new ChangeTrackingList<ComplianceDetail>();
        }

        /// <summary> Initializes a new instance of <see cref="PolicySummaryResults"/>. </summary>
        /// <param name="queryResultsUri"> HTTP POST URI for queryResults action on Microsoft.PolicyInsights to retrieve raw results for the compliance summary. This property will not be available by default in future API versions, but could be queried explicitly. </param>
        /// <param name="nonCompliantResources"> Number of non-compliant resources. </param>
        /// <param name="nonCompliantPolicies"> Number of non-compliant policies. </param>
        /// <param name="resourceDetails"> The resources summary at this level. </param>
        /// <param name="policyDetails"> The policy artifact summary at this level. For query scope level, it represents policy assignment summary. For policy assignment level, it represents policy definitions summary. </param>
        /// <param name="policyGroupDetails"> The policy definition group summary at this level. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PolicySummaryResults(Uri queryResultsUri, int? nonCompliantResources, int? nonCompliantPolicies, IReadOnlyList<ComplianceDetail> resourceDetails, IReadOnlyList<ComplianceDetail> policyDetails, IReadOnlyList<ComplianceDetail> policyGroupDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            QueryResultsUri = queryResultsUri;
            NonCompliantResources = nonCompliantResources;
            NonCompliantPolicies = nonCompliantPolicies;
            ResourceDetails = resourceDetails;
            PolicyDetails = policyDetails;
            PolicyGroupDetails = policyGroupDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> HTTP POST URI for queryResults action on Microsoft.PolicyInsights to retrieve raw results for the compliance summary. This property will not be available by default in future API versions, but could be queried explicitly. </summary>
        public Uri QueryResultsUri { get; }
        /// <summary> Number of non-compliant resources. </summary>
        public int? NonCompliantResources { get; }
        /// <summary> Number of non-compliant policies. </summary>
        public int? NonCompliantPolicies { get; }
        /// <summary> The resources summary at this level. </summary>
        public IReadOnlyList<ComplianceDetail> ResourceDetails { get; }
        /// <summary> The policy artifact summary at this level. For query scope level, it represents policy assignment summary. For policy assignment level, it represents policy definitions summary. </summary>
        public IReadOnlyList<ComplianceDetail> PolicyDetails { get; }
        /// <summary> The policy definition group summary at this level. </summary>
        public IReadOnlyList<ComplianceDetail> PolicyGroupDetails { get; }
    }
}
