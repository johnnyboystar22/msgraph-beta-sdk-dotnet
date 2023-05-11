// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Privileged Role Assignment.
    /// </summary>
    public partial class PrivilegedRoleAssignment : Entity
    {
    
        /// <summary>
        /// Gets or sets expiration date time.
        /// </summary>
        [JsonPropertyName("expirationDateTime")]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets is elevated.
        /// </summary>
        [JsonPropertyName("isElevated")]
        public bool? IsElevated { get; set; }
    
        /// <summary>
        /// Gets or sets result message.
        /// </summary>
        [JsonPropertyName("resultMessage")]
        public string ResultMessage { get; set; }
    
        /// <summary>
        /// Gets or sets role id.
        /// </summary>
        [JsonPropertyName("roleId")]
        public string RoleId { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets role info.
        /// </summary>
        [JsonPropertyName("roleInfo")]
        public PrivilegedRole RoleInfo { get; set; }
    
    }
}

