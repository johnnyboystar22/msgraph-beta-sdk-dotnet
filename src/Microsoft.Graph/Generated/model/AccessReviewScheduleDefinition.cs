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
    /// The type Access Review Schedule Definition.
    /// </summary>
    public partial class AccessReviewScheduleDefinition : Entity
    {
    
        /// <summary>
        /// Gets or sets additional notification recipients.
        /// Defines the list of additional users or group members to be notified of the access review progress.
        /// </summary>
        [JsonPropertyName("additionalNotificationRecipients")]
        public IEnumerable<AccessReviewNotificationRecipientItem> AdditionalNotificationRecipients { get; set; }
    
        /// <summary>
        /// Gets or sets backup reviewers.
        /// </summary>
        [JsonPropertyName("backupReviewers")]
        public IEnumerable<AccessReviewReviewerScope> BackupReviewers { get; set; }
    
        /// <summary>
        /// Gets or sets created by.
        /// User who created this review. Read-only.
        /// </summary>
        [JsonPropertyName("createdBy")]
        public UserIdentity CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Timestamp when the access review series was created. Supports $select. Read-only.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description for admins.
        /// Description provided by review creators to provide more context of the review to admins. Supports $select.
        /// </summary>
        [JsonPropertyName("descriptionForAdmins")]
        public string DescriptionForAdmins { get; set; }
    
        /// <summary>
        /// Gets or sets description for reviewers.
        /// Description provided  by review creators to provide more context of the review to reviewers. Reviewers will see this description in the email sent to them requesting their review. Email notifications support up to 256 characters. Supports $select.
        /// </summary>
        [JsonPropertyName("descriptionForReviewers")]
        public string DescriptionForReviewers { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Name of the access review series. Supports $select and $orderby. Required on create.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets fallback reviewers.
        /// This collection of reviewer scopes is used to define the list of fallback reviewers. These fallback reviewers will be notified to take action if no users are found from the list of reviewers specified. This could occur when either the group owner is specified as the reviewer but the group owner does not exist, or manager is specified as reviewer but a user's manager does not exist. See accessReviewReviewerScope. Replaces backupReviewers. Supports $select. NOTE: The value of this property will be ignored if fallback reviewers are assigned through the stageSettings property.
        /// </summary>
        [JsonPropertyName("fallbackReviewers")]
        public IEnumerable<AccessReviewReviewerScope> FallbackReviewers { get; set; }
    
        /// <summary>
        /// Gets or sets instance enumeration scope.
        /// This property is required when scoping a review to guest users' access across all Microsoft 365 groups and determines which Microsoft 365 groups are reviewed. Each group will become a unique accessReviewInstance of the access review series.  For supported scopes, see accessReviewScope. Supports $select. For examples of options for configuring instanceEnumerationScope, see Configure the scope of your access review definition using the Microsoft Graph API.
        /// </summary>
        [JsonPropertyName("instanceEnumerationScope")]
        public AccessReviewScope InstanceEnumerationScope { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Timestamp when the access review series was last modified. Supports $select. Read-only.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets reviewers.
        /// This collection of access review scopes is used to define who are the reviewers. The reviewers property is only updatable if individual users are assigned as reviewers. Required on create. Supports $select. For examples of options for assigning reviewers, see Assign reviewers to your access review definition using the Microsoft Graph API. NOTE: The value of this property will be ignored if reviewers are assigned through the stageSettings property.
        /// </summary>
        [JsonPropertyName("reviewers")]
        public IEnumerable<AccessReviewReviewerScope> Reviewers { get; set; }
    
        /// <summary>
        /// Gets or sets scope.
        /// Defines the entities whose access is reviewed. For supported scopes, see accessReviewScope. Required on create. Supports $select and $filter (contains only). For examples of options for configuring scope, see Configure the scope of your access review definition using the Microsoft Graph API.
        /// </summary>
        [JsonPropertyName("scope")]
        public AccessReviewScope Scope { get; set; }
    
        /// <summary>
        /// Gets or sets settings.
        /// The settings for an access review series, see type definition below. Supports $select. Required on create.
        /// </summary>
        [JsonPropertyName("settings")]
        public AccessReviewScheduleSettings Settings { get; set; }
    
        /// <summary>
        /// Gets or sets stage settings.
        /// Required only for a multi-stage access review to define the stages and their settings. You can break down each review instance into up to three sequential stages, where each stage can have a different set of reviewers, fallback reviewers, and settings. Stages will be created sequentially based on the dependsOn property. Optional.  When this property is defined, its settings are used instead of the corresponding settings in the accessReviewScheduleDefinition object and its settings, reviewers, and fallbackReviewers properties.
        /// </summary>
        [JsonPropertyName("stageSettings")]
        public IEnumerable<AccessReviewStageSettings> StageSettings { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// This read-only field specifies the status of an access review. The typical states include Initializing, NotStarted, Starting, InProgress, Completing, Completed, AutoReviewing, and AutoReviewed.  Supports $select, $orderby, and $filter (eq only). Read-only.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or sets instances.
        /// Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.
        /// </summary>
        [JsonPropertyName("instances")]
        public IAccessReviewScheduleDefinitionInstancesCollectionPage Instances { get; set; }

        /// <summary>
        /// Gets or sets instancesNextLink.
        /// </summary>
        [JsonPropertyName("instances@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string InstancesNextLink { get; set; }
    
    }
}

