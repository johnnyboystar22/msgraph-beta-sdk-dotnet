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
    /// The enum IpSecEncryption.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum IpSecEncryption
    {
    
        /// <summary>
        /// None
        /// </summary>
        None = 0,
	
        /// <summary>
        /// Gcm Aes128
        /// </summary>
        GcmAes128 = 1,
	
        /// <summary>
        /// Gcm Aes192
        /// </summary>
        GcmAes192 = 2,
	
        /// <summary>
        /// Gcm Aes256
        /// </summary>
        GcmAes256 = 3,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 4,
	
    }
}
