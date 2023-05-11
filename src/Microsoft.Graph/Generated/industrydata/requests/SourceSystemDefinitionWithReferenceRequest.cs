// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph.IndustryData
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type SourceSystemDefinitionWithReferenceRequest.
    /// </summary>
    public partial class SourceSystemDefinitionWithReferenceRequest : Microsoft.Graph.BaseRequest, ISourceSystemDefinitionWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new SourceSystemDefinitionWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public SourceSystemDefinitionWithReferenceRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified SourceSystemDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SourceSystemDefinition.</returns>
        public async System.Threading.Tasks.Task<SourceSystemDefinition> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<SourceSystemDefinition>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified SourceSystemDefinition and returns a <see cref="GraphResponse{SourceSystemDefinition}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SourceSystemDefinition}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SourceSystemDefinition>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<SourceSystemDefinition>(null, cancellationToken);
        }

		/// <summary>
        /// Creates the specified SourceSystemDefinition using POST.
        /// </summary>
        /// <param name="sourceSystemDefinitionToCreate">The SourceSystemDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SourceSystemDefinition.</returns>
        public async System.Threading.Tasks.Task<SourceSystemDefinition> CreateAsync(SourceSystemDefinition sourceSystemDefinitionToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<SourceSystemDefinition>(sourceSystemDefinitionToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Creates the specified SourceSystemDefinition using POST and returns a <see cref="GraphResponse{SourceSystemDefinition}"/> object.
        /// </summary>
        /// <param name="sourceSystemDefinitionToCreate">The SourceSystemDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SourceSystemDefinition}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SourceSystemDefinition>> CreateResponseAsync(SourceSystemDefinition sourceSystemDefinitionToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<SourceSystemDefinition>(sourceSystemDefinitionToCreate, cancellationToken);
        }

		/// <summary>
        /// Updates the specified SourceSystemDefinition using PATCH.
        /// </summary>
        /// <param name="sourceSystemDefinitionToUpdate">The SourceSystemDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SourceSystemDefinition.</returns>
        public async System.Threading.Tasks.Task<SourceSystemDefinition> UpdateAsync(SourceSystemDefinition sourceSystemDefinitionToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<SourceSystemDefinition>(sourceSystemDefinitionToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Updates the specified SourceSystemDefinition using PATCH and returns a <see cref="GraphResponse{SourceSystemDefinition}"/> object.
        /// </summary>
        /// <param name="sourceSystemDefinitionToUpdate">The SourceSystemDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SourceSystemDefinition}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SourceSystemDefinition>> UpdateResponseAsync(SourceSystemDefinition sourceSystemDefinitionToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<SourceSystemDefinition>(sourceSystemDefinitionToUpdate, cancellationToken);
        }

		/// <summary>
        /// Deletes the specified SourceSystemDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<SourceSystemDefinition>(null, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified SourceSystemDefinition and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISourceSystemDefinitionWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISourceSystemDefinitionWithReferenceRequest Expand(Expression<Func<SourceSystemDefinition, object>> expandExpression)
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
        public ISourceSystemDefinitionWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ISourceSystemDefinitionWithReferenceRequest Select(Expression<Func<SourceSystemDefinition, object>> selectExpression)
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

    }
}
