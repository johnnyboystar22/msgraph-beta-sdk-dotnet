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
    /// The interface ISkypeForBusinessActivityUserCountsRequest.
    /// </summary>
    public partial interface ISkypeForBusinessActivityUserCountsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SkypeForBusinessActivityUserCounts using POST.
        /// </summary>
        /// <param name="skypeForBusinessActivityUserCountsToCreate">The SkypeForBusinessActivityUserCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SkypeForBusinessActivityUserCounts.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessActivityUserCounts> CreateAsync(SkypeForBusinessActivityUserCounts skypeForBusinessActivityUserCountsToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified SkypeForBusinessActivityUserCounts using POST and returns a <see cref="GraphResponse{SkypeForBusinessActivityUserCounts}"/> object.
        /// </summary>
        /// <param name="skypeForBusinessActivityUserCountsToCreate">The SkypeForBusinessActivityUserCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessActivityUserCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessActivityUserCounts>> CreateResponseAsync(SkypeForBusinessActivityUserCounts skypeForBusinessActivityUserCountsToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified SkypeForBusinessActivityUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified SkypeForBusinessActivityUserCounts and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified SkypeForBusinessActivityUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SkypeForBusinessActivityUserCounts.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessActivityUserCounts> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified SkypeForBusinessActivityUserCounts and returns a <see cref="GraphResponse{SkypeForBusinessActivityUserCounts}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessActivityUserCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessActivityUserCounts>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SkypeForBusinessActivityUserCounts using PATCH.
        /// </summary>
        /// <param name="skypeForBusinessActivityUserCountsToUpdate">The SkypeForBusinessActivityUserCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SkypeForBusinessActivityUserCounts.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessActivityUserCounts> UpdateAsync(SkypeForBusinessActivityUserCounts skypeForBusinessActivityUserCountsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SkypeForBusinessActivityUserCounts using PATCH and returns a <see cref="GraphResponse{SkypeForBusinessActivityUserCounts}"/> object.
        /// </summary>
        /// <param name="skypeForBusinessActivityUserCountsToUpdate">The SkypeForBusinessActivityUserCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessActivityUserCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessActivityUserCounts>> UpdateResponseAsync(SkypeForBusinessActivityUserCounts skypeForBusinessActivityUserCountsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SkypeForBusinessActivityUserCounts using PUT.
        /// </summary>
        /// <param name="skypeForBusinessActivityUserCountsToUpdate">The SkypeForBusinessActivityUserCounts object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessActivityUserCounts> PutAsync(SkypeForBusinessActivityUserCounts skypeForBusinessActivityUserCountsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SkypeForBusinessActivityUserCounts using PUT and returns a <see cref="GraphResponse{SkypeForBusinessActivityUserCounts}"/> object.
        /// </summary>
        /// <param name="skypeForBusinessActivityUserCountsToUpdate">The SkypeForBusinessActivityUserCounts object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{SkypeForBusinessActivityUserCounts}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessActivityUserCounts>> PutResponseAsync(SkypeForBusinessActivityUserCounts skypeForBusinessActivityUserCountsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessActivityUserCountsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessActivityUserCountsRequest Expand(Expression<Func<SkypeForBusinessActivityUserCounts, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessActivityUserCountsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessActivityUserCountsRequest Select(Expression<Func<SkypeForBusinessActivityUserCounts, object>> selectExpression);

    }
}
