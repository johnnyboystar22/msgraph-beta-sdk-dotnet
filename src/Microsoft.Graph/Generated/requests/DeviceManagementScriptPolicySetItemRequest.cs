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
    /// The type DeviceManagementScriptPolicySetItemRequest.
    /// </summary>
    public partial class DeviceManagementScriptPolicySetItemRequest : BaseRequest, IDeviceManagementScriptPolicySetItemRequest
    {
        /// <summary>
        /// Constructs a new DeviceManagementScriptPolicySetItemRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceManagementScriptPolicySetItemRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceManagementScriptPolicySetItem using POST.
        /// </summary>
        /// <param name="deviceManagementScriptPolicySetItemToCreate">The DeviceManagementScriptPolicySetItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementScriptPolicySetItem.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementScriptPolicySetItem> CreateAsync(DeviceManagementScriptPolicySetItem deviceManagementScriptPolicySetItemToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<DeviceManagementScriptPolicySetItem>(deviceManagementScriptPolicySetItemToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DeviceManagementScriptPolicySetItem using POST and returns a <see cref="GraphResponse{DeviceManagementScriptPolicySetItem}"/> object.
        /// </summary>
        /// <param name="deviceManagementScriptPolicySetItemToCreate">The DeviceManagementScriptPolicySetItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementScriptPolicySetItem}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementScriptPolicySetItem>> CreateResponseAsync(DeviceManagementScriptPolicySetItem deviceManagementScriptPolicySetItemToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<DeviceManagementScriptPolicySetItem>(deviceManagementScriptPolicySetItemToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementScriptPolicySetItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<DeviceManagementScriptPolicySetItem>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementScriptPolicySetItem and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified DeviceManagementScriptPolicySetItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementScriptPolicySetItem.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementScriptPolicySetItem> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<DeviceManagementScriptPolicySetItem>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DeviceManagementScriptPolicySetItem and returns a <see cref="GraphResponse{DeviceManagementScriptPolicySetItem}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementScriptPolicySetItem}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementScriptPolicySetItem>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<DeviceManagementScriptPolicySetItem>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DeviceManagementScriptPolicySetItem using PATCH.
        /// </summary>
        /// <param name="deviceManagementScriptPolicySetItemToUpdate">The DeviceManagementScriptPolicySetItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementScriptPolicySetItem.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementScriptPolicySetItem> UpdateAsync(DeviceManagementScriptPolicySetItem deviceManagementScriptPolicySetItemToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<DeviceManagementScriptPolicySetItem>(deviceManagementScriptPolicySetItemToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagementScriptPolicySetItem using PATCH and returns a <see cref="GraphResponse{DeviceManagementScriptPolicySetItem}"/> object.
        /// </summary>
        /// <param name="deviceManagementScriptPolicySetItemToUpdate">The DeviceManagementScriptPolicySetItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementScriptPolicySetItem}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementScriptPolicySetItem>> UpdateResponseAsync(DeviceManagementScriptPolicySetItem deviceManagementScriptPolicySetItemToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<DeviceManagementScriptPolicySetItem>(deviceManagementScriptPolicySetItemToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DeviceManagementScriptPolicySetItem using PUT.
        /// </summary>
        /// <param name="deviceManagementScriptPolicySetItemToUpdate">The DeviceManagementScriptPolicySetItem object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementScriptPolicySetItem> PutAsync(DeviceManagementScriptPolicySetItem deviceManagementScriptPolicySetItemToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<DeviceManagementScriptPolicySetItem>(deviceManagementScriptPolicySetItemToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagementScriptPolicySetItem using PUT and returns a <see cref="GraphResponse{DeviceManagementScriptPolicySetItem}"/> object.
        /// </summary>
        /// <param name="deviceManagementScriptPolicySetItemToUpdate">The DeviceManagementScriptPolicySetItem object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{DeviceManagementScriptPolicySetItem}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementScriptPolicySetItem>> PutResponseAsync(DeviceManagementScriptPolicySetItem deviceManagementScriptPolicySetItemToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<DeviceManagementScriptPolicySetItem>(deviceManagementScriptPolicySetItemToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementScriptPolicySetItemRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementScriptPolicySetItemRequest Expand(Expression<Func<DeviceManagementScriptPolicySetItem, object>> expandExpression)
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
        public IDeviceManagementScriptPolicySetItemRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementScriptPolicySetItemRequest Select(Expression<Func<DeviceManagementScriptPolicySetItem, object>> selectExpression)
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
        /// <param name="deviceManagementScriptPolicySetItemToInitialize">The <see cref="DeviceManagementScriptPolicySetItem"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceManagementScriptPolicySetItem deviceManagementScriptPolicySetItemToInitialize)
        {

        }
    }
}
