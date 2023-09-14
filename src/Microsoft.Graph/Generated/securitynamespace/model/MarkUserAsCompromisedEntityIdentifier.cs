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
    /// The enum MarkUserAsCompromisedEntityIdentifier.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
	[System.Flags]
    public enum MarkUserAsCompromisedEntityIdentifier
    {
    
        /// <summary>
        /// Account Object Id
        /// </summary>
        AccountObjectId = 1,
	
        /// <summary>
        /// Initiating Process Account Object Id
        /// </summary>
        InitiatingProcessAccountObjectId = 2,
	
        /// <summary>
        /// Service Principal Id
        /// </summary>
        ServicePrincipalId = 4,
	
        /// <summary>
        /// Recipient Object Id
        /// </summary>
        RecipientObjectId = 8,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 16,
	
    }
}
