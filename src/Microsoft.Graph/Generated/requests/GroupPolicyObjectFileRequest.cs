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
    /// The type GroupPolicyObjectFileRequest.
    /// </summary>
    public partial class GroupPolicyObjectFileRequest : BaseRequest, IGroupPolicyObjectFileRequest
    {
        /// <summary>
        /// Constructs a new GroupPolicyObjectFileRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public GroupPolicyObjectFileRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified GroupPolicyObjectFile using POST.
        /// </summary>
        /// <param name="groupPolicyObjectFileToCreate">The GroupPolicyObjectFile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GroupPolicyObjectFile.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyObjectFile> CreateAsync(GroupPolicyObjectFile groupPolicyObjectFileToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<GroupPolicyObjectFile>(groupPolicyObjectFileToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified GroupPolicyObjectFile using POST and returns a <see cref="GraphResponse{GroupPolicyObjectFile}"/> object.
        /// </summary>
        /// <param name="groupPolicyObjectFileToCreate">The GroupPolicyObjectFile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyObjectFile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyObjectFile>> CreateResponseAsync(GroupPolicyObjectFile groupPolicyObjectFileToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<GroupPolicyObjectFile>(groupPolicyObjectFileToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified GroupPolicyObjectFile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<GroupPolicyObjectFile>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified GroupPolicyObjectFile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified GroupPolicyObjectFile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GroupPolicyObjectFile.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyObjectFile> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<GroupPolicyObjectFile>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified GroupPolicyObjectFile and returns a <see cref="GraphResponse{GroupPolicyObjectFile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyObjectFile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyObjectFile>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<GroupPolicyObjectFile>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified GroupPolicyObjectFile using PATCH.
        /// </summary>
        /// <param name="groupPolicyObjectFileToUpdate">The GroupPolicyObjectFile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GroupPolicyObjectFile.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyObjectFile> UpdateAsync(GroupPolicyObjectFile groupPolicyObjectFileToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<GroupPolicyObjectFile>(groupPolicyObjectFileToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified GroupPolicyObjectFile using PATCH and returns a <see cref="GraphResponse{GroupPolicyObjectFile}"/> object.
        /// </summary>
        /// <param name="groupPolicyObjectFileToUpdate">The GroupPolicyObjectFile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{GroupPolicyObjectFile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyObjectFile>> UpdateResponseAsync(GroupPolicyObjectFile groupPolicyObjectFileToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<GroupPolicyObjectFile>(groupPolicyObjectFileToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified GroupPolicyObjectFile using PUT.
        /// </summary>
        /// <param name="groupPolicyObjectFileToUpdate">The GroupPolicyObjectFile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyObjectFile> PutAsync(GroupPolicyObjectFile groupPolicyObjectFileToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<GroupPolicyObjectFile>(groupPolicyObjectFileToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified GroupPolicyObjectFile using PUT and returns a <see cref="GraphResponse{GroupPolicyObjectFile}"/> object.
        /// </summary>
        /// <param name="groupPolicyObjectFileToUpdate">The GroupPolicyObjectFile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{GroupPolicyObjectFile}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyObjectFile>> PutResponseAsync(GroupPolicyObjectFile groupPolicyObjectFileToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<GroupPolicyObjectFile>(groupPolicyObjectFileToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyObjectFileRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyObjectFileRequest Expand(Expression<Func<GroupPolicyObjectFile, object>> expandExpression)
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
        public IGroupPolicyObjectFileRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyObjectFileRequest Select(Expression<Func<GroupPolicyObjectFile, object>> selectExpression)
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
        /// <param name="groupPolicyObjectFileToInitialize">The <see cref="GroupPolicyObjectFile"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(GroupPolicyObjectFile groupPolicyObjectFileToInitialize)
        {

        }
    }
}
