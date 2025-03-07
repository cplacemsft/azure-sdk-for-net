// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> An object representing the detected language for a given text span. </summary>
    public partial class DocumentLanguage
    {
        /// <summary> Initializes a new instance of <see cref="DocumentLanguage"/>. </summary>
        /// <param name="locale"> Detected language.  Value may an ISO 639-1 language code (ex. "en", "fr") or BCP 47 language tag (ex. "zh-Hans"). </param>
        /// <param name="spans"> Location of the text elements in the concatenated content the language applies to. </param>
        /// <param name="confidence"> Confidence of correctly identifying the language. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locale"/> or <paramref name="spans"/> is null. </exception>
        internal DocumentLanguage(string locale, IEnumerable<DocumentSpan> spans, float confidence)
        {
            Argument.AssertNotNull(locale, nameof(locale));
            Argument.AssertNotNull(spans, nameof(spans));

            Locale = locale;
            Spans = spans.ToList();
            Confidence = confidence;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentLanguage"/>. </summary>
        /// <param name="locale"> Detected language.  Value may an ISO 639-1 language code (ex. "en", "fr") or BCP 47 language tag (ex. "zh-Hans"). </param>
        /// <param name="spans"> Location of the text elements in the concatenated content the language applies to. </param>
        /// <param name="confidence"> Confidence of correctly identifying the language. </param>
        internal DocumentLanguage(string locale, IReadOnlyList<DocumentSpan> spans, float confidence)
        {
            Locale = locale;
            Spans = spans;
            Confidence = confidence;
        }

        /// <summary> Detected language.  Value may an ISO 639-1 language code (ex. "en", "fr") or BCP 47 language tag (ex. "zh-Hans"). </summary>
        public string Locale { get; }
        /// <summary> Location of the text elements in the concatenated content the language applies to. </summary>
        public IReadOnlyList<DocumentSpan> Spans { get; }
        /// <summary> Confidence of correctly identifying the language. </summary>
        public float Confidence { get; }
    }
}
