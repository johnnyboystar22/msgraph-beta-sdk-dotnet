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
    /// The type WhoisHistoryRecordRequest.
    /// </summary>
    public partial class WhoisHistoryRecordRequest : Microsoft.Graph.BaseRequest, IWhoisHistoryRecordRequest
    {
        /// <summary>
        /// Constructs a new WhoisHistoryRecordRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WhoisHistoryRecordRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WhoisHistoryRecord using POST.
        /// </summary>
        /// <param name="whoisHistoryRecordToCreate">The WhoisHistoryRecord to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WhoisHistoryRecord.</returns>
        public async System.Threading.Tasks.Task<WhoisHistoryRecord> CreateAsync(WhoisHistoryRecord whoisHistoryRecordToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<WhoisHistoryRecord>(whoisHistoryRecordToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified WhoisHistoryRecord using POST and returns a <see cref="GraphResponse{WhoisHistoryRecord}"/> object.
        /// </summary>
        /// <param name="whoisHistoryRecordToCreate">The WhoisHistoryRecord to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WhoisHistoryRecord}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WhoisHistoryRecord>> CreateResponseAsync(WhoisHistoryRecord whoisHistoryRecordToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<WhoisHistoryRecord>(whoisHistoryRecordToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified WhoisHistoryRecord.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<WhoisHistoryRecord>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WhoisHistoryRecord and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified WhoisHistoryRecord.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WhoisHistoryRecord.</returns>
        public async System.Threading.Tasks.Task<WhoisHistoryRecord> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<WhoisHistoryRecord>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified WhoisHistoryRecord and returns a <see cref="GraphResponse{WhoisHistoryRecord}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WhoisHistoryRecord}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WhoisHistoryRecord>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<WhoisHistoryRecord>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified WhoisHistoryRecord using PATCH.
        /// </summary>
        /// <param name="whoisHistoryRecordToUpdate">The WhoisHistoryRecord to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WhoisHistoryRecord.</returns>
        public async System.Threading.Tasks.Task<WhoisHistoryRecord> UpdateAsync(WhoisHistoryRecord whoisHistoryRecordToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<WhoisHistoryRecord>(whoisHistoryRecordToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified WhoisHistoryRecord using PATCH and returns a <see cref="GraphResponse{WhoisHistoryRecord}"/> object.
        /// </summary>
        /// <param name="whoisHistoryRecordToUpdate">The WhoisHistoryRecord to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WhoisHistoryRecord}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WhoisHistoryRecord>> UpdateResponseAsync(WhoisHistoryRecord whoisHistoryRecordToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<WhoisHistoryRecord>(whoisHistoryRecordToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified WhoisHistoryRecord using PUT.
        /// </summary>
        /// <param name="whoisHistoryRecordToUpdate">The WhoisHistoryRecord object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<WhoisHistoryRecord> PutAsync(WhoisHistoryRecord whoisHistoryRecordToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<WhoisHistoryRecord>(whoisHistoryRecordToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified WhoisHistoryRecord using PUT and returns a <see cref="GraphResponse{WhoisHistoryRecord}"/> object.
        /// </summary>
        /// <param name="whoisHistoryRecordToUpdate">The WhoisHistoryRecord object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{WhoisHistoryRecord}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WhoisHistoryRecord>> PutResponseAsync(WhoisHistoryRecord whoisHistoryRecordToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<WhoisHistoryRecord>(whoisHistoryRecordToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWhoisHistoryRecordRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWhoisHistoryRecordRequest Expand(Expression<Func<WhoisHistoryRecord, object>> expandExpression)
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
        public IWhoisHistoryRecordRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWhoisHistoryRecordRequest Select(Expression<Func<WhoisHistoryRecord, object>> selectExpression)
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
        /// <param name="whoisHistoryRecordToInitialize">The <see cref="WhoisHistoryRecord"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WhoisHistoryRecord whoisHistoryRecordToInitialize)
        {

        }
    }
}
