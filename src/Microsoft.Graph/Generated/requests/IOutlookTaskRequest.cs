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
    /// The interface IOutlookTaskRequest.
    /// </summary>
    public partial interface IOutlookTaskRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified OutlookTask using POST.
        /// </summary>
        /// <param name="outlookTaskToCreate">The OutlookTask to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OutlookTask.</returns>
        System.Threading.Tasks.Task<OutlookTask> CreateAsync(OutlookTask outlookTaskToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified OutlookTask using POST and returns a <see cref="GraphResponse{OutlookTask}"/> object.
        /// </summary>
        /// <param name="outlookTaskToCreate">The OutlookTask to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OutlookTask}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OutlookTask>> CreateResponseAsync(OutlookTask outlookTaskToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified OutlookTask.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified OutlookTask and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified OutlookTask.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OutlookTask.</returns>
        System.Threading.Tasks.Task<OutlookTask> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified OutlookTask and returns a <see cref="GraphResponse{OutlookTask}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OutlookTask}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OutlookTask>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified OutlookTask using PATCH.
        /// </summary>
        /// <param name="outlookTaskToUpdate">The OutlookTask to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OutlookTask.</returns>
        System.Threading.Tasks.Task<OutlookTask> UpdateAsync(OutlookTask outlookTaskToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified OutlookTask using PATCH and returns a <see cref="GraphResponse{OutlookTask}"/> object.
        /// </summary>
        /// <param name="outlookTaskToUpdate">The OutlookTask to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{OutlookTask}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OutlookTask>> UpdateResponseAsync(OutlookTask outlookTaskToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified OutlookTask using PUT.
        /// </summary>
        /// <param name="outlookTaskToUpdate">The OutlookTask object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<OutlookTask> PutAsync(OutlookTask outlookTaskToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified OutlookTask using PUT and returns a <see cref="GraphResponse{OutlookTask}"/> object.
        /// </summary>
        /// <param name="outlookTaskToUpdate">The OutlookTask object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{OutlookTask}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<OutlookTask>> PutResponseAsync(OutlookTask outlookTaskToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOutlookTaskRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOutlookTaskRequest Expand(Expression<Func<OutlookTask, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOutlookTaskRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOutlookTaskRequest Select(Expression<Func<OutlookTask, object>> selectExpression);

    }
}
