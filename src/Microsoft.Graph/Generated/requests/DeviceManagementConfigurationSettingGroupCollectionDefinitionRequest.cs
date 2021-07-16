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
    /// The type DeviceManagementConfigurationSettingGroupCollectionDefinitionRequest.
    /// </summary>
    public partial class DeviceManagementConfigurationSettingGroupCollectionDefinitionRequest : BaseRequest, IDeviceManagementConfigurationSettingGroupCollectionDefinitionRequest
    {
        /// <summary>
        /// Constructs a new DeviceManagementConfigurationSettingGroupCollectionDefinitionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceManagementConfigurationSettingGroupCollectionDefinitionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceManagementConfigurationSettingGroupCollectionDefinition using POST.
        /// </summary>
        /// <param name="deviceManagementConfigurationSettingGroupCollectionDefinitionToCreate">The DeviceManagementConfigurationSettingGroupCollectionDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementConfigurationSettingGroupCollectionDefinition.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementConfigurationSettingGroupCollectionDefinition> CreateAsync(DeviceManagementConfigurationSettingGroupCollectionDefinition deviceManagementConfigurationSettingGroupCollectionDefinitionToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<DeviceManagementConfigurationSettingGroupCollectionDefinition>(deviceManagementConfigurationSettingGroupCollectionDefinitionToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DeviceManagementConfigurationSettingGroupCollectionDefinition using POST and returns a <see cref="GraphResponse{DeviceManagementConfigurationSettingGroupCollectionDefinition}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationSettingGroupCollectionDefinitionToCreate">The DeviceManagementConfigurationSettingGroupCollectionDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationSettingGroupCollectionDefinition}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationSettingGroupCollectionDefinition>> CreateResponseAsync(DeviceManagementConfigurationSettingGroupCollectionDefinition deviceManagementConfigurationSettingGroupCollectionDefinitionToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<DeviceManagementConfigurationSettingGroupCollectionDefinition>(deviceManagementConfigurationSettingGroupCollectionDefinitionToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementConfigurationSettingGroupCollectionDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<DeviceManagementConfigurationSettingGroupCollectionDefinition>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementConfigurationSettingGroupCollectionDefinition and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified DeviceManagementConfigurationSettingGroupCollectionDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementConfigurationSettingGroupCollectionDefinition.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementConfigurationSettingGroupCollectionDefinition> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<DeviceManagementConfigurationSettingGroupCollectionDefinition>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DeviceManagementConfigurationSettingGroupCollectionDefinition and returns a <see cref="GraphResponse{DeviceManagementConfigurationSettingGroupCollectionDefinition}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationSettingGroupCollectionDefinition}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationSettingGroupCollectionDefinition>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<DeviceManagementConfigurationSettingGroupCollectionDefinition>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationSettingGroupCollectionDefinition using PATCH.
        /// </summary>
        /// <param name="deviceManagementConfigurationSettingGroupCollectionDefinitionToUpdate">The DeviceManagementConfigurationSettingGroupCollectionDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementConfigurationSettingGroupCollectionDefinition.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementConfigurationSettingGroupCollectionDefinition> UpdateAsync(DeviceManagementConfigurationSettingGroupCollectionDefinition deviceManagementConfigurationSettingGroupCollectionDefinitionToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<DeviceManagementConfigurationSettingGroupCollectionDefinition>(deviceManagementConfigurationSettingGroupCollectionDefinitionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationSettingGroupCollectionDefinition using PATCH and returns a <see cref="GraphResponse{DeviceManagementConfigurationSettingGroupCollectionDefinition}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationSettingGroupCollectionDefinitionToUpdate">The DeviceManagementConfigurationSettingGroupCollectionDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationSettingGroupCollectionDefinition}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationSettingGroupCollectionDefinition>> UpdateResponseAsync(DeviceManagementConfigurationSettingGroupCollectionDefinition deviceManagementConfigurationSettingGroupCollectionDefinitionToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<DeviceManagementConfigurationSettingGroupCollectionDefinition>(deviceManagementConfigurationSettingGroupCollectionDefinitionToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationSettingGroupCollectionDefinition using PUT.
        /// </summary>
        /// <param name="deviceManagementConfigurationSettingGroupCollectionDefinitionToUpdate">The DeviceManagementConfigurationSettingGroupCollectionDefinition object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementConfigurationSettingGroupCollectionDefinition> PutAsync(DeviceManagementConfigurationSettingGroupCollectionDefinition deviceManagementConfigurationSettingGroupCollectionDefinitionToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<DeviceManagementConfigurationSettingGroupCollectionDefinition>(deviceManagementConfigurationSettingGroupCollectionDefinitionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationSettingGroupCollectionDefinition using PUT and returns a <see cref="GraphResponse{DeviceManagementConfigurationSettingGroupCollectionDefinition}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationSettingGroupCollectionDefinitionToUpdate">The DeviceManagementConfigurationSettingGroupCollectionDefinition object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{DeviceManagementConfigurationSettingGroupCollectionDefinition}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationSettingGroupCollectionDefinition>> PutResponseAsync(DeviceManagementConfigurationSettingGroupCollectionDefinition deviceManagementConfigurationSettingGroupCollectionDefinitionToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<DeviceManagementConfigurationSettingGroupCollectionDefinition>(deviceManagementConfigurationSettingGroupCollectionDefinitionToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementConfigurationSettingGroupCollectionDefinitionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementConfigurationSettingGroupCollectionDefinitionRequest Expand(Expression<Func<DeviceManagementConfigurationSettingGroupCollectionDefinition, object>> expandExpression)
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
        public IDeviceManagementConfigurationSettingGroupCollectionDefinitionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementConfigurationSettingGroupCollectionDefinitionRequest Select(Expression<Func<DeviceManagementConfigurationSettingGroupCollectionDefinition, object>> selectExpression)
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
        /// <param name="deviceManagementConfigurationSettingGroupCollectionDefinitionToInitialize">The <see cref="DeviceManagementConfigurationSettingGroupCollectionDefinition"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceManagementConfigurationSettingGroupCollectionDefinition deviceManagementConfigurationSettingGroupCollectionDefinitionToInitialize)
        {

        }
    }
}
