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
    /// The interface IUnifiedRbacResourceActionRequest.
    /// </summary>
    public partial interface IUnifiedRbacResourceActionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UnifiedRbacResourceAction using POST.
        /// </summary>
        /// <param name="unifiedRbacResourceActionToCreate">The UnifiedRbacResourceAction to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UnifiedRbacResourceAction.</returns>
        System.Threading.Tasks.Task<UnifiedRbacResourceAction> CreateAsync(UnifiedRbacResourceAction unifiedRbacResourceActionToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified UnifiedRbacResourceAction using POST and returns a <see cref="GraphResponse{UnifiedRbacResourceAction}"/> object.
        /// </summary>
        /// <param name="unifiedRbacResourceActionToCreate">The UnifiedRbacResourceAction to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRbacResourceAction}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRbacResourceAction>> CreateResponseAsync(UnifiedRbacResourceAction unifiedRbacResourceActionToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified UnifiedRbacResourceAction.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified UnifiedRbacResourceAction and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified UnifiedRbacResourceAction.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UnifiedRbacResourceAction.</returns>
        System.Threading.Tasks.Task<UnifiedRbacResourceAction> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified UnifiedRbacResourceAction and returns a <see cref="GraphResponse{UnifiedRbacResourceAction}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRbacResourceAction}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRbacResourceAction>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UnifiedRbacResourceAction using PATCH.
        /// </summary>
        /// <param name="unifiedRbacResourceActionToUpdate">The UnifiedRbacResourceAction to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UnifiedRbacResourceAction.</returns>
        System.Threading.Tasks.Task<UnifiedRbacResourceAction> UpdateAsync(UnifiedRbacResourceAction unifiedRbacResourceActionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UnifiedRbacResourceAction using PATCH and returns a <see cref="GraphResponse{UnifiedRbacResourceAction}"/> object.
        /// </summary>
        /// <param name="unifiedRbacResourceActionToUpdate">The UnifiedRbacResourceAction to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UnifiedRbacResourceAction}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRbacResourceAction>> UpdateResponseAsync(UnifiedRbacResourceAction unifiedRbacResourceActionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UnifiedRbacResourceAction using PUT.
        /// </summary>
        /// <param name="unifiedRbacResourceActionToUpdate">The UnifiedRbacResourceAction object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<UnifiedRbacResourceAction> PutAsync(UnifiedRbacResourceAction unifiedRbacResourceActionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UnifiedRbacResourceAction using PUT and returns a <see cref="GraphResponse{UnifiedRbacResourceAction}"/> object.
        /// </summary>
        /// <param name="unifiedRbacResourceActionToUpdate">The UnifiedRbacResourceAction object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{UnifiedRbacResourceAction}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRbacResourceAction>> PutResponseAsync(UnifiedRbacResourceAction unifiedRbacResourceActionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRbacResourceActionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRbacResourceActionRequest Expand(Expression<Func<UnifiedRbacResourceAction, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRbacResourceActionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRbacResourceActionRequest Select(Expression<Func<UnifiedRbacResourceAction, object>> selectExpression);

    }
}
