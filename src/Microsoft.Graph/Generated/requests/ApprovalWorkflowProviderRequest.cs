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
    /// The type ApprovalWorkflowProviderRequest.
    /// </summary>
    public partial class ApprovalWorkflowProviderRequest : BaseRequest, IApprovalWorkflowProviderRequest
    {
        /// <summary>
        /// Constructs a new ApprovalWorkflowProviderRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ApprovalWorkflowProviderRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ApprovalWorkflowProvider using POST.
        /// </summary>
        /// <param name="approvalWorkflowProviderToCreate">The ApprovalWorkflowProvider to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ApprovalWorkflowProvider.</returns>
        public async System.Threading.Tasks.Task<ApprovalWorkflowProvider> CreateAsync(ApprovalWorkflowProvider approvalWorkflowProviderToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<ApprovalWorkflowProvider>(approvalWorkflowProviderToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified ApprovalWorkflowProvider using POST and returns a <see cref="GraphResponse{ApprovalWorkflowProvider}"/> object.
        /// </summary>
        /// <param name="approvalWorkflowProviderToCreate">The ApprovalWorkflowProvider to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ApprovalWorkflowProvider}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ApprovalWorkflowProvider>> CreateResponseAsync(ApprovalWorkflowProvider approvalWorkflowProviderToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<ApprovalWorkflowProvider>(approvalWorkflowProviderToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified ApprovalWorkflowProvider.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<ApprovalWorkflowProvider>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ApprovalWorkflowProvider and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified ApprovalWorkflowProvider.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ApprovalWorkflowProvider.</returns>
        public async System.Threading.Tasks.Task<ApprovalWorkflowProvider> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<ApprovalWorkflowProvider>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ApprovalWorkflowProvider and returns a <see cref="GraphResponse{ApprovalWorkflowProvider}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ApprovalWorkflowProvider}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ApprovalWorkflowProvider>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<ApprovalWorkflowProvider>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ApprovalWorkflowProvider using PATCH.
        /// </summary>
        /// <param name="approvalWorkflowProviderToUpdate">The ApprovalWorkflowProvider to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ApprovalWorkflowProvider.</returns>
        public async System.Threading.Tasks.Task<ApprovalWorkflowProvider> UpdateAsync(ApprovalWorkflowProvider approvalWorkflowProviderToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<ApprovalWorkflowProvider>(approvalWorkflowProviderToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ApprovalWorkflowProvider using PATCH and returns a <see cref="GraphResponse{ApprovalWorkflowProvider}"/> object.
        /// </summary>
        /// <param name="approvalWorkflowProviderToUpdate">The ApprovalWorkflowProvider to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ApprovalWorkflowProvider}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ApprovalWorkflowProvider>> UpdateResponseAsync(ApprovalWorkflowProvider approvalWorkflowProviderToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<ApprovalWorkflowProvider>(approvalWorkflowProviderToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ApprovalWorkflowProvider using PUT.
        /// </summary>
        /// <param name="approvalWorkflowProviderToUpdate">The ApprovalWorkflowProvider object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<ApprovalWorkflowProvider> PutAsync(ApprovalWorkflowProvider approvalWorkflowProviderToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<ApprovalWorkflowProvider>(approvalWorkflowProviderToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ApprovalWorkflowProvider using PUT and returns a <see cref="GraphResponse{ApprovalWorkflowProvider}"/> object.
        /// </summary>
        /// <param name="approvalWorkflowProviderToUpdate">The ApprovalWorkflowProvider object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{ApprovalWorkflowProvider}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ApprovalWorkflowProvider>> PutResponseAsync(ApprovalWorkflowProvider approvalWorkflowProviderToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<ApprovalWorkflowProvider>(approvalWorkflowProviderToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IApprovalWorkflowProviderRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IApprovalWorkflowProviderRequest Expand(Expression<Func<ApprovalWorkflowProvider, object>> expandExpression)
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
        public IApprovalWorkflowProviderRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IApprovalWorkflowProviderRequest Select(Expression<Func<ApprovalWorkflowProvider, object>> selectExpression)
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
        /// <param name="approvalWorkflowProviderToInitialize">The <see cref="ApprovalWorkflowProvider"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ApprovalWorkflowProvider approvalWorkflowProviderToInitialize)
        {

            if (approvalWorkflowProviderToInitialize != null)
            {
                if (approvalWorkflowProviderToInitialize.BusinessFlows != null && approvalWorkflowProviderToInitialize.BusinessFlows.CurrentPage != null)
                {
                    approvalWorkflowProviderToInitialize.BusinessFlows.InitializeNextPageRequest(this.Client, approvalWorkflowProviderToInitialize.BusinessFlowsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    approvalWorkflowProviderToInitialize.BusinessFlows.AdditionalData = approvalWorkflowProviderToInitialize.AdditionalData;
                }
                if (approvalWorkflowProviderToInitialize.BusinessFlowsWithRequestsAwaitingMyDecision != null && approvalWorkflowProviderToInitialize.BusinessFlowsWithRequestsAwaitingMyDecision.CurrentPage != null)
                {
                    approvalWorkflowProviderToInitialize.BusinessFlowsWithRequestsAwaitingMyDecision.InitializeNextPageRequest(this.Client, approvalWorkflowProviderToInitialize.BusinessFlowsWithRequestsAwaitingMyDecisionNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    approvalWorkflowProviderToInitialize.BusinessFlowsWithRequestsAwaitingMyDecision.AdditionalData = approvalWorkflowProviderToInitialize.AdditionalData;
                }
                if (approvalWorkflowProviderToInitialize.PolicyTemplates != null && approvalWorkflowProviderToInitialize.PolicyTemplates.CurrentPage != null)
                {
                    approvalWorkflowProviderToInitialize.PolicyTemplates.InitializeNextPageRequest(this.Client, approvalWorkflowProviderToInitialize.PolicyTemplatesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    approvalWorkflowProviderToInitialize.PolicyTemplates.AdditionalData = approvalWorkflowProviderToInitialize.AdditionalData;
                }

            }


        }
    }
}
