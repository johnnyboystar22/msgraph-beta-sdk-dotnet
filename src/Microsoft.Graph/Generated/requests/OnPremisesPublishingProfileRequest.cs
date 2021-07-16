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
    /// The type OnPremisesPublishingProfileRequest.
    /// </summary>
    public partial class OnPremisesPublishingProfileRequest : BaseRequest, IOnPremisesPublishingProfileRequest
    {
        /// <summary>
        /// Constructs a new OnPremisesPublishingProfileRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public OnPremisesPublishingProfileRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified OnPremisesPublishingProfile using POST.
        /// </summary>
        /// <param name="onPremisesPublishingProfileToCreate">The OnPremisesPublishingProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OnPremisesPublishingProfile.</returns>
        public async System.Threading.Tasks.Task<OnPremisesPublishingProfile> CreateAsync(OnPremisesPublishingProfile onPremisesPublishingProfileToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<OnPremisesPublishingProfile>(onPremisesPublishingProfileToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified OnPremisesPublishingProfile using POST and returns a <see cref="GraphResponse{OnPremisesPublishingProfile}"/> object.
        /// </summary>
        /// <param name="onPremisesPublishingProfileToCreate">The OnPremisesPublishingProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OnPremisesPublishingProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OnPremisesPublishingProfile>> CreateResponseAsync(OnPremisesPublishingProfile onPremisesPublishingProfileToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<OnPremisesPublishingProfile>(onPremisesPublishingProfileToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified OnPremisesPublishingProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<OnPremisesPublishingProfile>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified OnPremisesPublishingProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified OnPremisesPublishingProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OnPremisesPublishingProfile.</returns>
        public async System.Threading.Tasks.Task<OnPremisesPublishingProfile> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<OnPremisesPublishingProfile>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified OnPremisesPublishingProfile and returns a <see cref="GraphResponse{OnPremisesPublishingProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OnPremisesPublishingProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OnPremisesPublishingProfile>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<OnPremisesPublishingProfile>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified OnPremisesPublishingProfile using PATCH.
        /// </summary>
        /// <param name="onPremisesPublishingProfileToUpdate">The OnPremisesPublishingProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OnPremisesPublishingProfile.</returns>
        public async System.Threading.Tasks.Task<OnPremisesPublishingProfile> UpdateAsync(OnPremisesPublishingProfile onPremisesPublishingProfileToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<OnPremisesPublishingProfile>(onPremisesPublishingProfileToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified OnPremisesPublishingProfile using PATCH and returns a <see cref="GraphResponse{OnPremisesPublishingProfile}"/> object.
        /// </summary>
        /// <param name="onPremisesPublishingProfileToUpdate">The OnPremisesPublishingProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{OnPremisesPublishingProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OnPremisesPublishingProfile>> UpdateResponseAsync(OnPremisesPublishingProfile onPremisesPublishingProfileToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<OnPremisesPublishingProfile>(onPremisesPublishingProfileToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified OnPremisesPublishingProfile using PUT.
        /// </summary>
        /// <param name="onPremisesPublishingProfileToUpdate">The OnPremisesPublishingProfile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<OnPremisesPublishingProfile> PutAsync(OnPremisesPublishingProfile onPremisesPublishingProfileToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<OnPremisesPublishingProfile>(onPremisesPublishingProfileToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified OnPremisesPublishingProfile using PUT and returns a <see cref="GraphResponse{OnPremisesPublishingProfile}"/> object.
        /// </summary>
        /// <param name="onPremisesPublishingProfileToUpdate">The OnPremisesPublishingProfile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{OnPremisesPublishingProfile}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OnPremisesPublishingProfile>> PutResponseAsync(OnPremisesPublishingProfile onPremisesPublishingProfileToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<OnPremisesPublishingProfile>(onPremisesPublishingProfileToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOnPremisesPublishingProfileRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOnPremisesPublishingProfileRequest Expand(Expression<Func<OnPremisesPublishingProfile, object>> expandExpression)
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
        public IOnPremisesPublishingProfileRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IOnPremisesPublishingProfileRequest Select(Expression<Func<OnPremisesPublishingProfile, object>> selectExpression)
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
        /// <param name="onPremisesPublishingProfileToInitialize">The <see cref="OnPremisesPublishingProfile"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(OnPremisesPublishingProfile onPremisesPublishingProfileToInitialize)
        {

            if (onPremisesPublishingProfileToInitialize != null)
            {
                if (onPremisesPublishingProfileToInitialize.AgentGroups != null && onPremisesPublishingProfileToInitialize.AgentGroups.CurrentPage != null)
                {
                    onPremisesPublishingProfileToInitialize.AgentGroups.InitializeNextPageRequest(this.Client, onPremisesPublishingProfileToInitialize.AgentGroupsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    onPremisesPublishingProfileToInitialize.AgentGroups.AdditionalData = onPremisesPublishingProfileToInitialize.AdditionalData;
                }
                if (onPremisesPublishingProfileToInitialize.Agents != null && onPremisesPublishingProfileToInitialize.Agents.CurrentPage != null)
                {
                    onPremisesPublishingProfileToInitialize.Agents.InitializeNextPageRequest(this.Client, onPremisesPublishingProfileToInitialize.AgentsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    onPremisesPublishingProfileToInitialize.Agents.AdditionalData = onPremisesPublishingProfileToInitialize.AdditionalData;
                }
                if (onPremisesPublishingProfileToInitialize.ConnectorGroups != null && onPremisesPublishingProfileToInitialize.ConnectorGroups.CurrentPage != null)
                {
                    onPremisesPublishingProfileToInitialize.ConnectorGroups.InitializeNextPageRequest(this.Client, onPremisesPublishingProfileToInitialize.ConnectorGroupsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    onPremisesPublishingProfileToInitialize.ConnectorGroups.AdditionalData = onPremisesPublishingProfileToInitialize.AdditionalData;
                }
                if (onPremisesPublishingProfileToInitialize.Connectors != null && onPremisesPublishingProfileToInitialize.Connectors.CurrentPage != null)
                {
                    onPremisesPublishingProfileToInitialize.Connectors.InitializeNextPageRequest(this.Client, onPremisesPublishingProfileToInitialize.ConnectorsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    onPremisesPublishingProfileToInitialize.Connectors.AdditionalData = onPremisesPublishingProfileToInitialize.AdditionalData;
                }
                if (onPremisesPublishingProfileToInitialize.PublishedResources != null && onPremisesPublishingProfileToInitialize.PublishedResources.CurrentPage != null)
                {
                    onPremisesPublishingProfileToInitialize.PublishedResources.InitializeNextPageRequest(this.Client, onPremisesPublishingProfileToInitialize.PublishedResourcesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    onPremisesPublishingProfileToInitialize.PublishedResources.AdditionalData = onPremisesPublishingProfileToInitialize.AdditionalData;
                }

            }


        }
    }
}
