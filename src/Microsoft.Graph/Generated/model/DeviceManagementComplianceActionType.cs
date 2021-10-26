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
    /// The enum DeviceManagementComplianceActionType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DeviceManagementComplianceActionType
    {
    
        /// <summary>
        /// No Action
        /// </summary>
        NoAction = 0,
	
        /// <summary>
        /// Notification
        /// </summary>
        Notification = 1,
	
        /// <summary>
        /// Block
        /// </summary>
        Block = 2,
	
        /// <summary>
        /// Retire
        /// </summary>
        Retire = 3,
	
        /// <summary>
        /// Wipe
        /// </summary>
        Wipe = 4,
	
        /// <summary>
        /// Remove Resource Access Profiles
        /// </summary>
        RemoveResourceAccessProfiles = 5,
	
        /// <summary>
        /// Push Notification
        /// </summary>
        PushNotification = 9,
	
        /// <summary>
        /// Remote Lock
        /// </summary>
        RemoteLock = 10,
	
    }
}
