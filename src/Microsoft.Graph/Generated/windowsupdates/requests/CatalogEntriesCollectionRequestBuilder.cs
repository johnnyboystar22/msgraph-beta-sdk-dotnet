// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.WindowsUpdates
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type CatalogEntriesCollectionRequestBuilder.
    /// </summary>
    public partial class CatalogEntriesCollectionRequestBuilder : Microsoft.Graph.BaseRequestBuilder, ICatalogEntriesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new CatalogEntriesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public CatalogEntriesCollectionRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ICatalogEntriesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ICatalogEntriesCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new CatalogEntriesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ICatalogEntryRequestBuilder"/> for the specified CatalogCatalogEntry.
        /// </summary>
        /// <param name="id">The ID for the CatalogCatalogEntry.</param>
        /// <returns>The <see cref="ICatalogEntryRequestBuilder"/>.</returns>
        public ICatalogEntryRequestBuilder this[string id]
        {
            get
            {
                return new CatalogEntryRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
