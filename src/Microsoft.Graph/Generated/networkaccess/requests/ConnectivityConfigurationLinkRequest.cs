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
    /// The type ConnectivityConfigurationLinkRequest.
    /// </summary>
    public partial class ConnectivityConfigurationLinkRequest : Microsoft.Graph.BaseRequest, IConnectivityConfigurationLinkRequest
    {
        /// <summary>
        /// Constructs a new ConnectivityConfigurationLinkRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ConnectivityConfigurationLinkRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ConnectivityConfigurationLink using POST.
        /// </summary>
        /// <param name="connectivityConfigurationLinkToCreate">The ConnectivityConfigurationLink to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ConnectivityConfigurationLink.</returns>
        public async System.Threading.Tasks.Task<ConnectivityConfigurationLink> CreateAsync(ConnectivityConfigurationLink connectivityConfigurationLinkToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<ConnectivityConfigurationLink>(connectivityConfigurationLinkToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified ConnectivityConfigurationLink using POST and returns a <see cref="GraphResponse{ConnectivityConfigurationLink}"/> object.
        /// </summary>
        /// <param name="connectivityConfigurationLinkToCreate">The ConnectivityConfigurationLink to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ConnectivityConfigurationLink}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ConnectivityConfigurationLink>> CreateResponseAsync(ConnectivityConfigurationLink connectivityConfigurationLinkToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<ConnectivityConfigurationLink>(connectivityConfigurationLinkToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified ConnectivityConfigurationLink.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<ConnectivityConfigurationLink>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ConnectivityConfigurationLink and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified ConnectivityConfigurationLink.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ConnectivityConfigurationLink.</returns>
        public async System.Threading.Tasks.Task<ConnectivityConfigurationLink> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<ConnectivityConfigurationLink>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ConnectivityConfigurationLink and returns a <see cref="GraphResponse{ConnectivityConfigurationLink}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ConnectivityConfigurationLink}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ConnectivityConfigurationLink>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<ConnectivityConfigurationLink>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ConnectivityConfigurationLink using PATCH.
        /// </summary>
        /// <param name="connectivityConfigurationLinkToUpdate">The ConnectivityConfigurationLink to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ConnectivityConfigurationLink.</returns>
        public async System.Threading.Tasks.Task<ConnectivityConfigurationLink> UpdateAsync(ConnectivityConfigurationLink connectivityConfigurationLinkToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<ConnectivityConfigurationLink>(connectivityConfigurationLinkToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ConnectivityConfigurationLink using PATCH and returns a <see cref="GraphResponse{ConnectivityConfigurationLink}"/> object.
        /// </summary>
        /// <param name="connectivityConfigurationLinkToUpdate">The ConnectivityConfigurationLink to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ConnectivityConfigurationLink}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ConnectivityConfigurationLink>> UpdateResponseAsync(ConnectivityConfigurationLink connectivityConfigurationLinkToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<ConnectivityConfigurationLink>(connectivityConfigurationLinkToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ConnectivityConfigurationLink using PUT.
        /// </summary>
        /// <param name="connectivityConfigurationLinkToUpdate">The ConnectivityConfigurationLink object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<ConnectivityConfigurationLink> PutAsync(ConnectivityConfigurationLink connectivityConfigurationLinkToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<ConnectivityConfigurationLink>(connectivityConfigurationLinkToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ConnectivityConfigurationLink using PUT and returns a <see cref="GraphResponse{ConnectivityConfigurationLink}"/> object.
        /// </summary>
        /// <param name="connectivityConfigurationLinkToUpdate">The ConnectivityConfigurationLink object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{ConnectivityConfigurationLink}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ConnectivityConfigurationLink>> PutResponseAsync(ConnectivityConfigurationLink connectivityConfigurationLinkToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<ConnectivityConfigurationLink>(connectivityConfigurationLinkToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IConnectivityConfigurationLinkRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IConnectivityConfigurationLinkRequest Expand(Expression<Func<ConnectivityConfigurationLink, object>> expandExpression)
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
        public IConnectivityConfigurationLinkRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IConnectivityConfigurationLinkRequest Select(Expression<Func<ConnectivityConfigurationLink, object>> selectExpression)
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
        /// <param name="connectivityConfigurationLinkToInitialize">The <see cref="ConnectivityConfigurationLink"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ConnectivityConfigurationLink connectivityConfigurationLinkToInitialize)
        {

        }
    }
}
