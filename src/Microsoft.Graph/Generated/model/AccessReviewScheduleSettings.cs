// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type AccessReviewScheduleSettings.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AccessReviewScheduleSettings>))]
    public partial class AccessReviewScheduleSettings
    {

        /// <summary>
        /// Gets or sets applyActions.
        /// Optional field. Describes the  actions to take once a review is complete. There are two types that are currently supported: removeAccessApplyAction (default) and disableAndDeleteUserApplyAction. Field only needs to be specified in the case of disableAndDeleteUserApplyAction.
        /// </summary>
        [JsonPropertyName("applyActions")]
        public IEnumerable<AccessReviewApplyAction> ApplyActions { get; set; }
    
        /// <summary>
        /// Gets or sets autoApplyDecisionsEnabled.
        /// Indicates whether decisions are automatically applied. When set to false, an admin must apply the decisions manually once the reviewer completes the access review. When set to true, decisions are applied automatically after the access review instance duration ends, whether or not the reviewers have responded. Default value is false.  CAUTION: If both autoApplyDecisionsEnabled and defaultDecisionEnabled are true, all access for the principals to the resource risks being revoked if the reviewers fail to respond.
        /// </summary>
        [JsonPropertyName("autoApplyDecisionsEnabled")]
        public bool? AutoApplyDecisionsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets decisionHistoriesForReviewersEnabled.
        /// Indicates whether decisions on previous access review stages are available for reviewers on an accessReviewInstance with multiple subsequent stages. If not provided, the default is disabled (false).
        /// </summary>
        [JsonPropertyName("decisionHistoriesForReviewersEnabled")]
        public bool? DecisionHistoriesForReviewersEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets defaultDecision.
        /// Decision chosen if defaultDecisionEnabled is enabled. Can be one of Approve, Deny, or Recommendation.
        /// </summary>
        [JsonPropertyName("defaultDecision")]
        public string DefaultDecision { get; set; }
    
        /// <summary>
        /// Gets or sets defaultDecisionEnabled.
        /// Indicates whether the default decision is enabled or disabled when reviewers do not respond. Default value is false.  CAUTION: If both autoApplyDecisionsEnabled and defaultDecisionEnabled are true, all access for the principals to the resource risks being revoked if the reviewers fail to respond.
        /// </summary>
        [JsonPropertyName("defaultDecisionEnabled")]
        public bool? DefaultDecisionEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets instanceDurationInDays.
        /// Duration of each recurrence of review (accessReviewInstance) in number of days. NOTE: If the stageSettings of the accessReviewScheduleDefinition object is defined, its durationInDays setting will be used instead of the value of this property.
        /// </summary>
        [JsonPropertyName("instanceDurationInDays")]
        public Int32? InstanceDurationInDays { get; set; }
    
        /// <summary>
        /// Gets or sets justificationRequiredOnApproval.
        /// Indicates whether reviewers are required to provide justification with their decision. Default value is false.
        /// </summary>
        [JsonPropertyName("justificationRequiredOnApproval")]
        public bool? JustificationRequiredOnApproval { get; set; }
    
        /// <summary>
        /// Gets or sets mailNotificationsEnabled.
        /// Indicates whether emails are enabled or disabled. Default value is false.
        /// </summary>
        [JsonPropertyName("mailNotificationsEnabled")]
        public bool? MailNotificationsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets recommendationInsightSettings.
        /// Optional. Describes the types of insights that aid reviewers to make access review decisions. NOTE: If the stageSettings of the accessReviewScheduleDefinition object is defined, its recommendationInsightSettings setting will be used instead of the value of this property.
        /// </summary>
        [JsonPropertyName("recommendationInsightSettings")]
        public IEnumerable<AccessReviewRecommendationInsightSetting> RecommendationInsightSettings { get; set; }
    
        /// <summary>
        /// Gets or sets recommendationLookBackDuration.
        /// Optional field. Indicates the period of inactivity (with respect to the start date of the review instance) that recommendations will be configured from. The recommendation will be to deny if the user is inactive during the look-back duration. For reviews of groups and Azure AD roles, any duration is accepted. For reviews of applications, 30 days is the maximum duration. If not specified, the duration is 30 days. NOTE: If the stageSettings of the accessReviewScheduleDefinition object is defined, its recommendationLookBackDuration setting will be used instead of the value of this property.
        /// </summary>
        [JsonPropertyName("recommendationLookBackDuration")]
        public Duration RecommendationLookBackDuration { get; set; }
    
        /// <summary>
        /// Gets or sets recommendationsEnabled.
        /// Indicates whether decision recommendations are enabled or disabled. NOTE: If the stageSettings of the accessReviewScheduleDefinition object is defined, its recommendationsEnabled setting will be used instead of the value of this property.
        /// </summary>
        [JsonPropertyName("recommendationsEnabled")]
        public bool? RecommendationsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets recurrence.
        /// Detailed settings for recurrence using the standard Outlook recurrence object. Note: Only dayOfMonth, interval, and type (weekly, absoluteMonthly) properties are supported. Use the property startDate on recurrenceRange to determine the day the review starts.
        /// </summary>
        [JsonPropertyName("recurrence")]
        public PatternedRecurrence Recurrence { get; set; }
    
        /// <summary>
        /// Gets or sets reminderNotificationsEnabled.
        /// Indicates whether reminders are enabled or disabled. Default value is false.
        /// </summary>
        [JsonPropertyName("reminderNotificationsEnabled")]
        public bool? ReminderNotificationsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
