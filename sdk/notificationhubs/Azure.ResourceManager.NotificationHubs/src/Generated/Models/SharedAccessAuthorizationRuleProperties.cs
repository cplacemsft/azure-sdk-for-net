// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary> SharedAccessAuthorizationRule properties. </summary>
    public partial class SharedAccessAuthorizationRuleProperties
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

        /// <summary> Initializes a new instance of <see cref="SharedAccessAuthorizationRuleProperties"/>. </summary>
        /// <param name="accessRights"> Gets or sets the rights associated with the rule. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accessRights"/> is null. </exception>
        public SharedAccessAuthorizationRuleProperties(IEnumerable<AuthorizationRuleAccessRightExt> accessRights)
        {
            Argument.AssertNotNull(accessRights, nameof(accessRights));

            AccessRights = accessRights.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="SharedAccessAuthorizationRuleProperties"/>. </summary>
        /// <param name="accessRights"> Gets or sets the rights associated with the rule. </param>
        /// <param name="primaryKey">
        /// Gets a base64-encoded 256-bit primary key for signing and
        /// validating the SAS token.
        /// </param>
        /// <param name="secondaryKey">
        /// Gets a base64-encoded 256-bit primary key for signing and
        /// validating the SAS token.
        /// </param>
        /// <param name="keyName"> Gets a string that describes the authorization rule. </param>
        /// <param name="modifiedOn"> Gets the last modified time for this rule. </param>
        /// <param name="createdOn"> Gets the created time for this rule. </param>
        /// <param name="claimType"> Gets a string that describes the claim type. </param>
        /// <param name="claimValue"> Gets a string that describes the claim value. </param>
        /// <param name="revision"> Gets the revision number for the rule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SharedAccessAuthorizationRuleProperties(IList<AuthorizationRuleAccessRightExt> accessRights, string primaryKey, string secondaryKey, string keyName, DateTimeOffset? modifiedOn, DateTimeOffset? createdOn, string claimType, string claimValue, int? revision, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AccessRights = accessRights;
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            KeyName = keyName;
            ModifiedOn = modifiedOn;
            CreatedOn = createdOn;
            ClaimType = claimType;
            ClaimValue = claimValue;
            Revision = revision;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the rights associated with the rule. </summary>
        public IList<AuthorizationRuleAccessRightExt> AccessRights { get; }
        /// <summary>
        /// Gets a base64-encoded 256-bit primary key for signing and
        /// validating the SAS token.
        /// </summary>
        public string PrimaryKey { get; set; }
        /// <summary>
        /// Gets a base64-encoded 256-bit primary key for signing and
        /// validating the SAS token.
        /// </summary>
        public string SecondaryKey { get; set; }
        /// <summary> Gets a string that describes the authorization rule. </summary>
        public string KeyName { get; }
        /// <summary> Gets the last modified time for this rule. </summary>
        public DateTimeOffset? ModifiedOn { get; }
        /// <summary> Gets the created time for this rule. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Gets a string that describes the claim type. </summary>
        public string ClaimType { get; }
        /// <summary> Gets a string that describes the claim value. </summary>
        public string ClaimValue { get; }
        /// <summary> Gets the revision number for the rule. </summary>
        public int? Revision { get; }
    }
}
