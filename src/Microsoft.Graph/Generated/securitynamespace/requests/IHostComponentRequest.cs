// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IHostComponentRequest.
    /// </summary>
    public partial interface IHostComponentRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified HostComponent using POST.
        /// </summary>
        /// <param name="hostComponentToCreate">The HostComponent to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created HostComponent.</returns>
        System.Threading.Tasks.Task<HostComponent> CreateAsync(HostComponent hostComponentToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified HostComponent using POST and returns a <see cref="GraphResponse{HostComponent}"/> object.
        /// </summary>
        /// <param name="hostComponentToCreate">The HostComponent to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{HostComponent}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<HostComponent>> CreateResponseAsync(HostComponent hostComponentToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified HostComponent.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified HostComponent and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified HostComponent.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The HostComponent.</returns>
        System.Threading.Tasks.Task<HostComponent> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified HostComponent and returns a <see cref="GraphResponse{HostComponent}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{HostComponent}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<HostComponent>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified HostComponent using PATCH.
        /// </summary>
        /// <param name="hostComponentToUpdate">The HostComponent to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated HostComponent.</returns>
        System.Threading.Tasks.Task<HostComponent> UpdateAsync(HostComponent hostComponentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified HostComponent using PATCH and returns a <see cref="GraphResponse{HostComponent}"/> object.
        /// </summary>
        /// <param name="hostComponentToUpdate">The HostComponent to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{HostComponent}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<HostComponent>> UpdateResponseAsync(HostComponent hostComponentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified HostComponent using PUT.
        /// </summary>
        /// <param name="hostComponentToUpdate">The HostComponent object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<HostComponent> PutAsync(HostComponent hostComponentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified HostComponent using PUT and returns a <see cref="GraphResponse{HostComponent}"/> object.
        /// </summary>
        /// <param name="hostComponentToUpdate">The HostComponent object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{HostComponent}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<HostComponent>> PutResponseAsync(HostComponent hostComponentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IHostComponentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IHostComponentRequest Expand(Expression<Func<HostComponent, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IHostComponentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IHostComponentRequest Select(Expression<Func<HostComponent, object>> selectExpression);

    }
}
