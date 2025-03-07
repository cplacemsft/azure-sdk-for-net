// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The ExternalStorage. </summary>
    internal partial class RecordingStorageInternal
    {
        /// <summary> Initializes a new instance of <see cref="RecordingStorageInternal"/>. </summary>
        /// <param name="recordingStorageKind"> Defines the kind of external storage. </param>
        public RecordingStorageInternal(RecordingStorageKind recordingStorageKind)
        {
            RecordingStorageKind = recordingStorageKind;
        }

        /// <summary> Initializes a new instance of <see cref="RecordingStorageInternal"/>. </summary>
        /// <param name="recordingStorageKind"> Defines the kind of external storage. </param>
        /// <param name="recordingDestinationContainerUrl"> Uri of a container or a location within a container. </param>
        internal RecordingStorageInternal(RecordingStorageKind recordingStorageKind, Uri recordingDestinationContainerUrl)
        {
            RecordingStorageKind = recordingStorageKind;
            RecordingDestinationContainerUrl = recordingDestinationContainerUrl;
        }

        /// <summary> Defines the kind of external storage. </summary>
        public RecordingStorageKind RecordingStorageKind { get; }
        /// <summary> Uri of a container or a location within a container. </summary>
        public Uri RecordingDestinationContainerUrl { get; set; }
    }
}
