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
    /// The type IndustryDataActivityStatistics.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<IndustryDataActivityStatistics>))]
    public partial class IndustryDataActivityStatistics
    {

        ///<summary>
        /// The internal IndustryDataActivityStatistics constructor
        ///</summary>
        protected internal IndustryDataActivityStatistics()
        {
            // Don't allow initialization of abstract complex types
        }

        /// <summary>
        /// Gets or sets activityId.
        /// The identifier for the activity that is being reported on.
        /// </summary>
        [JsonPropertyName("activityId")]
        public string ActivityId { get; set; }
    
        /// <summary>
        /// Gets or sets displayName.
        /// The display name of the underlying flow.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// The latest status of the activity in the run. The possible values are: inProgress, skipped, failed, completed, completedWithErrors, completedWithWarnings, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("status")]
        public IndustryDataActivityStatus? Status { get; set; }
    
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
