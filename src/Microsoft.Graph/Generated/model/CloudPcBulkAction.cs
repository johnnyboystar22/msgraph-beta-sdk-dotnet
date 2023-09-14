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
    /// The type Cloud Pc Bulk Action.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<CloudPcBulkAction>))]
    public partial class CloudPcBulkAction : Entity
    {
    
        ///<summary>
        /// The internal CloudPcBulkAction constructor
        ///</summary>
        protected internal CloudPcBulkAction()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets action summary.
        /// </summary>
        [JsonPropertyName("actionSummary")]
        public CloudPcBulkActionSummary ActionSummary { get; set; }
    
        /// <summary>
        /// Gets or sets cloud pc ids.
        /// </summary>
        [JsonPropertyName("cloudPcIds")]
        public IEnumerable<string> CloudPcIds { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
    }
}

