// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDepMacOSEnrollmentProfileWithReferenceRequest.
    /// </summary>
    public partial interface IDepMacOSEnrollmentProfileWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified DepMacOSEnrollmentProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DepMacOSEnrollmentProfile.</returns>
        System.Threading.Tasks.Task<DepMacOSEnrollmentProfile> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DepMacOSEnrollmentProfile and returns a <see cref="GraphResponse{DepMacOSEnrollmentProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DepMacOSEnrollmentProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DepMacOSEnrollmentProfile>> GetResponseAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified DepMacOSEnrollmentProfile using POST.
        /// </summary>
        /// <param name="depMacOSEnrollmentProfileToCreate">The DepMacOSEnrollmentProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DepMacOSEnrollmentProfile.</returns>
        System.Threading.Tasks.Task<DepMacOSEnrollmentProfile> CreateAsync(DepMacOSEnrollmentProfile depMacOSEnrollmentProfileToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified DepMacOSEnrollmentProfile using POST and returns a <see cref="GraphResponse{DepMacOSEnrollmentProfile}"/> object.
        /// </summary>
        /// <param name="depMacOSEnrollmentProfileToCreate">The DepMacOSEnrollmentProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DepMacOSEnrollmentProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DepMacOSEnrollmentProfile>> CreateResponseAsync(DepMacOSEnrollmentProfile depMacOSEnrollmentProfileToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified DepMacOSEnrollmentProfile using PATCH.
        /// </summary>
        /// <param name="depMacOSEnrollmentProfileToUpdate">The DepMacOSEnrollmentProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DepMacOSEnrollmentProfile.</returns>
        System.Threading.Tasks.Task<DepMacOSEnrollmentProfile> UpdateAsync(DepMacOSEnrollmentProfile depMacOSEnrollmentProfileToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified DepMacOSEnrollmentProfile using PATCH and returns a <see cref="GraphResponse{DepMacOSEnrollmentProfile}"/> object.
        /// </summary>
        /// <param name="depMacOSEnrollmentProfileToUpdate">The DepMacOSEnrollmentProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DepMacOSEnrollmentProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DepMacOSEnrollmentProfile>> UpdateResponseAsync(DepMacOSEnrollmentProfile depMacOSEnrollmentProfileToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified DepMacOSEnrollmentProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified DepMacOSEnrollmentProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDepMacOSEnrollmentProfileWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDepMacOSEnrollmentProfileWithReferenceRequest Expand(Expression<Func<DepMacOSEnrollmentProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDepMacOSEnrollmentProfileWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDepMacOSEnrollmentProfileWithReferenceRequest Select(Expression<Func<DepMacOSEnrollmentProfile, object>> selectExpression);

    }
}
