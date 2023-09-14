// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph.WindowsUpdates
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum MonitoringAction.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MonitoringAction
    {
    
        /// <summary>
        /// Alert Error
        /// </summary>
        AlertError = 0,
	
        /// <summary>
        /// Offer Fallback
        /// </summary>
        OfferFallback = 1,
	
        /// <summary>
        /// Pause Deployment
        /// </summary>
        PauseDeployment = 3,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 4,
	
    }
}
