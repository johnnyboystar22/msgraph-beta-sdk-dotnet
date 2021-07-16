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
    /// The type NoteRequest.
    /// </summary>
    public partial class NoteRequest : BaseRequest, INoteRequest
    {
        /// <summary>
        /// Constructs a new NoteRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public NoteRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Note using POST.
        /// </summary>
        /// <param name="noteToCreate">The Note to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Note.</returns>
        public async System.Threading.Tasks.Task<Note> CreateAsync(Note noteToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<Note>(noteToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Note using POST and returns a <see cref="GraphResponse{Note}"/> object.
        /// </summary>
        /// <param name="noteToCreate">The Note to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Note}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Note>> CreateResponseAsync(Note noteToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<Note>(noteToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified Note.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<Note>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Note and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified Note.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Note.</returns>
        public async System.Threading.Tasks.Task<Note> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<Note>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Note and returns a <see cref="GraphResponse{Note}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Note}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Note>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<Note>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Note using PATCH.
        /// </summary>
        /// <param name="noteToUpdate">The Note to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Note.</returns>
        public async System.Threading.Tasks.Task<Note> UpdateAsync(Note noteToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<Note>(noteToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Note using PATCH and returns a <see cref="GraphResponse{Note}"/> object.
        /// </summary>
        /// <param name="noteToUpdate">The Note to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Note}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Note>> UpdateResponseAsync(Note noteToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<Note>(noteToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Note using PUT.
        /// </summary>
        /// <param name="noteToUpdate">The Note object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<Note> PutAsync(Note noteToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<Note>(noteToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Note using PUT and returns a <see cref="GraphResponse{Note}"/> object.
        /// </summary>
        /// <param name="noteToUpdate">The Note object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{Note}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Note>> PutResponseAsync(Note noteToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<Note>(noteToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public INoteRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public INoteRequest Expand(Expression<Func<Note, object>> expandExpression)
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
        public INoteRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public INoteRequest Select(Expression<Func<Note, object>> selectExpression)
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
        /// <param name="noteToInitialize">The <see cref="Note"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Note noteToInitialize)
        {

            if (noteToInitialize != null)
            {
                if (noteToInitialize.Attachments != null && noteToInitialize.Attachments.CurrentPage != null)
                {
                    noteToInitialize.Attachments.InitializeNextPageRequest(this.Client, noteToInitialize.AttachmentsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    noteToInitialize.Attachments.AdditionalData = noteToInitialize.AdditionalData;
                }
                if (noteToInitialize.Extensions != null && noteToInitialize.Extensions.CurrentPage != null)
                {
                    noteToInitialize.Extensions.InitializeNextPageRequest(this.Client, noteToInitialize.ExtensionsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    noteToInitialize.Extensions.AdditionalData = noteToInitialize.AdditionalData;
                }
                if (noteToInitialize.MultiValueExtendedProperties != null && noteToInitialize.MultiValueExtendedProperties.CurrentPage != null)
                {
                    noteToInitialize.MultiValueExtendedProperties.InitializeNextPageRequest(this.Client, noteToInitialize.MultiValueExtendedPropertiesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    noteToInitialize.MultiValueExtendedProperties.AdditionalData = noteToInitialize.AdditionalData;
                }
                if (noteToInitialize.SingleValueExtendedProperties != null && noteToInitialize.SingleValueExtendedProperties.CurrentPage != null)
                {
                    noteToInitialize.SingleValueExtendedProperties.InitializeNextPageRequest(this.Client, noteToInitialize.SingleValueExtendedPropertiesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    noteToInitialize.SingleValueExtendedProperties.AdditionalData = noteToInitialize.AdditionalData;
                }

            }


        }
    }
}
