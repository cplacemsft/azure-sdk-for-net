// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Parameters to create and update an Azure Cosmos DB Mongo Role Definition. </summary>
    public partial class MongoDBRoleDefinitionCreateOrUpdateContent
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

        /// <summary> Initializes a new instance of <see cref="MongoDBRoleDefinitionCreateOrUpdateContent"/>. </summary>
        public MongoDBRoleDefinitionCreateOrUpdateContent()
        {
            Privileges = new ChangeTrackingList<MongoDBPrivilege>();
            Roles = new ChangeTrackingList<MongoDBRole>();
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBRoleDefinitionCreateOrUpdateContent"/>. </summary>
        /// <param name="roleName"> A user-friendly name for the Role Definition. Must be unique for the database account. </param>
        /// <param name="definitionType"> Indicates whether the Role Definition was built-in or user created. </param>
        /// <param name="databaseName"> The database name for which access is being granted for this Role Definition. </param>
        /// <param name="privileges"> A set of privileges contained by the Role Definition. This will allow application of this Role Definition on the entire database account or any underlying Database / Collection. Scopes higher than Database are not enforceable as privilege. </param>
        /// <param name="roles"> The set of roles inherited by this Role Definition. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MongoDBRoleDefinitionCreateOrUpdateContent(string roleName, MongoDBRoleDefinitionType? definitionType, string databaseName, IList<MongoDBPrivilege> privileges, IList<MongoDBRole> roles, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RoleName = roleName;
            DefinitionType = definitionType;
            DatabaseName = databaseName;
            Privileges = privileges;
            Roles = roles;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A user-friendly name for the Role Definition. Must be unique for the database account. </summary>
        [WirePath("properties.roleName")]
        public string RoleName { get; set; }
        /// <summary> Indicates whether the Role Definition was built-in or user created. </summary>
        [WirePath("properties.type")]
        public MongoDBRoleDefinitionType? DefinitionType { get; set; }
        /// <summary> The database name for which access is being granted for this Role Definition. </summary>
        [WirePath("properties.databaseName")]
        public string DatabaseName { get; set; }
        /// <summary> A set of privileges contained by the Role Definition. This will allow application of this Role Definition on the entire database account or any underlying Database / Collection. Scopes higher than Database are not enforceable as privilege. </summary>
        [WirePath("properties.privileges")]
        public IList<MongoDBPrivilege> Privileges { get; }
        /// <summary> The set of roles inherited by this Role Definition. </summary>
        [WirePath("properties.roles")]
        public IList<MongoDBRole> Roles { get; }
    }
}
