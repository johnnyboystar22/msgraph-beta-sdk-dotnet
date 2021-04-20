// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.WindowsUpdates
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Quality Update Catalog Entry.
    /// </summary>
    public partial class QualityUpdateCatalogEntry : SoftwareUpdateCatalogEntry
    {
    
		///<summary>
		/// The QualityUpdateCatalogEntry constructor
		///</summary>
        public QualityUpdateCatalogEntry()
        {
            this.ODataType = "microsoft.graph.windowsUpdates.qualityUpdateCatalogEntry";
        }
	
        /// <summary>
        /// Gets or sets is expeditable.
        /// </summary>
        [JsonPropertyName("isExpeditable")]
        public bool? IsExpeditable { get; set; }
    
        /// <summary>
        /// Gets or sets quality update classification.
        /// </summary>
        [JsonPropertyName("qualityUpdateClassification")]
        public QualityUpdateClassification? QualityUpdateClassification { get; set; }
    
    }
}

