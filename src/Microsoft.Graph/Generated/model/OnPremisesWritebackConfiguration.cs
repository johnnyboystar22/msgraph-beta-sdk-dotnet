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
    /// The type OnPremisesWritebackConfiguration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<OnPremisesWritebackConfiguration>))]
    public partial class OnPremisesWritebackConfiguration
    {

        /// <summary>
        /// Gets or sets unifiedGroupContainer.
        /// The distinguished name of the on-premises container that the customer is using to store unified groups which are created in the cloud.
        /// </summary>
        [JsonPropertyName("unifiedGroupContainer")]
        public string UnifiedGroupContainer { get; set; }
    
        /// <summary>
        /// Gets or sets userContainer.
        /// The distinguished name of the on-premises container that the customer is using to store users which are created in the cloud.
        /// </summary>
        [JsonPropertyName("userContainer")]
        public string UserContainer { get; set; }
    
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
