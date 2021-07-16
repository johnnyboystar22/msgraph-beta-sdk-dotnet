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
    /// The type MobileAppTroubleshootingEventRequest.
    /// </summary>
    public partial class MobileAppTroubleshootingEventRequest : BaseRequest, IMobileAppTroubleshootingEventRequest
    {
        /// <summary>
        /// Constructs a new MobileAppTroubleshootingEventRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MobileAppTroubleshootingEventRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified MobileAppTroubleshootingEvent using POST.
        /// </summary>
        /// <param name="mobileAppTroubleshootingEventToCreate">The MobileAppTroubleshootingEvent to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MobileAppTroubleshootingEvent.</returns>
        public async System.Threading.Tasks.Task<MobileAppTroubleshootingEvent> CreateAsync(MobileAppTroubleshootingEvent mobileAppTroubleshootingEventToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<MobileAppTroubleshootingEvent>(mobileAppTroubleshootingEventToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified MobileAppTroubleshootingEvent using POST and returns a <see cref="GraphResponse{MobileAppTroubleshootingEvent}"/> object.
        /// </summary>
        /// <param name="mobileAppTroubleshootingEventToCreate">The MobileAppTroubleshootingEvent to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MobileAppTroubleshootingEvent}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MobileAppTroubleshootingEvent>> CreateResponseAsync(MobileAppTroubleshootingEvent mobileAppTroubleshootingEventToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<MobileAppTroubleshootingEvent>(mobileAppTroubleshootingEventToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified MobileAppTroubleshootingEvent.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<MobileAppTroubleshootingEvent>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MobileAppTroubleshootingEvent and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified MobileAppTroubleshootingEvent.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MobileAppTroubleshootingEvent.</returns>
        public async System.Threading.Tasks.Task<MobileAppTroubleshootingEvent> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<MobileAppTroubleshootingEvent>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified MobileAppTroubleshootingEvent and returns a <see cref="GraphResponse{MobileAppTroubleshootingEvent}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MobileAppTroubleshootingEvent}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MobileAppTroubleshootingEvent>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<MobileAppTroubleshootingEvent>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified MobileAppTroubleshootingEvent using PATCH.
        /// </summary>
        /// <param name="mobileAppTroubleshootingEventToUpdate">The MobileAppTroubleshootingEvent to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MobileAppTroubleshootingEvent.</returns>
        public async System.Threading.Tasks.Task<MobileAppTroubleshootingEvent> UpdateAsync(MobileAppTroubleshootingEvent mobileAppTroubleshootingEventToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<MobileAppTroubleshootingEvent>(mobileAppTroubleshootingEventToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified MobileAppTroubleshootingEvent using PATCH and returns a <see cref="GraphResponse{MobileAppTroubleshootingEvent}"/> object.
        /// </summary>
        /// <param name="mobileAppTroubleshootingEventToUpdate">The MobileAppTroubleshootingEvent to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MobileAppTroubleshootingEvent}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MobileAppTroubleshootingEvent>> UpdateResponseAsync(MobileAppTroubleshootingEvent mobileAppTroubleshootingEventToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<MobileAppTroubleshootingEvent>(mobileAppTroubleshootingEventToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified MobileAppTroubleshootingEvent using PUT.
        /// </summary>
        /// <param name="mobileAppTroubleshootingEventToUpdate">The MobileAppTroubleshootingEvent object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<MobileAppTroubleshootingEvent> PutAsync(MobileAppTroubleshootingEvent mobileAppTroubleshootingEventToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<MobileAppTroubleshootingEvent>(mobileAppTroubleshootingEventToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified MobileAppTroubleshootingEvent using PUT and returns a <see cref="GraphResponse{MobileAppTroubleshootingEvent}"/> object.
        /// </summary>
        /// <param name="mobileAppTroubleshootingEventToUpdate">The MobileAppTroubleshootingEvent object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{MobileAppTroubleshootingEvent}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MobileAppTroubleshootingEvent>> PutResponseAsync(MobileAppTroubleshootingEvent mobileAppTroubleshootingEventToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<MobileAppTroubleshootingEvent>(mobileAppTroubleshootingEventToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMobileAppTroubleshootingEventRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMobileAppTroubleshootingEventRequest Expand(Expression<Func<MobileAppTroubleshootingEvent, object>> expandExpression)
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
        public IMobileAppTroubleshootingEventRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMobileAppTroubleshootingEventRequest Select(Expression<Func<MobileAppTroubleshootingEvent, object>> selectExpression)
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
        /// <param name="mobileAppTroubleshootingEventToInitialize">The <see cref="MobileAppTroubleshootingEvent"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(MobileAppTroubleshootingEvent mobileAppTroubleshootingEventToInitialize)
        {

            if (mobileAppTroubleshootingEventToInitialize != null)
            {
                if (mobileAppTroubleshootingEventToInitialize.AppLogCollectionRequests != null && mobileAppTroubleshootingEventToInitialize.AppLogCollectionRequests.CurrentPage != null)
                {
                    mobileAppTroubleshootingEventToInitialize.AppLogCollectionRequests.InitializeNextPageRequest(this.Client, mobileAppTroubleshootingEventToInitialize.AppLogCollectionRequestsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    mobileAppTroubleshootingEventToInitialize.AppLogCollectionRequests.AdditionalData = mobileAppTroubleshootingEventToInitialize.AdditionalData;
                }

            }


        }
    }
}
