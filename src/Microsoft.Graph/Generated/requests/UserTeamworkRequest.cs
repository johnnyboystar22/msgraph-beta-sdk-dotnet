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
    /// The type UserTeamworkRequest.
    /// </summary>
    public partial class UserTeamworkRequest : BaseRequest, IUserTeamworkRequest
    {
        /// <summary>
        /// Constructs a new UserTeamworkRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public UserTeamworkRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified UserTeamwork using POST.
        /// </summary>
        /// <param name="userTeamworkToCreate">The UserTeamwork to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserTeamwork.</returns>
        public async System.Threading.Tasks.Task<UserTeamwork> CreateAsync(UserTeamwork userTeamworkToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<UserTeamwork>(userTeamworkToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified UserTeamwork using POST and returns a <see cref="GraphResponse{UserTeamwork}"/> object.
        /// </summary>
        /// <param name="userTeamworkToCreate">The UserTeamwork to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserTeamwork}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserTeamwork>> CreateResponseAsync(UserTeamwork userTeamworkToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<UserTeamwork>(userTeamworkToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified UserTeamwork.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<UserTeamwork>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified UserTeamwork and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified UserTeamwork.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UserTeamwork.</returns>
        public async System.Threading.Tasks.Task<UserTeamwork> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<UserTeamwork>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified UserTeamwork and returns a <see cref="GraphResponse{UserTeamwork}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserTeamwork}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserTeamwork>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<UserTeamwork>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified UserTeamwork using PATCH.
        /// </summary>
        /// <param name="userTeamworkToUpdate">The UserTeamwork to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UserTeamwork.</returns>
        public async System.Threading.Tasks.Task<UserTeamwork> UpdateAsync(UserTeamwork userTeamworkToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<UserTeamwork>(userTeamworkToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified UserTeamwork using PATCH and returns a <see cref="GraphResponse{UserTeamwork}"/> object.
        /// </summary>
        /// <param name="userTeamworkToUpdate">The UserTeamwork to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UserTeamwork}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserTeamwork>> UpdateResponseAsync(UserTeamwork userTeamworkToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<UserTeamwork>(userTeamworkToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified UserTeamwork using PUT.
        /// </summary>
        /// <param name="userTeamworkToUpdate">The UserTeamwork object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<UserTeamwork> PutAsync(UserTeamwork userTeamworkToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<UserTeamwork>(userTeamworkToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified UserTeamwork using PUT and returns a <see cref="GraphResponse{UserTeamwork}"/> object.
        /// </summary>
        /// <param name="userTeamworkToUpdate">The UserTeamwork object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{UserTeamwork}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserTeamwork>> PutResponseAsync(UserTeamwork userTeamworkToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<UserTeamwork>(userTeamworkToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUserTeamworkRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUserTeamworkRequest Expand(Expression<Func<UserTeamwork, object>> expandExpression)
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
        public IUserTeamworkRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IUserTeamworkRequest Select(Expression<Func<UserTeamwork, object>> selectExpression)
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
        /// <param name="userTeamworkToInitialize">The <see cref="UserTeamwork"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(UserTeamwork userTeamworkToInitialize)
        {

            if (userTeamworkToInitialize != null)
            {
                if (userTeamworkToInitialize.InstalledApps != null && userTeamworkToInitialize.InstalledApps.CurrentPage != null)
                {
                    userTeamworkToInitialize.InstalledApps.InitializeNextPageRequest(this.Client, userTeamworkToInitialize.InstalledAppsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userTeamworkToInitialize.InstalledApps.AdditionalData = userTeamworkToInitialize.AdditionalData;
                }

            }


        }
    }
}
