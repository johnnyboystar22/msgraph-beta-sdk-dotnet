// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph.SecurityNamespace
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum StopAndQuarantineFileEntityIdentifier.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
	[System.Flags]
    public enum StopAndQuarantineFileEntityIdentifier
    {
    
        /// <summary>
        /// Device Id
        /// </summary>
        DeviceId = 1,
	
        /// <summary>
        /// Sha1
        /// </summary>
        Sha1 = 2,
	
        /// <summary>
        /// Initiating Process SHA1
        /// </summary>
        InitiatingProcessSHA1 = 4,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 8,
	
    }
}
