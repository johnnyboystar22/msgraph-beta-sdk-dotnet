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
    /// The type Office365GroupsActivityFileCountsRequest.
    /// </summary>
    public partial class Office365GroupsActivityFileCountsRequest : BaseRequest, IOffice365GroupsActivityFileCountsRequest
    {
        /// <summary>
        /// Constructs a new Office365GroupsActivityFileCountsRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public Office365GroupsActivityFileCountsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Office365GroupsActivityFileCounts using POST.
        /// </summary>
        /// <param name="office365GroupsActivityFileCountsToCreate">The Office365GroupsActivityFileCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Office365GroupsActivityFileCounts.</returns>
        public async System.Threading.Tasks.Task<Office365GroupsActivityFileCounts> CreateAsync(Office365GroupsActivityFileCounts office365GroupsActivityFileCountsToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<Office365GroupsActivityFileCounts>(office365GroupsActivityFileCountsToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Office365GroupsActivityFileCounts using POST and returns a <see cref="GraphResponse{Office365GroupsActivityFileCounts}"/> object.
        /// </summary>
        /// <param name="office365GroupsActivityFileCountsToCreate">The Office365GroupsActivityFileCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Office365GroupsActivityFileCounts}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Office365GroupsActivityFileCounts>> CreateResponseAsync(Office365GroupsActivityFileCounts office365GroupsActivityFileCountsToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<Office365GroupsActivityFileCounts>(office365GroupsActivityFileCountsToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified Office365GroupsActivityFileCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<Office365GroupsActivityFileCounts>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Office365GroupsActivityFileCounts and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified Office365GroupsActivityFileCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Office365GroupsActivityFileCounts.</returns>
        public async System.Threading.Tasks.Task<Office365GroupsActivityFileCounts> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<Office365GroupsActivityFileCounts>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Office365GroupsActivityFileCounts and returns a <see cref="GraphResponse{Office365GroupsActivityFileCounts}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Office365GroupsActivityFileCounts}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Office365GroupsActivityFileCounts>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<Office365GroupsActivityFileCounts>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Office365GroupsActivityFileCounts using PATCH.
        /// </summary>
        /// <param name="office365GroupsActivityFileCountsToUpdate">The Office365GroupsActivityFileCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Office365GroupsActivityFileCounts.</returns>
        public async System.Threading.Tasks.Task<Office365GroupsActivityFileCounts> UpdateAsync(Office365GroupsActivityFileCounts office365GroupsActivityFileCountsToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<Office365GroupsActivityFileCounts>(office365GroupsActivityFileCountsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Office365GroupsActivityFileCounts using PATCH and returns a <see cref="GraphResponse{Office365GroupsActivityFileCounts}"/> object.
        /// </summary>
        /// <param name="office365GroupsActivityFileCountsToUpdate">The Office365GroupsActivityFileCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Office365GroupsActivityFileCounts}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Office365GroupsActivityFileCounts>> UpdateResponseAsync(Office365GroupsActivityFileCounts office365GroupsActivityFileCountsToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<Office365GroupsActivityFileCounts>(office365GroupsActivityFileCountsToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Office365GroupsActivityFileCounts using PUT.
        /// </summary>
        /// <param name="office365GroupsActivityFileCountsToUpdate">The Office365GroupsActivityFileCounts object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<Office365GroupsActivityFileCounts> PutAsync(Office365GroupsActivityFileCounts office365GroupsActivityFileCountsToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<Office365GroupsActivityFileCounts>(office365GroupsActivityFileCountsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Office365GroupsActivityFileCounts using PUT and returns a <see cref="GraphResponse{Office365GroupsActivityFileCounts}"/> object.
        /// </summary>
        /// <param name="office365GroupsActivityFileCountsToUpdate">The Office365GroupsActivityFileCounts object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{Office365GroupsActivityFileCounts}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Office365GroupsActivityFileCounts>> PutResponseAsync(Office365GroupsActivityFileCounts office365GroupsActivityFileCountsToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<Office365GroupsActivityFileCounts>(office365GroupsActivityFileCountsToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOffice365GroupsActivityFileCountsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOffice365GroupsActivityFileCountsRequest Expand(Expression<Func<Office365GroupsActivityFileCounts, object>> expandExpression)
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
        public IOffice365GroupsActivityFileCountsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IOffice365GroupsActivityFileCountsRequest Select(Expression<Func<Office365GroupsActivityFileCounts, object>> selectExpression)
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
        /// <param name="office365GroupsActivityFileCountsToInitialize">The <see cref="Office365GroupsActivityFileCounts"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Office365GroupsActivityFileCounts office365GroupsActivityFileCountsToInitialize)
        {

        }
    }
}
