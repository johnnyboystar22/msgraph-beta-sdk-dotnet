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
    /// The type Software Update Catalog Entry.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<SoftwareUpdateCatalogEntry>))]
    public partial class SoftwareUpdateCatalogEntry : CatalogEntry
    {
    
		///<summary>
		/// The internal SoftwareUpdateCatalogEntry constructor
		///</summary>
        protected internal SoftwareUpdateCatalogEntry()
        {
            // Don't allow initialization of abstract entity types
        }
    
    }
}

