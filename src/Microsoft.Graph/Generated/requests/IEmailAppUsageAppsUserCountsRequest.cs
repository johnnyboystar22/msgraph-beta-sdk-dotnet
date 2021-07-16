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
    /// The interface IEmailAppUsageAppsUserCountsRequest.
    /// </summary>
    public partial interface IEmailAppUsageAppsUserCountsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EmailAppUsageAppsUserCounts using POST.
        /// </summary>
        /// <param name="emailAppUsageAppsUserCountsToCreate">The EmailAppUsageAppsUserCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EmailAppUsageAppsUserCounts.</returns>
        System.Threading.Tasks.Task<EmailAppUsageAppsUserCounts> CreateAsync(EmailAppUsageAppsUserCounts emailAppUsageAppsUserCountsToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified EmailAppUsageAppsUserCounts using POST and returns a <see cref="GraphResponse{EmailAppUsageAppsUserCounts}"/> object.
        /// </summary>
        /// <param name="emailAppUsageAppsUserCountsToCreate">The EmailAppUsageAppsUserCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EmailAppUsageAppsUserCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EmailAppUsageAppsUserCounts>> CreateResponseAsync(EmailAppUsageAppsUserCounts emailAppUsageAppsUserCountsToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified EmailAppUsageAppsUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified EmailAppUsageAppsUserCounts and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified EmailAppUsageAppsUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EmailAppUsageAppsUserCounts.</returns>
        System.Threading.Tasks.Task<EmailAppUsageAppsUserCounts> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified EmailAppUsageAppsUserCounts and returns a <see cref="GraphResponse{EmailAppUsageAppsUserCounts}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EmailAppUsageAppsUserCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EmailAppUsageAppsUserCounts>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EmailAppUsageAppsUserCounts using PATCH.
        /// </summary>
        /// <param name="emailAppUsageAppsUserCountsToUpdate">The EmailAppUsageAppsUserCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EmailAppUsageAppsUserCounts.</returns>
        System.Threading.Tasks.Task<EmailAppUsageAppsUserCounts> UpdateAsync(EmailAppUsageAppsUserCounts emailAppUsageAppsUserCountsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EmailAppUsageAppsUserCounts using PATCH and returns a <see cref="GraphResponse{EmailAppUsageAppsUserCounts}"/> object.
        /// </summary>
        /// <param name="emailAppUsageAppsUserCountsToUpdate">The EmailAppUsageAppsUserCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EmailAppUsageAppsUserCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EmailAppUsageAppsUserCounts>> UpdateResponseAsync(EmailAppUsageAppsUserCounts emailAppUsageAppsUserCountsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EmailAppUsageAppsUserCounts using PUT.
        /// </summary>
        /// <param name="emailAppUsageAppsUserCountsToUpdate">The EmailAppUsageAppsUserCounts object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<EmailAppUsageAppsUserCounts> PutAsync(EmailAppUsageAppsUserCounts emailAppUsageAppsUserCountsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EmailAppUsageAppsUserCounts using PUT and returns a <see cref="GraphResponse{EmailAppUsageAppsUserCounts}"/> object.
        /// </summary>
        /// <param name="emailAppUsageAppsUserCountsToUpdate">The EmailAppUsageAppsUserCounts object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{EmailAppUsageAppsUserCounts}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<EmailAppUsageAppsUserCounts>> PutResponseAsync(EmailAppUsageAppsUserCounts emailAppUsageAppsUserCountsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEmailAppUsageAppsUserCountsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEmailAppUsageAppsUserCountsRequest Expand(Expression<Func<EmailAppUsageAppsUserCounts, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEmailAppUsageAppsUserCountsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEmailAppUsageAppsUserCountsRequest Select(Expression<Func<EmailAppUsageAppsUserCounts, object>> selectExpression);

    }
}
