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
    /// The interface INoteRequest.
    /// </summary>
    public partial interface INoteRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Note using POST.
        /// </summary>
        /// <param name="noteToCreate">The Note to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Note.</returns>
        System.Threading.Tasks.Task<Note> CreateAsync(Note noteToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified Note using POST and returns a <see cref="GraphResponse{Note}"/> object.
        /// </summary>
        /// <param name="noteToCreate">The Note to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Note}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Note>> CreateResponseAsync(Note noteToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Note.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Note and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Note.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Note.</returns>
        System.Threading.Tasks.Task<Note> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Note and returns a <see cref="GraphResponse{Note}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Note}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Note>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Note using PATCH.
        /// </summary>
        /// <param name="noteToUpdate">The Note to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Note.</returns>
        System.Threading.Tasks.Task<Note> UpdateAsync(Note noteToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Note using PATCH and returns a <see cref="GraphResponse{Note}"/> object.
        /// </summary>
        /// <param name="noteToUpdate">The Note to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Note}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Note>> UpdateResponseAsync(Note noteToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Note using PUT.
        /// </summary>
        /// <param name="noteToUpdate">The Note object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<Note> PutAsync(Note noteToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Note using PUT and returns a <see cref="GraphResponse{Note}"/> object.
        /// </summary>
        /// <param name="noteToUpdate">The Note object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{Note}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<Note>> PutResponseAsync(Note noteToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        INoteRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        INoteRequest Expand(Expression<Func<Note, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        INoteRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        INoteRequest Select(Expression<Func<Note, object>> selectExpression);

    }
}
