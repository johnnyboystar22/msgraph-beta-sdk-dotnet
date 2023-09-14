// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph.Networkaccess
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type ConditionalAccessPolicyRequest.
    /// </summary>
    public partial class ConditionalAccessPolicyRequest : Microsoft.Graph.BaseRequest, IConditionalAccessPolicyRequest
    {
        /// <summary>
        /// Constructs a new ConditionalAccessPolicyRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ConditionalAccessPolicyRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ConditionalAccessPolicy using POST.
        /// </summary>
        /// <param name="conditionalAccessPolicyToCreate">The ConditionalAccessPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ConditionalAccessPolicy.</returns>
        public async System.Threading.Tasks.Task<ConditionalAccessPolicy> CreateAsync(ConditionalAccessPolicy conditionalAccessPolicyToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<ConditionalAccessPolicy>(conditionalAccessPolicyToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified ConditionalAccessPolicy using POST and returns a <see cref="GraphResponse{ConditionalAccessPolicy}"/> object.
        /// </summary>
        /// <param name="conditionalAccessPolicyToCreate">The ConditionalAccessPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ConditionalAccessPolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ConditionalAccessPolicy>> CreateResponseAsync(ConditionalAccessPolicy conditionalAccessPolicyToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<ConditionalAccessPolicy>(conditionalAccessPolicyToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified ConditionalAccessPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<ConditionalAccessPolicy>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ConditionalAccessPolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified ConditionalAccessPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ConditionalAccessPolicy.</returns>
        public async System.Threading.Tasks.Task<ConditionalAccessPolicy> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<ConditionalAccessPolicy>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ConditionalAccessPolicy and returns a <see cref="GraphResponse{ConditionalAccessPolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ConditionalAccessPolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ConditionalAccessPolicy>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<ConditionalAccessPolicy>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ConditionalAccessPolicy using PATCH.
        /// </summary>
        /// <param name="conditionalAccessPolicyToUpdate">The ConditionalAccessPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ConditionalAccessPolicy.</returns>
        public async System.Threading.Tasks.Task<ConditionalAccessPolicy> UpdateAsync(ConditionalAccessPolicy conditionalAccessPolicyToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<ConditionalAccessPolicy>(conditionalAccessPolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ConditionalAccessPolicy using PATCH and returns a <see cref="GraphResponse{ConditionalAccessPolicy}"/> object.
        /// </summary>
        /// <param name="conditionalAccessPolicyToUpdate">The ConditionalAccessPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ConditionalAccessPolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ConditionalAccessPolicy>> UpdateResponseAsync(ConditionalAccessPolicy conditionalAccessPolicyToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<ConditionalAccessPolicy>(conditionalAccessPolicyToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ConditionalAccessPolicy using PUT.
        /// </summary>
        /// <param name="conditionalAccessPolicyToUpdate">The ConditionalAccessPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<ConditionalAccessPolicy> PutAsync(ConditionalAccessPolicy conditionalAccessPolicyToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<ConditionalAccessPolicy>(conditionalAccessPolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ConditionalAccessPolicy using PUT and returns a <see cref="GraphResponse{ConditionalAccessPolicy}"/> object.
        /// </summary>
        /// <param name="conditionalAccessPolicyToUpdate">The ConditionalAccessPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{ConditionalAccessPolicy}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ConditionalAccessPolicy>> PutResponseAsync(ConditionalAccessPolicy conditionalAccessPolicyToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<ConditionalAccessPolicy>(conditionalAccessPolicyToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IConditionalAccessPolicyRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IConditionalAccessPolicyRequest Expand(Expression<Func<ConditionalAccessPolicy, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IConditionalAccessPolicyRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IConditionalAccessPolicyRequest Select(Expression<Func<ConditionalAccessPolicy, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="conditionalAccessPolicyToInitialize">The <see cref="ConditionalAccessPolicy"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ConditionalAccessPolicy conditionalAccessPolicyToInitialize)
        {

        }
    }
}
