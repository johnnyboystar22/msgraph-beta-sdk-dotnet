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
    /// The type Admin.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Admin>))]
    public partial class Admin
    {
    
        /// <summary>
        /// Gets or sets edge.
        /// A container for Microsoft Edge resources. Read-only.
        /// </summary>
        [JsonPropertyName("edge")]
        public Edge Edge { get; set; }
    
        /// <summary>
        /// Gets or sets sharepoint.
        /// </summary>
        [JsonPropertyName("sharepoint")]
        public Sharepoint Sharepoint { get; set; }
    
        /// <summary>
        /// Gets or sets service announcement.
        /// A container for service communications resources. Read-only.
        /// </summary>
        [JsonPropertyName("serviceAnnouncement")]
        public ServiceAnnouncement ServiceAnnouncement { get; set; }
    
        /// <summary>
        /// Gets or sets report settings.
        /// A container for administrative resources to manage reports.
        /// </summary>
        [JsonPropertyName("reportSettings")]
        public AdminReportSettings ReportSettings { get; set; }
    
        /// <summary>
        /// Gets or sets apps and services.
        /// </summary>
        [JsonPropertyName("appsAndServices")]
        public AdminAppsAndServices AppsAndServices { get; set; }
    
        /// <summary>
        /// Gets or sets dynamics.
        /// </summary>
        [JsonPropertyName("dynamics")]
        public AdminDynamics Dynamics { get; set; }
    
        /// <summary>
        /// Gets or sets forms.
        /// </summary>
        [JsonPropertyName("forms")]
        public AdminForms Forms { get; set; }
    
        /// <summary>
        /// Gets or sets todo.
        /// </summary>
        [JsonPropertyName("todo")]
        public AdminTodo Todo { get; set; }
    
        /// <summary>
        /// Gets or sets people.
        /// </summary>
        [JsonPropertyName("people")]
        public PeopleAdminSettings People { get; set; }
    
        /// <summary>
        /// Gets or sets windows.
        /// A container for all Windows administrator functionalities. Read-only.
        /// </summary>
        [JsonPropertyName("windows")]
        public AdminWindows Windows { get; set; }
    
        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}

