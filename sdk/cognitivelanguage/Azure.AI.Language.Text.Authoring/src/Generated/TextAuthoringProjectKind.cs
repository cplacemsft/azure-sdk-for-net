// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Text.Authoring
{
    /// <summary> The TextAuthoringProjectKind. </summary>
    public readonly partial struct TextAuthoringProjectKind : IEquatable<TextAuthoringProjectKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TextAuthoringProjectKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TextAuthoringProjectKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CustomSingleLabelClassificationValue = "CustomSingleLabelClassification";
        private const string CustomMultiLabelClassificationValue = "CustomMultiLabelClassification";
        private const string CustomEntityRecognitionValue = "CustomEntityRecognition";
        private const string CustomAbstractiveSummarizationValue = "CustomAbstractiveSummarization";
        private const string CustomHealthcareValue = "CustomHealthcare";
        private const string CustomTextSentimentValue = "CustomTextSentiment";

        /// <summary> For building a classification model to classify text using your own data. Each file will have only one label. For example, file 1 is classified as A and file 2 is classified as B. </summary>
        public static TextAuthoringProjectKind CustomSingleLabelClassification { get; } = new TextAuthoringProjectKind(CustomSingleLabelClassificationValue);
        /// <summary> For building a classification model to classify text using your own data. Each file can have one or many labels. For example, file 1 is classified as A, B, and C and file 2 is classified as B and C. </summary>
        public static TextAuthoringProjectKind CustomMultiLabelClassification { get; } = new TextAuthoringProjectKind(CustomMultiLabelClassificationValue);
        /// <summary> For building an extraction model to identify your domain categories using your own data. </summary>
        public static TextAuthoringProjectKind CustomEntityRecognition { get; } = new TextAuthoringProjectKind(CustomEntityRecognitionValue);
        /// <summary> For building an abstractive summarization models which are able to summarize long documents. </summary>
        public static TextAuthoringProjectKind CustomAbstractiveSummarization { get; } = new TextAuthoringProjectKind(CustomAbstractiveSummarizationValue);
        /// <summary> For building an text analytics for health model to identify your health domain data. </summary>
        public static TextAuthoringProjectKind CustomHealthcare { get; } = new TextAuthoringProjectKind(CustomHealthcareValue);
        /// <summary> For building a sentiment models which are able to extract sentiment for long documents. </summary>
        public static TextAuthoringProjectKind CustomTextSentiment { get; } = new TextAuthoringProjectKind(CustomTextSentimentValue);
        /// <summary> Determines if two <see cref="TextAuthoringProjectKind"/> values are the same. </summary>
        public static bool operator ==(TextAuthoringProjectKind left, TextAuthoringProjectKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TextAuthoringProjectKind"/> values are not the same. </summary>
        public static bool operator !=(TextAuthoringProjectKind left, TextAuthoringProjectKind right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="TextAuthoringProjectKind"/>. </summary>
        public static implicit operator TextAuthoringProjectKind(string value) => new TextAuthoringProjectKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TextAuthoringProjectKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TextAuthoringProjectKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
