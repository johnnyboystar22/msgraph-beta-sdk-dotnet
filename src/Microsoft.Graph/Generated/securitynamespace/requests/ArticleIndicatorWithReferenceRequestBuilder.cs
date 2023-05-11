// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityWithReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ArticleIndicatorWithReferenceRequestBuilder.
    /// </summary>
    public partial class ArticleIndicatorWithReferenceRequestBuilder : Microsoft.Graph.BaseRequestBuilder, IArticleIndicatorWithReferenceRequestBuilder
    {

        /// <summary>
        /// Constructs a new ArticleIndicatorWithReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public ArticleIndicatorWithReferenceRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IArticleIndicatorWithReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IArticleIndicatorWithReferenceRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new ArticleIndicatorWithReferenceRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets the request builder for the reference of the articleIndicator.
        /// </summary>
        /// <returns>The <see cref="IArticleIndicatorReferenceRequestBuilder"/>.</returns>
        public IArticleIndicatorReferenceRequestBuilder Reference
        {
            get
            {
                return new ArticleIndicatorReferenceRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
