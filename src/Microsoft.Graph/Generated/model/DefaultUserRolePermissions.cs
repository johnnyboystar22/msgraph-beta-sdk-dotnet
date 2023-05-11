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
    /// The type DefaultUserRolePermissions.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DefaultUserRolePermissions>))]
    public partial class DefaultUserRolePermissions
    {

        /// <summary>
        /// Gets or sets allowedToCreateApps.
        /// Indicates whether the default user role can create applications.
        /// </summary>
        [JsonPropertyName("allowedToCreateApps")]
        public bool? AllowedToCreateApps { get; set; }
    
        /// <summary>
        /// Gets or sets allowedToCreateSecurityGroups.
        /// Indicates whether the default user role can create security groups.
        /// </summary>
        [JsonPropertyName("allowedToCreateSecurityGroups")]
        public bool? AllowedToCreateSecurityGroups { get; set; }
    
        /// <summary>
        /// Gets or sets allowedToCreateTenants.
        /// Indicates whether the default user role can create tenants.
        /// </summary>
        [JsonPropertyName("allowedToCreateTenants")]
        public bool? AllowedToCreateTenants { get; set; }
    
        /// <summary>
        /// Gets or sets allowedToReadBitlockerKeysForOwnedDevice.
        /// Indicates whether the registered owners of a device can read their own BitLocker recovery keys with default user role.
        /// </summary>
        [JsonPropertyName("allowedToReadBitlockerKeysForOwnedDevice")]
        public bool? AllowedToReadBitlockerKeysForOwnedDevice { get; set; }
    
        /// <summary>
        /// Gets or sets allowedToReadOtherUsers.
        /// Indicates whether the default user role can read other users.
        /// </summary>
        [JsonPropertyName("allowedToReadOtherUsers")]
        public bool? AllowedToReadOtherUsers { get; set; }
    
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
