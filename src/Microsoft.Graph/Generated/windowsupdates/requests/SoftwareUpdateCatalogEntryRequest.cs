// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph.WindowsUpdates
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type SoftwareUpdateCatalogEntryRequest.
    /// </summary>
    public partial class SoftwareUpdateCatalogEntryRequest : Microsoft.Graph.BaseRequest, ISoftwareUpdateCatalogEntryRequest
    {
        /// <summary>
        /// Constructs a new SoftwareUpdateCatalogEntryRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public SoftwareUpdateCatalogEntryRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified SoftwareUpdateCatalogEntry using POST.
        /// </summary>
        /// <param name="softwareUpdateCatalogEntryToCreate">The SoftwareUpdateCatalogEntry to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SoftwareUpdateCatalogEntry.</returns>
        public async System.Threading.Tasks.Task<SoftwareUpdateCatalogEntry> CreateAsync(SoftwareUpdateCatalogEntry softwareUpdateCatalogEntryToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<SoftwareUpdateCatalogEntry>(softwareUpdateCatalogEntryToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified SoftwareUpdateCatalogEntry using POST and returns a <see cref="GraphResponse{SoftwareUpdateCatalogEntry}"/> object.
        /// </summary>
        /// <param name="softwareUpdateCatalogEntryToCreate">The SoftwareUpdateCatalogEntry to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SoftwareUpdateCatalogEntry}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SoftwareUpdateCatalogEntry>> CreateResponseAsync(SoftwareUpdateCatalogEntry softwareUpdateCatalogEntryToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<SoftwareUpdateCatalogEntry>(softwareUpdateCatalogEntryToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified SoftwareUpdateCatalogEntry.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<SoftwareUpdateCatalogEntry>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified SoftwareUpdateCatalogEntry and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified SoftwareUpdateCatalogEntry.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SoftwareUpdateCatalogEntry.</returns>
        public async System.Threading.Tasks.Task<SoftwareUpdateCatalogEntry> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<SoftwareUpdateCatalogEntry>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified SoftwareUpdateCatalogEntry and returns a <see cref="GraphResponse{SoftwareUpdateCatalogEntry}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SoftwareUpdateCatalogEntry}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SoftwareUpdateCatalogEntry>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<SoftwareUpdateCatalogEntry>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified SoftwareUpdateCatalogEntry using PATCH.
        /// </summary>
        /// <param name="softwareUpdateCatalogEntryToUpdate">The SoftwareUpdateCatalogEntry to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SoftwareUpdateCatalogEntry.</returns>
        public async System.Threading.Tasks.Task<SoftwareUpdateCatalogEntry> UpdateAsync(SoftwareUpdateCatalogEntry softwareUpdateCatalogEntryToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<SoftwareUpdateCatalogEntry>(softwareUpdateCatalogEntryToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified SoftwareUpdateCatalogEntry using PATCH and returns a <see cref="GraphResponse{SoftwareUpdateCatalogEntry}"/> object.
        /// </summary>
        /// <param name="softwareUpdateCatalogEntryToUpdate">The SoftwareUpdateCatalogEntry to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SoftwareUpdateCatalogEntry}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SoftwareUpdateCatalogEntry>> UpdateResponseAsync(SoftwareUpdateCatalogEntry softwareUpdateCatalogEntryToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<SoftwareUpdateCatalogEntry>(softwareUpdateCatalogEntryToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified SoftwareUpdateCatalogEntry using PUT.
        /// </summary>
        /// <param name="softwareUpdateCatalogEntryToUpdate">The SoftwareUpdateCatalogEntry object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<SoftwareUpdateCatalogEntry> PutAsync(SoftwareUpdateCatalogEntry softwareUpdateCatalogEntryToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<SoftwareUpdateCatalogEntry>(softwareUpdateCatalogEntryToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified SoftwareUpdateCatalogEntry using PUT and returns a <see cref="GraphResponse{SoftwareUpdateCatalogEntry}"/> object.
        /// </summary>
        /// <param name="softwareUpdateCatalogEntryToUpdate">The SoftwareUpdateCatalogEntry object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{SoftwareUpdateCatalogEntry}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SoftwareUpdateCatalogEntry>> PutResponseAsync(SoftwareUpdateCatalogEntry softwareUpdateCatalogEntryToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<SoftwareUpdateCatalogEntry>(softwareUpdateCatalogEntryToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISoftwareUpdateCatalogEntryRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISoftwareUpdateCatalogEntryRequest Expand(Expression<Func<SoftwareUpdateCatalogEntry, object>> expandExpression)
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
        public ISoftwareUpdateCatalogEntryRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ISoftwareUpdateCatalogEntryRequest Select(Expression<Func<SoftwareUpdateCatalogEntry, object>> selectExpression)
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
        /// <param name="softwareUpdateCatalogEntryToInitialize">The <see cref="SoftwareUpdateCatalogEntry"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(SoftwareUpdateCatalogEntry softwareUpdateCatalogEntryToInitialize)
        {

        }
    }
}
