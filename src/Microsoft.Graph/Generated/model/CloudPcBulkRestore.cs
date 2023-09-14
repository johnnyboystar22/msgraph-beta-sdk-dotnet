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
    /// The type Cloud Pc Bulk Restore.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<CloudPcBulkRestore>))]
    public partial class CloudPcBulkRestore : CloudPcBulkAction
    {
    
        ///<summary>
        /// The CloudPcBulkRestore constructor
        ///</summary>
        public CloudPcBulkRestore()
        {
            this.ODataType = "microsoft.graph.cloudPcBulkRestore";
        }

        /// <summary>
        /// Gets or sets restore point date time.
        /// </summary>
        [JsonPropertyName("restorePointDateTime")]
        public DateTimeOffset? RestorePointDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets time range.
        /// </summary>
        [JsonPropertyName("timeRange")]
        public RestoreTimeRange? TimeRange { get; set; }
    
    }
}

