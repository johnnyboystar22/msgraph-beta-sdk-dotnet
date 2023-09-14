// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type LandingPageDetailsCollectionRequestBuilder.
    /// </summary>
    public partial class LandingPageDetailsCollectionRequestBuilder : BaseRequestBuilder, ILandingPageDetailsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new LandingPageDetailsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public LandingPageDetailsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ILandingPageDetailsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ILandingPageDetailsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new LandingPageDetailsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ILandingPageDetailRequestBuilder"/> for the specified LandingPageLandingPageDetail.
        /// </summary>
        /// <param name="id">The ID for the LandingPageLandingPageDetail.</param>
        /// <returns>The <see cref="ILandingPageDetailRequestBuilder"/>.</returns>
        public ILandingPageDetailRequestBuilder this[string id]
        {
            get
            {
                return new LandingPageDetailRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
