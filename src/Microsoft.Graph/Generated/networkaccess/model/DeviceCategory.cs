// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph.Networkaccess
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum DeviceCategory.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DeviceCategory
    {
    
        /// <summary>
        /// Client
        /// </summary>
        Client = 0,
	
        /// <summary>
        /// Branch
        /// </summary>
        Branch = 1,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 2,
	
    }
}
