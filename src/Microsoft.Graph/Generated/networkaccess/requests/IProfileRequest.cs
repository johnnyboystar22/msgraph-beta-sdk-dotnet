// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph.Networkaccess
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IProfileRequest.
    /// </summary>
    public partial interface IProfileRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified Profile using POST.
        /// </summary>
        /// <param name="profileToCreate">The Profile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Profile.</returns>
        System.Threading.Tasks.Task<Profile> CreateAsync(Profile profileToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified Profile using POST and returns a <see cref="GraphResponse{Profile}"/> object.
        /// </summary>
        /// <param name="profileToCreate">The Profile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Profile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Profile>> CreateResponseAsync(Profile profileToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Profile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Profile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Profile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Profile.</returns>
        System.Threading.Tasks.Task<Profile> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Profile and returns a <see cref="GraphResponse{Profile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Profile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Profile>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Profile using PATCH.
        /// </summary>
        /// <param name="profileToUpdate">The Profile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Profile.</returns>
        System.Threading.Tasks.Task<Profile> UpdateAsync(Profile profileToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Profile using PATCH and returns a <see cref="GraphResponse{Profile}"/> object.
        /// </summary>
        /// <param name="profileToUpdate">The Profile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Profile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Profile>> UpdateResponseAsync(Profile profileToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Profile using PUT.
        /// </summary>
        /// <param name="profileToUpdate">The Profile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<Profile> PutAsync(Profile profileToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Profile using PUT and returns a <see cref="GraphResponse{Profile}"/> object.
        /// </summary>
        /// <param name="profileToUpdate">The Profile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{Profile}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<Profile>> PutResponseAsync(Profile profileToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IProfileRequest Expand(Expression<Func<Profile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IProfileRequest Select(Expression<Func<Profile, object>> selectExpression);

    }
}
