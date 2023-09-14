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
    /// The interface ISettingsRequest.
    /// </summary>
    public partial interface ISettingsRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified Settings using POST.
        /// </summary>
        /// <param name="settingsToCreate">The Settings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Settings.</returns>
        System.Threading.Tasks.Task<Settings> CreateAsync(Settings settingsToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified Settings using POST and returns a <see cref="GraphResponse{Settings}"/> object.
        /// </summary>
        /// <param name="settingsToCreate">The Settings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Settings}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Settings>> CreateResponseAsync(Settings settingsToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Settings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Settings and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Settings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Settings.</returns>
        System.Threading.Tasks.Task<Settings> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Settings and returns a <see cref="GraphResponse{Settings}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Settings}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Settings>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Settings using PATCH.
        /// </summary>
        /// <param name="settingsToUpdate">The Settings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Settings.</returns>
        System.Threading.Tasks.Task<Settings> UpdateAsync(Settings settingsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Settings using PATCH and returns a <see cref="GraphResponse{Settings}"/> object.
        /// </summary>
        /// <param name="settingsToUpdate">The Settings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Settings}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Settings>> UpdateResponseAsync(Settings settingsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Settings using PUT.
        /// </summary>
        /// <param name="settingsToUpdate">The Settings object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<Settings> PutAsync(Settings settingsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Settings using PUT and returns a <see cref="GraphResponse{Settings}"/> object.
        /// </summary>
        /// <param name="settingsToUpdate">The Settings object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{Settings}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<Settings>> PutResponseAsync(Settings settingsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISettingsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISettingsRequest Expand(Expression<Func<Settings, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISettingsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISettingsRequest Select(Expression<Func<Settings, object>> selectExpression);

    }
}
