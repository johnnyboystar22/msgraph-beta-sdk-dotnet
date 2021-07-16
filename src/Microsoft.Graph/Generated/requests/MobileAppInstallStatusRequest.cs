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
    /// The type MobileAppInstallStatusRequest.
    /// </summary>
    public partial class MobileAppInstallStatusRequest : BaseRequest, IMobileAppInstallStatusRequest
    {
        /// <summary>
        /// Constructs a new MobileAppInstallStatusRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MobileAppInstallStatusRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified MobileAppInstallStatus using POST.
        /// </summary>
        /// <param name="mobileAppInstallStatusToCreate">The MobileAppInstallStatus to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MobileAppInstallStatus.</returns>
        public async System.Threading.Tasks.Task<MobileAppInstallStatus> CreateAsync(MobileAppInstallStatus mobileAppInstallStatusToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<MobileAppInstallStatus>(mobileAppInstallStatusToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified MobileAppInstallStatus using POST and returns a <see cref="GraphResponse{MobileAppInstallStatus}"/> object.
        /// </summary>
        /// <param name="mobileAppInstallStatusToCreate">The MobileAppInstallStatus to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MobileAppInstallStatus}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MobileAppInstallStatus>> CreateResponseAsync(MobileAppInstallStatus mobileAppInstallStatusToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<MobileAppInstallStatus>(mobileAppInstallStatusToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified MobileAppInstallStatus.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<MobileAppInstallStatus>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MobileAppInstallStatus and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified MobileAppInstallStatus.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MobileAppInstallStatus.</returns>
        public async System.Threading.Tasks.Task<MobileAppInstallStatus> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<MobileAppInstallStatus>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified MobileAppInstallStatus and returns a <see cref="GraphResponse{MobileAppInstallStatus}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MobileAppInstallStatus}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MobileAppInstallStatus>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<MobileAppInstallStatus>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified MobileAppInstallStatus using PATCH.
        /// </summary>
        /// <param name="mobileAppInstallStatusToUpdate">The MobileAppInstallStatus to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MobileAppInstallStatus.</returns>
        public async System.Threading.Tasks.Task<MobileAppInstallStatus> UpdateAsync(MobileAppInstallStatus mobileAppInstallStatusToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<MobileAppInstallStatus>(mobileAppInstallStatusToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified MobileAppInstallStatus using PATCH and returns a <see cref="GraphResponse{MobileAppInstallStatus}"/> object.
        /// </summary>
        /// <param name="mobileAppInstallStatusToUpdate">The MobileAppInstallStatus to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MobileAppInstallStatus}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MobileAppInstallStatus>> UpdateResponseAsync(MobileAppInstallStatus mobileAppInstallStatusToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<MobileAppInstallStatus>(mobileAppInstallStatusToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified MobileAppInstallStatus using PUT.
        /// </summary>
        /// <param name="mobileAppInstallStatusToUpdate">The MobileAppInstallStatus object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<MobileAppInstallStatus> PutAsync(MobileAppInstallStatus mobileAppInstallStatusToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<MobileAppInstallStatus>(mobileAppInstallStatusToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified MobileAppInstallStatus using PUT and returns a <see cref="GraphResponse{MobileAppInstallStatus}"/> object.
        /// </summary>
        /// <param name="mobileAppInstallStatusToUpdate">The MobileAppInstallStatus object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{MobileAppInstallStatus}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MobileAppInstallStatus>> PutResponseAsync(MobileAppInstallStatus mobileAppInstallStatusToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<MobileAppInstallStatus>(mobileAppInstallStatusToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMobileAppInstallStatusRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMobileAppInstallStatusRequest Expand(Expression<Func<MobileAppInstallStatus, object>> expandExpression)
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
        public IMobileAppInstallStatusRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMobileAppInstallStatusRequest Select(Expression<Func<MobileAppInstallStatus, object>> selectExpression)
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
        /// <param name="mobileAppInstallStatusToInitialize">The <see cref="MobileAppInstallStatus"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(MobileAppInstallStatus mobileAppInstallStatusToInitialize)
        {

        }
    }
}
