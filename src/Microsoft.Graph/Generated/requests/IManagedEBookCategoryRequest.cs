// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IManagedEBookCategoryRequest.
    /// </summary>
    public partial interface IManagedEBookCategoryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ManagedEBookCategory using POST.
        /// </summary>
        /// <param name="managedEBookCategoryToCreate">The ManagedEBookCategory to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedEBookCategory.</returns>
        System.Threading.Tasks.Task<ManagedEBookCategory> CreateAsync(ManagedEBookCategory managedEBookCategoryToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified ManagedEBookCategory using POST and returns a <see cref="GraphResponse{ManagedEBookCategory}"/> object.
        /// </summary>
        /// <param name="managedEBookCategoryToCreate">The ManagedEBookCategory to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedEBookCategory}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedEBookCategory>> CreateResponseAsync(ManagedEBookCategory managedEBookCategoryToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ManagedEBookCategory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ManagedEBookCategory and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ManagedEBookCategory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedEBookCategory.</returns>
        System.Threading.Tasks.Task<ManagedEBookCategory> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ManagedEBookCategory and returns a <see cref="GraphResponse{ManagedEBookCategory}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedEBookCategory}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedEBookCategory>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedEBookCategory using PATCH.
        /// </summary>
        /// <param name="managedEBookCategoryToUpdate">The ManagedEBookCategory to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedEBookCategory.</returns>
        System.Threading.Tasks.Task<ManagedEBookCategory> UpdateAsync(ManagedEBookCategory managedEBookCategoryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedEBookCategory using PATCH and returns a <see cref="GraphResponse{ManagedEBookCategory}"/> object.
        /// </summary>
        /// <param name="managedEBookCategoryToUpdate">The ManagedEBookCategory to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ManagedEBookCategory}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedEBookCategory>> UpdateResponseAsync(ManagedEBookCategory managedEBookCategoryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedEBookCategory using PUT.
        /// </summary>
        /// <param name="managedEBookCategoryToUpdate">The ManagedEBookCategory object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ManagedEBookCategory> PutAsync(ManagedEBookCategory managedEBookCategoryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedEBookCategory using PUT and returns a <see cref="GraphResponse{ManagedEBookCategory}"/> object.
        /// </summary>
        /// <param name="managedEBookCategoryToUpdate">The ManagedEBookCategory object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ManagedEBookCategory}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedEBookCategory>> PutResponseAsync(ManagedEBookCategory managedEBookCategoryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedEBookCategoryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedEBookCategoryRequest Expand(Expression<Func<ManagedEBookCategory, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedEBookCategoryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedEBookCategoryRequest Select(Expression<Func<ManagedEBookCategory, object>> selectExpression);

    }
}
