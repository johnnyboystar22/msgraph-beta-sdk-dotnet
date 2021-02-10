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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type AssignmentFilterEvaluationSummary.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class AssignmentFilterEvaluationSummary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssignmentFilterEvaluationSummary"/> class.
        /// </summary>
        public AssignmentFilterEvaluationSummary()
        {
            this.ODataType = "microsoft.graph.assignmentFilterEvaluationSummary";
        }

        /// <summary>
        /// Gets or sets assignmentFilterDisplayName.
        /// The admin defined name for assignment filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignmentFilterDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string AssignmentFilterDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets assignmentFilterId.
        /// Unique identifier for the assignment filter object
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignmentFilterId", Required = Newtonsoft.Json.Required.Default)]
        public string AssignmentFilterId { get; set; }
    
        /// <summary>
        /// Gets or sets assignmentFilterLastModifiedDateTime.
        /// The time the assignment filter was last modified.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignmentFilterLastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? AssignmentFilterLastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets assignmentFilterPlatform.
        /// The platform for which this assignment filter is created. Possible values are: android, androidForWork, iOS, macOS, windowsPhone81, windows81AndLater, windows10AndLater, androidWorkProfile, unknown.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignmentFilterPlatform", Required = Newtonsoft.Json.Required.Default)]
        public DevicePlatformType? AssignmentFilterPlatform { get; set; }
    
        /// <summary>
        /// Gets or sets assignmentFilterType.
        /// Indicate filter type either include or exclude. Possible values are: none, include, exclude.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignmentFilterType", Required = Newtonsoft.Json.Required.Default)]
        public DeviceAndAppManagementAssignmentFilterType? AssignmentFilterType { get; set; }
    
        /// <summary>
        /// Gets or sets evaluationDateTime.
        /// The time assignment filter was evaluated.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "evaluationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? EvaluationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets evaluationResult.
        /// Assignment filter evaluation result. Possible values are: unknown, match, notMatch, inconclusive, failure, notEvaluated.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "evaluationResult", Required = Newtonsoft.Json.Required.Default)]
        public AssignmentFilterEvaluationResult? EvaluationResult { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
