// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type IntelligenceProfileIndicatorRequest.
    /// </summary>
    public partial class IntelligenceProfileIndicatorRequest : Microsoft.Graph.BaseRequest, IIntelligenceProfileIndicatorRequest
    {
        /// <summary>
        /// Constructs a new IntelligenceProfileIndicatorRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public IntelligenceProfileIndicatorRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified IntelligenceProfileIndicator using POST.
        /// </summary>
        /// <param name="intelligenceProfileIndicatorToCreate">The IntelligenceProfileIndicator to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IntelligenceProfileIndicator.</returns>
        public async System.Threading.Tasks.Task<IntelligenceProfileIndicator> CreateAsync(IntelligenceProfileIndicator intelligenceProfileIndicatorToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<IntelligenceProfileIndicator>(intelligenceProfileIndicatorToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified IntelligenceProfileIndicator using POST and returns a <see cref="GraphResponse{IntelligenceProfileIndicator}"/> object.
        /// </summary>
        /// <param name="intelligenceProfileIndicatorToCreate">The IntelligenceProfileIndicator to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IntelligenceProfileIndicator}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IntelligenceProfileIndicator>> CreateResponseAsync(IntelligenceProfileIndicator intelligenceProfileIndicatorToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<IntelligenceProfileIndicator>(intelligenceProfileIndicatorToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified IntelligenceProfileIndicator.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<IntelligenceProfileIndicator>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified IntelligenceProfileIndicator and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified IntelligenceProfileIndicator.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IntelligenceProfileIndicator.</returns>
        public async System.Threading.Tasks.Task<IntelligenceProfileIndicator> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<IntelligenceProfileIndicator>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified IntelligenceProfileIndicator and returns a <see cref="GraphResponse{IntelligenceProfileIndicator}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IntelligenceProfileIndicator}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IntelligenceProfileIndicator>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<IntelligenceProfileIndicator>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified IntelligenceProfileIndicator using PATCH.
        /// </summary>
        /// <param name="intelligenceProfileIndicatorToUpdate">The IntelligenceProfileIndicator to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IntelligenceProfileIndicator.</returns>
        public async System.Threading.Tasks.Task<IntelligenceProfileIndicator> UpdateAsync(IntelligenceProfileIndicator intelligenceProfileIndicatorToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<IntelligenceProfileIndicator>(intelligenceProfileIndicatorToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified IntelligenceProfileIndicator using PATCH and returns a <see cref="GraphResponse{IntelligenceProfileIndicator}"/> object.
        /// </summary>
        /// <param name="intelligenceProfileIndicatorToUpdate">The IntelligenceProfileIndicator to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IntelligenceProfileIndicator}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IntelligenceProfileIndicator>> UpdateResponseAsync(IntelligenceProfileIndicator intelligenceProfileIndicatorToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<IntelligenceProfileIndicator>(intelligenceProfileIndicatorToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified IntelligenceProfileIndicator using PUT.
        /// </summary>
        /// <param name="intelligenceProfileIndicatorToUpdate">The IntelligenceProfileIndicator object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<IntelligenceProfileIndicator> PutAsync(IntelligenceProfileIndicator intelligenceProfileIndicatorToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<IntelligenceProfileIndicator>(intelligenceProfileIndicatorToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified IntelligenceProfileIndicator using PUT and returns a <see cref="GraphResponse{IntelligenceProfileIndicator}"/> object.
        /// </summary>
        /// <param name="intelligenceProfileIndicatorToUpdate">The IntelligenceProfileIndicator object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{IntelligenceProfileIndicator}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IntelligenceProfileIndicator>> PutResponseAsync(IntelligenceProfileIndicator intelligenceProfileIndicatorToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<IntelligenceProfileIndicator>(intelligenceProfileIndicatorToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIntelligenceProfileIndicatorRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIntelligenceProfileIndicatorRequest Expand(Expression<Func<IntelligenceProfileIndicator, object>> expandExpression)
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
        public IIntelligenceProfileIndicatorRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IIntelligenceProfileIndicatorRequest Select(Expression<Func<IntelligenceProfileIndicator, object>> selectExpression)
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
        /// <param name="intelligenceProfileIndicatorToInitialize">The <see cref="IntelligenceProfileIndicator"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(IntelligenceProfileIndicator intelligenceProfileIndicatorToInitialize)
        {

        }
    }
}
