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
    /// The type Tenant Relationship.
    /// </summary>
    public partial class TenantRelationship : Entity
    {
    
        /// <summary>
        /// Gets or sets managed tenants.
        /// The operations available to interact with the multi-tenant management platform.
        /// </summary>
        [JsonPropertyName("managedTenants")]
        public Microsoft.Graph.ManagedTenants.ManagedTenant ManagedTenants { get; set; }
    
    }
}

