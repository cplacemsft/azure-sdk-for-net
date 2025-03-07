// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> resource representing a command. </summary>
    public partial class CassandraClusterCommand
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

        /// <summary> Initializes a new instance of <see cref="CassandraClusterCommand"/>. </summary>
        internal CassandraClusterCommand()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CassandraClusterCommand"/>. </summary>
        /// <param name="command"> The command which should be run. </param>
        /// <param name="commandId"> The unique id of command. </param>
        /// <param name="arguments"> The arguments for the command to be run. </param>
        /// <param name="host"> IP address of the cassandra host to run the command on. </param>
        /// <param name="isAdmin"> Whether command has admin privileges. </param>
        /// <param name="shouldStopCassandraBeforeStart"> If true, stops cassandra before executing the command and then start it again. </param>
        /// <param name="isReadWrite"> If true, allows the command to *write* to the cassandra directory, otherwise read-only. </param>
        /// <param name="result"> Result output of the command. </param>
        /// <param name="status"> Status of the command. </param>
        /// <param name="outputFile"> The name of the file where the result is written. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CassandraClusterCommand(string command, string commandId, BinaryData arguments, string host, bool? isAdmin, bool? shouldStopCassandraBeforeStart, bool? isReadWrite, string result, CassandraClusterCommandStatus? status, string outputFile, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Command = command;
            CommandId = commandId;
            Arguments = arguments;
            Host = host;
            IsAdmin = isAdmin;
            ShouldStopCassandraBeforeStart = shouldStopCassandraBeforeStart;
            IsReadWrite = isReadWrite;
            Result = result;
            Status = status;
            OutputFile = outputFile;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The command which should be run. </summary>
        [WirePath("command")]
        public string Command { get; }
        /// <summary> The unique id of command. </summary>
        [WirePath("commandId")]
        public string CommandId { get; }
        /// <summary>
        /// The arguments for the command to be run
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        [WirePath("arguments")]
        public BinaryData Arguments { get; }
        /// <summary> IP address of the cassandra host to run the command on. </summary>
        [WirePath("host")]
        public string Host { get; }
        /// <summary> Whether command has admin privileges. </summary>
        [WirePath("isAdmin")]
        public bool? IsAdmin { get; }
        /// <summary> If true, stops cassandra before executing the command and then start it again. </summary>
        [WirePath("cassandraStopStart")]
        public bool? ShouldStopCassandraBeforeStart { get; }
        /// <summary> If true, allows the command to *write* to the cassandra directory, otherwise read-only. </summary>
        [WirePath("readWrite")]
        public bool? IsReadWrite { get; }
        /// <summary> Result output of the command. </summary>
        [WirePath("result")]
        public string Result { get; }
        /// <summary> Status of the command. </summary>
        [WirePath("status")]
        public CassandraClusterCommandStatus? Status { get; }
        /// <summary> The name of the file where the result is written. </summary>
        [WirePath("outputFile")]
        public string OutputFile { get; }
    }
}
