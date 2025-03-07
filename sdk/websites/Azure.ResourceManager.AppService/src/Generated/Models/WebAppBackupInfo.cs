// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description of a backup which will be performed. </summary>
    public partial class WebAppBackupInfo : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="WebAppBackupInfo"/>. </summary>
        public WebAppBackupInfo()
        {
            Databases = new ChangeTrackingList<AppServiceDatabaseBackupSetting>();
        }

        /// <summary> Initializes a new instance of <see cref="WebAppBackupInfo"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="backupName"> Name of the backup. </param>
        /// <param name="isEnabled"> True if the backup schedule is enabled (must be included in that case), false if the backup schedule should be disabled. </param>
        /// <param name="storageAccountUri"> SAS URL to the container. </param>
        /// <param name="backupSchedule"> Schedule for the backup if it is executed periodically. </param>
        /// <param name="databases"> Databases included in the backup. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WebAppBackupInfo(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string backupName, bool? isEnabled, Uri storageAccountUri, WebAppBackupSchedule backupSchedule, IList<AppServiceDatabaseBackupSetting> databases, string kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            BackupName = backupName;
            IsEnabled = isEnabled;
            StorageAccountUri = storageAccountUri;
            BackupSchedule = backupSchedule;
            Databases = databases;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the backup. </summary>
        [WirePath("properties.backupName")]
        public string BackupName { get; set; }
        /// <summary> True if the backup schedule is enabled (must be included in that case), false if the backup schedule should be disabled. </summary>
        [WirePath("properties.enabled")]
        public bool? IsEnabled { get; set; }
        /// <summary> SAS URL to the container. </summary>
        [WirePath("properties.storageAccountUrl")]
        public Uri StorageAccountUri { get; set; }
        /// <summary> Schedule for the backup if it is executed periodically. </summary>
        [WirePath("properties.backupSchedule")]
        public WebAppBackupSchedule BackupSchedule { get; set; }
        /// <summary> Databases included in the backup. </summary>
        [WirePath("properties.databases")]
        public IList<AppServiceDatabaseBackupSetting> Databases { get; }
        /// <summary> Kind of resource. </summary>
        [WirePath("kind")]
        public string Kind { get; set; }
    }
}
