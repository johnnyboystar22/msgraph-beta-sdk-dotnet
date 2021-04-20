// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Team.
    /// </summary>
    public partial class Team : Entity
    {
    
		///<summary>
		/// The Team constructor
		///</summary>
        public Team()
        {
            this.ODataType = "microsoft.graph.team";
        }
	
        /// <summary>
        /// Gets or sets classification.
        /// An optional label. Typically describes the data or business sensitivity of the team. Must match one of a pre-configured set in the tenant's directory.
        /// </summary>
        [JsonPropertyName("classification")]
        public string Classification { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Timestamp at which the team was created.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// An optional description for the team.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets discovery settings.
        /// Settings to configure team discoverability by others.
        /// </summary>
        [JsonPropertyName("discoverySettings")]
        public TeamDiscoverySettings DiscoverySettings { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The name of the team.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets fun settings.
        /// Settings to configure use of Giphy, memes, and stickers in the team.
        /// </summary>
        [JsonPropertyName("funSettings")]
        public TeamFunSettings FunSettings { get; set; }
    
        /// <summary>
        /// Gets or sets guest settings.
        /// Settings to configure whether guests can create, update, or delete channels in the team.
        /// </summary>
        [JsonPropertyName("guestSettings")]
        public TeamGuestSettings GuestSettings { get; set; }
    
        /// <summary>
        /// Gets or sets internal id.
        /// A unique ID for the team that has been used in a few places such as the audit log/Office 365 Management Activity API.
        /// </summary>
        [JsonPropertyName("internalId")]
        public string InternalId { get; set; }
    
        /// <summary>
        /// Gets or sets is archived.
        /// Whether this team is in read-only mode.
        /// </summary>
        [JsonPropertyName("isArchived")]
        public bool? IsArchived { get; set; }
    
        /// <summary>
        /// Gets or sets is membership limited to owners.
        /// If set to true, the team is currently in the owner-only team membership state and not accessible by other team members, such as students.
        /// </summary>
        [JsonPropertyName("isMembershipLimitedToOwners")]
        public bool? IsMembershipLimitedToOwners { get; set; }
    
        /// <summary>
        /// Gets or sets member settings.
        /// Settings to configure whether members can perform certain actions, for example, create channels and add bots, in the team.
        /// </summary>
        [JsonPropertyName("memberSettings")]
        public TeamMemberSettings MemberSettings { get; set; }
    
        /// <summary>
        /// Gets or sets messaging settings.
        /// Settings to configure messaging and mentions in the team.
        /// </summary>
        [JsonPropertyName("messagingSettings")]
        public TeamMessagingSettings MessagingSettings { get; set; }
    
        /// <summary>
        /// Gets or sets specialization.
        /// Optional. Indicates whether the team is intended for a particular use case.  Each team specialization has access to unique behaviors and experiences targeted to its use case.
        /// </summary>
        [JsonPropertyName("specialization")]
        public TeamSpecialization? Specialization { get; set; }
    
        /// <summary>
        /// Gets or sets visibility.
        /// The visibility of the group and team. Defaults to Public.
        /// </summary>
        [JsonPropertyName("visibility")]
        public TeamVisibilityType? Visibility { get; set; }
    
        /// <summary>
        /// Gets or sets web url.
        /// A hyperlink that will go to the team in the Microsoft Teams client. This is the URL that you get when you right-click a team in the Microsoft Teams client and select Get link to team. This URL should be treated as an opaque blob, and not parsed.
        /// </summary>
        [JsonPropertyName("webUrl")]
        public string WebUrl { get; set; }
    
        /// <summary>
        /// Gets or sets channels.
        /// The collection of channels &amp; messages associated with the team.
        /// </summary>
        [JsonPropertyName("channels")]
        public ITeamChannelsCollectionPage Channels { get; set; }

        /// <summary>
        /// Gets or sets channelsNextLink.
        /// </summary>
        [JsonPropertyName("channels@odata.nextLink")]
        public string ChannelsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets group.
        /// </summary>
        [JsonPropertyName("group")]
        public Group Group { get; set; }
    
        /// <summary>
        /// Gets or sets installed apps.
        /// The apps installed in this team.
        /// </summary>
        [JsonPropertyName("installedApps")]
        public ITeamInstalledAppsCollectionPage InstalledApps { get; set; }

        /// <summary>
        /// Gets or sets installedAppsNextLink.
        /// </summary>
        [JsonPropertyName("installedApps@odata.nextLink")]
        public string InstalledAppsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets members.
        /// Members and owners of the team.
        /// </summary>
        [JsonPropertyName("members")]
        public ITeamMembersCollectionPage Members { get; set; }

        /// <summary>
        /// Gets or sets membersNextLink.
        /// </summary>
        [JsonPropertyName("members@odata.nextLink")]
        public string MembersNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets operations.
        /// The async operations that ran or are running on this team.
        /// </summary>
        [JsonPropertyName("operations")]
        public ITeamOperationsCollectionPage Operations { get; set; }

        /// <summary>
        /// Gets or sets operationsNextLink.
        /// </summary>
        [JsonPropertyName("operations@odata.nextLink")]
        public string OperationsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets owners.
        /// The list of this team's owners. Currently, when creating a team using application permissions, exactly one owner must be specified. When using user delegated permissions, no owner can be specified (the current user is the owner). Owner must be specified as an object ID (GUID), not a UPN.
        /// </summary>
        [JsonPropertyName("owners")]
        public ITeamOwnersCollectionWithReferencesPage Owners { get; set; }

        /// <summary>
        /// Gets or sets ownersNextLink.
        /// </summary>
        [JsonPropertyName("owners@odata.nextLink")]
        public string OwnersNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets photo.
        /// The team photo.
        /// </summary>
        [JsonPropertyName("photo")]
        public ProfilePhoto Photo { get; set; }
    
        /// <summary>
        /// Gets or sets primary channel.
        /// The general channel for the team.
        /// </summary>
        [JsonPropertyName("primaryChannel")]
        public Channel PrimaryChannel { get; set; }
    
        /// <summary>
        /// Gets or sets tags.
        /// </summary>
        [JsonPropertyName("tags")]
        public ITeamTagsCollectionPage Tags { get; set; }

        /// <summary>
        /// Gets or sets tagsNextLink.
        /// </summary>
        [JsonPropertyName("tags@odata.nextLink")]
        public string TagsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets template.
        /// The template this team was created from. See available templates.
        /// </summary>
        [JsonPropertyName("template")]
        public TeamsTemplate Template { get; set; }
    
        /// <summary>
        /// Gets or sets schedule.
        /// The schedule of shifts for this team.
        /// </summary>
        [JsonPropertyName("schedule")]
        public Schedule Schedule { get; set; }
    
    }
}

