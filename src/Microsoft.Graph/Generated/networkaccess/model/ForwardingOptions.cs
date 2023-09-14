// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.Networkaccess
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Forwarding Options.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<ForwardingOptions>))]
    public partial class ForwardingOptions : Microsoft.Graph.Entity
    {
    
        /// <summary>
        /// Gets or sets skip dns lookup state.
        /// Dns lookup options. The possible values are: enabled, disabled.
        /// </summary>
        [JsonPropertyName("skipDnsLookupState")]
        public Status? SkipDnsLookupState { get; set; }
    
    }
}

