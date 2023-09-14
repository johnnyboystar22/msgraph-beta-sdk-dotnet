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
    /// The interface ICertificateAuthorityAsEntityRequest.
    /// </summary>
    public partial interface ICertificateAuthorityAsEntityRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified CertificateAuthorityAsEntity using POST.
        /// </summary>
        /// <param name="certificateAuthorityAsEntityToCreate">The CertificateAuthorityAsEntity to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CertificateAuthorityAsEntity.</returns>
        System.Threading.Tasks.Task<CertificateAuthorityAsEntity> CreateAsync(CertificateAuthorityAsEntity certificateAuthorityAsEntityToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified CertificateAuthorityAsEntity using POST and returns a <see cref="GraphResponse{CertificateAuthorityAsEntity}"/> object.
        /// </summary>
        /// <param name="certificateAuthorityAsEntityToCreate">The CertificateAuthorityAsEntity to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CertificateAuthorityAsEntity}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CertificateAuthorityAsEntity>> CreateResponseAsync(CertificateAuthorityAsEntity certificateAuthorityAsEntityToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified CertificateAuthorityAsEntity.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified CertificateAuthorityAsEntity and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified CertificateAuthorityAsEntity.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CertificateAuthorityAsEntity.</returns>
        System.Threading.Tasks.Task<CertificateAuthorityAsEntity> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified CertificateAuthorityAsEntity and returns a <see cref="GraphResponse{CertificateAuthorityAsEntity}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CertificateAuthorityAsEntity}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CertificateAuthorityAsEntity>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CertificateAuthorityAsEntity using PATCH.
        /// </summary>
        /// <param name="certificateAuthorityAsEntityToUpdate">The CertificateAuthorityAsEntity to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CertificateAuthorityAsEntity.</returns>
        System.Threading.Tasks.Task<CertificateAuthorityAsEntity> UpdateAsync(CertificateAuthorityAsEntity certificateAuthorityAsEntityToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CertificateAuthorityAsEntity using PATCH and returns a <see cref="GraphResponse{CertificateAuthorityAsEntity}"/> object.
        /// </summary>
        /// <param name="certificateAuthorityAsEntityToUpdate">The CertificateAuthorityAsEntity to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{CertificateAuthorityAsEntity}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CertificateAuthorityAsEntity>> UpdateResponseAsync(CertificateAuthorityAsEntity certificateAuthorityAsEntityToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CertificateAuthorityAsEntity using PUT.
        /// </summary>
        /// <param name="certificateAuthorityAsEntityToUpdate">The CertificateAuthorityAsEntity object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<CertificateAuthorityAsEntity> PutAsync(CertificateAuthorityAsEntity certificateAuthorityAsEntityToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CertificateAuthorityAsEntity using PUT and returns a <see cref="GraphResponse{CertificateAuthorityAsEntity}"/> object.
        /// </summary>
        /// <param name="certificateAuthorityAsEntityToUpdate">The CertificateAuthorityAsEntity object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{CertificateAuthorityAsEntity}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<CertificateAuthorityAsEntity>> PutResponseAsync(CertificateAuthorityAsEntity certificateAuthorityAsEntityToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICertificateAuthorityAsEntityRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICertificateAuthorityAsEntityRequest Expand(Expression<Func<CertificateAuthorityAsEntity, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICertificateAuthorityAsEntityRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICertificateAuthorityAsEntityRequest Select(Expression<Func<CertificateAuthorityAsEntity, object>> selectExpression);

    }
}
