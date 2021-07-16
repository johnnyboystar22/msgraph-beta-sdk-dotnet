// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IManagementActionRequest.
    /// </summary>
    public partial interface IManagementActionRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified ManagementAction using POST.
        /// </summary>
        /// <param name="managementActionToCreate">The ManagementAction to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagementAction.</returns>
        System.Threading.Tasks.Task<ManagementAction> CreateAsync(ManagementAction managementActionToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified ManagementAction using POST and returns a <see cref="GraphResponse{ManagementAction}"/> object.
        /// </summary>
        /// <param name="managementActionToCreate">The ManagementAction to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagementAction}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagementAction>> CreateResponseAsync(ManagementAction managementActionToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ManagementAction.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ManagementAction and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ManagementAction.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagementAction.</returns>
        System.Threading.Tasks.Task<ManagementAction> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ManagementAction and returns a <see cref="GraphResponse{ManagementAction}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagementAction}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagementAction>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagementAction using PATCH.
        /// </summary>
        /// <param name="managementActionToUpdate">The ManagementAction to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagementAction.</returns>
        System.Threading.Tasks.Task<ManagementAction> UpdateAsync(ManagementAction managementActionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagementAction using PATCH and returns a <see cref="GraphResponse{ManagementAction}"/> object.
        /// </summary>
        /// <param name="managementActionToUpdate">The ManagementAction to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ManagementAction}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagementAction>> UpdateResponseAsync(ManagementAction managementActionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagementAction using PUT.
        /// </summary>
        /// <param name="managementActionToUpdate">The ManagementAction object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ManagementAction> PutAsync(ManagementAction managementActionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagementAction using PUT and returns a <see cref="GraphResponse{ManagementAction}"/> object.
        /// </summary>
        /// <param name="managementActionToUpdate">The ManagementAction object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ManagementAction}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagementAction>> PutResponseAsync(ManagementAction managementActionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagementActionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagementActionRequest Expand(Expression<Func<ManagementAction, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagementActionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagementActionRequest Select(Expression<Func<ManagementAction, object>> selectExpression);

    }
}
