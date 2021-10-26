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
    /// The type Continuous Access Evaluation Policy.
    /// </summary>
    public partial class ContinuousAccessEvaluationPolicy : Entity
    {
    
        /// <summary>
        /// Gets or sets description.
        /// Continuous access evaluation automatically blocks access to resources and applications in near real time when a user's access is removed or a client IP address changes. Read-only.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The value is always Continuous Access Evaluation. Read-only.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets groups.
        /// The collection of group identifiers in scope for evaluation. All groups are in scope when the collection is empty. Read-only.
        /// </summary>
        [JsonPropertyName("groups")]
        public IEnumerable<string> Groups { get; set; }
    
        /// <summary>
        /// Gets or sets is enabled.
        /// true to indicate whether continuous access evaluation should be performed; otherwise false. Read-only.
        /// </summary>
        [JsonPropertyName("isEnabled")]
        public bool? IsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets migrate.
        /// true to indicate that the continuous access evaluation policy settings should be or has been migrated to the conditional access policy.
        /// </summary>
        [JsonPropertyName("migrate")]
        public bool? Migrate { get; set; }
    
        /// <summary>
        /// Gets or sets users.
        /// The collection of user identifiers in scope for evaluation. All users are in scope when the collection is empty. Read-only.
        /// </summary>
        [JsonPropertyName("users")]
        public IEnumerable<string> Users { get; set; }
    
    }
}

