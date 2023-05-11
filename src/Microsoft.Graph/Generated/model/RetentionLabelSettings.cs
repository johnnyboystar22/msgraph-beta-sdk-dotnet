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
    /// The type RetentionLabelSettings.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<RetentionLabelSettings>))]
    public partial class RetentionLabelSettings
    {

        /// <summary>
        /// Gets or sets behaviorDuringRetentionPeriod.
        /// </summary>
        [JsonPropertyName("behaviorDuringRetentionPeriod")]
        public Microsoft.Graph.SecurityNamespace.BehaviorDuringRetentionPeriod? BehaviorDuringRetentionPeriod { get; set; }
    
        /// <summary>
        /// Gets or sets isContentUpdateAllowed.
        /// </summary>
        [JsonPropertyName("isContentUpdateAllowed")]
        public bool? IsContentUpdateAllowed { get; set; }
    
        /// <summary>
        /// Gets or sets isDeleteAllowed.
        /// </summary>
        [JsonPropertyName("isDeleteAllowed")]
        public bool? IsDeleteAllowed { get; set; }
    
        /// <summary>
        /// Gets or sets isLabelUpdateAllowed.
        /// </summary>
        [JsonPropertyName("isLabelUpdateAllowed")]
        public bool? IsLabelUpdateAllowed { get; set; }
    
        /// <summary>
        /// Gets or sets isMetadataUpdateAllowed.
        /// </summary>
        [JsonPropertyName("isMetadataUpdateAllowed")]
        public bool? IsMetadataUpdateAllowed { get; set; }
    
        /// <summary>
        /// Gets or sets isRecordLocked.
        /// </summary>
        [JsonPropertyName("isRecordLocked")]
        public bool? IsRecordLocked { get; set; }
    
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
