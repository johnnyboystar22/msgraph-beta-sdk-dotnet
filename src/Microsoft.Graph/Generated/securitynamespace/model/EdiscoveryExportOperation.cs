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
    /// The type Ediscovery Export Operation.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<EdiscoveryExportOperation>))]
    public partial class EdiscoveryExportOperation : CaseOperation
    {
    
        ///<summary>
        /// The EdiscoveryExportOperation constructor
        ///</summary>
        public EdiscoveryExportOperation()
        {
            this.ODataType = "microsoft.graph.security.ediscoveryExportOperation";
        }

        /// <summary>
        /// Gets or sets azure blob container.
        /// </summary>
        [Obsolete("The azureBlobContainer will be deprecated on April 30, 2023.")]
        [JsonPropertyName("azureBlobContainer")]
        public string AzureBlobContainer { get; set; }
    
        /// <summary>
        /// Gets or sets azure blob token.
        /// </summary>
        [Obsolete("The azureBlobToken will be deprecated on April 30, 2023.")]
        [JsonPropertyName("azureBlobToken")]
        public string AzureBlobToken { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// The description provided for the export.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets export file metadata.
        /// </summary>
        [JsonPropertyName("exportFileMetadata")]
        public IEnumerable<ExportFileMetadata> ExportFileMetadata { get; set; }
    
        /// <summary>
        /// Gets or sets export options.
        /// The options provided for the export. For more details, see reviewSet: export. Possible values are: originalFiles, text, pdfReplacement, fileInfo, tags. The fileInfo member is deprecated and will stop returning data on April 30th, 2023. Going forward, the summary and load file are always included.
        /// </summary>
        [JsonPropertyName("exportOptions")]
        public ExportOptions? ExportOptions { get; set; }
    
        /// <summary>
        /// Gets or sets export structure.
        /// The options provided that specify the structure of the export. For more details, see reviewSet: export. Possible values are: none, directory, pst.
        /// </summary>
        [JsonPropertyName("exportStructure")]
        public ExportFileStructure? ExportStructure { get; set; }
    
        /// <summary>
        /// Gets or sets output folder id.
        /// </summary>
        [Obsolete("The outputFolderId will be deprecated on April 30, 2023.")]
        [JsonPropertyName("outputFolderId")]
        public string OutputFolderId { get; set; }
    
        /// <summary>
        /// Gets or sets output name.
        /// The name provided for the export.
        /// </summary>
        [JsonPropertyName("outputName")]
        public string OutputName { get; set; }
    
        /// <summary>
        /// Gets or sets review set.
        /// Review set from where documents are exported.
        /// </summary>
        [JsonPropertyName("reviewSet")]
        public EdiscoveryReviewSet ReviewSet { get; set; }
    
        /// <summary>
        /// Gets or sets review set query.
        /// The review set query which is used to filter the documents for export.
        /// </summary>
        [JsonPropertyName("reviewSetQuery")]
        public EdiscoveryReviewSetQuery ReviewSetQuery { get; set; }
    
    }
}

