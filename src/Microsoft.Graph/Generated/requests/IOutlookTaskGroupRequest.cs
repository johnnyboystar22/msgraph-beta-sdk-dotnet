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
    /// The interface IOutlookTaskGroupRequest.
    /// </summary>
    public partial interface IOutlookTaskGroupRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified OutlookTaskGroup using POST.
        /// </summary>
        /// <param name="outlookTaskGroupToCreate">The OutlookTaskGroup to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OutlookTaskGroup.</returns>
        System.Threading.Tasks.Task<OutlookTaskGroup> CreateAsync(OutlookTaskGroup outlookTaskGroupToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified OutlookTaskGroup using POST and returns a <see cref="GraphResponse{OutlookTaskGroup}"/> object.
        /// </summary>
        /// <param name="outlookTaskGroupToCreate">The OutlookTaskGroup to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OutlookTaskGroup}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OutlookTaskGroup>> CreateResponseAsync(OutlookTaskGroup outlookTaskGroupToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified OutlookTaskGroup.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified OutlookTaskGroup and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified OutlookTaskGroup.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OutlookTaskGroup.</returns>
        System.Threading.Tasks.Task<OutlookTaskGroup> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified OutlookTaskGroup and returns a <see cref="GraphResponse{OutlookTaskGroup}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OutlookTaskGroup}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OutlookTaskGroup>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified OutlookTaskGroup using PATCH.
        /// </summary>
        /// <param name="outlookTaskGroupToUpdate">The OutlookTaskGroup to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OutlookTaskGroup.</returns>
        System.Threading.Tasks.Task<OutlookTaskGroup> UpdateAsync(OutlookTaskGroup outlookTaskGroupToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified OutlookTaskGroup using PATCH and returns a <see cref="GraphResponse{OutlookTaskGroup}"/> object.
        /// </summary>
        /// <param name="outlookTaskGroupToUpdate">The OutlookTaskGroup to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{OutlookTaskGroup}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OutlookTaskGroup>> UpdateResponseAsync(OutlookTaskGroup outlookTaskGroupToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified OutlookTaskGroup using PUT.
        /// </summary>
        /// <param name="outlookTaskGroupToUpdate">The OutlookTaskGroup object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<OutlookTaskGroup> PutAsync(OutlookTaskGroup outlookTaskGroupToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified OutlookTaskGroup using PUT and returns a <see cref="GraphResponse{OutlookTaskGroup}"/> object.
        /// </summary>
        /// <param name="outlookTaskGroupToUpdate">The OutlookTaskGroup object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{OutlookTaskGroup}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<OutlookTaskGroup>> PutResponseAsync(OutlookTaskGroup outlookTaskGroupToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOutlookTaskGroupRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOutlookTaskGroupRequest Expand(Expression<Func<OutlookTaskGroup, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOutlookTaskGroupRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOutlookTaskGroupRequest Select(Expression<Func<OutlookTaskGroup, object>> selectExpression);

    }
}
