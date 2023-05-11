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
    /// The type Privileged Operation Event.
    /// </summary>
    public partial class PrivilegedOperationEvent : Entity
    {
    
        /// <summary>
        /// Gets or sets additional information.
        /// </summary>
        [JsonPropertyName("additionalInformation")]
        public string AdditionalInformation { get; set; }
    
        /// <summary>
        /// Gets or sets creation date time.
        /// </summary>
        [JsonPropertyName("creationDateTime")]
        public DateTimeOffset? CreationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets expiration date time.
        /// </summary>
        [JsonPropertyName("expirationDateTime")]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets reference key.
        /// </summary>
        [JsonPropertyName("referenceKey")]
        public string ReferenceKey { get; set; }
    
        /// <summary>
        /// Gets or sets reference system.
        /// </summary>
        [JsonPropertyName("referenceSystem")]
        public string ReferenceSystem { get; set; }
    
        /// <summary>
        /// Gets or sets requestor id.
        /// </summary>
        [JsonPropertyName("requestorId")]
        public string RequestorId { get; set; }
    
        /// <summary>
        /// Gets or sets requestor name.
        /// </summary>
        [JsonPropertyName("requestorName")]
        public string RequestorName { get; set; }
    
        /// <summary>
        /// Gets or sets request type.
        /// </summary>
        [JsonPropertyName("requestType")]
        public string RequestType { get; set; }
    
        /// <summary>
        /// Gets or sets role id.
        /// </summary>
        [JsonPropertyName("roleId")]
        public string RoleId { get; set; }
    
        /// <summary>
        /// Gets or sets role name.
        /// </summary>
        [JsonPropertyName("roleName")]
        public string RoleName { get; set; }
    
        /// <summary>
        /// Gets or sets tenant id.
        /// </summary>
        [JsonPropertyName("tenantId")]
        public string TenantId { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets user mail.
        /// </summary>
        [JsonPropertyName("userMail")]
        public string UserMail { get; set; }
    
        /// <summary>
        /// Gets or sets user name.
        /// </summary>
        [JsonPropertyName("userName")]
        public string UserName { get; set; }
    
    }
}

