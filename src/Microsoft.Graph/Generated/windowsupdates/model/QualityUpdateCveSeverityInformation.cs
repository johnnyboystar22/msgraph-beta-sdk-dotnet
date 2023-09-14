// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.WindowsUpdates
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type QualityUpdateCveSeverityInformation.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<QualityUpdateCveSeverityInformation>))]
    public partial class QualityUpdateCveSeverityInformation
    {

        /// <summary>
        /// Gets or sets maxBaseScore.
        /// Highest base score that occurs of any CVE addressed by the quality update. Read-only.
        /// </summary>
        [JsonPropertyName("maxBaseScore")]
        public double? MaxBaseScore { get; set; }
    
        /// <summary>
        /// Gets or sets maxSeverity.
        /// </summary>
        [JsonPropertyName("maxSeverity")]
        public CveSeverityLevel? MaxSeverity { get; set; }
    
        /// <summary>
        /// Gets or sets exploitedCves.
        /// </summary>
        [JsonPropertyName("exploitedCves")]
        public IEnumerable<CveInformation> ExploitedCves { get; set; }
    
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
