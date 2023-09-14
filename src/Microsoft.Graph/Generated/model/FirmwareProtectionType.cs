// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum FirmwareProtectionType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FirmwareProtectionType
    {
    
        /// <summary>
        /// Not Applicable
        /// </summary>
        NotApplicable = 0,
	
        /// <summary>
        /// System Guard Secure Launch
        /// </summary>
        SystemGuardSecureLaunch = 1,
	
        /// <summary>
        /// Firmware Attack Surface Reduction
        /// </summary>
        FirmwareAttackSurfaceReduction = 2,
	
        /// <summary>
        /// Disabled
        /// </summary>
        Disabled = 3,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 4,
	
    }
}
