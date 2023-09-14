// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Labels Root.
    /// </summary>
    public partial class LabelsRoot : Microsoft.Graph.Entity
    {
    
        /// <summary>
        /// Gets or sets authorities.
        /// Specifies the underlying authority that describes the type of content to be retained and its retention schedule.
        /// </summary>
        [JsonPropertyName("authorities")]
        public ILabelsRootAuthoritiesCollectionPage Authorities { get; set; }

        /// <summary>
        /// Gets or sets authoritiesNextLink.
        /// </summary>
        [JsonPropertyName("authorities@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AuthoritiesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets categories.
        /// Specifies a group of similar types of content in a particular department.
        /// </summary>
        [JsonPropertyName("categories")]
        public ILabelsRootCategoriesCollectionPage Categories { get; set; }

        /// <summary>
        /// Gets or sets categoriesNextLink.
        /// </summary>
        [JsonPropertyName("categories@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string CategoriesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets citations.
        /// The specific rule or regulation created by a jurisdiction used to determine whether certain labels and content should be retained or deleted.
        /// </summary>
        [JsonPropertyName("citations")]
        public ILabelsRootCitationsCollectionPage Citations { get; set; }

        /// <summary>
        /// Gets or sets citationsNextLink.
        /// </summary>
        [JsonPropertyName("citations@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string CitationsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets departments.
        /// Specifies the department or business unit of an organization to which a label belongs.
        /// </summary>
        [JsonPropertyName("departments")]
        public ILabelsRootDepartmentsCollectionPage Departments { get; set; }

        /// <summary>
        /// Gets or sets departmentsNextLink.
        /// </summary>
        [JsonPropertyName("departments@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string DepartmentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets file plan references.
        /// Specifies a unique alpha-numeric identifier for an organization’s retention schedule.
        /// </summary>
        [JsonPropertyName("filePlanReferences")]
        public ILabelsRootFilePlanReferencesCollectionPage FilePlanReferences { get; set; }

        /// <summary>
        /// Gets or sets filePlanReferencesNextLink.
        /// </summary>
        [JsonPropertyName("filePlanReferences@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string FilePlanReferencesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets retention labels.
        /// Represents how customers can manage their data, whether and for how long to retain or delete it.
        /// </summary>
        [JsonPropertyName("retentionLabels")]
        public ILabelsRootRetentionLabelsCollectionPage RetentionLabels { get; set; }

        /// <summary>
        /// Gets or sets retentionLabelsNextLink.
        /// </summary>
        [JsonPropertyName("retentionLabels@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string RetentionLabelsNextLink { get; set; }
    
    }
}

