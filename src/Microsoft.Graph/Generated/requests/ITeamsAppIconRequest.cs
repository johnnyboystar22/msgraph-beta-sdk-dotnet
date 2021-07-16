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
    /// The interface ITeamsAppIconRequest.
    /// </summary>
    public partial interface ITeamsAppIconRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TeamsAppIcon using POST.
        /// </summary>
        /// <param name="teamsAppIconToCreate">The TeamsAppIcon to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TeamsAppIcon.</returns>
        System.Threading.Tasks.Task<TeamsAppIcon> CreateAsync(TeamsAppIcon teamsAppIconToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified TeamsAppIcon using POST and returns a <see cref="GraphResponse{TeamsAppIcon}"/> object.
        /// </summary>
        /// <param name="teamsAppIconToCreate">The TeamsAppIcon to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamsAppIcon}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsAppIcon>> CreateResponseAsync(TeamsAppIcon teamsAppIconToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified TeamsAppIcon.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified TeamsAppIcon and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified TeamsAppIcon.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TeamsAppIcon.</returns>
        System.Threading.Tasks.Task<TeamsAppIcon> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified TeamsAppIcon and returns a <see cref="GraphResponse{TeamsAppIcon}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamsAppIcon}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsAppIcon>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TeamsAppIcon using PATCH.
        /// </summary>
        /// <param name="teamsAppIconToUpdate">The TeamsAppIcon to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TeamsAppIcon.</returns>
        System.Threading.Tasks.Task<TeamsAppIcon> UpdateAsync(TeamsAppIcon teamsAppIconToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TeamsAppIcon using PATCH and returns a <see cref="GraphResponse{TeamsAppIcon}"/> object.
        /// </summary>
        /// <param name="teamsAppIconToUpdate">The TeamsAppIcon to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TeamsAppIcon}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsAppIcon>> UpdateResponseAsync(TeamsAppIcon teamsAppIconToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TeamsAppIcon using PUT.
        /// </summary>
        /// <param name="teamsAppIconToUpdate">The TeamsAppIcon object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<TeamsAppIcon> PutAsync(TeamsAppIcon teamsAppIconToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TeamsAppIcon using PUT and returns a <see cref="GraphResponse{TeamsAppIcon}"/> object.
        /// </summary>
        /// <param name="teamsAppIconToUpdate">The TeamsAppIcon object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{TeamsAppIcon}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsAppIcon>> PutResponseAsync(TeamsAppIcon teamsAppIconToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsAppIconRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsAppIconRequest Expand(Expression<Func<TeamsAppIcon, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsAppIconRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsAppIconRequest Select(Expression<Func<TeamsAppIcon, object>> selectExpression);

    }
}
