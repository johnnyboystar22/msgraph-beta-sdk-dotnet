// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph.Networkaccess
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ILogsRequest.
    /// </summary>
    public partial interface ILogsRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified Logs using POST.
        /// </summary>
        /// <param name="logsToCreate">The Logs to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Logs.</returns>
        System.Threading.Tasks.Task<Logs> CreateAsync(Logs logsToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified Logs using POST and returns a <see cref="GraphResponse{Logs}"/> object.
        /// </summary>
        /// <param name="logsToCreate">The Logs to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Logs}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Logs>> CreateResponseAsync(Logs logsToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Logs.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Logs and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Logs.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Logs.</returns>
        System.Threading.Tasks.Task<Logs> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Logs and returns a <see cref="GraphResponse{Logs}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Logs}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Logs>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Logs using PATCH.
        /// </summary>
        /// <param name="logsToUpdate">The Logs to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Logs.</returns>
        System.Threading.Tasks.Task<Logs> UpdateAsync(Logs logsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Logs using PATCH and returns a <see cref="GraphResponse{Logs}"/> object.
        /// </summary>
        /// <param name="logsToUpdate">The Logs to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Logs}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Logs>> UpdateResponseAsync(Logs logsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Logs using PUT.
        /// </summary>
        /// <param name="logsToUpdate">The Logs object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<Logs> PutAsync(Logs logsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Logs using PUT and returns a <see cref="GraphResponse{Logs}"/> object.
        /// </summary>
        /// <param name="logsToUpdate">The Logs object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{Logs}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<Logs>> PutResponseAsync(Logs logsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ILogsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ILogsRequest Expand(Expression<Func<Logs, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ILogsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ILogsRequest Select(Expression<Func<Logs, object>> selectExpression);

    }
}
