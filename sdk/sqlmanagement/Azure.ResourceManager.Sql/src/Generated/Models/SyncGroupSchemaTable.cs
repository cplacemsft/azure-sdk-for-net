// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Properties of table in sync group schema. </summary>
    public partial class SyncGroupSchemaTable
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

        /// <summary> Initializes a new instance of <see cref="SyncGroupSchemaTable"/>. </summary>
        public SyncGroupSchemaTable()
        {
            Columns = new ChangeTrackingList<SyncGroupSchemaTableColumn>();
        }

        /// <summary> Initializes a new instance of <see cref="SyncGroupSchemaTable"/>. </summary>
        /// <param name="columns"> List of columns in sync group schema. </param>
        /// <param name="quotedName"> Quoted name of sync group schema table. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SyncGroupSchemaTable(IList<SyncGroupSchemaTableColumn> columns, string quotedName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Columns = columns;
            QuotedName = quotedName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of columns in sync group schema. </summary>
        [WirePath("columns")]
        public IList<SyncGroupSchemaTableColumn> Columns { get; }
        /// <summary> Quoted name of sync group schema table. </summary>
        [WirePath("quotedName")]
        public string QuotedName { get; set; }
    }
}
