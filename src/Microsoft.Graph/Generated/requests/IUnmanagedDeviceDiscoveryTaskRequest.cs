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
    /// The interface IUnmanagedDeviceDiscoveryTaskRequest.
    /// </summary>
    public partial interface IUnmanagedDeviceDiscoveryTaskRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UnmanagedDeviceDiscoveryTask using POST.
        /// </summary>
        /// <param name="unmanagedDeviceDiscoveryTaskToCreate">The UnmanagedDeviceDiscoveryTask to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UnmanagedDeviceDiscoveryTask.</returns>
        System.Threading.Tasks.Task<UnmanagedDeviceDiscoveryTask> CreateAsync(UnmanagedDeviceDiscoveryTask unmanagedDeviceDiscoveryTaskToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified UnmanagedDeviceDiscoveryTask using POST and returns a <see cref="GraphResponse{UnmanagedDeviceDiscoveryTask}"/> object.
        /// </summary>
        /// <param name="unmanagedDeviceDiscoveryTaskToCreate">The UnmanagedDeviceDiscoveryTask to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnmanagedDeviceDiscoveryTask}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnmanagedDeviceDiscoveryTask>> CreateResponseAsync(UnmanagedDeviceDiscoveryTask unmanagedDeviceDiscoveryTaskToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified UnmanagedDeviceDiscoveryTask.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified UnmanagedDeviceDiscoveryTask and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified UnmanagedDeviceDiscoveryTask.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UnmanagedDeviceDiscoveryTask.</returns>
        System.Threading.Tasks.Task<UnmanagedDeviceDiscoveryTask> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified UnmanagedDeviceDiscoveryTask and returns a <see cref="GraphResponse{UnmanagedDeviceDiscoveryTask}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnmanagedDeviceDiscoveryTask}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnmanagedDeviceDiscoveryTask>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UnmanagedDeviceDiscoveryTask using PATCH.
        /// </summary>
        /// <param name="unmanagedDeviceDiscoveryTaskToUpdate">The UnmanagedDeviceDiscoveryTask to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UnmanagedDeviceDiscoveryTask.</returns>
        System.Threading.Tasks.Task<UnmanagedDeviceDiscoveryTask> UpdateAsync(UnmanagedDeviceDiscoveryTask unmanagedDeviceDiscoveryTaskToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UnmanagedDeviceDiscoveryTask using PATCH and returns a <see cref="GraphResponse{UnmanagedDeviceDiscoveryTask}"/> object.
        /// </summary>
        /// <param name="unmanagedDeviceDiscoveryTaskToUpdate">The UnmanagedDeviceDiscoveryTask to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UnmanagedDeviceDiscoveryTask}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnmanagedDeviceDiscoveryTask>> UpdateResponseAsync(UnmanagedDeviceDiscoveryTask unmanagedDeviceDiscoveryTaskToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UnmanagedDeviceDiscoveryTask using PUT.
        /// </summary>
        /// <param name="unmanagedDeviceDiscoveryTaskToUpdate">The UnmanagedDeviceDiscoveryTask object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<UnmanagedDeviceDiscoveryTask> PutAsync(UnmanagedDeviceDiscoveryTask unmanagedDeviceDiscoveryTaskToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UnmanagedDeviceDiscoveryTask using PUT and returns a <see cref="GraphResponse{UnmanagedDeviceDiscoveryTask}"/> object.
        /// </summary>
        /// <param name="unmanagedDeviceDiscoveryTaskToUpdate">The UnmanagedDeviceDiscoveryTask object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{UnmanagedDeviceDiscoveryTask}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnmanagedDeviceDiscoveryTask>> PutResponseAsync(UnmanagedDeviceDiscoveryTask unmanagedDeviceDiscoveryTaskToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnmanagedDeviceDiscoveryTaskRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnmanagedDeviceDiscoveryTaskRequest Expand(Expression<Func<UnmanagedDeviceDiscoveryTask, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUnmanagedDeviceDiscoveryTaskRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUnmanagedDeviceDiscoveryTaskRequest Select(Expression<Func<UnmanagedDeviceDiscoveryTask, object>> selectExpression);

    }
}
