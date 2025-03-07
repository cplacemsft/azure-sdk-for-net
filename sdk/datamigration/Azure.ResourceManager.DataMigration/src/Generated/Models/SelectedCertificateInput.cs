// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Info for certificate to be exported for TDE enabled databases. </summary>
    public partial class SelectedCertificateInput
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

        /// <summary> Initializes a new instance of <see cref="SelectedCertificateInput"/>. </summary>
        /// <param name="certificateName"> Name of certificate to be exported. </param>
        /// <param name="password"> Password to use for encrypting the exported certificate. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> or <paramref name="password"/> is null. </exception>
        public SelectedCertificateInput(string certificateName, string password)
        {
            Argument.AssertNotNull(certificateName, nameof(certificateName));
            Argument.AssertNotNull(password, nameof(password));

            CertificateName = certificateName;
            Password = password;
        }

        /// <summary> Initializes a new instance of <see cref="SelectedCertificateInput"/>. </summary>
        /// <param name="certificateName"> Name of certificate to be exported. </param>
        /// <param name="password"> Password to use for encrypting the exported certificate. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SelectedCertificateInput(string certificateName, string password, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CertificateName = certificateName;
            Password = password;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SelectedCertificateInput"/> for deserialization. </summary>
        internal SelectedCertificateInput()
        {
        }

        /// <summary> Name of certificate to be exported. </summary>
        public string CertificateName { get; set; }
        /// <summary> Password to use for encrypting the exported certificate. </summary>
        public string Password { get; set; }
    }
}
