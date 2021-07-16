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
    /// The type IosVppAppAssignedLicensesCollectionRequest.
    /// </summary>
    public partial class IosVppAppAssignedLicensesCollectionRequest : BaseRequest, IIosVppAppAssignedLicensesCollectionRequest
    {
        /// <summary>
        /// Constructs a new IosVppAppAssignedLicensesCollectionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public IosVppAppAssignedLicensesCollectionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }
        /// <summary>
        /// Adds the specified IosVppAppAssignedLicense to the collection via POST.
        /// </summary>
        /// <param name="iosVppAppAssignedLicense">The IosVppAppAssignedLicense to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosVppAppAssignedLicense.</returns>
        public System.Threading.Tasks.Task<IosVppAppAssignedLicense> AddAsync(IosVppAppAssignedLicense iosVppAppAssignedLicense, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsync<IosVppAppAssignedLicense>(iosVppAppAssignedLicense, cancellationToken);
        }

        /// <summary>
        /// Adds the specified IosVppAppAssignedLicense to the collection via POST and returns a <see cref="GraphResponse{IosVppAppAssignedLicense}"/> object of the request.
        /// </summary>
        /// <param name="iosVppAppAssignedLicense">The IosVppAppAssignedLicense to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosVppAppAssignedLicense}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IosVppAppAssignedLicense>> AddResponseAsync(IosVppAppAssignedLicense iosVppAppAssignedLicense, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<IosVppAppAssignedLicense>(iosVppAppAssignedLicense, cancellationToken);
        }


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        public async System.Threading.Tasks.Task<IIosVppAppAssignedLicensesCollectionPage> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var response = await this.SendAsync<IosVppAppAssignedLicensesCollectionResponse>(null, cancellationToken).ConfigureAwait(false);
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
        /// Gets the collection page and returns a <see cref="GraphResponse{IosVppAppAssignedLicensesCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosVppAppAssignedLicensesCollectionResponse}"/> object.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IosVppAppAssignedLicensesCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<IosVppAppAssignedLicensesCollectionResponse>(null, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIosVppAppAssignedLicensesCollectionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIosVppAppAssignedLicensesCollectionRequest Expand(Expression<Func<IosVppAppAssignedLicense, object>> expandExpression)
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
        public IIosVppAppAssignedLicensesCollectionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IIosVppAppAssignedLicensesCollectionRequest Select(Expression<Func<IosVppAppAssignedLicense, object>> selectExpression)
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
        public IIosVppAppAssignedLicensesCollectionRequest Top(int value)
        {
            this.QueryOptions.Add(new QueryOption("$top", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        public IIosVppAppAssignedLicensesCollectionRequest Filter(string value)
        {
            this.QueryOptions.Add(new QueryOption("$filter", value));
            return this;
        }

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        public IIosVppAppAssignedLicensesCollectionRequest Skip(int value)
        {
            this.QueryOptions.Add(new QueryOption("$skip", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        public IIosVppAppAssignedLicensesCollectionRequest OrderBy(string value)
        {
            this.QueryOptions.Add(new QueryOption("$orderby", value));
            return this;
        }
    }
}
