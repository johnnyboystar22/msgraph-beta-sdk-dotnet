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
    /// The interface IMailboxUsageDetailRequest.
    /// </summary>
    public partial interface IMailboxUsageDetailRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MailboxUsageDetail using POST.
        /// </summary>
        /// <param name="mailboxUsageDetailToCreate">The MailboxUsageDetail to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MailboxUsageDetail.</returns>
        System.Threading.Tasks.Task<MailboxUsageDetail> CreateAsync(MailboxUsageDetail mailboxUsageDetailToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified MailboxUsageDetail using POST and returns a <see cref="GraphResponse{MailboxUsageDetail}"/> object.
        /// </summary>
        /// <param name="mailboxUsageDetailToCreate">The MailboxUsageDetail to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MailboxUsageDetail}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MailboxUsageDetail>> CreateResponseAsync(MailboxUsageDetail mailboxUsageDetailToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified MailboxUsageDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified MailboxUsageDetail and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified MailboxUsageDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MailboxUsageDetail.</returns>
        System.Threading.Tasks.Task<MailboxUsageDetail> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified MailboxUsageDetail and returns a <see cref="GraphResponse{MailboxUsageDetail}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MailboxUsageDetail}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MailboxUsageDetail>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MailboxUsageDetail using PATCH.
        /// </summary>
        /// <param name="mailboxUsageDetailToUpdate">The MailboxUsageDetail to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MailboxUsageDetail.</returns>
        System.Threading.Tasks.Task<MailboxUsageDetail> UpdateAsync(MailboxUsageDetail mailboxUsageDetailToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MailboxUsageDetail using PATCH and returns a <see cref="GraphResponse{MailboxUsageDetail}"/> object.
        /// </summary>
        /// <param name="mailboxUsageDetailToUpdate">The MailboxUsageDetail to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MailboxUsageDetail}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MailboxUsageDetail>> UpdateResponseAsync(MailboxUsageDetail mailboxUsageDetailToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MailboxUsageDetail using PUT.
        /// </summary>
        /// <param name="mailboxUsageDetailToUpdate">The MailboxUsageDetail object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<MailboxUsageDetail> PutAsync(MailboxUsageDetail mailboxUsageDetailToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MailboxUsageDetail using PUT and returns a <see cref="GraphResponse{MailboxUsageDetail}"/> object.
        /// </summary>
        /// <param name="mailboxUsageDetailToUpdate">The MailboxUsageDetail object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{MailboxUsageDetail}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<MailboxUsageDetail>> PutResponseAsync(MailboxUsageDetail mailboxUsageDetailToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMailboxUsageDetailRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMailboxUsageDetailRequest Expand(Expression<Func<MailboxUsageDetail, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMailboxUsageDetailRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMailboxUsageDetailRequest Select(Expression<Func<MailboxUsageDetail, object>> selectExpression);

    }
}
