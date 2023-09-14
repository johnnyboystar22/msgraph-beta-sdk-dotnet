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
    /// The type Print Service Endpoint.
    /// </summary>
    public partial class PrintServiceEndpoint : Entity
    {
    
        /// <summary>
        /// Gets or sets display name.
        /// A human-readable display name for the endpoint.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [Obsolete("The name property is deprecated and will stop returning data on July 31, 2023. Please use the id property instead of this.")]
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets uri.
        /// The URI that can be used to access the service.
        /// </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    
    }
}

