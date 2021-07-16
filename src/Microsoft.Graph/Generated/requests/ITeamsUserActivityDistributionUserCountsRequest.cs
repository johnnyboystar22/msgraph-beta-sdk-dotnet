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
    /// The interface ITeamsUserActivityDistributionUserCountsRequest.
    /// </summary>
    public partial interface ITeamsUserActivityDistributionUserCountsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TeamsUserActivityDistributionUserCounts using POST.
        /// </summary>
        /// <param name="teamsUserActivityDistributionUserCountsToCreate">The TeamsUserActivityDistributionUserCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TeamsUserActivityDistributionUserCounts.</returns>
        System.Threading.Tasks.Task<TeamsUserActivityDistributionUserCounts> CreateAsync(TeamsUserActivityDistributionUserCounts teamsUserActivityDistributionUserCountsToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified TeamsUserActivityDistributionUserCounts using POST and returns a <see cref="GraphResponse{TeamsUserActivityDistributionUserCounts}"/> object.
        /// </summary>
        /// <param name="teamsUserActivityDistributionUserCountsToCreate">The TeamsUserActivityDistributionUserCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamsUserActivityDistributionUserCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsUserActivityDistributionUserCounts>> CreateResponseAsync(TeamsUserActivityDistributionUserCounts teamsUserActivityDistributionUserCountsToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified TeamsUserActivityDistributionUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified TeamsUserActivityDistributionUserCounts and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified TeamsUserActivityDistributionUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TeamsUserActivityDistributionUserCounts.</returns>
        System.Threading.Tasks.Task<TeamsUserActivityDistributionUserCounts> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified TeamsUserActivityDistributionUserCounts and returns a <see cref="GraphResponse{TeamsUserActivityDistributionUserCounts}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamsUserActivityDistributionUserCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsUserActivityDistributionUserCounts>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TeamsUserActivityDistributionUserCounts using PATCH.
        /// </summary>
        /// <param name="teamsUserActivityDistributionUserCountsToUpdate">The TeamsUserActivityDistributionUserCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TeamsUserActivityDistributionUserCounts.</returns>
        System.Threading.Tasks.Task<TeamsUserActivityDistributionUserCounts> UpdateAsync(TeamsUserActivityDistributionUserCounts teamsUserActivityDistributionUserCountsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TeamsUserActivityDistributionUserCounts using PATCH and returns a <see cref="GraphResponse{TeamsUserActivityDistributionUserCounts}"/> object.
        /// </summary>
        /// <param name="teamsUserActivityDistributionUserCountsToUpdate">The TeamsUserActivityDistributionUserCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TeamsUserActivityDistributionUserCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsUserActivityDistributionUserCounts>> UpdateResponseAsync(TeamsUserActivityDistributionUserCounts teamsUserActivityDistributionUserCountsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TeamsUserActivityDistributionUserCounts using PUT.
        /// </summary>
        /// <param name="teamsUserActivityDistributionUserCountsToUpdate">The TeamsUserActivityDistributionUserCounts object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<TeamsUserActivityDistributionUserCounts> PutAsync(TeamsUserActivityDistributionUserCounts teamsUserActivityDistributionUserCountsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TeamsUserActivityDistributionUserCounts using PUT and returns a <see cref="GraphResponse{TeamsUserActivityDistributionUserCounts}"/> object.
        /// </summary>
        /// <param name="teamsUserActivityDistributionUserCountsToUpdate">The TeamsUserActivityDistributionUserCounts object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{TeamsUserActivityDistributionUserCounts}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsUserActivityDistributionUserCounts>> PutResponseAsync(TeamsUserActivityDistributionUserCounts teamsUserActivityDistributionUserCountsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsUserActivityDistributionUserCountsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsUserActivityDistributionUserCountsRequest Expand(Expression<Func<TeamsUserActivityDistributionUserCounts, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsUserActivityDistributionUserCountsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsUserActivityDistributionUserCountsRequest Select(Expression<Func<TeamsUserActivityDistributionUserCounts, object>> selectExpression);

    }
}
