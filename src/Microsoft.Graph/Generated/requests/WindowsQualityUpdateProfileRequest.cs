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
    /// The type WindowsQualityUpdateProfileRequest.
    /// </summary>
    public partial class WindowsQualityUpdateProfileRequest : BaseRequest, IWindowsQualityUpdateProfileRequest
    {
        /// <summary>
        /// Constructs a new WindowsQualityUpdateProfileRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WindowsQualityUpdateProfileRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WindowsQualityUpdateProfile using POST.
        /// </summary>
        /// <param name="windowsQualityUpdateProfileToCreate">The WindowsQualityUpdateProfile to create.</param>
        /// <returns>The created WindowsQualityUpdateProfile.</returns>
        public System.Threading.Tasks.Task<WindowsQualityUpdateProfile> CreateAsync(WindowsQualityUpdateProfile windowsQualityUpdateProfileToCreate)
        {
            return this.CreateAsync(windowsQualityUpdateProfileToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WindowsQualityUpdateProfile using POST.
        /// </summary>
        /// <param name="windowsQualityUpdateProfileToCreate">The WindowsQualityUpdateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsQualityUpdateProfile.</returns>
        public async System.Threading.Tasks.Task<WindowsQualityUpdateProfile> CreateAsync(WindowsQualityUpdateProfile windowsQualityUpdateProfileToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<WindowsQualityUpdateProfile>(windowsQualityUpdateProfileToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified WindowsQualityUpdateProfile.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WindowsQualityUpdateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<WindowsQualityUpdateProfile>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified WindowsQualityUpdateProfile.
        /// </summary>
        /// <returns>The WindowsQualityUpdateProfile.</returns>
        public System.Threading.Tasks.Task<WindowsQualityUpdateProfile> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WindowsQualityUpdateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsQualityUpdateProfile.</returns>
        public async System.Threading.Tasks.Task<WindowsQualityUpdateProfile> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WindowsQualityUpdateProfile>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified WindowsQualityUpdateProfile using PATCH.
        /// </summary>
        /// <param name="windowsQualityUpdateProfileToUpdate">The WindowsQualityUpdateProfile to update.</param>
        /// <returns>The updated WindowsQualityUpdateProfile.</returns>
        public System.Threading.Tasks.Task<WindowsQualityUpdateProfile> UpdateAsync(WindowsQualityUpdateProfile windowsQualityUpdateProfileToUpdate)
        {
            return this.UpdateAsync(windowsQualityUpdateProfileToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WindowsQualityUpdateProfile using PATCH.
        /// </summary>
        /// <param name="windowsQualityUpdateProfileToUpdate">The WindowsQualityUpdateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsQualityUpdateProfile.</returns>
        public async System.Threading.Tasks.Task<WindowsQualityUpdateProfile> UpdateAsync(WindowsQualityUpdateProfile windowsQualityUpdateProfileToUpdate, CancellationToken cancellationToken)
        {
			if (windowsQualityUpdateProfileToUpdate.AdditionalData != null)
			{
				if (windowsQualityUpdateProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					windowsQualityUpdateProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, windowsQualityUpdateProfileToUpdate.GetType().Name)
						});
				}
			}
            if (windowsQualityUpdateProfileToUpdate.AdditionalData != null)
            {
                if (windowsQualityUpdateProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    windowsQualityUpdateProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, windowsQualityUpdateProfileToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WindowsQualityUpdateProfile>(windowsQualityUpdateProfileToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsQualityUpdateProfileRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsQualityUpdateProfileRequest Expand(Expression<Func<WindowsQualityUpdateProfile, object>> expandExpression)
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
        public IWindowsQualityUpdateProfileRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsQualityUpdateProfileRequest Select(Expression<Func<WindowsQualityUpdateProfile, object>> selectExpression)
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
        /// <param name="windowsQualityUpdateProfileToInitialize">The <see cref="WindowsQualityUpdateProfile"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WindowsQualityUpdateProfile windowsQualityUpdateProfileToInitialize)
        {

            if (windowsQualityUpdateProfileToInitialize != null && windowsQualityUpdateProfileToInitialize.AdditionalData != null)
            {

                if (windowsQualityUpdateProfileToInitialize.Assignments != null && windowsQualityUpdateProfileToInitialize.Assignments.CurrentPage != null)
                {
                    windowsQualityUpdateProfileToInitialize.Assignments.AdditionalData = windowsQualityUpdateProfileToInitialize.AdditionalData;

                    object nextPageLink;
                    windowsQualityUpdateProfileToInitialize.AdditionalData.TryGetValue("assignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        windowsQualityUpdateProfileToInitialize.Assignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
