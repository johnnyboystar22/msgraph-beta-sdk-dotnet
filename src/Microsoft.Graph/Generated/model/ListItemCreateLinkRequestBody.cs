// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type ListItemCreateLinkRequestBody.
    /// </summary>
    public partial class ListItemCreateLinkRequestBody
    {
    
        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
        /// <summary>
        /// Gets or sets Scope.
        /// </summary>
        [JsonPropertyName("scope")]
        public string Scope { get; set; }
    
        /// <summary>
        /// Gets or sets ExpirationDateTime.
        /// </summary>
        [JsonPropertyName("expirationDateTime")]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets Password.
        /// </summary>
        [JsonPropertyName("password")]
        public string Password { get; set; }
    
        /// <summary>
        /// Gets or sets Recipients.
        /// </summary>
        [JsonPropertyName("recipients")]
        public IEnumerable<DriveRecipient> Recipients { get; set; }
    
        /// <summary>
        /// Gets or sets RetainInheritedPermissions.
        /// </summary>
        [JsonPropertyName("retainInheritedPermissions")]
        public bool? RetainInheritedPermissions { get; set; }
    
        /// <summary>
        /// Gets or sets SendNotification.
        /// </summary>
        [JsonPropertyName("sendNotification")]
        public bool? SendNotification { get; set; }
    
    }
}
