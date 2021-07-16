// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type B2cAuthenticationMethodsPolicyRequest.
    /// </summary>
    public partial class B2cAuthenticationMethodsPolicyRequest : BaseRequest, IB2cAuthenticationMethodsPolicyRequest
    {
        /// <summary>
        /// Constructs a new B2cAuthenticationMethodsPolicyRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public B2cAuthenticationMethodsPolicyRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified B2cAuthenticationMethodsPolicy using POST.
        /// </summary>
        /// <param name="b2cAuthenticationMethodsPolicyToCreate">The B2cAuthenticationMethodsPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created B2cAuthenticationMethodsPolicy.</returns>
        public async System.Threading.Tasks.Task<B2cAuthenticationMethodsPolicy> CreateAsync(B2cAuthenticationMethodsPolicy b2cAuthenticationMethodsPolicyToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<B2cAuthenticationMethodsPolicy>(b2cAuthenticationMethodsPolicyToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified B2cAuthenticationMethodsPolicy using POST and returns a <see cref="GraphResponse{B2cAuthenticationMethodsPolicy}"/> object.
        /// </summary>
        /// <param name="b2cAuthenticationMethodsPolicyToCreate">The B2cAuthenticationMethodsPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{B2cAuthenticationMethodsPolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<B2cAuthenticationMethodsPolicy>> CreateResponseAsync(B2cAuthenticationMethodsPolicy b2cAuthenticationMethodsPolicyToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<B2cAuthenticationMethodsPolicy>(b2cAuthenticationMethodsPolicyToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified B2cAuthenticationMethodsPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<B2cAuthenticationMethodsPolicy>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified B2cAuthenticationMethodsPolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified B2cAuthenticationMethodsPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The B2cAuthenticationMethodsPolicy.</returns>
        public async System.Threading.Tasks.Task<B2cAuthenticationMethodsPolicy> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<B2cAuthenticationMethodsPolicy>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified B2cAuthenticationMethodsPolicy and returns a <see cref="GraphResponse{B2cAuthenticationMethodsPolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{B2cAuthenticationMethodsPolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<B2cAuthenticationMethodsPolicy>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<B2cAuthenticationMethodsPolicy>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified B2cAuthenticationMethodsPolicy using PATCH.
        /// </summary>
        /// <param name="b2cAuthenticationMethodsPolicyToUpdate">The B2cAuthenticationMethodsPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated B2cAuthenticationMethodsPolicy.</returns>
        public async System.Threading.Tasks.Task<B2cAuthenticationMethodsPolicy> UpdateAsync(B2cAuthenticationMethodsPolicy b2cAuthenticationMethodsPolicyToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<B2cAuthenticationMethodsPolicy>(b2cAuthenticationMethodsPolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified B2cAuthenticationMethodsPolicy using PATCH and returns a <see cref="GraphResponse{B2cAuthenticationMethodsPolicy}"/> object.
        /// </summary>
        /// <param name="b2cAuthenticationMethodsPolicyToUpdate">The B2cAuthenticationMethodsPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{B2cAuthenticationMethodsPolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<B2cAuthenticationMethodsPolicy>> UpdateResponseAsync(B2cAuthenticationMethodsPolicy b2cAuthenticationMethodsPolicyToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<B2cAuthenticationMethodsPolicy>(b2cAuthenticationMethodsPolicyToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified B2cAuthenticationMethodsPolicy using PUT.
        /// </summary>
        /// <param name="b2cAuthenticationMethodsPolicyToUpdate">The B2cAuthenticationMethodsPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<B2cAuthenticationMethodsPolicy> PutAsync(B2cAuthenticationMethodsPolicy b2cAuthenticationMethodsPolicyToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<B2cAuthenticationMethodsPolicy>(b2cAuthenticationMethodsPolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified B2cAuthenticationMethodsPolicy using PUT and returns a <see cref="GraphResponse{B2cAuthenticationMethodsPolicy}"/> object.
        /// </summary>
        /// <param name="b2cAuthenticationMethodsPolicyToUpdate">The B2cAuthenticationMethodsPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{B2cAuthenticationMethodsPolicy}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<B2cAuthenticationMethodsPolicy>> PutResponseAsync(B2cAuthenticationMethodsPolicy b2cAuthenticationMethodsPolicyToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<B2cAuthenticationMethodsPolicy>(b2cAuthenticationMethodsPolicyToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IB2cAuthenticationMethodsPolicyRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IB2cAuthenticationMethodsPolicyRequest Expand(Expression<Func<B2cAuthenticationMethodsPolicy, object>> expandExpression)
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
        public IB2cAuthenticationMethodsPolicyRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IB2cAuthenticationMethodsPolicyRequest Select(Expression<Func<B2cAuthenticationMethodsPolicy, object>> selectExpression)
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
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="b2cAuthenticationMethodsPolicyToInitialize">The <see cref="B2cAuthenticationMethodsPolicy"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(B2cAuthenticationMethodsPolicy b2cAuthenticationMethodsPolicyToInitialize)
        {

        }
    }
}
