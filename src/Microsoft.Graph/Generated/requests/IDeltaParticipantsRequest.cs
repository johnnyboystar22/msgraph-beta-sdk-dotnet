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
    /// The interface IDeltaParticipantsRequest.
    /// </summary>
    public partial interface IDeltaParticipantsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeltaParticipants using POST.
        /// </summary>
        /// <param name="deltaParticipantsToCreate">The DeltaParticipants to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeltaParticipants.</returns>
        System.Threading.Tasks.Task<DeltaParticipants> CreateAsync(DeltaParticipants deltaParticipantsToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified DeltaParticipants using POST and returns a <see cref="GraphResponse{DeltaParticipants}"/> object.
        /// </summary>
        /// <param name="deltaParticipantsToCreate">The DeltaParticipants to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeltaParticipants}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeltaParticipants>> CreateResponseAsync(DeltaParticipants deltaParticipantsToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeltaParticipants.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeltaParticipants and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeltaParticipants.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeltaParticipants.</returns>
        System.Threading.Tasks.Task<DeltaParticipants> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeltaParticipants and returns a <see cref="GraphResponse{DeltaParticipants}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeltaParticipants}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeltaParticipants>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeltaParticipants using PATCH.
        /// </summary>
        /// <param name="deltaParticipantsToUpdate">The DeltaParticipants to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeltaParticipants.</returns>
        System.Threading.Tasks.Task<DeltaParticipants> UpdateAsync(DeltaParticipants deltaParticipantsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeltaParticipants using PATCH and returns a <see cref="GraphResponse{DeltaParticipants}"/> object.
        /// </summary>
        /// <param name="deltaParticipantsToUpdate">The DeltaParticipants to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeltaParticipants}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeltaParticipants>> UpdateResponseAsync(DeltaParticipants deltaParticipantsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeltaParticipants using PUT.
        /// </summary>
        /// <param name="deltaParticipantsToUpdate">The DeltaParticipants object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DeltaParticipants> PutAsync(DeltaParticipants deltaParticipantsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeltaParticipants using PUT and returns a <see cref="GraphResponse{DeltaParticipants}"/> object.
        /// </summary>
        /// <param name="deltaParticipantsToUpdate">The DeltaParticipants object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DeltaParticipants}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeltaParticipants>> PutResponseAsync(DeltaParticipants deltaParticipantsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeltaParticipantsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeltaParticipantsRequest Expand(Expression<Func<DeltaParticipants, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeltaParticipantsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeltaParticipantsRequest Select(Expression<Func<DeltaParticipants, object>> selectExpression);

    }
}
