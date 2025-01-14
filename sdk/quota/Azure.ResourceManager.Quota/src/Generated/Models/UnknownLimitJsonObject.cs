// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Quota.Models
{
    /// <summary> The UnknownLimitJsonObject. </summary>
    internal partial class UnknownLimitJsonObject : QuotaLimitJsonObject
    {
        /// <summary> Initializes a new instance of <see cref="UnknownLimitJsonObject"/>. </summary>
        /// <param name="limitObjectType"> The limit object type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownLimitJsonObject(LimitType limitObjectType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(limitObjectType, serializedAdditionalRawData)
        {
            LimitObjectType = limitObjectType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownLimitJsonObject"/> for deserialization. </summary>
        internal UnknownLimitJsonObject()
        {
        }
    }
}
