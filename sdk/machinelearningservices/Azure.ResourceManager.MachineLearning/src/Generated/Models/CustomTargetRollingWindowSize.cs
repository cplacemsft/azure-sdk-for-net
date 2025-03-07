// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The CustomTargetRollingWindowSize. </summary>
    public partial class CustomTargetRollingWindowSize : TargetRollingWindowSize
    {
        /// <summary> Initializes a new instance of <see cref="CustomTargetRollingWindowSize"/>. </summary>
        /// <param name="value"> [Required] TargetRollingWindowSize value. </param>
        public CustomTargetRollingWindowSize(int value)
        {
            Value = value;
            Mode = TargetRollingWindowSizeMode.Custom;
        }

        /// <summary> Initializes a new instance of <see cref="CustomTargetRollingWindowSize"/>. </summary>
        /// <param name="mode"> [Required] TargetRollingWindowSiz detection mode. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="value"> [Required] TargetRollingWindowSize value. </param>
        internal CustomTargetRollingWindowSize(TargetRollingWindowSizeMode mode, IDictionary<string, BinaryData> serializedAdditionalRawData, int value) : base(mode, serializedAdditionalRawData)
        {
            Value = value;
            Mode = mode;
        }

        /// <summary> Initializes a new instance of <see cref="CustomTargetRollingWindowSize"/> for deserialization. </summary>
        internal CustomTargetRollingWindowSize()
        {
        }

        /// <summary> [Required] TargetRollingWindowSize value. </summary>
        [WirePath("value")]
        public int Value { get; set; }
    }
}
