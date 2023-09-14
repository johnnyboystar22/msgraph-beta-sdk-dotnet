// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum PrintDuplexConfiguration.
    /// </summary>
    [Obsolete("The duplexConfiguration enum type is deprecated and will stop returning data on July 31, 2023. Please use the printDuplexMode enum type instead of this.")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PrintDuplexConfiguration
    {
    
        /// <summary>
        /// Two Sided Long Edge
        /// </summary>
        TwoSidedLongEdge = 0,
	
        /// <summary>
        /// Two Sided Short Edge
        /// </summary>
        TwoSidedShortEdge = 1,
	
        /// <summary>
        /// One Sided
        /// </summary>
        OneSided = 2,
	
    }
}
