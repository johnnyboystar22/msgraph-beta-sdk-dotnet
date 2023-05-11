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
    /// The type Too Many Global Admins Assigned To Tenant Alert Configuration.
    /// </summary>
    public partial class TooManyGlobalAdminsAssignedToTenantAlertConfiguration : UnifiedRoleManagementAlertConfiguration
    {
    
        ///<summary>
        /// The TooManyGlobalAdminsAssignedToTenantAlertConfiguration constructor
        ///</summary>
        public TooManyGlobalAdminsAssignedToTenantAlertConfiguration()
        {
            this.ODataType = "microsoft.graph.tooManyGlobalAdminsAssignedToTenantAlertConfiguration";
        }

        /// <summary>
        /// Gets or sets global admin count threshold.
        /// </summary>
        [JsonPropertyName("globalAdminCountThreshold")]
        public Int32? GlobalAdminCountThreshold { get; set; }
    
        /// <summary>
        /// Gets or sets percentage of global admins out of roles threshold.
        /// </summary>
        [JsonPropertyName("percentageOfGlobalAdminsOutOfRolesThreshold")]
        public Int32? PercentageOfGlobalAdminsOutOfRolesThreshold { get; set; }
    
    }
}

