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
    /// The type AttackSimulationUser.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AttackSimulationUser>))]
    public partial class AttackSimulationUser
    {

        /// <summary>
        /// Gets or sets displayName.
        /// Display name of the user.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets email.
        /// Email address of the user.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }
    
        /// <summary>
        /// Gets or sets outOfOfficeDays.
        /// Number of days the user is OOF during a simulation journey/course of a campaign.
        /// </summary>
        [JsonPropertyName("outOfOfficeDays")]
        public Int32? OutOfOfficeDays { get; set; }
    
        /// <summary>
        /// Gets or sets userId.
        /// The id property value of the user resource that represents the user in the Azure Active Directory tenant.
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    
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
