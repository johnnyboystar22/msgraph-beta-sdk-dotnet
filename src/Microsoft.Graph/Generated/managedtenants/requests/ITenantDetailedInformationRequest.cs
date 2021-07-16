// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ITenantDetailedInformationRequest.
    /// </summary>
    public partial interface ITenantDetailedInformationRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified TenantDetailedInformation using POST.
        /// </summary>
        /// <param name="tenantDetailedInformationToCreate">The TenantDetailedInformation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TenantDetailedInformation.</returns>
        System.Threading.Tasks.Task<TenantDetailedInformation> CreateAsync(TenantDetailedInformation tenantDetailedInformationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified TenantDetailedInformation using POST and returns a <see cref="GraphResponse{TenantDetailedInformation}"/> object.
        /// </summary>
        /// <param name="tenantDetailedInformationToCreate">The TenantDetailedInformation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TenantDetailedInformation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TenantDetailedInformation>> CreateResponseAsync(TenantDetailedInformation tenantDetailedInformationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified TenantDetailedInformation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified TenantDetailedInformation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified TenantDetailedInformation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TenantDetailedInformation.</returns>
        System.Threading.Tasks.Task<TenantDetailedInformation> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified TenantDetailedInformation and returns a <see cref="GraphResponse{TenantDetailedInformation}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TenantDetailedInformation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TenantDetailedInformation>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TenantDetailedInformation using PATCH.
        /// </summary>
        /// <param name="tenantDetailedInformationToUpdate">The TenantDetailedInformation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TenantDetailedInformation.</returns>
        System.Threading.Tasks.Task<TenantDetailedInformation> UpdateAsync(TenantDetailedInformation tenantDetailedInformationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TenantDetailedInformation using PATCH and returns a <see cref="GraphResponse{TenantDetailedInformation}"/> object.
        /// </summary>
        /// <param name="tenantDetailedInformationToUpdate">The TenantDetailedInformation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TenantDetailedInformation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TenantDetailedInformation>> UpdateResponseAsync(TenantDetailedInformation tenantDetailedInformationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TenantDetailedInformation using PUT.
        /// </summary>
        /// <param name="tenantDetailedInformationToUpdate">The TenantDetailedInformation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<TenantDetailedInformation> PutAsync(TenantDetailedInformation tenantDetailedInformationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TenantDetailedInformation using PUT and returns a <see cref="GraphResponse{TenantDetailedInformation}"/> object.
        /// </summary>
        /// <param name="tenantDetailedInformationToUpdate">The TenantDetailedInformation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{TenantDetailedInformation}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<TenantDetailedInformation>> PutResponseAsync(TenantDetailedInformation tenantDetailedInformationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITenantDetailedInformationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITenantDetailedInformationRequest Expand(Expression<Func<TenantDetailedInformation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITenantDetailedInformationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITenantDetailedInformationRequest Select(Expression<Func<TenantDetailedInformation, object>> selectExpression);

    }
}
