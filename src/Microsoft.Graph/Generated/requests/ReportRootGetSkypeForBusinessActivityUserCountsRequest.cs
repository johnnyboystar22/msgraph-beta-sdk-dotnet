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
    /// The type ReportRootGetSkypeForBusinessActivityUserCountsRequest.
    /// </summary>
    public partial class ReportRootGetSkypeForBusinessActivityUserCountsRequest : BaseRequest, IReportRootGetSkypeForBusinessActivityUserCountsRequest
    {
        /// <summary>
        /// Constructs a new ReportRootGetSkypeForBusinessActivityUserCountsRequest.
        /// </summary>
        public ReportRootGetSkypeForBusinessActivityUserCountsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Issues the GET request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public async System.Threading.Tasks.Task<IReportRootGetSkypeForBusinessActivityUserCountsCollectionPage> GetAsync(
            CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var response = await this.SendAsync<ReportRootGetSkypeForBusinessActivityUserCountsCollectionResponse>(null, cancellationToken).ConfigureAwait(false);
            if (response?.Value?.CurrentPage != null)
            {
                response.Value.InitializeNextPageRequest(this.Client, response.NextLink);
                // Copy the additional data collection to the page itself so that information is not lost
                response.Value.AdditionalData = response.AdditionalData;
                return response.Value;
            }

            return null;
        }

        /// <summary>
        /// Issues the GET request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        public System.Threading.Tasks.Task<GraphResponse<ReportRootGetSkypeForBusinessActivityUserCountsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<ReportRootGetSkypeForBusinessActivityUserCountsCollectionResponse>(null, cancellationToken);
        }


        /// <summary>
        /// Issues the PATCH request.
        /// </summary>
        /// <param name="skypeforbusinessactivityusercounts">The SkypeForBusinessActivityUserCounts object set with the properties to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public async System.Threading.Tasks.Task<IReportRootGetSkypeForBusinessActivityUserCountsCollectionPage> PatchAsync(SkypeForBusinessActivityUserCounts skypeforbusinessactivityusercounts,
            CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.PATCH;
            var response = await this.SendAsync<ReportRootGetSkypeForBusinessActivityUserCountsCollectionResponse>(skypeforbusinessactivityusercounts, cancellationToken).ConfigureAwait(false);
            if (response?.Value?.CurrentPage != null)
            {
                response.Value.InitializeNextPageRequest(this.Client, response.NextLink);
                // Copy the additional data collection to the page itself so that information is not lost
                response.Value.AdditionalData = response.AdditionalData;
                return response.Value;
            }

            return null;
        }

        /// <summary>
        /// Issues the PATCH request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="skypeforbusinessactivityusercounts">The SkypeForBusinessActivityUserCounts object set with the properties to update.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        public System.Threading.Tasks.Task<GraphResponse<ReportRootGetSkypeForBusinessActivityUserCountsCollectionResponse>> PatchResponseAsync(SkypeForBusinessActivityUserCounts skypeforbusinessactivityusercounts, CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<ReportRootGetSkypeForBusinessActivityUserCountsCollectionResponse>(skypeforbusinessactivityusercounts, cancellationToken);
        }

        /// <summary>
        /// Issues the PUT request.
        /// </summary>
        /// <param name="skypeforbusinessactivityusercounts">The SkypeForBusinessActivityUserCounts object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public async System.Threading.Tasks.Task<IReportRootGetSkypeForBusinessActivityUserCountsCollectionPage> PutAsync(SkypeForBusinessActivityUserCounts skypeforbusinessactivityusercounts,
            CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.PUT;
            var response = await this.SendAsync<ReportRootGetSkypeForBusinessActivityUserCountsCollectionResponse>(skypeforbusinessactivityusercounts, cancellationToken).ConfigureAwait(false);
            if (response?.Value?.CurrentPage != null)
            {
                response.Value.InitializeNextPageRequest(this.Client, response.NextLink);
                // Copy the additional data collection to the page itself so that information is not lost
                response.Value.AdditionalData = response.AdditionalData;
                return response.Value;
            }

            return null;
        }

        /// <summary>
        /// Issues the PUT request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="skypeforbusinessactivityusercounts">The SkypeForBusinessActivityUserCounts object set with the properties to update.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        public System.Threading.Tasks.Task<GraphResponse<ReportRootGetSkypeForBusinessActivityUserCountsCollectionResponse>> PutResponseAsync(SkypeForBusinessActivityUserCounts skypeforbusinessactivityusercounts, CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<ReportRootGetSkypeForBusinessActivityUserCountsCollectionResponse>(skypeforbusinessactivityusercounts, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootGetSkypeForBusinessActivityUserCountsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootGetSkypeForBusinessActivityUserCountsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootGetSkypeForBusinessActivityUserCountsRequest Top(int value)
        {
            this.QueryOptions.Add(new QueryOption("$top", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootGetSkypeForBusinessActivityUserCountsRequest Filter(string value)
        {
            this.QueryOptions.Add(new QueryOption("$filter", value));
            return this;
        }

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootGetSkypeForBusinessActivityUserCountsRequest Skip(int value)
        {
            this.QueryOptions.Add(new QueryOption("$skip", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootGetSkypeForBusinessActivityUserCountsRequest OrderBy(string value)
        {
            this.QueryOptions.Add(new QueryOption("$orderby", value));
            return this;
        }
    }
}
