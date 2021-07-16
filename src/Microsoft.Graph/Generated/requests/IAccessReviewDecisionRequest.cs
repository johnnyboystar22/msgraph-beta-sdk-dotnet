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
    /// The interface IAccessReviewDecisionRequest.
    /// </summary>
    public partial interface IAccessReviewDecisionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AccessReviewDecision using POST.
        /// </summary>
        /// <param name="accessReviewDecisionToCreate">The AccessReviewDecision to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AccessReviewDecision.</returns>
        System.Threading.Tasks.Task<AccessReviewDecision> CreateAsync(AccessReviewDecision accessReviewDecisionToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified AccessReviewDecision using POST and returns a <see cref="GraphResponse{AccessReviewDecision}"/> object.
        /// </summary>
        /// <param name="accessReviewDecisionToCreate">The AccessReviewDecision to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessReviewDecision}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessReviewDecision>> CreateResponseAsync(AccessReviewDecision accessReviewDecisionToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AccessReviewDecision.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AccessReviewDecision and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AccessReviewDecision.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AccessReviewDecision.</returns>
        System.Threading.Tasks.Task<AccessReviewDecision> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AccessReviewDecision and returns a <see cref="GraphResponse{AccessReviewDecision}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessReviewDecision}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessReviewDecision>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AccessReviewDecision using PATCH.
        /// </summary>
        /// <param name="accessReviewDecisionToUpdate">The AccessReviewDecision to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AccessReviewDecision.</returns>
        System.Threading.Tasks.Task<AccessReviewDecision> UpdateAsync(AccessReviewDecision accessReviewDecisionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AccessReviewDecision using PATCH and returns a <see cref="GraphResponse{AccessReviewDecision}"/> object.
        /// </summary>
        /// <param name="accessReviewDecisionToUpdate">The AccessReviewDecision to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AccessReviewDecision}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessReviewDecision>> UpdateResponseAsync(AccessReviewDecision accessReviewDecisionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AccessReviewDecision using PUT.
        /// </summary>
        /// <param name="accessReviewDecisionToUpdate">The AccessReviewDecision object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<AccessReviewDecision> PutAsync(AccessReviewDecision accessReviewDecisionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AccessReviewDecision using PUT and returns a <see cref="GraphResponse{AccessReviewDecision}"/> object.
        /// </summary>
        /// <param name="accessReviewDecisionToUpdate">The AccessReviewDecision object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{AccessReviewDecision}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessReviewDecision>> PutResponseAsync(AccessReviewDecision accessReviewDecisionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewDecisionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewDecisionRequest Expand(Expression<Func<AccessReviewDecision, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewDecisionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewDecisionRequest Select(Expression<Func<AccessReviewDecision, object>> selectExpression);

    }
}
