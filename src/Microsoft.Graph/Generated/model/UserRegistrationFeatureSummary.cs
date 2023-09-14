// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type UserRegistrationFeatureSummary.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<UserRegistrationFeatureSummary>))]
    public partial class UserRegistrationFeatureSummary
    {

        /// <summary>
        /// Gets or sets totalUserCount.
        /// Total number of users accounts, excluding those that are blocked.
        /// </summary>
        [JsonPropertyName("totalUserCount")]
        public Int64? TotalUserCount { get; set; }
    
        /// <summary>
        /// Gets or sets userRegistrationFeatureCounts.
        /// Number of users registered or capable for multi-factor authentication, self-service password reset, and passwordless authentication.
        /// </summary>
        [JsonPropertyName("userRegistrationFeatureCounts")]
        public IEnumerable<UserRegistrationFeatureCount> UserRegistrationFeatureCounts { get; set; }
    
        /// <summary>
        /// Gets or sets userRoles.
        /// The role type of the user. Possible values are: all, privilegedAdmin, admin, user, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("userRoles")]
        public IncludedUserRoles? UserRoles { get; set; }
    
        /// <summary>
        /// Gets or sets userTypes.
        /// User type. Possible values are: all, member, guest, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("userTypes")]
        public IncludedUserTypes? UserTypes { get; set; }
    
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
