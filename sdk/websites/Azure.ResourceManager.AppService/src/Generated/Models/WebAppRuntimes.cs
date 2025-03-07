// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Web App stack runtimes. </summary>
    public partial class WebAppRuntimes
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

        /// <summary> Initializes a new instance of <see cref="WebAppRuntimes"/>. </summary>
        internal WebAppRuntimes()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WebAppRuntimes"/>. </summary>
        /// <param name="linuxRuntimeSettings"> Linux-specific settings associated with the minor version. </param>
        /// <param name="windowsRuntimeSettings"> Windows-specific settings associated with the minor version. </param>
        /// <param name="linuxContainerSettings"> Linux-specific settings associated with the Java container minor version. </param>
        /// <param name="windowsContainerSettings"> Windows-specific settings associated with the Java container minor version. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WebAppRuntimes(WebAppRuntimeSettings linuxRuntimeSettings, WebAppRuntimeSettings windowsRuntimeSettings, LinuxJavaContainerSettings linuxContainerSettings, WindowsJavaContainerSettings windowsContainerSettings, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LinuxRuntimeSettings = linuxRuntimeSettings;
            WindowsRuntimeSettings = windowsRuntimeSettings;
            LinuxContainerSettings = linuxContainerSettings;
            WindowsContainerSettings = windowsContainerSettings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Linux-specific settings associated with the minor version. </summary>
        [WirePath("linuxRuntimeSettings")]
        public WebAppRuntimeSettings LinuxRuntimeSettings { get; }
        /// <summary> Windows-specific settings associated with the minor version. </summary>
        [WirePath("windowsRuntimeSettings")]
        public WebAppRuntimeSettings WindowsRuntimeSettings { get; }
        /// <summary> Linux-specific settings associated with the Java container minor version. </summary>
        [WirePath("linuxContainerSettings")]
        public LinuxJavaContainerSettings LinuxContainerSettings { get; }
        /// <summary> Windows-specific settings associated with the Java container minor version. </summary>
        [WirePath("windowsContainerSettings")]
        public WindowsJavaContainerSettings WindowsContainerSettings { get; }
    }
}
