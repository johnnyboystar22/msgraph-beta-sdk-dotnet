// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type HostParentHostPairsCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class HostParentHostPairsCollectionWithReferencesRequestBuilder : Microsoft.Graph.BaseRequestBuilder, IHostParentHostPairsCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new HostParentHostPairsCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public HostParentHostPairsCollectionWithReferencesRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IHostParentHostPairsCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IHostParentHostPairsCollectionWithReferencesRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new HostParentHostPairsCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IHostPairWithReferenceRequestBuilder"/> for the specified HostHostPair.
        /// </summary>
        /// <param name="id">The ID for the HostHostPair.</param>
        /// <returns>The <see cref="IHostPairWithReferenceRequestBuilder"/>.</returns>
        public IHostPairWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new HostPairWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IHostParentHostPairsCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IHostParentHostPairsCollectionReferencesRequestBuilder"/>.</returns>
        public IHostParentHostPairsCollectionReferencesRequestBuilder References
        {
            get
            {
                return new HostParentHostPairsCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
