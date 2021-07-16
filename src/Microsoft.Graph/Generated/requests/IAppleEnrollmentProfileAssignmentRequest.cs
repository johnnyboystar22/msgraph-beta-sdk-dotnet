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
    /// The interface IAppleEnrollmentProfileAssignmentRequest.
    /// </summary>
    public partial interface IAppleEnrollmentProfileAssignmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AppleEnrollmentProfileAssignment using POST.
        /// </summary>
        /// <param name="appleEnrollmentProfileAssignmentToCreate">The AppleEnrollmentProfileAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AppleEnrollmentProfileAssignment.</returns>
        System.Threading.Tasks.Task<AppleEnrollmentProfileAssignment> CreateAsync(AppleEnrollmentProfileAssignment appleEnrollmentProfileAssignmentToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified AppleEnrollmentProfileAssignment using POST and returns a <see cref="GraphResponse{AppleEnrollmentProfileAssignment}"/> object.
        /// </summary>
        /// <param name="appleEnrollmentProfileAssignmentToCreate">The AppleEnrollmentProfileAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AppleEnrollmentProfileAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AppleEnrollmentProfileAssignment>> CreateResponseAsync(AppleEnrollmentProfileAssignment appleEnrollmentProfileAssignmentToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AppleEnrollmentProfileAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AppleEnrollmentProfileAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AppleEnrollmentProfileAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AppleEnrollmentProfileAssignment.</returns>
        System.Threading.Tasks.Task<AppleEnrollmentProfileAssignment> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AppleEnrollmentProfileAssignment and returns a <see cref="GraphResponse{AppleEnrollmentProfileAssignment}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AppleEnrollmentProfileAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AppleEnrollmentProfileAssignment>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AppleEnrollmentProfileAssignment using PATCH.
        /// </summary>
        /// <param name="appleEnrollmentProfileAssignmentToUpdate">The AppleEnrollmentProfileAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AppleEnrollmentProfileAssignment.</returns>
        System.Threading.Tasks.Task<AppleEnrollmentProfileAssignment> UpdateAsync(AppleEnrollmentProfileAssignment appleEnrollmentProfileAssignmentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AppleEnrollmentProfileAssignment using PATCH and returns a <see cref="GraphResponse{AppleEnrollmentProfileAssignment}"/> object.
        /// </summary>
        /// <param name="appleEnrollmentProfileAssignmentToUpdate">The AppleEnrollmentProfileAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AppleEnrollmentProfileAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AppleEnrollmentProfileAssignment>> UpdateResponseAsync(AppleEnrollmentProfileAssignment appleEnrollmentProfileAssignmentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AppleEnrollmentProfileAssignment using PUT.
        /// </summary>
        /// <param name="appleEnrollmentProfileAssignmentToUpdate">The AppleEnrollmentProfileAssignment object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<AppleEnrollmentProfileAssignment> PutAsync(AppleEnrollmentProfileAssignment appleEnrollmentProfileAssignmentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AppleEnrollmentProfileAssignment using PUT and returns a <see cref="GraphResponse{AppleEnrollmentProfileAssignment}"/> object.
        /// </summary>
        /// <param name="appleEnrollmentProfileAssignmentToUpdate">The AppleEnrollmentProfileAssignment object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{AppleEnrollmentProfileAssignment}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<AppleEnrollmentProfileAssignment>> PutResponseAsync(AppleEnrollmentProfileAssignment appleEnrollmentProfileAssignmentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAppleEnrollmentProfileAssignmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAppleEnrollmentProfileAssignmentRequest Expand(Expression<Func<AppleEnrollmentProfileAssignment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAppleEnrollmentProfileAssignmentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAppleEnrollmentProfileAssignmentRequest Select(Expression<Func<AppleEnrollmentProfileAssignment, object>> selectExpression);

    }
}
