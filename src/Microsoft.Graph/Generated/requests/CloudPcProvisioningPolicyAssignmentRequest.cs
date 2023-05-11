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
    /// The type CloudPcProvisioningPolicyAssignmentRequest.
    /// </summary>
    public partial class CloudPcProvisioningPolicyAssignmentRequest : BaseRequest, ICloudPcProvisioningPolicyAssignmentRequest
    {
        /// <summary>
        /// Constructs a new CloudPcProvisioningPolicyAssignmentRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public CloudPcProvisioningPolicyAssignmentRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified CloudPcProvisioningPolicyAssignment using POST.
        /// </summary>
        /// <param name="cloudPcProvisioningPolicyAssignmentToCreate">The CloudPcProvisioningPolicyAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CloudPcProvisioningPolicyAssignment.</returns>
        public async System.Threading.Tasks.Task<CloudPcProvisioningPolicyAssignment> CreateAsync(CloudPcProvisioningPolicyAssignment cloudPcProvisioningPolicyAssignmentToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<CloudPcProvisioningPolicyAssignment>(cloudPcProvisioningPolicyAssignmentToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified CloudPcProvisioningPolicyAssignment using POST and returns a <see cref="GraphResponse{CloudPcProvisioningPolicyAssignment}"/> object.
        /// </summary>
        /// <param name="cloudPcProvisioningPolicyAssignmentToCreate">The CloudPcProvisioningPolicyAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CloudPcProvisioningPolicyAssignment}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CloudPcProvisioningPolicyAssignment>> CreateResponseAsync(CloudPcProvisioningPolicyAssignment cloudPcProvisioningPolicyAssignmentToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<CloudPcProvisioningPolicyAssignment>(cloudPcProvisioningPolicyAssignmentToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified CloudPcProvisioningPolicyAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<CloudPcProvisioningPolicyAssignment>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified CloudPcProvisioningPolicyAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified CloudPcProvisioningPolicyAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CloudPcProvisioningPolicyAssignment.</returns>
        public async System.Threading.Tasks.Task<CloudPcProvisioningPolicyAssignment> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<CloudPcProvisioningPolicyAssignment>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified CloudPcProvisioningPolicyAssignment and returns a <see cref="GraphResponse{CloudPcProvisioningPolicyAssignment}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CloudPcProvisioningPolicyAssignment}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CloudPcProvisioningPolicyAssignment>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<CloudPcProvisioningPolicyAssignment>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified CloudPcProvisioningPolicyAssignment using PATCH.
        /// </summary>
        /// <param name="cloudPcProvisioningPolicyAssignmentToUpdate">The CloudPcProvisioningPolicyAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CloudPcProvisioningPolicyAssignment.</returns>
        public async System.Threading.Tasks.Task<CloudPcProvisioningPolicyAssignment> UpdateAsync(CloudPcProvisioningPolicyAssignment cloudPcProvisioningPolicyAssignmentToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<CloudPcProvisioningPolicyAssignment>(cloudPcProvisioningPolicyAssignmentToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified CloudPcProvisioningPolicyAssignment using PATCH and returns a <see cref="GraphResponse{CloudPcProvisioningPolicyAssignment}"/> object.
        /// </summary>
        /// <param name="cloudPcProvisioningPolicyAssignmentToUpdate">The CloudPcProvisioningPolicyAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{CloudPcProvisioningPolicyAssignment}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CloudPcProvisioningPolicyAssignment>> UpdateResponseAsync(CloudPcProvisioningPolicyAssignment cloudPcProvisioningPolicyAssignmentToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<CloudPcProvisioningPolicyAssignment>(cloudPcProvisioningPolicyAssignmentToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified CloudPcProvisioningPolicyAssignment using PUT.
        /// </summary>
        /// <param name="cloudPcProvisioningPolicyAssignmentToUpdate">The CloudPcProvisioningPolicyAssignment object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<CloudPcProvisioningPolicyAssignment> PutAsync(CloudPcProvisioningPolicyAssignment cloudPcProvisioningPolicyAssignmentToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<CloudPcProvisioningPolicyAssignment>(cloudPcProvisioningPolicyAssignmentToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified CloudPcProvisioningPolicyAssignment using PUT and returns a <see cref="GraphResponse{CloudPcProvisioningPolicyAssignment}"/> object.
        /// </summary>
        /// <param name="cloudPcProvisioningPolicyAssignmentToUpdate">The CloudPcProvisioningPolicyAssignment object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{CloudPcProvisioningPolicyAssignment}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CloudPcProvisioningPolicyAssignment>> PutResponseAsync(CloudPcProvisioningPolicyAssignment cloudPcProvisioningPolicyAssignmentToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<CloudPcProvisioningPolicyAssignment>(cloudPcProvisioningPolicyAssignmentToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICloudPcProvisioningPolicyAssignmentRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICloudPcProvisioningPolicyAssignmentRequest Expand(Expression<Func<CloudPcProvisioningPolicyAssignment, object>> expandExpression)
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
        public ICloudPcProvisioningPolicyAssignmentRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ICloudPcProvisioningPolicyAssignmentRequest Select(Expression<Func<CloudPcProvisioningPolicyAssignment, object>> selectExpression)
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
        /// <param name="cloudPcProvisioningPolicyAssignmentToInitialize">The <see cref="CloudPcProvisioningPolicyAssignment"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(CloudPcProvisioningPolicyAssignment cloudPcProvisioningPolicyAssignmentToInitialize)
        {

            if (cloudPcProvisioningPolicyAssignmentToInitialize != null)
            {
                if (cloudPcProvisioningPolicyAssignmentToInitialize.AssignedUsers != null && cloudPcProvisioningPolicyAssignmentToInitialize.AssignedUsers.CurrentPage != null)
                {
                    cloudPcProvisioningPolicyAssignmentToInitialize.AssignedUsers.InitializeNextPageRequest(this.Client, cloudPcProvisioningPolicyAssignmentToInitialize.AssignedUsersNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    cloudPcProvisioningPolicyAssignmentToInitialize.AssignedUsers.AdditionalData = cloudPcProvisioningPolicyAssignmentToInitialize.AdditionalData;
                }

            }


        }
    }
}
