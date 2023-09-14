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
    /// The interface ITrainingRequest.
    /// </summary>
    public partial interface ITrainingRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Training using POST.
        /// </summary>
        /// <param name="trainingToCreate">The Training to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Training.</returns>
        System.Threading.Tasks.Task<Training> CreateAsync(Training trainingToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified Training using POST and returns a <see cref="GraphResponse{Training}"/> object.
        /// </summary>
        /// <param name="trainingToCreate">The Training to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Training}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Training>> CreateResponseAsync(Training trainingToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Training.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Training and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Training.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Training.</returns>
        System.Threading.Tasks.Task<Training> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Training and returns a <see cref="GraphResponse{Training}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Training}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Training>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Training using PATCH.
        /// </summary>
        /// <param name="trainingToUpdate">The Training to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Training.</returns>
        System.Threading.Tasks.Task<Training> UpdateAsync(Training trainingToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Training using PATCH and returns a <see cref="GraphResponse{Training}"/> object.
        /// </summary>
        /// <param name="trainingToUpdate">The Training to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Training}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Training>> UpdateResponseAsync(Training trainingToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Training using PUT.
        /// </summary>
        /// <param name="trainingToUpdate">The Training object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<Training> PutAsync(Training trainingToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Training using PUT and returns a <see cref="GraphResponse{Training}"/> object.
        /// </summary>
        /// <param name="trainingToUpdate">The Training object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{Training}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<Training>> PutResponseAsync(Training trainingToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITrainingRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITrainingRequest Expand(Expression<Func<Training, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITrainingRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITrainingRequest Select(Expression<Func<Training, object>> selectExpression);

    }
}
