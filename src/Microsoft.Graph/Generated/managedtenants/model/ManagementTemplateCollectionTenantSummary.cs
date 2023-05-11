// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Management Template Collection Tenant Summary.
    /// </summary>
    public partial class ManagementTemplateCollectionTenantSummary : Microsoft.Graph.Entity
    {
    
        /// <summary>
        /// Gets or sets complete steps count.
        /// </summary>
        [JsonPropertyName("completeStepsCount")]
        public Int32? CompleteStepsCount { get; set; }
    
        /// <summary>
        /// Gets or sets complete users count.
        /// </summary>
        [JsonPropertyName("completeUsersCount")]
        public Int32? CompleteUsersCount { get; set; }
    
        /// <summary>
        /// Gets or sets created by user id.
        /// </summary>
        [JsonPropertyName("createdByUserId")]
        public string CreatedByUserId { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets dismissed steps count.
        /// </summary>
        [JsonPropertyName("dismissedStepsCount")]
        public Int32? DismissedStepsCount { get; set; }
    
        /// <summary>
        /// Gets or sets excluded users count.
        /// </summary>
        [JsonPropertyName("excludedUsersCount")]
        public Int32? ExcludedUsersCount { get; set; }
    
        /// <summary>
        /// Gets or sets excluded users distinct count.
        /// </summary>
        [JsonPropertyName("excludedUsersDistinctCount")]
        public Int32? ExcludedUsersDistinctCount { get; set; }
    
        /// <summary>
        /// Gets or sets incomplete steps count.
        /// </summary>
        [JsonPropertyName("incompleteStepsCount")]
        public Int32? IncompleteStepsCount { get; set; }
    
        /// <summary>
        /// Gets or sets incomplete users count.
        /// </summary>
        [JsonPropertyName("incompleteUsersCount")]
        public Int32? IncompleteUsersCount { get; set; }
    
        /// <summary>
        /// Gets or sets ineligible steps count.
        /// </summary>
        [JsonPropertyName("ineligibleStepsCount")]
        public Int32? IneligibleStepsCount { get; set; }
    
        /// <summary>
        /// Gets or sets is complete.
        /// </summary>
        [JsonPropertyName("isComplete")]
        public bool? IsComplete { get; set; }
    
        /// <summary>
        /// Gets or sets last action by user id.
        /// </summary>
        [JsonPropertyName("lastActionByUserId")]
        public string LastActionByUserId { get; set; }
    
        /// <summary>
        /// Gets or sets last action date time.
        /// </summary>
        [JsonPropertyName("lastActionDateTime")]
        public DateTimeOffset? LastActionDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets management template collection display name.
        /// </summary>
        [JsonPropertyName("managementTemplateCollectionDisplayName")]
        public string ManagementTemplateCollectionDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets management template collection id.
        /// </summary>
        [JsonPropertyName("managementTemplateCollectionId")]
        public string ManagementTemplateCollectionId { get; set; }
    
        /// <summary>
        /// Gets or sets regressed steps count.
        /// </summary>
        [JsonPropertyName("regressedStepsCount")]
        public Int32? RegressedStepsCount { get; set; }
    
        /// <summary>
        /// Gets or sets regressed users count.
        /// </summary>
        [JsonPropertyName("regressedUsersCount")]
        public Int32? RegressedUsersCount { get; set; }
    
        /// <summary>
        /// Gets or sets tenant id.
        /// </summary>
        [JsonPropertyName("tenantId")]
        public string TenantId { get; set; }
    
        /// <summary>
        /// Gets or sets unlicensed users count.
        /// </summary>
        [JsonPropertyName("unlicensedUsersCount")]
        public Int32? UnlicensedUsersCount { get; set; }
    
    }
}

