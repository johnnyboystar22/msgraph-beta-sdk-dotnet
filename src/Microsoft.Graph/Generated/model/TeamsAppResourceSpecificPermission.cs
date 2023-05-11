// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type TeamsAppResourceSpecificPermission.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<TeamsAppResourceSpecificPermission>))]
    public partial class TeamsAppResourceSpecificPermission
    {

        /// <summary>
        /// Gets or sets permissionType.
        /// The type of resource-specific permission.
        /// </summary>
        [JsonPropertyName("permissionType")]
        public TeamsAppResourceSpecificPermissionType? PermissionType { get; set; }
    
        /// <summary>
        /// Gets or sets permissionValue.
        /// The name of the resource-specific permission.
        /// </summary>
        [JsonPropertyName("permissionValue")]
        public string PermissionValue { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
