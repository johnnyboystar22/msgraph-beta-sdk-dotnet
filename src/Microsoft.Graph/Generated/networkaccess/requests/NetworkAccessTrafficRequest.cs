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
    /// The type NetworkAccessTrafficRequest.
    /// </summary>
    public partial class NetworkAccessTrafficRequest : Microsoft.Graph.BaseRequest, INetworkAccessTrafficRequest
    {
        /// <summary>
        /// Constructs a new NetworkAccessTrafficRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public NetworkAccessTrafficRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified NetworkAccessTraffic using POST.
        /// </summary>
        /// <param name="networkAccessTrafficToCreate">The NetworkAccessTraffic to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created NetworkAccessTraffic.</returns>
        public async System.Threading.Tasks.Task<NetworkAccessTraffic> CreateAsync(NetworkAccessTraffic networkAccessTrafficToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<NetworkAccessTraffic>(networkAccessTrafficToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified NetworkAccessTraffic using POST and returns a <see cref="GraphResponse{NetworkAccessTraffic}"/> object.
        /// </summary>
        /// <param name="networkAccessTrafficToCreate">The NetworkAccessTraffic to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{NetworkAccessTraffic}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<NetworkAccessTraffic>> CreateResponseAsync(NetworkAccessTraffic networkAccessTrafficToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<NetworkAccessTraffic>(networkAccessTrafficToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified NetworkAccessTraffic.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<NetworkAccessTraffic>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified NetworkAccessTraffic and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified NetworkAccessTraffic.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The NetworkAccessTraffic.</returns>
        public async System.Threading.Tasks.Task<NetworkAccessTraffic> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<NetworkAccessTraffic>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified NetworkAccessTraffic and returns a <see cref="GraphResponse{NetworkAccessTraffic}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{NetworkAccessTraffic}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<NetworkAccessTraffic>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<NetworkAccessTraffic>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified NetworkAccessTraffic using PATCH.
        /// </summary>
        /// <param name="networkAccessTrafficToUpdate">The NetworkAccessTraffic to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated NetworkAccessTraffic.</returns>
        public async System.Threading.Tasks.Task<NetworkAccessTraffic> UpdateAsync(NetworkAccessTraffic networkAccessTrafficToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<NetworkAccessTraffic>(networkAccessTrafficToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified NetworkAccessTraffic using PATCH and returns a <see cref="GraphResponse{NetworkAccessTraffic}"/> object.
        /// </summary>
        /// <param name="networkAccessTrafficToUpdate">The NetworkAccessTraffic to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{NetworkAccessTraffic}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<NetworkAccessTraffic>> UpdateResponseAsync(NetworkAccessTraffic networkAccessTrafficToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<NetworkAccessTraffic>(networkAccessTrafficToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified NetworkAccessTraffic using PUT.
        /// </summary>
        /// <param name="networkAccessTrafficToUpdate">The NetworkAccessTraffic object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<NetworkAccessTraffic> PutAsync(NetworkAccessTraffic networkAccessTrafficToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<NetworkAccessTraffic>(networkAccessTrafficToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified NetworkAccessTraffic using PUT and returns a <see cref="GraphResponse{NetworkAccessTraffic}"/> object.
        /// </summary>
        /// <param name="networkAccessTrafficToUpdate">The NetworkAccessTraffic object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{NetworkAccessTraffic}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<NetworkAccessTraffic>> PutResponseAsync(NetworkAccessTraffic networkAccessTrafficToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<NetworkAccessTraffic>(networkAccessTrafficToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public INetworkAccessTrafficRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public INetworkAccessTrafficRequest Expand(Expression<Func<NetworkAccessTraffic, object>> expandExpression)
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
        public INetworkAccessTrafficRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public INetworkAccessTrafficRequest Select(Expression<Func<NetworkAccessTraffic, object>> selectExpression)
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
        /// <param name="networkAccessTrafficToInitialize">The <see cref="NetworkAccessTraffic"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(NetworkAccessTraffic networkAccessTrafficToInitialize)
        {

        }
    }
}
