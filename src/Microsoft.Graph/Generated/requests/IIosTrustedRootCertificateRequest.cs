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
    /// The interface IIosTrustedRootCertificateRequest.
    /// </summary>
    public partial interface IIosTrustedRootCertificateRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IosTrustedRootCertificate using POST.
        /// </summary>
        /// <param name="iosTrustedRootCertificateToCreate">The IosTrustedRootCertificate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<IosTrustedRootCertificate> CreateAsync(IosTrustedRootCertificate iosTrustedRootCertificateToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified IosTrustedRootCertificate using POST and returns a <see cref="GraphResponse{IosTrustedRootCertificate}"/> object.
        /// </summary>
        /// <param name="iosTrustedRootCertificateToCreate">The IosTrustedRootCertificate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosTrustedRootCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosTrustedRootCertificate>> CreateResponseAsync(IosTrustedRootCertificate iosTrustedRootCertificateToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified IosTrustedRootCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified IosTrustedRootCertificate and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified IosTrustedRootCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<IosTrustedRootCertificate> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified IosTrustedRootCertificate and returns a <see cref="GraphResponse{IosTrustedRootCertificate}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosTrustedRootCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosTrustedRootCertificate>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IosTrustedRootCertificate using PATCH.
        /// </summary>
        /// <param name="iosTrustedRootCertificateToUpdate">The IosTrustedRootCertificate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<IosTrustedRootCertificate> UpdateAsync(IosTrustedRootCertificate iosTrustedRootCertificateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IosTrustedRootCertificate using PATCH and returns a <see cref="GraphResponse{IosTrustedRootCertificate}"/> object.
        /// </summary>
        /// <param name="iosTrustedRootCertificateToUpdate">The IosTrustedRootCertificate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IosTrustedRootCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosTrustedRootCertificate>> UpdateResponseAsync(IosTrustedRootCertificate iosTrustedRootCertificateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IosTrustedRootCertificate using PUT.
        /// </summary>
        /// <param name="iosTrustedRootCertificateToUpdate">The IosTrustedRootCertificate object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<IosTrustedRootCertificate> PutAsync(IosTrustedRootCertificate iosTrustedRootCertificateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IosTrustedRootCertificate using PUT and returns a <see cref="GraphResponse{IosTrustedRootCertificate}"/> object.
        /// </summary>
        /// <param name="iosTrustedRootCertificateToUpdate">The IosTrustedRootCertificate object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{IosTrustedRootCertificate}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosTrustedRootCertificate>> PutResponseAsync(IosTrustedRootCertificate iosTrustedRootCertificateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosTrustedRootCertificateRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosTrustedRootCertificateRequest Expand(Expression<Func<IosTrustedRootCertificate, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIosTrustedRootCertificateRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIosTrustedRootCertificateRequest Select(Expression<Func<IosTrustedRootCertificate, object>> selectExpression);

    }
}
