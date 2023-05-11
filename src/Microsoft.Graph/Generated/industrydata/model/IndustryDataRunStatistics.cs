// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.IndustryData
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type IndustryDataRunStatistics.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<IndustryDataRunStatistics>))]
    public partial class IndustryDataRunStatistics
    {

        /// <summary>
        /// Gets or sets activityStatistics.
        /// The collection of statistics for each activity included in this run.
        /// </summary>
        [JsonPropertyName("activityStatistics")]
        public IEnumerable<IndustryDataActivityStatistics> ActivityStatistics { get; set; }
    
        /// <summary>
        /// Gets or sets inboundTotals.
        /// The aggregate statistics for all inbound flows.
        /// </summary>
        [JsonPropertyName("inboundTotals")]
        public AggregatedInboundStatistics InboundTotals { get; set; }
    
        /// <summary>
        /// Gets or sets runId.
        /// The ID of the underlying run for the statistics.
        /// </summary>
        [JsonPropertyName("runId")]
        public string RunId { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// The latest status of the run. The possible values are: running, failed, completed, completedWithErrors, completedWithWarnings, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("status")]
        public IndustryDataRunStatus? Status { get; set; }
    
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
