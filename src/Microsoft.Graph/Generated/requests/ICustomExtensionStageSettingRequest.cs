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
    /// The interface ICustomExtensionStageSettingRequest.
    /// </summary>
    public partial interface ICustomExtensionStageSettingRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified CustomExtensionStageSetting using POST.
        /// </summary>
        /// <param name="customExtensionStageSettingToCreate">The CustomExtensionStageSetting to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CustomExtensionStageSetting.</returns>
        System.Threading.Tasks.Task<CustomExtensionStageSetting> CreateAsync(CustomExtensionStageSetting customExtensionStageSettingToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified CustomExtensionStageSetting using POST and returns a <see cref="GraphResponse{CustomExtensionStageSetting}"/> object.
        /// </summary>
        /// <param name="customExtensionStageSettingToCreate">The CustomExtensionStageSetting to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CustomExtensionStageSetting}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CustomExtensionStageSetting>> CreateResponseAsync(CustomExtensionStageSetting customExtensionStageSettingToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified CustomExtensionStageSetting.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified CustomExtensionStageSetting and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified CustomExtensionStageSetting.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CustomExtensionStageSetting.</returns>
        System.Threading.Tasks.Task<CustomExtensionStageSetting> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified CustomExtensionStageSetting and returns a <see cref="GraphResponse{CustomExtensionStageSetting}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CustomExtensionStageSetting}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CustomExtensionStageSetting>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CustomExtensionStageSetting using PATCH.
        /// </summary>
        /// <param name="customExtensionStageSettingToUpdate">The CustomExtensionStageSetting to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CustomExtensionStageSetting.</returns>
        System.Threading.Tasks.Task<CustomExtensionStageSetting> UpdateAsync(CustomExtensionStageSetting customExtensionStageSettingToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CustomExtensionStageSetting using PATCH and returns a <see cref="GraphResponse{CustomExtensionStageSetting}"/> object.
        /// </summary>
        /// <param name="customExtensionStageSettingToUpdate">The CustomExtensionStageSetting to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{CustomExtensionStageSetting}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CustomExtensionStageSetting>> UpdateResponseAsync(CustomExtensionStageSetting customExtensionStageSettingToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CustomExtensionStageSetting using PUT.
        /// </summary>
        /// <param name="customExtensionStageSettingToUpdate">The CustomExtensionStageSetting object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<CustomExtensionStageSetting> PutAsync(CustomExtensionStageSetting customExtensionStageSettingToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CustomExtensionStageSetting using PUT and returns a <see cref="GraphResponse{CustomExtensionStageSetting}"/> object.
        /// </summary>
        /// <param name="customExtensionStageSettingToUpdate">The CustomExtensionStageSetting object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{CustomExtensionStageSetting}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<CustomExtensionStageSetting>> PutResponseAsync(CustomExtensionStageSetting customExtensionStageSettingToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICustomExtensionStageSettingRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICustomExtensionStageSettingRequest Expand(Expression<Func<CustomExtensionStageSetting, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICustomExtensionStageSettingRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICustomExtensionStageSettingRequest Select(Expression<Func<CustomExtensionStageSetting, object>> selectExpression);

    }
}
