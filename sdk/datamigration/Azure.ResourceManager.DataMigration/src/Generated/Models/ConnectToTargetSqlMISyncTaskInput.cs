// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for the task that validates connection to Azure SQL Database Managed Instance online scenario. </summary>
    public partial class ConnectToTargetSqlMISyncTaskInput
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

        /// <summary> Initializes a new instance of <see cref="ConnectToTargetSqlMISyncTaskInput"/>. </summary>
        /// <param name="targetConnectionInfo"> Connection information for Azure SQL Database Managed Instance. </param>
        /// <param name="azureApp"> Azure Active Directory Application the DMS instance will use to connect to the target instance of Azure SQL Database Managed Instance and the Azure Storage Account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetConnectionInfo"/> or <paramref name="azureApp"/> is null. </exception>
        public ConnectToTargetSqlMISyncTaskInput(MISqlConnectionInfo targetConnectionInfo, AzureActiveDirectoryApp azureApp)
        {
            Argument.AssertNotNull(targetConnectionInfo, nameof(targetConnectionInfo));
            Argument.AssertNotNull(azureApp, nameof(azureApp));

            TargetConnectionInfo = targetConnectionInfo;
            AzureApp = azureApp;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectToTargetSqlMISyncTaskInput"/>. </summary>
        /// <param name="targetConnectionInfo"> Connection information for Azure SQL Database Managed Instance. </param>
        /// <param name="azureApp"> Azure Active Directory Application the DMS instance will use to connect to the target instance of Azure SQL Database Managed Instance and the Azure Storage Account. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectToTargetSqlMISyncTaskInput(MISqlConnectionInfo targetConnectionInfo, AzureActiveDirectoryApp azureApp, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TargetConnectionInfo = targetConnectionInfo;
            AzureApp = azureApp;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectToTargetSqlMISyncTaskInput"/> for deserialization. </summary>
        internal ConnectToTargetSqlMISyncTaskInput()
        {
        }

        /// <summary> Connection information for Azure SQL Database Managed Instance. </summary>
        public MISqlConnectionInfo TargetConnectionInfo { get; set; }
        /// <summary> Azure Active Directory Application the DMS instance will use to connect to the target instance of Azure SQL Database Managed Instance and the Azure Storage Account. </summary>
        public AzureActiveDirectoryApp AzureApp { get; set; }
    }
}
