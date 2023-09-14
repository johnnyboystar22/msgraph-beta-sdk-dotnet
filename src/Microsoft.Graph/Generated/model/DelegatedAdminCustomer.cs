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
    /// The type Delegated Admin Customer.
    /// </summary>
    public partial class DelegatedAdminCustomer : Entity
    {
    
        /// <summary>
        /// Gets or sets display name.
        /// The Azure AD display name of the customer tenant. Read-only. Supports $orderby.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets tenant id.
        /// The Azure AD-assigned tenant ID of the customer. Read-only.
        /// </summary>
        [JsonPropertyName("tenantId")]
        public string TenantId { get; set; }
    
        /// <summary>
        /// Gets or sets service management details.
        /// Contains the management details of a service in the customer tenant that's managed by delegated administration.
        /// </summary>
        [JsonPropertyName("serviceManagementDetails")]
        public IDelegatedAdminCustomerServiceManagementDetailsCollectionPage ServiceManagementDetails { get; set; }

        /// <summary>
        /// Gets or sets serviceManagementDetailsNextLink.
        /// </summary>
        [JsonPropertyName("serviceManagementDetails@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ServiceManagementDetailsNextLink { get; set; }
    
    }
}

