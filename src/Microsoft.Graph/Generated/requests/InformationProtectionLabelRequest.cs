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
    /// The type InformationProtectionLabelRequest.
    /// </summary>
    public partial class InformationProtectionLabelRequest : BaseRequest, IInformationProtectionLabelRequest
    {
        /// <summary>
        /// Constructs a new InformationProtectionLabelRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public InformationProtectionLabelRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified InformationProtectionLabel using POST.
        /// </summary>
        /// <param name="informationProtectionLabelToCreate">The InformationProtectionLabel to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created InformationProtectionLabel.</returns>
        public async System.Threading.Tasks.Task<InformationProtectionLabel> CreateAsync(InformationProtectionLabel informationProtectionLabelToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<InformationProtectionLabel>(informationProtectionLabelToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified InformationProtectionLabel using POST and returns a <see cref="GraphResponse{InformationProtectionLabel}"/> object.
        /// </summary>
        /// <param name="informationProtectionLabelToCreate">The InformationProtectionLabel to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{InformationProtectionLabel}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<InformationProtectionLabel>> CreateResponseAsync(InformationProtectionLabel informationProtectionLabelToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<InformationProtectionLabel>(informationProtectionLabelToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified InformationProtectionLabel.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<InformationProtectionLabel>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified InformationProtectionLabel and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified InformationProtectionLabel.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The InformationProtectionLabel.</returns>
        public async System.Threading.Tasks.Task<InformationProtectionLabel> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<InformationProtectionLabel>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified InformationProtectionLabel and returns a <see cref="GraphResponse{InformationProtectionLabel}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{InformationProtectionLabel}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<InformationProtectionLabel>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<InformationProtectionLabel>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified InformationProtectionLabel using PATCH.
        /// </summary>
        /// <param name="informationProtectionLabelToUpdate">The InformationProtectionLabel to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated InformationProtectionLabel.</returns>
        public async System.Threading.Tasks.Task<InformationProtectionLabel> UpdateAsync(InformationProtectionLabel informationProtectionLabelToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<InformationProtectionLabel>(informationProtectionLabelToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified InformationProtectionLabel using PATCH and returns a <see cref="GraphResponse{InformationProtectionLabel}"/> object.
        /// </summary>
        /// <param name="informationProtectionLabelToUpdate">The InformationProtectionLabel to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{InformationProtectionLabel}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<InformationProtectionLabel>> UpdateResponseAsync(InformationProtectionLabel informationProtectionLabelToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<InformationProtectionLabel>(informationProtectionLabelToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified InformationProtectionLabel using PUT.
        /// </summary>
        /// <param name="informationProtectionLabelToUpdate">The InformationProtectionLabel object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<InformationProtectionLabel> PutAsync(InformationProtectionLabel informationProtectionLabelToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<InformationProtectionLabel>(informationProtectionLabelToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified InformationProtectionLabel using PUT and returns a <see cref="GraphResponse{InformationProtectionLabel}"/> object.
        /// </summary>
        /// <param name="informationProtectionLabelToUpdate">The InformationProtectionLabel object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{InformationProtectionLabel}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<InformationProtectionLabel>> PutResponseAsync(InformationProtectionLabel informationProtectionLabelToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<InformationProtectionLabel>(informationProtectionLabelToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IInformationProtectionLabelRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IInformationProtectionLabelRequest Expand(Expression<Func<InformationProtectionLabel, object>> expandExpression)
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
        public IInformationProtectionLabelRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IInformationProtectionLabelRequest Select(Expression<Func<InformationProtectionLabel, object>> selectExpression)
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
        /// <param name="informationProtectionLabelToInitialize">The <see cref="InformationProtectionLabel"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(InformationProtectionLabel informationProtectionLabelToInitialize)
        {

        }
    }
}
