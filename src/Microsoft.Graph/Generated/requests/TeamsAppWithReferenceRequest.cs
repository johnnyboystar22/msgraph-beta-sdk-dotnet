// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type TeamsAppWithReferenceRequest.
    /// </summary>
    public partial class TeamsAppWithReferenceRequest : BaseRequest, ITeamsAppWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new TeamsAppWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public TeamsAppWithReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified TeamsApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TeamsApp.</returns>
        public async System.Threading.Tasks.Task<TeamsApp> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.GET.ToString();
            var retrievedEntity = await this.SendAsync<TeamsApp>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified TeamsApp and returns a <see cref="GraphResponse{TeamsApp}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamsApp}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TeamsApp>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.GET.ToString();
            return this.SendAsyncWithGraphResponse<TeamsApp>(null, cancellationToken);
        }

		/// <summary>
        /// Creates the specified TeamsApp using POST.
        /// </summary>
        /// <param name="teamsAppToCreate">The TeamsApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TeamsApp.</returns>
        public async System.Threading.Tasks.Task<TeamsApp> CreateAsync(TeamsApp teamsAppToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.POST.ToString();
            var newEntity = await this.SendAsync<TeamsApp>(teamsAppToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Creates the specified TeamsApp using POST and returns a <see cref="GraphResponse{TeamsApp}"/> object.
        /// </summary>
        /// <param name="teamsAppToCreate">The TeamsApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamsApp}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TeamsApp>> CreateResponseAsync(TeamsApp teamsAppToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.POST.ToString();
            return this.SendAsyncWithGraphResponse<TeamsApp>(teamsAppToCreate, cancellationToken);
        }

		/// <summary>
        /// Updates the specified TeamsApp using PATCH.
        /// </summary>
        /// <param name="teamsAppToUpdate">The TeamsApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TeamsApp.</returns>
        public async System.Threading.Tasks.Task<TeamsApp> UpdateAsync(TeamsApp teamsAppToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.PATCH.ToString();
            var updatedEntity = await this.SendAsync<TeamsApp>(teamsAppToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Updates the specified TeamsApp using PATCH and returns a <see cref="GraphResponse{TeamsApp}"/> object.
        /// </summary>
        /// <param name="teamsAppToUpdate">The TeamsApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TeamsApp}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TeamsApp>> UpdateResponseAsync(TeamsApp teamsAppToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.PATCH.ToString();
            return this.SendAsyncWithGraphResponse<TeamsApp>(teamsAppToUpdate, cancellationToken);
        }

		/// <summary>
        /// Deletes the specified TeamsApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.DELETE.ToString();
            await this.SendAsync<TeamsApp>(null, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified TeamsApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.DELETE.ToString();
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITeamsAppWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITeamsAppWithReferenceRequest Expand(Expression<Func<TeamsApp, object>> expandExpression)
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
        public ITeamsAppWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ITeamsAppWithReferenceRequest Select(Expression<Func<TeamsApp, object>> selectExpression)
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

    }
}
