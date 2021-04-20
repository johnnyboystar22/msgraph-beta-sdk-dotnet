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
    /// The enum AccessReviewHistoryDecisionFilter.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AccessReviewHistoryDecisionFilter
    {
    
        /// <summary>
        /// Approve
        /// </summary>
        Approve = 0,
	
        /// <summary>
        /// Deny
        /// </summary>
        Deny = 1,
	
        /// <summary>
        /// Not Reviewed
        /// </summary>
        NotReviewed = 2,
	
        /// <summary>
        /// Dont Know
        /// </summary>
        DontKnow = 3,
	
        /// <summary>
        /// Not Notified
        /// </summary>
        NotNotified = 4,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 5,
	
    }
}
