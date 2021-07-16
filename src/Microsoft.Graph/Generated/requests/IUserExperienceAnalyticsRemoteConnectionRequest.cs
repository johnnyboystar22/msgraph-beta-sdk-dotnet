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
    /// The interface IUserExperienceAnalyticsRemoteConnectionRequest.
    /// </summary>
    public partial interface IUserExperienceAnalyticsRemoteConnectionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UserExperienceAnalyticsRemoteConnection using POST.
        /// </summary>
        /// <param name="userExperienceAnalyticsRemoteConnectionToCreate">The UserExperienceAnalyticsRemoteConnection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserExperienceAnalyticsRemoteConnection.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsRemoteConnection> CreateAsync(UserExperienceAnalyticsRemoteConnection userExperienceAnalyticsRemoteConnectionToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified UserExperienceAnalyticsRemoteConnection using POST and returns a <see cref="GraphResponse{UserExperienceAnalyticsRemoteConnection}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsRemoteConnectionToCreate">The UserExperienceAnalyticsRemoteConnection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsRemoteConnection}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsRemoteConnection>> CreateResponseAsync(UserExperienceAnalyticsRemoteConnection userExperienceAnalyticsRemoteConnectionToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsRemoteConnection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsRemoteConnection and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsRemoteConnection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UserExperienceAnalyticsRemoteConnection.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsRemoteConnection> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsRemoteConnection and returns a <see cref="GraphResponse{UserExperienceAnalyticsRemoteConnection}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsRemoteConnection}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsRemoteConnection>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsRemoteConnection using PATCH.
        /// </summary>
        /// <param name="userExperienceAnalyticsRemoteConnectionToUpdate">The UserExperienceAnalyticsRemoteConnection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UserExperienceAnalyticsRemoteConnection.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsRemoteConnection> UpdateAsync(UserExperienceAnalyticsRemoteConnection userExperienceAnalyticsRemoteConnectionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsRemoteConnection using PATCH and returns a <see cref="GraphResponse{UserExperienceAnalyticsRemoteConnection}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsRemoteConnectionToUpdate">The UserExperienceAnalyticsRemoteConnection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsRemoteConnection}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsRemoteConnection>> UpdateResponseAsync(UserExperienceAnalyticsRemoteConnection userExperienceAnalyticsRemoteConnectionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsRemoteConnection using PUT.
        /// </summary>
        /// <param name="userExperienceAnalyticsRemoteConnectionToUpdate">The UserExperienceAnalyticsRemoteConnection object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsRemoteConnection> PutAsync(UserExperienceAnalyticsRemoteConnection userExperienceAnalyticsRemoteConnectionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsRemoteConnection using PUT and returns a <see cref="GraphResponse{UserExperienceAnalyticsRemoteConnection}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsRemoteConnectionToUpdate">The UserExperienceAnalyticsRemoteConnection object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{UserExperienceAnalyticsRemoteConnection}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsRemoteConnection>> PutResponseAsync(UserExperienceAnalyticsRemoteConnection userExperienceAnalyticsRemoteConnectionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsRemoteConnectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsRemoteConnectionRequest Expand(Expression<Func<UserExperienceAnalyticsRemoteConnection, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsRemoteConnectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsRemoteConnectionRequest Select(Expression<Func<UserExperienceAnalyticsRemoteConnection, object>> selectExpression);

    }
}
