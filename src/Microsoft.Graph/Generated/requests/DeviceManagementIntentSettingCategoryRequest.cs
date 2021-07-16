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
    /// The type DeviceManagementIntentSettingCategoryRequest.
    /// </summary>
    public partial class DeviceManagementIntentSettingCategoryRequest : BaseRequest, IDeviceManagementIntentSettingCategoryRequest
    {
        /// <summary>
        /// Constructs a new DeviceManagementIntentSettingCategoryRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceManagementIntentSettingCategoryRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceManagementIntentSettingCategory using POST.
        /// </summary>
        /// <param name="deviceManagementIntentSettingCategoryToCreate">The DeviceManagementIntentSettingCategory to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementIntentSettingCategory.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementIntentSettingCategory> CreateAsync(DeviceManagementIntentSettingCategory deviceManagementIntentSettingCategoryToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<DeviceManagementIntentSettingCategory>(deviceManagementIntentSettingCategoryToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DeviceManagementIntentSettingCategory using POST and returns a <see cref="GraphResponse{DeviceManagementIntentSettingCategory}"/> object.
        /// </summary>
        /// <param name="deviceManagementIntentSettingCategoryToCreate">The DeviceManagementIntentSettingCategory to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementIntentSettingCategory}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementIntentSettingCategory>> CreateResponseAsync(DeviceManagementIntentSettingCategory deviceManagementIntentSettingCategoryToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<DeviceManagementIntentSettingCategory>(deviceManagementIntentSettingCategoryToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementIntentSettingCategory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<DeviceManagementIntentSettingCategory>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementIntentSettingCategory and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified DeviceManagementIntentSettingCategory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementIntentSettingCategory.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementIntentSettingCategory> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<DeviceManagementIntentSettingCategory>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DeviceManagementIntentSettingCategory and returns a <see cref="GraphResponse{DeviceManagementIntentSettingCategory}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementIntentSettingCategory}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementIntentSettingCategory>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<DeviceManagementIntentSettingCategory>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DeviceManagementIntentSettingCategory using PATCH.
        /// </summary>
        /// <param name="deviceManagementIntentSettingCategoryToUpdate">The DeviceManagementIntentSettingCategory to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementIntentSettingCategory.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementIntentSettingCategory> UpdateAsync(DeviceManagementIntentSettingCategory deviceManagementIntentSettingCategoryToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<DeviceManagementIntentSettingCategory>(deviceManagementIntentSettingCategoryToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagementIntentSettingCategory using PATCH and returns a <see cref="GraphResponse{DeviceManagementIntentSettingCategory}"/> object.
        /// </summary>
        /// <param name="deviceManagementIntentSettingCategoryToUpdate">The DeviceManagementIntentSettingCategory to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementIntentSettingCategory}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementIntentSettingCategory>> UpdateResponseAsync(DeviceManagementIntentSettingCategory deviceManagementIntentSettingCategoryToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<DeviceManagementIntentSettingCategory>(deviceManagementIntentSettingCategoryToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DeviceManagementIntentSettingCategory using PUT.
        /// </summary>
        /// <param name="deviceManagementIntentSettingCategoryToUpdate">The DeviceManagementIntentSettingCategory object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementIntentSettingCategory> PutAsync(DeviceManagementIntentSettingCategory deviceManagementIntentSettingCategoryToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<DeviceManagementIntentSettingCategory>(deviceManagementIntentSettingCategoryToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagementIntentSettingCategory using PUT and returns a <see cref="GraphResponse{DeviceManagementIntentSettingCategory}"/> object.
        /// </summary>
        /// <param name="deviceManagementIntentSettingCategoryToUpdate">The DeviceManagementIntentSettingCategory object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{DeviceManagementIntentSettingCategory}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementIntentSettingCategory>> PutResponseAsync(DeviceManagementIntentSettingCategory deviceManagementIntentSettingCategoryToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<DeviceManagementIntentSettingCategory>(deviceManagementIntentSettingCategoryToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementIntentSettingCategoryRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementIntentSettingCategoryRequest Expand(Expression<Func<DeviceManagementIntentSettingCategory, object>> expandExpression)
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
        public IDeviceManagementIntentSettingCategoryRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementIntentSettingCategoryRequest Select(Expression<Func<DeviceManagementIntentSettingCategory, object>> selectExpression)
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
        /// <param name="deviceManagementIntentSettingCategoryToInitialize">The <see cref="DeviceManagementIntentSettingCategory"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceManagementIntentSettingCategory deviceManagementIntentSettingCategoryToInitialize)
        {

            if (deviceManagementIntentSettingCategoryToInitialize != null)
            {
                if (deviceManagementIntentSettingCategoryToInitialize.Settings != null && deviceManagementIntentSettingCategoryToInitialize.Settings.CurrentPage != null)
                {
                    deviceManagementIntentSettingCategoryToInitialize.Settings.InitializeNextPageRequest(this.Client, deviceManagementIntentSettingCategoryToInitialize.SettingsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    deviceManagementIntentSettingCategoryToInitialize.Settings.AdditionalData = deviceManagementIntentSettingCategoryToInitialize.AdditionalData;
                }

            }


        }
    }
}
