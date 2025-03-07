// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.ShortCodes.Models
{
    /// <summary> A phone number. </summary>
    internal partial class PhoneNumberIdentifierModel
    {
        /// <summary> Initializes a new instance of <see cref="PhoneNumberIdentifierModel"/>. </summary>
        /// <param name="value"> The phone number in E.164 format. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal PhoneNumberIdentifierModel(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value;
        }

        /// <summary> The phone number in E.164 format. </summary>
        public string Value { get; }
    }
}
