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
    /// The type CloudPcUserSettingRequest.
    /// </summary>
    public partial class CloudPcUserSettingRequest : BaseRequest, ICloudPcUserSettingRequest
    {
        /// <summary>
        /// Constructs a new CloudPcUserSettingRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public CloudPcUserSettingRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified CloudPcUserSetting using POST.
        /// </summary>
        /// <param name="cloudPcUserSettingToCreate">The CloudPcUserSetting to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CloudPcUserSetting.</returns>
        public async System.Threading.Tasks.Task<CloudPcUserSetting> CreateAsync(CloudPcUserSetting cloudPcUserSettingToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<CloudPcUserSetting>(cloudPcUserSettingToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified CloudPcUserSetting using POST and returns a <see cref="GraphResponse{CloudPcUserSetting}"/> object.
        /// </summary>
        /// <param name="cloudPcUserSettingToCreate">The CloudPcUserSetting to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CloudPcUserSetting}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CloudPcUserSetting>> CreateResponseAsync(CloudPcUserSetting cloudPcUserSettingToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<CloudPcUserSetting>(cloudPcUserSettingToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified CloudPcUserSetting.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<CloudPcUserSetting>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified CloudPcUserSetting and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified CloudPcUserSetting.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CloudPcUserSetting.</returns>
        public async System.Threading.Tasks.Task<CloudPcUserSetting> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<CloudPcUserSetting>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified CloudPcUserSetting and returns a <see cref="GraphResponse{CloudPcUserSetting}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CloudPcUserSetting}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CloudPcUserSetting>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<CloudPcUserSetting>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified CloudPcUserSetting using PATCH.
        /// </summary>
        /// <param name="cloudPcUserSettingToUpdate">The CloudPcUserSetting to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CloudPcUserSetting.</returns>
        public async System.Threading.Tasks.Task<CloudPcUserSetting> UpdateAsync(CloudPcUserSetting cloudPcUserSettingToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<CloudPcUserSetting>(cloudPcUserSettingToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified CloudPcUserSetting using PATCH and returns a <see cref="GraphResponse{CloudPcUserSetting}"/> object.
        /// </summary>
        /// <param name="cloudPcUserSettingToUpdate">The CloudPcUserSetting to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{CloudPcUserSetting}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CloudPcUserSetting>> UpdateResponseAsync(CloudPcUserSetting cloudPcUserSettingToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<CloudPcUserSetting>(cloudPcUserSettingToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified CloudPcUserSetting using PUT.
        /// </summary>
        /// <param name="cloudPcUserSettingToUpdate">The CloudPcUserSetting object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<CloudPcUserSetting> PutAsync(CloudPcUserSetting cloudPcUserSettingToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<CloudPcUserSetting>(cloudPcUserSettingToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified CloudPcUserSetting using PUT and returns a <see cref="GraphResponse{CloudPcUserSetting}"/> object.
        /// </summary>
        /// <param name="cloudPcUserSettingToUpdate">The CloudPcUserSetting object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{CloudPcUserSetting}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CloudPcUserSetting>> PutResponseAsync(CloudPcUserSetting cloudPcUserSettingToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<CloudPcUserSetting>(cloudPcUserSettingToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICloudPcUserSettingRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICloudPcUserSettingRequest Expand(Expression<Func<CloudPcUserSetting, object>> expandExpression)
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
        public ICloudPcUserSettingRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ICloudPcUserSettingRequest Select(Expression<Func<CloudPcUserSetting, object>> selectExpression)
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
        /// <param name="cloudPcUserSettingToInitialize">The <see cref="CloudPcUserSetting"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(CloudPcUserSetting cloudPcUserSettingToInitialize)
        {

            if (cloudPcUserSettingToInitialize != null)
            {
                if (cloudPcUserSettingToInitialize.Assignments != null && cloudPcUserSettingToInitialize.Assignments.CurrentPage != null)
                {
                    cloudPcUserSettingToInitialize.Assignments.InitializeNextPageRequest(this.Client, cloudPcUserSettingToInitialize.AssignmentsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    cloudPcUserSettingToInitialize.Assignments.AdditionalData = cloudPcUserSettingToInitialize.AdditionalData;
                }

            }


        }
    }
}
