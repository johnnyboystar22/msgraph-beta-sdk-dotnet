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
    /// The type Roles Assigned Outside Privileged Identity Management Alert Incident.
    /// </summary>
    public partial class RolesAssignedOutsidePrivilegedIdentityManagementAlertIncident : UnifiedRoleManagementAlertIncident
    {
    
        ///<summary>
        /// The RolesAssignedOutsidePrivilegedIdentityManagementAlertIncident constructor
        ///</summary>
        public RolesAssignedOutsidePrivilegedIdentityManagementAlertIncident()
        {
            this.ODataType = "microsoft.graph.rolesAssignedOutsidePrivilegedIdentityManagementAlertIncident";
        }

        /// <summary>
        /// Gets or sets assignee display name.
        /// </summary>
        [JsonPropertyName("assigneeDisplayName")]
        public string AssigneeDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets assignee id.
        /// </summary>
        [JsonPropertyName("assigneeId")]
        public string AssigneeId { get; set; }
    
        /// <summary>
        /// Gets or sets assignee user principal name.
        /// </summary>
        [JsonPropertyName("assigneeUserPrincipalName")]
        public string AssigneeUserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets assignment created date time.
        /// </summary>
        [JsonPropertyName("assignmentCreatedDateTime")]
        public DateTimeOffset? AssignmentCreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets role definition id.
        /// </summary>
        [JsonPropertyName("roleDefinitionId")]
        public string RoleDefinitionId { get; set; }
    
        /// <summary>
        /// Gets or sets role display name.
        /// </summary>
        [JsonPropertyName("roleDisplayName")]
        public string RoleDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets role template id.
        /// </summary>
        [JsonPropertyName("roleTemplateId")]
        public string RoleTemplateId { get; set; }
    
    }
}

