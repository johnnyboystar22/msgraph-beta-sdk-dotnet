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
    /// The type WhoisRecordRequest.
    /// </summary>
    public partial class WhoisRecordRequest : Microsoft.Graph.BaseRequest, IWhoisRecordRequest
    {
        /// <summary>
        /// Constructs a new WhoisRecordRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WhoisRecordRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WhoisRecord using POST.
        /// </summary>
        /// <param name="whoisRecordToCreate">The WhoisRecord to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WhoisRecord.</returns>
        public async System.Threading.Tasks.Task<WhoisRecord> CreateAsync(WhoisRecord whoisRecordToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<WhoisRecord>(whoisRecordToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified WhoisRecord using POST and returns a <see cref="GraphResponse{WhoisRecord}"/> object.
        /// </summary>
        /// <param name="whoisRecordToCreate">The WhoisRecord to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WhoisRecord}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WhoisRecord>> CreateResponseAsync(WhoisRecord whoisRecordToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<WhoisRecord>(whoisRecordToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified WhoisRecord.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<WhoisRecord>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WhoisRecord and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified WhoisRecord.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WhoisRecord.</returns>
        public async System.Threading.Tasks.Task<WhoisRecord> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<WhoisRecord>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified WhoisRecord and returns a <see cref="GraphResponse{WhoisRecord}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WhoisRecord}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WhoisRecord>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<WhoisRecord>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified WhoisRecord using PATCH.
        /// </summary>
        /// <param name="whoisRecordToUpdate">The WhoisRecord to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WhoisRecord.</returns>
        public async System.Threading.Tasks.Task<WhoisRecord> UpdateAsync(WhoisRecord whoisRecordToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<WhoisRecord>(whoisRecordToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified WhoisRecord using PATCH and returns a <see cref="GraphResponse{WhoisRecord}"/> object.
        /// </summary>
        /// <param name="whoisRecordToUpdate">The WhoisRecord to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WhoisRecord}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WhoisRecord>> UpdateResponseAsync(WhoisRecord whoisRecordToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<WhoisRecord>(whoisRecordToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified WhoisRecord using PUT.
        /// </summary>
        /// <param name="whoisRecordToUpdate">The WhoisRecord object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<WhoisRecord> PutAsync(WhoisRecord whoisRecordToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<WhoisRecord>(whoisRecordToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified WhoisRecord using PUT and returns a <see cref="GraphResponse{WhoisRecord}"/> object.
        /// </summary>
        /// <param name="whoisRecordToUpdate">The WhoisRecord object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{WhoisRecord}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WhoisRecord>> PutResponseAsync(WhoisRecord whoisRecordToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<WhoisRecord>(whoisRecordToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWhoisRecordRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWhoisRecordRequest Expand(Expression<Func<WhoisRecord, object>> expandExpression)
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
        public IWhoisRecordRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWhoisRecordRequest Select(Expression<Func<WhoisRecord, object>> selectExpression)
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
        /// <param name="whoisRecordToInitialize">The <see cref="WhoisRecord"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WhoisRecord whoisRecordToInitialize)
        {

            if (whoisRecordToInitialize != null)
            {
                if (whoisRecordToInitialize.History != null && whoisRecordToInitialize.History.CurrentPage != null)
                {
                    whoisRecordToInitialize.History.InitializeNextPageRequest(this.Client, whoisRecordToInitialize.HistoryNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    whoisRecordToInitialize.History.AdditionalData = whoisRecordToInitialize.AdditionalData;
                }

            }


        }
    }
}
