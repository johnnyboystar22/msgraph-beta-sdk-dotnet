// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type SearchEntityQueryRequest.
    /// </summary>
    public partial class SearchEntityQueryRequest : BaseRequest, ISearchEntityQueryRequest
    {
        /// <summary>
        /// Constructs a new SearchEntityQueryRequest.
        /// </summary>
        public SearchEntityQueryRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.RequestBody = new SearchEntityQueryRequestBody();
        }

        /// <summary>
        /// Gets the request body.
        /// </summary>
        public SearchEntityQueryRequestBody RequestBody { get; private set; }

        /// <summary>
        /// Issues the POST request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task<SearchResponse> PostAsync(
            CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.POST;
            return this.SendAsync<SearchResponse>(this.RequestBody, cancellationToken);
        }

        /// <summary>
        /// Issues the POST request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        public System.Threading.Tasks.Task<GraphResponse<SearchResponse>> PostResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<SearchResponse>(this.RequestBody, cancellationToken);
        }



        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISearchEntityQueryRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public ISearchEntityQueryRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }
    }
}
