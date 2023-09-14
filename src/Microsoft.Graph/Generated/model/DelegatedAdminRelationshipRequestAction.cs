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
    /// The enum DelegatedAdminRelationshipRequestAction.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DelegatedAdminRelationshipRequestAction
    {
    
        /// <summary>
        /// Lock For Approval
        /// </summary>
        LockForApproval = 0,
	
        /// <summary>
        /// Approve
        /// </summary>
        Approve = 1,
	
        /// <summary>
        /// Terminate
        /// </summary>
        Terminate = 2,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 3,
	
        /// <summary>
        /// Reject
        /// </summary>
        Reject = 4,
	
    }
}
