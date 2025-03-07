// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text.Authoring
{
    /// <summary> Represents a supported language. </summary>
    public partial class TextAuthoringSupportedLanguage
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

        /// <summary> Initializes a new instance of <see cref="TextAuthoringSupportedLanguage"/>. </summary>
        /// <param name="languageCode"> The language code. This is BCP-47 representation of a language. For example, "en" for English, "en-gb" for English (UK), "es" for Spanish etc. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="languageCode"/> is null. </exception>
        internal TextAuthoringSupportedLanguage(string languageCode)
        {
            Argument.AssertNotNull(languageCode, nameof(languageCode));

            LanguageCode = languageCode;
        }

        /// <summary> Initializes a new instance of <see cref="TextAuthoringSupportedLanguage"/>. </summary>
        /// <param name="languageName"> The language name. </param>
        /// <param name="languageCode"> The language code. This is BCP-47 representation of a language. For example, "en" for English, "en-gb" for English (UK), "es" for Spanish etc. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TextAuthoringSupportedLanguage(string languageName, string languageCode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LanguageName = languageName;
            LanguageCode = languageCode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TextAuthoringSupportedLanguage"/> for deserialization. </summary>
        internal TextAuthoringSupportedLanguage()
        {
        }

        /// <summary> The language name. </summary>
        public string LanguageName { get; }
        /// <summary> The language code. This is BCP-47 representation of a language. For example, "en" for English, "en-gb" for English (UK), "es" for Spanish etc. </summary>
        public string LanguageCode { get; }
    }
}
