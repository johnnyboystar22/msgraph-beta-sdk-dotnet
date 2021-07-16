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
    /// The type OneDriveUsageAccountDetailRequest.
    /// </summary>
    public partial class OneDriveUsageAccountDetailRequest : BaseRequest, IOneDriveUsageAccountDetailRequest
    {
        /// <summary>
        /// Constructs a new OneDriveUsageAccountDetailRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public OneDriveUsageAccountDetailRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified OneDriveUsageAccountDetail using POST.
        /// </summary>
        /// <param name="oneDriveUsageAccountDetailToCreate">The OneDriveUsageAccountDetail to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OneDriveUsageAccountDetail.</returns>
        public async System.Threading.Tasks.Task<OneDriveUsageAccountDetail> CreateAsync(OneDriveUsageAccountDetail oneDriveUsageAccountDetailToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<OneDriveUsageAccountDetail>(oneDriveUsageAccountDetailToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified OneDriveUsageAccountDetail using POST and returns a <see cref="GraphResponse{OneDriveUsageAccountDetail}"/> object.
        /// </summary>
        /// <param name="oneDriveUsageAccountDetailToCreate">The OneDriveUsageAccountDetail to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OneDriveUsageAccountDetail}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OneDriveUsageAccountDetail>> CreateResponseAsync(OneDriveUsageAccountDetail oneDriveUsageAccountDetailToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<OneDriveUsageAccountDetail>(oneDriveUsageAccountDetailToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified OneDriveUsageAccountDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<OneDriveUsageAccountDetail>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified OneDriveUsageAccountDetail and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified OneDriveUsageAccountDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OneDriveUsageAccountDetail.</returns>
        public async System.Threading.Tasks.Task<OneDriveUsageAccountDetail> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<OneDriveUsageAccountDetail>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified OneDriveUsageAccountDetail and returns a <see cref="GraphResponse{OneDriveUsageAccountDetail}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OneDriveUsageAccountDetail}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OneDriveUsageAccountDetail>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<OneDriveUsageAccountDetail>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified OneDriveUsageAccountDetail using PATCH.
        /// </summary>
        /// <param name="oneDriveUsageAccountDetailToUpdate">The OneDriveUsageAccountDetail to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OneDriveUsageAccountDetail.</returns>
        public async System.Threading.Tasks.Task<OneDriveUsageAccountDetail> UpdateAsync(OneDriveUsageAccountDetail oneDriveUsageAccountDetailToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<OneDriveUsageAccountDetail>(oneDriveUsageAccountDetailToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified OneDriveUsageAccountDetail using PATCH and returns a <see cref="GraphResponse{OneDriveUsageAccountDetail}"/> object.
        /// </summary>
        /// <param name="oneDriveUsageAccountDetailToUpdate">The OneDriveUsageAccountDetail to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{OneDriveUsageAccountDetail}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OneDriveUsageAccountDetail>> UpdateResponseAsync(OneDriveUsageAccountDetail oneDriveUsageAccountDetailToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<OneDriveUsageAccountDetail>(oneDriveUsageAccountDetailToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified OneDriveUsageAccountDetail using PUT.
        /// </summary>
        /// <param name="oneDriveUsageAccountDetailToUpdate">The OneDriveUsageAccountDetail object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<OneDriveUsageAccountDetail> PutAsync(OneDriveUsageAccountDetail oneDriveUsageAccountDetailToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<OneDriveUsageAccountDetail>(oneDriveUsageAccountDetailToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified OneDriveUsageAccountDetail using PUT and returns a <see cref="GraphResponse{OneDriveUsageAccountDetail}"/> object.
        /// </summary>
        /// <param name="oneDriveUsageAccountDetailToUpdate">The OneDriveUsageAccountDetail object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{OneDriveUsageAccountDetail}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OneDriveUsageAccountDetail>> PutResponseAsync(OneDriveUsageAccountDetail oneDriveUsageAccountDetailToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<OneDriveUsageAccountDetail>(oneDriveUsageAccountDetailToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOneDriveUsageAccountDetailRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOneDriveUsageAccountDetailRequest Expand(Expression<Func<OneDriveUsageAccountDetail, object>> expandExpression)
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
        public IOneDriveUsageAccountDetailRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IOneDriveUsageAccountDetailRequest Select(Expression<Func<OneDriveUsageAccountDetail, object>> selectExpression)
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
        /// <param name="oneDriveUsageAccountDetailToInitialize">The <see cref="OneDriveUsageAccountDetail"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(OneDriveUsageAccountDetail oneDriveUsageAccountDetailToInitialize)
        {

        }
    }
}
