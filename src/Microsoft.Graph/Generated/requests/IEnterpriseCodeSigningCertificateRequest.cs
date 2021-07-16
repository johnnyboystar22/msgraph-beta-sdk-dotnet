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
    /// The interface IEnterpriseCodeSigningCertificateRequest.
    /// </summary>
    public partial interface IEnterpriseCodeSigningCertificateRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EnterpriseCodeSigningCertificate using POST.
        /// </summary>
        /// <param name="enterpriseCodeSigningCertificateToCreate">The EnterpriseCodeSigningCertificate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EnterpriseCodeSigningCertificate.</returns>
        System.Threading.Tasks.Task<EnterpriseCodeSigningCertificate> CreateAsync(EnterpriseCodeSigningCertificate enterpriseCodeSigningCertificateToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified EnterpriseCodeSigningCertificate using POST and returns a <see cref="GraphResponse{EnterpriseCodeSigningCertificate}"/> object.
        /// </summary>
        /// <param name="enterpriseCodeSigningCertificateToCreate">The EnterpriseCodeSigningCertificate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EnterpriseCodeSigningCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EnterpriseCodeSigningCertificate>> CreateResponseAsync(EnterpriseCodeSigningCertificate enterpriseCodeSigningCertificateToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified EnterpriseCodeSigningCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified EnterpriseCodeSigningCertificate and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified EnterpriseCodeSigningCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EnterpriseCodeSigningCertificate.</returns>
        System.Threading.Tasks.Task<EnterpriseCodeSigningCertificate> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified EnterpriseCodeSigningCertificate and returns a <see cref="GraphResponse{EnterpriseCodeSigningCertificate}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EnterpriseCodeSigningCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EnterpriseCodeSigningCertificate>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EnterpriseCodeSigningCertificate using PATCH.
        /// </summary>
        /// <param name="enterpriseCodeSigningCertificateToUpdate">The EnterpriseCodeSigningCertificate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EnterpriseCodeSigningCertificate.</returns>
        System.Threading.Tasks.Task<EnterpriseCodeSigningCertificate> UpdateAsync(EnterpriseCodeSigningCertificate enterpriseCodeSigningCertificateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EnterpriseCodeSigningCertificate using PATCH and returns a <see cref="GraphResponse{EnterpriseCodeSigningCertificate}"/> object.
        /// </summary>
        /// <param name="enterpriseCodeSigningCertificateToUpdate">The EnterpriseCodeSigningCertificate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EnterpriseCodeSigningCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EnterpriseCodeSigningCertificate>> UpdateResponseAsync(EnterpriseCodeSigningCertificate enterpriseCodeSigningCertificateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EnterpriseCodeSigningCertificate using PUT.
        /// </summary>
        /// <param name="enterpriseCodeSigningCertificateToUpdate">The EnterpriseCodeSigningCertificate object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<EnterpriseCodeSigningCertificate> PutAsync(EnterpriseCodeSigningCertificate enterpriseCodeSigningCertificateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EnterpriseCodeSigningCertificate using PUT and returns a <see cref="GraphResponse{EnterpriseCodeSigningCertificate}"/> object.
        /// </summary>
        /// <param name="enterpriseCodeSigningCertificateToUpdate">The EnterpriseCodeSigningCertificate object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{EnterpriseCodeSigningCertificate}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<EnterpriseCodeSigningCertificate>> PutResponseAsync(EnterpriseCodeSigningCertificate enterpriseCodeSigningCertificateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEnterpriseCodeSigningCertificateRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEnterpriseCodeSigningCertificateRequest Expand(Expression<Func<EnterpriseCodeSigningCertificate, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEnterpriseCodeSigningCertificateRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEnterpriseCodeSigningCertificateRequest Select(Expression<Func<EnterpriseCodeSigningCertificate, object>> selectExpression);

    }
}
