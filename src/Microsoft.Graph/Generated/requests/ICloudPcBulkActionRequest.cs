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
    /// The interface ICloudPcBulkActionRequest.
    /// </summary>
    public partial interface ICloudPcBulkActionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified CloudPcBulkAction using POST.
        /// </summary>
        /// <param name="cloudPcBulkActionToCreate">The CloudPcBulkAction to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CloudPcBulkAction.</returns>
        System.Threading.Tasks.Task<CloudPcBulkAction> CreateAsync(CloudPcBulkAction cloudPcBulkActionToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified CloudPcBulkAction using POST and returns a <see cref="GraphResponse{CloudPcBulkAction}"/> object.
        /// </summary>
        /// <param name="cloudPcBulkActionToCreate">The CloudPcBulkAction to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CloudPcBulkAction}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CloudPcBulkAction>> CreateResponseAsync(CloudPcBulkAction cloudPcBulkActionToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified CloudPcBulkAction.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified CloudPcBulkAction and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified CloudPcBulkAction.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CloudPcBulkAction.</returns>
        System.Threading.Tasks.Task<CloudPcBulkAction> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified CloudPcBulkAction and returns a <see cref="GraphResponse{CloudPcBulkAction}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CloudPcBulkAction}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CloudPcBulkAction>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CloudPcBulkAction using PATCH.
        /// </summary>
        /// <param name="cloudPcBulkActionToUpdate">The CloudPcBulkAction to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CloudPcBulkAction.</returns>
        System.Threading.Tasks.Task<CloudPcBulkAction> UpdateAsync(CloudPcBulkAction cloudPcBulkActionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CloudPcBulkAction using PATCH and returns a <see cref="GraphResponse{CloudPcBulkAction}"/> object.
        /// </summary>
        /// <param name="cloudPcBulkActionToUpdate">The CloudPcBulkAction to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{CloudPcBulkAction}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CloudPcBulkAction>> UpdateResponseAsync(CloudPcBulkAction cloudPcBulkActionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CloudPcBulkAction using PUT.
        /// </summary>
        /// <param name="cloudPcBulkActionToUpdate">The CloudPcBulkAction object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<CloudPcBulkAction> PutAsync(CloudPcBulkAction cloudPcBulkActionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CloudPcBulkAction using PUT and returns a <see cref="GraphResponse{CloudPcBulkAction}"/> object.
        /// </summary>
        /// <param name="cloudPcBulkActionToUpdate">The CloudPcBulkAction object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{CloudPcBulkAction}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<CloudPcBulkAction>> PutResponseAsync(CloudPcBulkAction cloudPcBulkActionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPcBulkActionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPcBulkActionRequest Expand(Expression<Func<CloudPcBulkAction, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPcBulkActionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPcBulkActionRequest Select(Expression<Func<CloudPcBulkAction, object>> selectExpression);

    }
}
