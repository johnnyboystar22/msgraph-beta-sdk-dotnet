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
    /// The interface IItemInsightsSettingsRequest.
    /// </summary>
    public partial interface IItemInsightsSettingsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ItemInsightsSettings using POST.
        /// </summary>
        /// <param name="itemInsightsSettingsToCreate">The ItemInsightsSettings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ItemInsightsSettings.</returns>
        System.Threading.Tasks.Task<ItemInsightsSettings> CreateAsync(ItemInsightsSettings itemInsightsSettingsToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified ItemInsightsSettings using POST and returns a <see cref="GraphResponse{ItemInsightsSettings}"/> object.
        /// </summary>
        /// <param name="itemInsightsSettingsToCreate">The ItemInsightsSettings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ItemInsightsSettings}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ItemInsightsSettings>> CreateResponseAsync(ItemInsightsSettings itemInsightsSettingsToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ItemInsightsSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ItemInsightsSettings and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ItemInsightsSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ItemInsightsSettings.</returns>
        System.Threading.Tasks.Task<ItemInsightsSettings> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ItemInsightsSettings and returns a <see cref="GraphResponse{ItemInsightsSettings}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ItemInsightsSettings}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ItemInsightsSettings>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ItemInsightsSettings using PATCH.
        /// </summary>
        /// <param name="itemInsightsSettingsToUpdate">The ItemInsightsSettings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ItemInsightsSettings.</returns>
        System.Threading.Tasks.Task<ItemInsightsSettings> UpdateAsync(ItemInsightsSettings itemInsightsSettingsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ItemInsightsSettings using PATCH and returns a <see cref="GraphResponse{ItemInsightsSettings}"/> object.
        /// </summary>
        /// <param name="itemInsightsSettingsToUpdate">The ItemInsightsSettings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ItemInsightsSettings}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ItemInsightsSettings>> UpdateResponseAsync(ItemInsightsSettings itemInsightsSettingsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ItemInsightsSettings using PUT.
        /// </summary>
        /// <param name="itemInsightsSettingsToUpdate">The ItemInsightsSettings object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ItemInsightsSettings> PutAsync(ItemInsightsSettings itemInsightsSettingsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ItemInsightsSettings using PUT and returns a <see cref="GraphResponse{ItemInsightsSettings}"/> object.
        /// </summary>
        /// <param name="itemInsightsSettingsToUpdate">The ItemInsightsSettings object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ItemInsightsSettings}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ItemInsightsSettings>> PutResponseAsync(ItemInsightsSettings itemInsightsSettingsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IItemInsightsSettingsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IItemInsightsSettingsRequest Expand(Expression<Func<ItemInsightsSettings, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IItemInsightsSettingsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IItemInsightsSettingsRequest Select(Expression<Func<ItemInsightsSettings, object>> selectExpression);

    }
}
