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
    /// The interface IWindowsPrivacyDataAccessControlItemRequest.
    /// </summary>
    public partial interface IWindowsPrivacyDataAccessControlItemRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsPrivacyDataAccessControlItem using POST.
        /// </summary>
        /// <param name="windowsPrivacyDataAccessControlItemToCreate">The WindowsPrivacyDataAccessControlItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsPrivacyDataAccessControlItem.</returns>
        System.Threading.Tasks.Task<WindowsPrivacyDataAccessControlItem> CreateAsync(WindowsPrivacyDataAccessControlItem windowsPrivacyDataAccessControlItemToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified WindowsPrivacyDataAccessControlItem using POST and returns a <see cref="GraphResponse{WindowsPrivacyDataAccessControlItem}"/> object.
        /// </summary>
        /// <param name="windowsPrivacyDataAccessControlItemToCreate">The WindowsPrivacyDataAccessControlItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsPrivacyDataAccessControlItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsPrivacyDataAccessControlItem>> CreateResponseAsync(WindowsPrivacyDataAccessControlItem windowsPrivacyDataAccessControlItemToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WindowsPrivacyDataAccessControlItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WindowsPrivacyDataAccessControlItem and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WindowsPrivacyDataAccessControlItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsPrivacyDataAccessControlItem.</returns>
        System.Threading.Tasks.Task<WindowsPrivacyDataAccessControlItem> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WindowsPrivacyDataAccessControlItem and returns a <see cref="GraphResponse{WindowsPrivacyDataAccessControlItem}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsPrivacyDataAccessControlItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsPrivacyDataAccessControlItem>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WindowsPrivacyDataAccessControlItem using PATCH.
        /// </summary>
        /// <param name="windowsPrivacyDataAccessControlItemToUpdate">The WindowsPrivacyDataAccessControlItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsPrivacyDataAccessControlItem.</returns>
        System.Threading.Tasks.Task<WindowsPrivacyDataAccessControlItem> UpdateAsync(WindowsPrivacyDataAccessControlItem windowsPrivacyDataAccessControlItemToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WindowsPrivacyDataAccessControlItem using PATCH and returns a <see cref="GraphResponse{WindowsPrivacyDataAccessControlItem}"/> object.
        /// </summary>
        /// <param name="windowsPrivacyDataAccessControlItemToUpdate">The WindowsPrivacyDataAccessControlItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WindowsPrivacyDataAccessControlItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsPrivacyDataAccessControlItem>> UpdateResponseAsync(WindowsPrivacyDataAccessControlItem windowsPrivacyDataAccessControlItemToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WindowsPrivacyDataAccessControlItem using PUT.
        /// </summary>
        /// <param name="windowsPrivacyDataAccessControlItemToUpdate">The WindowsPrivacyDataAccessControlItem object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<WindowsPrivacyDataAccessControlItem> PutAsync(WindowsPrivacyDataAccessControlItem windowsPrivacyDataAccessControlItemToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WindowsPrivacyDataAccessControlItem using PUT and returns a <see cref="GraphResponse{WindowsPrivacyDataAccessControlItem}"/> object.
        /// </summary>
        /// <param name="windowsPrivacyDataAccessControlItemToUpdate">The WindowsPrivacyDataAccessControlItem object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{WindowsPrivacyDataAccessControlItem}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsPrivacyDataAccessControlItem>> PutResponseAsync(WindowsPrivacyDataAccessControlItem windowsPrivacyDataAccessControlItemToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPrivacyDataAccessControlItemRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPrivacyDataAccessControlItemRequest Expand(Expression<Func<WindowsPrivacyDataAccessControlItem, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPrivacyDataAccessControlItemRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPrivacyDataAccessControlItemRequest Select(Expression<Func<WindowsPrivacyDataAccessControlItem, object>> selectExpression);

    }
}
