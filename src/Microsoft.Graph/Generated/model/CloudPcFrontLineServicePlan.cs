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
    /// The type Cloud Pc Front Line Service Plan.
    /// </summary>
    public partial class CloudPcFrontLineServicePlan : Entity
    {
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets total count.
        /// </summary>
        [JsonPropertyName("totalCount")]
        public Int32? TotalCount { get; set; }
    
        /// <summary>
        /// Gets or sets used count.
        /// </summary>
        [JsonPropertyName("usedCount")]
        public Int32? UsedCount { get; set; }
    
    }
}

