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
    /// The interface IDirectorySettingRequest.
    /// </summary>
    public partial interface IDirectorySettingRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DirectorySetting using POST.
        /// </summary>
        /// <param name="directorySettingToCreate">The DirectorySetting to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DirectorySetting.</returns>
        System.Threading.Tasks.Task<DirectorySetting> CreateAsync(DirectorySetting directorySettingToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified DirectorySetting using POST and returns a <see cref="GraphResponse{DirectorySetting}"/> object.
        /// </summary>
        /// <param name="directorySettingToCreate">The DirectorySetting to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DirectorySetting}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DirectorySetting>> CreateResponseAsync(DirectorySetting directorySettingToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DirectorySetting.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DirectorySetting and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DirectorySetting.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DirectorySetting.</returns>
        System.Threading.Tasks.Task<DirectorySetting> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DirectorySetting and returns a <see cref="GraphResponse{DirectorySetting}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DirectorySetting}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DirectorySetting>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DirectorySetting using PATCH.
        /// </summary>
        /// <param name="directorySettingToUpdate">The DirectorySetting to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DirectorySetting.</returns>
        System.Threading.Tasks.Task<DirectorySetting> UpdateAsync(DirectorySetting directorySettingToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DirectorySetting using PATCH and returns a <see cref="GraphResponse{DirectorySetting}"/> object.
        /// </summary>
        /// <param name="directorySettingToUpdate">The DirectorySetting to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DirectorySetting}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DirectorySetting>> UpdateResponseAsync(DirectorySetting directorySettingToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DirectorySetting using PUT.
        /// </summary>
        /// <param name="directorySettingToUpdate">The DirectorySetting object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DirectorySetting> PutAsync(DirectorySetting directorySettingToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DirectorySetting using PUT and returns a <see cref="GraphResponse{DirectorySetting}"/> object.
        /// </summary>
        /// <param name="directorySettingToUpdate">The DirectorySetting object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DirectorySetting}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DirectorySetting>> PutResponseAsync(DirectorySetting directorySettingToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDirectorySettingRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDirectorySettingRequest Expand(Expression<Func<DirectorySetting, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDirectorySettingRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDirectorySettingRequest Select(Expression<Func<DirectorySetting, object>> selectExpression);

    }
}
