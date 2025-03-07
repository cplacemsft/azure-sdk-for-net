// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Authoring
{
    /// <summary> Represents the orchestration options for a LUIS application target. </summary>
    public partial class ExportedLuisOrchestrationDetails : ExportedOrchestrationDetails
    {
        /// <summary> Initializes a new instance of <see cref="ExportedLuisOrchestrationDetails"/>. </summary>
        /// <param name="luisOrchestration"> The LUIS application target details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="luisOrchestration"/> is null. </exception>
        public ExportedLuisOrchestrationDetails(ExportedLuisOrchestration luisOrchestration)
        {
            Argument.AssertNotNull(luisOrchestration, nameof(luisOrchestration));

            TargetProjectKind = OrchestrationTargetProjectKind.Luis;
            LuisOrchestration = luisOrchestration;
        }

        /// <summary> Initializes a new instance of <see cref="ExportedLuisOrchestrationDetails"/>. </summary>
        /// <param name="targetProjectKind"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="luisOrchestration"> The LUIS application target details. </param>
        internal ExportedLuisOrchestrationDetails(OrchestrationTargetProjectKind targetProjectKind, IDictionary<string, BinaryData> serializedAdditionalRawData, ExportedLuisOrchestration luisOrchestration) : base(targetProjectKind, serializedAdditionalRawData)
        {
            LuisOrchestration = luisOrchestration;
        }

        /// <summary> Initializes a new instance of <see cref="ExportedLuisOrchestrationDetails"/> for deserialization. </summary>
        internal ExportedLuisOrchestrationDetails()
        {
        }

        /// <summary> The LUIS application target details. </summary>
        public ExportedLuisOrchestration LuisOrchestration { get; }
    }
}
