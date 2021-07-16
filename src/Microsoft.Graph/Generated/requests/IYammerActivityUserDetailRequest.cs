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
    /// The interface IYammerActivityUserDetailRequest.
    /// </summary>
    public partial interface IYammerActivityUserDetailRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified YammerActivityUserDetail using POST.
        /// </summary>
        /// <param name="yammerActivityUserDetailToCreate">The YammerActivityUserDetail to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created YammerActivityUserDetail.</returns>
        System.Threading.Tasks.Task<YammerActivityUserDetail> CreateAsync(YammerActivityUserDetail yammerActivityUserDetailToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified YammerActivityUserDetail using POST and returns a <see cref="GraphResponse{YammerActivityUserDetail}"/> object.
        /// </summary>
        /// <param name="yammerActivityUserDetailToCreate">The YammerActivityUserDetail to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{YammerActivityUserDetail}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<YammerActivityUserDetail>> CreateResponseAsync(YammerActivityUserDetail yammerActivityUserDetailToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified YammerActivityUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified YammerActivityUserDetail and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified YammerActivityUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The YammerActivityUserDetail.</returns>
        System.Threading.Tasks.Task<YammerActivityUserDetail> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified YammerActivityUserDetail and returns a <see cref="GraphResponse{YammerActivityUserDetail}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{YammerActivityUserDetail}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<YammerActivityUserDetail>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified YammerActivityUserDetail using PATCH.
        /// </summary>
        /// <param name="yammerActivityUserDetailToUpdate">The YammerActivityUserDetail to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated YammerActivityUserDetail.</returns>
        System.Threading.Tasks.Task<YammerActivityUserDetail> UpdateAsync(YammerActivityUserDetail yammerActivityUserDetailToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified YammerActivityUserDetail using PATCH and returns a <see cref="GraphResponse{YammerActivityUserDetail}"/> object.
        /// </summary>
        /// <param name="yammerActivityUserDetailToUpdate">The YammerActivityUserDetail to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{YammerActivityUserDetail}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<YammerActivityUserDetail>> UpdateResponseAsync(YammerActivityUserDetail yammerActivityUserDetailToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified YammerActivityUserDetail using PUT.
        /// </summary>
        /// <param name="yammerActivityUserDetailToUpdate">The YammerActivityUserDetail object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<YammerActivityUserDetail> PutAsync(YammerActivityUserDetail yammerActivityUserDetailToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified YammerActivityUserDetail using PUT and returns a <see cref="GraphResponse{YammerActivityUserDetail}"/> object.
        /// </summary>
        /// <param name="yammerActivityUserDetailToUpdate">The YammerActivityUserDetail object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{YammerActivityUserDetail}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<YammerActivityUserDetail>> PutResponseAsync(YammerActivityUserDetail yammerActivityUserDetailToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IYammerActivityUserDetailRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IYammerActivityUserDetailRequest Expand(Expression<Func<YammerActivityUserDetail, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IYammerActivityUserDetailRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IYammerActivityUserDetailRequest Select(Expression<Func<YammerActivityUserDetail, object>> selectExpression);

    }
}
