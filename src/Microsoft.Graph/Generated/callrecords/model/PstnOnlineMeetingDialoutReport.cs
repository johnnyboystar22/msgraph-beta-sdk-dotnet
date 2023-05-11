// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.CallRecords
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type PstnOnlineMeetingDialoutReport.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<PstnOnlineMeetingDialoutReport>))]
    public partial class PstnOnlineMeetingDialoutReport
    {

        /// <summary>
        /// Gets or sets currency.
        /// Currency used to calculate the cost of the call. For details, see ISO 4217.
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
    
        /// <summary>
        /// Gets or sets destinationContext.
        /// Indicates whether the call was Domestic (within a country or region) or International (outside a country or region) based on the user's location.
        /// </summary>
        [JsonPropertyName("destinationContext")]
        public string DestinationContext { get; set; }
    
        /// <summary>
        /// Gets or sets totalCallCharge.
        /// Total costs of all the calls within the selected time range, including call charges and connection fees.
        /// </summary>
        [JsonPropertyName("totalCallCharge")]
        public Decimal? TotalCallCharge { get; set; }
    
        /// <summary>
        /// Gets or sets totalCalls.
        /// Total number of dial-out calls within the selected time range.
        /// </summary>
        [JsonPropertyName("totalCalls")]
        public Int32? TotalCalls { get; set; }
    
        /// <summary>
        /// Gets or sets totalCallSeconds.
        /// Total duration of all the calls within the selected time range, in seconds.
        /// </summary>
        [JsonPropertyName("totalCallSeconds")]
        public Int32? TotalCallSeconds { get; set; }
    
        /// <summary>
        /// Gets or sets usageLocation.
        /// Country code of the user. For details, see ISO 3166-1 alpha-2.
        /// </summary>
        [JsonPropertyName("usageLocation")]
        public string UsageLocation { get; set; }
    
        /// <summary>
        /// Gets or sets userDisplayName.
        /// Display name of the user.
        /// </summary>
        [JsonPropertyName("userDisplayName")]
        public string UserDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets userId.
        /// The unique identifier (GUID) of the user in Azure Active Directory.
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets userPrincipalName.
        /// The user principal name (sign-in name) in Azure Active Directory. This is usually the same as the user's SIP address, and can be same as the user's e-mail address.
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
