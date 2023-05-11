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
    /// The type Privileged Role.
    /// </summary>
    public partial class PrivilegedRole : Entity
    {
    
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// </summary>
        [JsonPropertyName("assignments")]
        public IPrivilegedRoleAssignmentsCollectionWithReferencesPage Assignments { get; set; }

        /// <summary>
        /// Gets or sets assignmentsNextLink.
        /// </summary>
        [JsonPropertyName("assignments@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AssignmentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets settings.
        /// </summary>
        [JsonPropertyName("settings")]
        public PrivilegedRoleSettings Settings { get; set; }
    
        /// <summary>
        /// Gets or sets summary.
        /// </summary>
        [JsonPropertyName("summary")]
        public PrivilegedRoleSummary Summary { get; set; }
    
    }
}

