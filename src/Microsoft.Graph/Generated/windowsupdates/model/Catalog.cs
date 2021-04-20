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
    /// The type Catalog.
    /// </summary>
    public partial class Catalog : Microsoft.Graph.Entity
    {
    
		///<summary>
		/// The Catalog constructor
		///</summary>
        public Catalog()
        {
            this.ODataType = "microsoft.graph.windowsUpdates.catalog";
        }
	
        /// <summary>
        /// Gets or sets entries.
        /// </summary>
        [JsonPropertyName("entries")]
        public ICatalogEntriesCollectionPage Entries { get; set; }

        /// <summary>
        /// Gets or sets entriesNextLink.
        /// </summary>
        [JsonPropertyName("entries@odata.nextLink")]
        public string EntriesNextLink { get; set; }
    
    }
}

