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
    /// The type GroupPolicyConfigurationAssignmentRequest.
    /// </summary>
    public partial class GroupPolicyConfigurationAssignmentRequest : BaseRequest, IGroupPolicyConfigurationAssignmentRequest
    {
        /// <summary>
        /// Constructs a new GroupPolicyConfigurationAssignmentRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public GroupPolicyConfigurationAssignmentRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified GroupPolicyConfigurationAssignment using POST.
        /// </summary>
        /// <param name="groupPolicyConfigurationAssignmentToCreate">The GroupPolicyConfigurationAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GroupPolicyConfigurationAssignment.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyConfigurationAssignment> CreateAsync(GroupPolicyConfigurationAssignment groupPolicyConfigurationAssignmentToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<GroupPolicyConfigurationAssignment>(groupPolicyConfigurationAssignmentToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified GroupPolicyConfigurationAssignment using POST and returns a <see cref="GraphResponse{GroupPolicyConfigurationAssignment}"/> object.
        /// </summary>
        /// <param name="groupPolicyConfigurationAssignmentToCreate">The GroupPolicyConfigurationAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyConfigurationAssignment}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyConfigurationAssignment>> CreateResponseAsync(GroupPolicyConfigurationAssignment groupPolicyConfigurationAssignmentToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<GroupPolicyConfigurationAssignment>(groupPolicyConfigurationAssignmentToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified GroupPolicyConfigurationAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<GroupPolicyConfigurationAssignment>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified GroupPolicyConfigurationAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified GroupPolicyConfigurationAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GroupPolicyConfigurationAssignment.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyConfigurationAssignment> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<GroupPolicyConfigurationAssignment>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified GroupPolicyConfigurationAssignment and returns a <see cref="GraphResponse{GroupPolicyConfigurationAssignment}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyConfigurationAssignment}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyConfigurationAssignment>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<GroupPolicyConfigurationAssignment>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified GroupPolicyConfigurationAssignment using PATCH.
        /// </summary>
        /// <param name="groupPolicyConfigurationAssignmentToUpdate">The GroupPolicyConfigurationAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GroupPolicyConfigurationAssignment.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyConfigurationAssignment> UpdateAsync(GroupPolicyConfigurationAssignment groupPolicyConfigurationAssignmentToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<GroupPolicyConfigurationAssignment>(groupPolicyConfigurationAssignmentToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified GroupPolicyConfigurationAssignment using PATCH and returns a <see cref="GraphResponse{GroupPolicyConfigurationAssignment}"/> object.
        /// </summary>
        /// <param name="groupPolicyConfigurationAssignmentToUpdate">The GroupPolicyConfigurationAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{GroupPolicyConfigurationAssignment}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyConfigurationAssignment>> UpdateResponseAsync(GroupPolicyConfigurationAssignment groupPolicyConfigurationAssignmentToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<GroupPolicyConfigurationAssignment>(groupPolicyConfigurationAssignmentToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified GroupPolicyConfigurationAssignment using PUT.
        /// </summary>
        /// <param name="groupPolicyConfigurationAssignmentToUpdate">The GroupPolicyConfigurationAssignment object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyConfigurationAssignment> PutAsync(GroupPolicyConfigurationAssignment groupPolicyConfigurationAssignmentToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<GroupPolicyConfigurationAssignment>(groupPolicyConfigurationAssignmentToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified GroupPolicyConfigurationAssignment using PUT and returns a <see cref="GraphResponse{GroupPolicyConfigurationAssignment}"/> object.
        /// </summary>
        /// <param name="groupPolicyConfigurationAssignmentToUpdate">The GroupPolicyConfigurationAssignment object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{GroupPolicyConfigurationAssignment}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyConfigurationAssignment>> PutResponseAsync(GroupPolicyConfigurationAssignment groupPolicyConfigurationAssignmentToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<GroupPolicyConfigurationAssignment>(groupPolicyConfigurationAssignmentToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyConfigurationAssignmentRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyConfigurationAssignmentRequest Expand(Expression<Func<GroupPolicyConfigurationAssignment, object>> expandExpression)
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
        public IGroupPolicyConfigurationAssignmentRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyConfigurationAssignmentRequest Select(Expression<Func<GroupPolicyConfigurationAssignment, object>> selectExpression)
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
        /// <param name="groupPolicyConfigurationAssignmentToInitialize">The <see cref="GroupPolicyConfigurationAssignment"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(GroupPolicyConfigurationAssignment groupPolicyConfigurationAssignmentToInitialize)
        {

        }
    }
}
