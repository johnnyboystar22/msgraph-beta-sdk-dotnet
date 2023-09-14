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
    /// The type Multi Tenant Organization Member.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MultiTenantOrganizationMember>))]
    public partial class MultiTenantOrganizationMember : DirectoryObject
    {
    
        ///<summary>
        /// The MultiTenantOrganizationMember constructor
        ///</summary>
        public MultiTenantOrganizationMember()
        {
            this.ODataType = "microsoft.graph.multiTenantOrganizationMember";
        }

        /// <summary>
        /// Gets or sets added by tenant id.
        /// Tenant ID of the tenant that added the tenant to the multi-tenant organization. Read-only.
        /// </summary>
        [JsonPropertyName("addedByTenantId")]
        public Guid? AddedByTenantId { get; set; }
    
        /// <summary>
        /// Gets or sets added date time.
        /// Date and time when the tenant was added to the multi-tenant organization. Read-only.
        /// </summary>
        [JsonPropertyName("addedDateTime")]
        public DateTimeOffset? AddedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Display name of the tenant added to the multi-tenant organization.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets joined date time.
        /// Date and time when the tenant joined the multi-tenant organization. Read-only.
        /// </summary>
        [JsonPropertyName("joinedDateTime")]
        public DateTimeOffset? JoinedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets role.
        /// Role of the tenant in the multi-tenant organization. The possible values are: owner, member (default), unknownFutureValue. Tenants with the owner role can manage the multi-tenant organization but tenants with the member role can only participate in a multi-tenant organization. There can be multiple tenants with the owner role in a multi-tenant organization.
        /// </summary>
        [JsonPropertyName("role")]
        public MultiTenantOrganizationMemberRole? Role { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// State of the tenant in the multi-tenant organization. The possible values are: pending, active, removed, unknownFutureValue. Tenants in the pending state must join the multi-tenant organization to participate in the multi-tenant organization. Tenants in the active state can participate in the multi-tenant organization. Tenants in the removed state are in the process of being removed from the multi-tenant organization. Read-only.
        /// </summary>
        [JsonPropertyName("state")]
        public MultiTenantOrganizationMemberState? State { get; set; }
    
        /// <summary>
        /// Gets or sets tenant id.
        /// Tenant ID of the Azure Active Directory tenant added to the multi-tenant organization. Set at the time tenant is added.Supports $filter. Key.
        /// </summary>
        [JsonPropertyName("tenantId")]
        public string TenantId { get; set; }
    
        /// <summary>
        /// Gets or sets transition details.
        /// Details of the processing status for a tenant in a multi-tenant organization. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("transitionDetails")]
        public MultiTenantOrganizationMemberTransitionDetails TransitionDetails { get; set; }
    
    }
}

