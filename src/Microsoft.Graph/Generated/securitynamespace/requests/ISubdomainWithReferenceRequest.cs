// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ISubdomainWithReferenceRequest.
    /// </summary>
    public partial interface ISubdomainWithReferenceRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Gets the specified Subdomain.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Subdomain.</returns>
        System.Threading.Tasks.Task<Subdomain> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Subdomain and returns a <see cref="GraphResponse{Subdomain}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Subdomain}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Subdomain>> GetResponseAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified Subdomain using POST.
        /// </summary>
        /// <param name="subdomainToCreate">The Subdomain to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Subdomain.</returns>
        System.Threading.Tasks.Task<Subdomain> CreateAsync(Subdomain subdomainToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified Subdomain using POST and returns a <see cref="GraphResponse{Subdomain}"/> object.
        /// </summary>
        /// <param name="subdomainToCreate">The Subdomain to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Subdomain}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Subdomain>> CreateResponseAsync(Subdomain subdomainToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified Subdomain using PATCH.
        /// </summary>
        /// <param name="subdomainToUpdate">The Subdomain to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Subdomain.</returns>
        System.Threading.Tasks.Task<Subdomain> UpdateAsync(Subdomain subdomainToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified Subdomain using PATCH and returns a <see cref="GraphResponse{Subdomain}"/> object.
        /// </summary>
        /// <param name="subdomainToUpdate">The Subdomain to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Subdomain}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Subdomain>> UpdateResponseAsync(Subdomain subdomainToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified Subdomain.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified Subdomain and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISubdomainWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISubdomainWithReferenceRequest Expand(Expression<Func<Subdomain, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISubdomainWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISubdomainWithReferenceRequest Select(Expression<Func<Subdomain, object>> selectExpression);

    }
}
