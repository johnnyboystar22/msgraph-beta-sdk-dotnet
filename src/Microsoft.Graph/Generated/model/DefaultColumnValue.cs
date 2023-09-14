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
    /// The type DefaultColumnValue.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DefaultColumnValue>))]
    public partial class DefaultColumnValue
    {

        /// <summary>
        /// Gets or sets formula.
        /// The formula used to compute the default value for the column.
        /// </summary>
        [JsonPropertyName("formula")]
        public string Formula { get; set; }
    
        /// <summary>
        /// Gets or sets value.
        /// The direct value to use as the default value for the column.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    
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
