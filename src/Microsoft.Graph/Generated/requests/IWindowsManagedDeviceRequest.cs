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
    /// The interface IWindowsManagedDeviceRequest.
    /// </summary>
    public partial interface IWindowsManagedDeviceRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsManagedDevice using POST.
        /// </summary>
        /// <param name="windowsManagedDeviceToCreate">The WindowsManagedDevice to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsManagedDevice.</returns>
        System.Threading.Tasks.Task<WindowsManagedDevice> CreateAsync(WindowsManagedDevice windowsManagedDeviceToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified WindowsManagedDevice using POST and returns a <see cref="GraphResponse{WindowsManagedDevice}"/> object.
        /// </summary>
        /// <param name="windowsManagedDeviceToCreate">The WindowsManagedDevice to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsManagedDevice}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsManagedDevice>> CreateResponseAsync(WindowsManagedDevice windowsManagedDeviceToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WindowsManagedDevice.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WindowsManagedDevice and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WindowsManagedDevice.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsManagedDevice.</returns>
        System.Threading.Tasks.Task<WindowsManagedDevice> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WindowsManagedDevice and returns a <see cref="GraphResponse{WindowsManagedDevice}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsManagedDevice}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsManagedDevice>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WindowsManagedDevice using PATCH.
        /// </summary>
        /// <param name="windowsManagedDeviceToUpdate">The WindowsManagedDevice to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsManagedDevice.</returns>
        System.Threading.Tasks.Task<WindowsManagedDevice> UpdateAsync(WindowsManagedDevice windowsManagedDeviceToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WindowsManagedDevice using PATCH and returns a <see cref="GraphResponse{WindowsManagedDevice}"/> object.
        /// </summary>
        /// <param name="windowsManagedDeviceToUpdate">The WindowsManagedDevice to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WindowsManagedDevice}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsManagedDevice>> UpdateResponseAsync(WindowsManagedDevice windowsManagedDeviceToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WindowsManagedDevice using PUT.
        /// </summary>
        /// <param name="windowsManagedDeviceToUpdate">The WindowsManagedDevice object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<WindowsManagedDevice> PutAsync(WindowsManagedDevice windowsManagedDeviceToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WindowsManagedDevice using PUT and returns a <see cref="GraphResponse{WindowsManagedDevice}"/> object.
        /// </summary>
        /// <param name="windowsManagedDeviceToUpdate">The WindowsManagedDevice object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{WindowsManagedDevice}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsManagedDevice>> PutResponseAsync(WindowsManagedDevice windowsManagedDeviceToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsManagedDeviceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsManagedDeviceRequest Expand(Expression<Func<WindowsManagedDevice, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsManagedDeviceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsManagedDeviceRequest Select(Expression<Func<WindowsManagedDevice, object>> selectExpression);

    }
}
