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
    /// The interface IEmailAppUsageUserDetailRequest.
    /// </summary>
    public partial interface IEmailAppUsageUserDetailRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EmailAppUsageUserDetail using POST.
        /// </summary>
        /// <param name="emailAppUsageUserDetailToCreate">The EmailAppUsageUserDetail to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EmailAppUsageUserDetail.</returns>
        System.Threading.Tasks.Task<EmailAppUsageUserDetail> CreateAsync(EmailAppUsageUserDetail emailAppUsageUserDetailToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified EmailAppUsageUserDetail using POST and returns a <see cref="GraphResponse{EmailAppUsageUserDetail}"/> object.
        /// </summary>
        /// <param name="emailAppUsageUserDetailToCreate">The EmailAppUsageUserDetail to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EmailAppUsageUserDetail}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EmailAppUsageUserDetail>> CreateResponseAsync(EmailAppUsageUserDetail emailAppUsageUserDetailToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified EmailAppUsageUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified EmailAppUsageUserDetail and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified EmailAppUsageUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EmailAppUsageUserDetail.</returns>
        System.Threading.Tasks.Task<EmailAppUsageUserDetail> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified EmailAppUsageUserDetail and returns a <see cref="GraphResponse{EmailAppUsageUserDetail}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EmailAppUsageUserDetail}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EmailAppUsageUserDetail>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EmailAppUsageUserDetail using PATCH.
        /// </summary>
        /// <param name="emailAppUsageUserDetailToUpdate">The EmailAppUsageUserDetail to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EmailAppUsageUserDetail.</returns>
        System.Threading.Tasks.Task<EmailAppUsageUserDetail> UpdateAsync(EmailAppUsageUserDetail emailAppUsageUserDetailToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EmailAppUsageUserDetail using PATCH and returns a <see cref="GraphResponse{EmailAppUsageUserDetail}"/> object.
        /// </summary>
        /// <param name="emailAppUsageUserDetailToUpdate">The EmailAppUsageUserDetail to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EmailAppUsageUserDetail}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EmailAppUsageUserDetail>> UpdateResponseAsync(EmailAppUsageUserDetail emailAppUsageUserDetailToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EmailAppUsageUserDetail using PUT.
        /// </summary>
        /// <param name="emailAppUsageUserDetailToUpdate">The EmailAppUsageUserDetail object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<EmailAppUsageUserDetail> PutAsync(EmailAppUsageUserDetail emailAppUsageUserDetailToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EmailAppUsageUserDetail using PUT and returns a <see cref="GraphResponse{EmailAppUsageUserDetail}"/> object.
        /// </summary>
        /// <param name="emailAppUsageUserDetailToUpdate">The EmailAppUsageUserDetail object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{EmailAppUsageUserDetail}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<EmailAppUsageUserDetail>> PutResponseAsync(EmailAppUsageUserDetail emailAppUsageUserDetailToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEmailAppUsageUserDetailRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEmailAppUsageUserDetailRequest Expand(Expression<Func<EmailAppUsageUserDetail, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEmailAppUsageUserDetailRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEmailAppUsageUserDetailRequest Select(Expression<Func<EmailAppUsageUserDetail, object>> selectExpression);

    }
}
