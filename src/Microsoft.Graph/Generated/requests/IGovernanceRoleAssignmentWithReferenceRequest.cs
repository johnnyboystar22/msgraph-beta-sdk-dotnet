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
    /// The interface IGovernanceRoleAssignmentWithReferenceRequest.
    /// </summary>
    public partial interface IGovernanceRoleAssignmentWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified GovernanceRoleAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GovernanceRoleAssignment.</returns>
        System.Threading.Tasks.Task<GovernanceRoleAssignment> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified GovernanceRoleAssignment and returns a <see cref="GraphResponse{GovernanceRoleAssignment}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GovernanceRoleAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GovernanceRoleAssignment>> GetResponseAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified GovernanceRoleAssignment using POST.
        /// </summary>
        /// <param name="governanceRoleAssignmentToCreate">The GovernanceRoleAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GovernanceRoleAssignment.</returns>
        System.Threading.Tasks.Task<GovernanceRoleAssignment> CreateAsync(GovernanceRoleAssignment governanceRoleAssignmentToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified GovernanceRoleAssignment using POST and returns a <see cref="GraphResponse{GovernanceRoleAssignment}"/> object.
        /// </summary>
        /// <param name="governanceRoleAssignmentToCreate">The GovernanceRoleAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GovernanceRoleAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GovernanceRoleAssignment>> CreateResponseAsync(GovernanceRoleAssignment governanceRoleAssignmentToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified GovernanceRoleAssignment using PATCH.
        /// </summary>
        /// <param name="governanceRoleAssignmentToUpdate">The GovernanceRoleAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GovernanceRoleAssignment.</returns>
        System.Threading.Tasks.Task<GovernanceRoleAssignment> UpdateAsync(GovernanceRoleAssignment governanceRoleAssignmentToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified GovernanceRoleAssignment using PATCH and returns a <see cref="GraphResponse{GovernanceRoleAssignment}"/> object.
        /// </summary>
        /// <param name="governanceRoleAssignmentToUpdate">The GovernanceRoleAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{GovernanceRoleAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GovernanceRoleAssignment>> UpdateResponseAsync(GovernanceRoleAssignment governanceRoleAssignmentToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified GovernanceRoleAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified GovernanceRoleAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IGovernanceRoleAssignmentWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IGovernanceRoleAssignmentWithReferenceRequest Expand(Expression<Func<GovernanceRoleAssignment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IGovernanceRoleAssignmentWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IGovernanceRoleAssignmentWithReferenceRequest Select(Expression<Func<GovernanceRoleAssignment, object>> selectExpression);

    }
}
