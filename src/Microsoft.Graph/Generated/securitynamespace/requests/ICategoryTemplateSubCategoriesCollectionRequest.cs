// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ICategoryTemplateSubCategoriesCollectionRequest.
    /// </summary>
    public partial interface ICategoryTemplateSubCategoriesCollectionRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Adds the specified SubCategoryTemplate to the collection via POST.
        /// </summary>
        /// <param name="subCategoryTemplate">The SubCategoryTemplate to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SubCategoryTemplate.</returns>
        System.Threading.Tasks.Task<SubCategoryTemplate> AddAsync(SubCategoryTemplate subCategoryTemplate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified SubCategoryTemplate to the collection via POST and returns a <see cref="GraphResponse{SubCategoryTemplate}"/> object of the request.
        /// </summary>
        /// <param name="subCategoryTemplate">The SubCategoryTemplate to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SubCategoryTemplate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SubCategoryTemplate>> AddResponseAsync(SubCategoryTemplate subCategoryTemplate, CancellationToken cancellationToken = default);


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<ICategoryTemplateSubCategoriesCollectionPage> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{CategoryTemplateSubCategoriesCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CategoryTemplateSubCategoriesCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<CategoryTemplateSubCategoriesCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICategoryTemplateSubCategoriesCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICategoryTemplateSubCategoriesCollectionRequest Expand(Expression<Func<SubCategoryTemplate, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICategoryTemplateSubCategoriesCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICategoryTemplateSubCategoriesCollectionRequest Select(Expression<Func<SubCategoryTemplate, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        ICategoryTemplateSubCategoriesCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        ICategoryTemplateSubCategoriesCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        ICategoryTemplateSubCategoriesCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        ICategoryTemplateSubCategoriesCollectionRequest OrderBy(string value);
    }
}
