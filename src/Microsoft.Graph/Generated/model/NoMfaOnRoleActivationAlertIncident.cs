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
    /// The type No Mfa On Role Activation Alert Incident.
    /// </summary>
    public partial class NoMfaOnRoleActivationAlertIncident : UnifiedRoleManagementAlertIncident
    {
    
        ///<summary>
        /// The NoMfaOnRoleActivationAlertIncident constructor
        ///</summary>
        public NoMfaOnRoleActivationAlertIncident()
        {
            this.ODataType = "microsoft.graph.noMfaOnRoleActivationAlertIncident";
        }

        /// <summary>
        /// Gets or sets role display name.
        /// The name of the Azure AD directory role.
        /// </summary>
        [JsonPropertyName("roleDisplayName")]
        public string RoleDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets role template id.
        /// The globally unique identifier for a directory role.
        /// </summary>
        [JsonPropertyName("roleTemplateId")]
        public string RoleTemplateId { get; set; }
    
    }
}

