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
    /// The interface IExactMatchJobBaseRequest.
    /// </summary>
    public partial interface IExactMatchJobBaseRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ExactMatchJobBase using POST.
        /// </summary>
        /// <param name="exactMatchJobBaseToCreate">The ExactMatchJobBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ExactMatchJobBase.</returns>
        System.Threading.Tasks.Task<ExactMatchJobBase> CreateAsync(ExactMatchJobBase exactMatchJobBaseToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified ExactMatchJobBase using POST and returns a <see cref="GraphResponse{ExactMatchJobBase}"/> object.
        /// </summary>
        /// <param name="exactMatchJobBaseToCreate">The ExactMatchJobBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ExactMatchJobBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ExactMatchJobBase>> CreateResponseAsync(ExactMatchJobBase exactMatchJobBaseToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ExactMatchJobBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ExactMatchJobBase and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ExactMatchJobBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ExactMatchJobBase.</returns>
        System.Threading.Tasks.Task<ExactMatchJobBase> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ExactMatchJobBase and returns a <see cref="GraphResponse{ExactMatchJobBase}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ExactMatchJobBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ExactMatchJobBase>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ExactMatchJobBase using PATCH.
        /// </summary>
        /// <param name="exactMatchJobBaseToUpdate">The ExactMatchJobBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ExactMatchJobBase.</returns>
        System.Threading.Tasks.Task<ExactMatchJobBase> UpdateAsync(ExactMatchJobBase exactMatchJobBaseToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ExactMatchJobBase using PATCH and returns a <see cref="GraphResponse{ExactMatchJobBase}"/> object.
        /// </summary>
        /// <param name="exactMatchJobBaseToUpdate">The ExactMatchJobBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ExactMatchJobBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ExactMatchJobBase>> UpdateResponseAsync(ExactMatchJobBase exactMatchJobBaseToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ExactMatchJobBase using PUT.
        /// </summary>
        /// <param name="exactMatchJobBaseToUpdate">The ExactMatchJobBase object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ExactMatchJobBase> PutAsync(ExactMatchJobBase exactMatchJobBaseToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ExactMatchJobBase using PUT and returns a <see cref="GraphResponse{ExactMatchJobBase}"/> object.
        /// </summary>
        /// <param name="exactMatchJobBaseToUpdate">The ExactMatchJobBase object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ExactMatchJobBase}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ExactMatchJobBase>> PutResponseAsync(ExactMatchJobBase exactMatchJobBaseToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IExactMatchJobBaseRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IExactMatchJobBaseRequest Expand(Expression<Func<ExactMatchJobBase, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IExactMatchJobBaseRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IExactMatchJobBaseRequest Select(Expression<Func<ExactMatchJobBase, object>> selectExpression);

    }
}
