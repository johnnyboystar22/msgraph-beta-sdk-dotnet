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
    /// The type RiskProfile.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<RiskProfile>))]
    public partial class RiskProfile
    {

        /// <summary>
        /// Gets or sets humanCount.
        /// </summary>
        [JsonPropertyName("humanCount")]
        public Int32? HumanCount { get; set; }
    
        /// <summary>
        /// Gets or sets nonHumanCount.
        /// </summary>
        [JsonPropertyName("nonHumanCount")]
        public Int32? NonHumanCount { get; set; }
    
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
