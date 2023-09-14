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
    /// The type EducationClassRequest.
    /// </summary>
    public partial class EducationClassRequest : BaseRequest, IEducationClassRequest
    {
        /// <summary>
        /// Constructs a new EducationClassRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public EducationClassRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified EducationClass using POST.
        /// </summary>
        /// <param name="educationClassToCreate">The EducationClass to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EducationClass.</returns>
        public async System.Threading.Tasks.Task<EducationClass> CreateAsync(EducationClass educationClassToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<EducationClass>(educationClassToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified EducationClass using POST and returns a <see cref="GraphResponse{EducationClass}"/> object.
        /// </summary>
        /// <param name="educationClassToCreate">The EducationClass to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationClass}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EducationClass>> CreateResponseAsync(EducationClass educationClassToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<EducationClass>(educationClassToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified EducationClass.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<EducationClass>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified EducationClass and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified EducationClass.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EducationClass.</returns>
        public async System.Threading.Tasks.Task<EducationClass> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<EducationClass>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified EducationClass and returns a <see cref="GraphResponse{EducationClass}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationClass}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EducationClass>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<EducationClass>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified EducationClass using PATCH.
        /// </summary>
        /// <param name="educationClassToUpdate">The EducationClass to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EducationClass.</returns>
        public async System.Threading.Tasks.Task<EducationClass> UpdateAsync(EducationClass educationClassToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<EducationClass>(educationClassToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified EducationClass using PATCH and returns a <see cref="GraphResponse{EducationClass}"/> object.
        /// </summary>
        /// <param name="educationClassToUpdate">The EducationClass to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EducationClass}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EducationClass>> UpdateResponseAsync(EducationClass educationClassToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<EducationClass>(educationClassToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified EducationClass using PUT.
        /// </summary>
        /// <param name="educationClassToUpdate">The EducationClass object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<EducationClass> PutAsync(EducationClass educationClassToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<EducationClass>(educationClassToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified EducationClass using PUT and returns a <see cref="GraphResponse{EducationClass}"/> object.
        /// </summary>
        /// <param name="educationClassToUpdate">The EducationClass object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{EducationClass}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EducationClass>> PutResponseAsync(EducationClass educationClassToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<EducationClass>(educationClassToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEducationClassRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEducationClassRequest Expand(Expression<Func<EducationClass, object>> expandExpression)
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
        public IEducationClassRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IEducationClassRequest Select(Expression<Func<EducationClass, object>> selectExpression)
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
        /// <param name="educationClassToInitialize">The <see cref="EducationClass"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(EducationClass educationClassToInitialize)
        {

            if (educationClassToInitialize != null)
            {
                if (educationClassToInitialize.AssignmentCategories != null && educationClassToInitialize.AssignmentCategories.CurrentPage != null)
                {
                    educationClassToInitialize.AssignmentCategories.InitializeNextPageRequest(this.Client, educationClassToInitialize.AssignmentCategoriesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    educationClassToInitialize.AssignmentCategories.AdditionalData = educationClassToInitialize.AdditionalData;
                }
                if (educationClassToInitialize.Assignments != null && educationClassToInitialize.Assignments.CurrentPage != null)
                {
                    educationClassToInitialize.Assignments.InitializeNextPageRequest(this.Client, educationClassToInitialize.AssignmentsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    educationClassToInitialize.Assignments.AdditionalData = educationClassToInitialize.AdditionalData;
                }
                if (educationClassToInitialize.Modules != null && educationClassToInitialize.Modules.CurrentPage != null)
                {
                    educationClassToInitialize.Modules.InitializeNextPageRequest(this.Client, educationClassToInitialize.ModulesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    educationClassToInitialize.Modules.AdditionalData = educationClassToInitialize.AdditionalData;
                }
                if (educationClassToInitialize.Members != null && educationClassToInitialize.Members.CurrentPage != null)
                {
                    educationClassToInitialize.Members.InitializeNextPageRequest(this.Client, educationClassToInitialize.MembersNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    educationClassToInitialize.Members.AdditionalData = educationClassToInitialize.AdditionalData;
                }
                if (educationClassToInitialize.Schools != null && educationClassToInitialize.Schools.CurrentPage != null)
                {
                    educationClassToInitialize.Schools.InitializeNextPageRequest(this.Client, educationClassToInitialize.SchoolsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    educationClassToInitialize.Schools.AdditionalData = educationClassToInitialize.AdditionalData;
                }
                if (educationClassToInitialize.Teachers != null && educationClassToInitialize.Teachers.CurrentPage != null)
                {
                    educationClassToInitialize.Teachers.InitializeNextPageRequest(this.Client, educationClassToInitialize.TeachersNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    educationClassToInitialize.Teachers.AdditionalData = educationClassToInitialize.AdditionalData;
                }

            }


        }
    }
}
