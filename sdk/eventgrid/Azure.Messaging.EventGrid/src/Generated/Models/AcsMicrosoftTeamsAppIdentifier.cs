// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> A Microsoft Teams application. </summary>
    public partial class AcsMicrosoftTeamsAppIdentifier
    {
        /// <summary> Initializes a new instance of <see cref="AcsMicrosoftTeamsAppIdentifier"/>. </summary>
        /// <param name="appId"> The Id of the Microsoft Teams application. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="appId"/> is null. </exception>
        internal AcsMicrosoftTeamsAppIdentifier(string appId)
        {
            Argument.AssertNotNull(appId, nameof(appId));

            AppId = appId;
        }

        /// <summary> Initializes a new instance of <see cref="AcsMicrosoftTeamsAppIdentifier"/>. </summary>
        /// <param name="appId"> The Id of the Microsoft Teams application. </param>
        /// <param name="cloud"> The cloud that the Microsoft Teams application belongs to. By default 'public' if missing. </param>
        internal AcsMicrosoftTeamsAppIdentifier(string appId, CommunicationCloudEnvironmentModel? cloud)
        {
            AppId = appId;
            Cloud = cloud;
        }

        /// <summary> The Id of the Microsoft Teams application. </summary>
        public string AppId { get; }
        /// <summary> The cloud that the Microsoft Teams application belongs to. By default 'public' if missing. </summary>
        public CommunicationCloudEnvironmentModel? Cloud { get; }
    }
}
