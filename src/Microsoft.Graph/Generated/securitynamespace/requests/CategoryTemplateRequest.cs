// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type CategoryTemplateRequest.
    /// </summary>
    public partial class CategoryTemplateRequest : Microsoft.Graph.BaseRequest, ICategoryTemplateRequest
    {
        /// <summary>
        /// Constructs a new CategoryTemplateRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public CategoryTemplateRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified CategoryTemplate using POST.
        /// </summary>
        /// <param name="categoryTemplateToCreate">The CategoryTemplate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CategoryTemplate.</returns>
        public async System.Threading.Tasks.Task<CategoryTemplate> CreateAsync(CategoryTemplate categoryTemplateToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<CategoryTemplate>(categoryTemplateToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified CategoryTemplate using POST and returns a <see cref="GraphResponse{CategoryTemplate}"/> object.
        /// </summary>
        /// <param name="categoryTemplateToCreate">The CategoryTemplate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CategoryTemplate}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CategoryTemplate>> CreateResponseAsync(CategoryTemplate categoryTemplateToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<CategoryTemplate>(categoryTemplateToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified CategoryTemplate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<CategoryTemplate>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified CategoryTemplate and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified CategoryTemplate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CategoryTemplate.</returns>
        public async System.Threading.Tasks.Task<CategoryTemplate> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<CategoryTemplate>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified CategoryTemplate and returns a <see cref="GraphResponse{CategoryTemplate}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CategoryTemplate}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CategoryTemplate>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<CategoryTemplate>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified CategoryTemplate using PATCH.
        /// </summary>
        /// <param name="categoryTemplateToUpdate">The CategoryTemplate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CategoryTemplate.</returns>
        public async System.Threading.Tasks.Task<CategoryTemplate> UpdateAsync(CategoryTemplate categoryTemplateToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<CategoryTemplate>(categoryTemplateToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified CategoryTemplate using PATCH and returns a <see cref="GraphResponse{CategoryTemplate}"/> object.
        /// </summary>
        /// <param name="categoryTemplateToUpdate">The CategoryTemplate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{CategoryTemplate}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CategoryTemplate>> UpdateResponseAsync(CategoryTemplate categoryTemplateToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<CategoryTemplate>(categoryTemplateToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified CategoryTemplate using PUT.
        /// </summary>
        /// <param name="categoryTemplateToUpdate">The CategoryTemplate object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<CategoryTemplate> PutAsync(CategoryTemplate categoryTemplateToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<CategoryTemplate>(categoryTemplateToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified CategoryTemplate using PUT and returns a <see cref="GraphResponse{CategoryTemplate}"/> object.
        /// </summary>
        /// <param name="categoryTemplateToUpdate">The CategoryTemplate object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{CategoryTemplate}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CategoryTemplate>> PutResponseAsync(CategoryTemplate categoryTemplateToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<CategoryTemplate>(categoryTemplateToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICategoryTemplateRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICategoryTemplateRequest Expand(Expression<Func<CategoryTemplate, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public ICategoryTemplateRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ICategoryTemplateRequest Select(Expression<Func<CategoryTemplate, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="categoryTemplateToInitialize">The <see cref="CategoryTemplate"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(CategoryTemplate categoryTemplateToInitialize)
        {

            if (categoryTemplateToInitialize != null)
            {
                if (categoryTemplateToInitialize.SubCategories != null && categoryTemplateToInitialize.SubCategories.CurrentPage != null)
                {
                    categoryTemplateToInitialize.SubCategories.InitializeNextPageRequest(this.Client, categoryTemplateToInitialize.SubCategoriesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    categoryTemplateToInitialize.SubCategories.AdditionalData = categoryTemplateToInitialize.AdditionalData;
                }

            }


        }
    }
}
