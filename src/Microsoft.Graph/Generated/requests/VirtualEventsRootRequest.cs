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
    /// The type VirtualEventsRootRequest.
    /// </summary>
    public partial class VirtualEventsRootRequest : BaseRequest, IVirtualEventsRootRequest
    {
        /// <summary>
        /// Constructs a new VirtualEventsRootRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public VirtualEventsRootRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified VirtualEventsRoot using POST.
        /// </summary>
        /// <param name="virtualEventsRootToCreate">The VirtualEventsRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created VirtualEventsRoot.</returns>
        public async System.Threading.Tasks.Task<VirtualEventsRoot> CreateAsync(VirtualEventsRoot virtualEventsRootToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<VirtualEventsRoot>(virtualEventsRootToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified VirtualEventsRoot using POST and returns a <see cref="GraphResponse{VirtualEventsRoot}"/> object.
        /// </summary>
        /// <param name="virtualEventsRootToCreate">The VirtualEventsRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{VirtualEventsRoot}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<VirtualEventsRoot>> CreateResponseAsync(VirtualEventsRoot virtualEventsRootToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<VirtualEventsRoot>(virtualEventsRootToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified VirtualEventsRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<VirtualEventsRoot>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified VirtualEventsRoot and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified VirtualEventsRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The VirtualEventsRoot.</returns>
        public async System.Threading.Tasks.Task<VirtualEventsRoot> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<VirtualEventsRoot>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified VirtualEventsRoot and returns a <see cref="GraphResponse{VirtualEventsRoot}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{VirtualEventsRoot}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<VirtualEventsRoot>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<VirtualEventsRoot>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified VirtualEventsRoot using PATCH.
        /// </summary>
        /// <param name="virtualEventsRootToUpdate">The VirtualEventsRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated VirtualEventsRoot.</returns>
        public async System.Threading.Tasks.Task<VirtualEventsRoot> UpdateAsync(VirtualEventsRoot virtualEventsRootToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<VirtualEventsRoot>(virtualEventsRootToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified VirtualEventsRoot using PATCH and returns a <see cref="GraphResponse{VirtualEventsRoot}"/> object.
        /// </summary>
        /// <param name="virtualEventsRootToUpdate">The VirtualEventsRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{VirtualEventsRoot}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<VirtualEventsRoot>> UpdateResponseAsync(VirtualEventsRoot virtualEventsRootToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<VirtualEventsRoot>(virtualEventsRootToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified VirtualEventsRoot using PUT.
        /// </summary>
        /// <param name="virtualEventsRootToUpdate">The VirtualEventsRoot object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<VirtualEventsRoot> PutAsync(VirtualEventsRoot virtualEventsRootToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<VirtualEventsRoot>(virtualEventsRootToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified VirtualEventsRoot using PUT and returns a <see cref="GraphResponse{VirtualEventsRoot}"/> object.
        /// </summary>
        /// <param name="virtualEventsRootToUpdate">The VirtualEventsRoot object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{VirtualEventsRoot}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<VirtualEventsRoot>> PutResponseAsync(VirtualEventsRoot virtualEventsRootToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<VirtualEventsRoot>(virtualEventsRootToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IVirtualEventsRootRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IVirtualEventsRootRequest Expand(Expression<Func<VirtualEventsRoot, object>> expandExpression)
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
        public IVirtualEventsRootRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IVirtualEventsRootRequest Select(Expression<Func<VirtualEventsRoot, object>> selectExpression)
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
        /// <param name="virtualEventsRootToInitialize">The <see cref="VirtualEventsRoot"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(VirtualEventsRoot virtualEventsRootToInitialize)
        {

            if (virtualEventsRootToInitialize != null)
            {
                if (virtualEventsRootToInitialize.Events != null && virtualEventsRootToInitialize.Events.CurrentPage != null)
                {
                    virtualEventsRootToInitialize.Events.InitializeNextPageRequest(this.Client, virtualEventsRootToInitialize.EventsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    virtualEventsRootToInitialize.Events.AdditionalData = virtualEventsRootToInitialize.AdditionalData;
                }
                if (virtualEventsRootToInitialize.Webinars != null && virtualEventsRootToInitialize.Webinars.CurrentPage != null)
                {
                    virtualEventsRootToInitialize.Webinars.InitializeNextPageRequest(this.Client, virtualEventsRootToInitialize.WebinarsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    virtualEventsRootToInitialize.Webinars.AdditionalData = virtualEventsRootToInitialize.AdditionalData;
                }

            }


        }
    }
}
