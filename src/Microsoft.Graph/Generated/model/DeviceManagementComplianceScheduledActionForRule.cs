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
    /// The type Device Management Compliance Scheduled Action For Rule.
    /// </summary>
    public partial class DeviceManagementComplianceScheduledActionForRule : Entity
    {
    
        /// <summary>
        /// Gets or sets rule name.
        /// Name of the rule which this scheduled action applies to.
        /// </summary>
        [JsonPropertyName("ruleName")]
        public string RuleName { get; set; }
    
        /// <summary>
        /// Gets or sets scheduled action configurations.
        /// The list of scheduled action configurations for this compliance policy. This collection can contain a maximum of 100 elements.
        /// </summary>
        [JsonPropertyName("scheduledActionConfigurations")]
        public IDeviceManagementComplianceScheduledActionForRuleScheduledActionConfigurationsCollectionWithReferencesPage ScheduledActionConfigurations { get; set; }

        /// <summary>
        /// Gets or sets scheduledActionConfigurationsNextLink.
        /// </summary>
        [JsonPropertyName("scheduledActionConfigurations@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ScheduledActionConfigurationsNextLink { get; set; }
    
    }
}

