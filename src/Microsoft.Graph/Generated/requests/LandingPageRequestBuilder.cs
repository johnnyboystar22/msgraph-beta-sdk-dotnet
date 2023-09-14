// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type LandingPageRequestBuilder.
    /// </summary>
    public partial class LandingPageRequestBuilder : EntityRequestBuilder, ILandingPageRequestBuilder
    {

        /// <summary>
        /// Constructs a new LandingPageRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public LandingPageRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new ILandingPageRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new ILandingPageRequest Request(IEnumerable<Option> options)
        {
            return new LandingPageRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Details.
        /// </summary>
        /// <returns>The <see cref="ILandingPageDetailsCollectionRequestBuilder"/>.</returns>
        public ILandingPageDetailsCollectionRequestBuilder Details
        {
            get
            {
                return new LandingPageDetailsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("details"), this.Client);
            }
        }
    
    }
}
