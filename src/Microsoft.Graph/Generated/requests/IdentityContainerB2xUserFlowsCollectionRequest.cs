// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type IdentityContainerB2xUserFlowsCollectionRequest.
    /// </summary>
    public partial class IdentityContainerB2xUserFlowsCollectionRequest : BaseRequest, IIdentityContainerB2xUserFlowsCollectionRequest
    {
        /// <summary>
        /// Constructs a new IdentityContainerB2xUserFlowsCollectionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public IdentityContainerB2xUserFlowsCollectionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }
        /// <summary>
        /// Adds the specified B2xIdentityUserFlow to the collection via POST.
        /// </summary>
        /// <param name="b2xIdentityUserFlow">The B2xIdentityUserFlow to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created B2xIdentityUserFlow.</returns>
        public System.Threading.Tasks.Task<B2xIdentityUserFlow> AddAsync(B2xIdentityUserFlow b2xIdentityUserFlow, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsync<B2xIdentityUserFlow>(b2xIdentityUserFlow, cancellationToken);
        }

        /// <summary>
        /// Adds the specified B2xIdentityUserFlow to the collection via POST and returns a <see cref="GraphResponse{B2xIdentityUserFlow}"/> object of the request.
        /// </summary>
        /// <param name="b2xIdentityUserFlow">The B2xIdentityUserFlow to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{B2xIdentityUserFlow}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<B2xIdentityUserFlow>> AddResponseAsync(B2xIdentityUserFlow b2xIdentityUserFlow, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<B2xIdentityUserFlow>(b2xIdentityUserFlow, cancellationToken);
        }


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        public async System.Threading.Tasks.Task<IIdentityContainerB2xUserFlowsCollectionPage> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var response = await this.SendAsync<IdentityContainerB2xUserFlowsCollectionResponse>(null, cancellationToken).ConfigureAwait(false);
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
        /// Gets the collection page and returns a <see cref="GraphResponse{IdentityContainerB2xUserFlowsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IdentityContainerB2xUserFlowsCollectionResponse}"/> object.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IdentityContainerB2xUserFlowsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<IdentityContainerB2xUserFlowsCollectionResponse>(null, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIdentityContainerB2xUserFlowsCollectionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIdentityContainerB2xUserFlowsCollectionRequest Expand(Expression<Func<B2xIdentityUserFlow, object>> expandExpression)
        {
            if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IIdentityContainerB2xUserFlowsCollectionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IIdentityContainerB2xUserFlowsCollectionRequest Select(Expression<Func<B2xIdentityUserFlow, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        public IIdentityContainerB2xUserFlowsCollectionRequest Top(int value)
        {
            this.QueryOptions.Add(new QueryOption("$top", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        public IIdentityContainerB2xUserFlowsCollectionRequest Filter(string value)
        {
            this.QueryOptions.Add(new QueryOption("$filter", value));
            return this;
        }

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        public IIdentityContainerB2xUserFlowsCollectionRequest Skip(int value)
        {
            this.QueryOptions.Add(new QueryOption("$skip", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        public IIdentityContainerB2xUserFlowsCollectionRequest OrderBy(string value)
        {
            this.QueryOptions.Add(new QueryOption("$orderby", value));
            return this;
        }
    }
}
