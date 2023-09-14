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
    /// The interface IServicePrincipalSignInActivityRequest.
    /// </summary>
    public partial interface IServicePrincipalSignInActivityRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ServicePrincipalSignInActivity using POST.
        /// </summary>
        /// <param name="servicePrincipalSignInActivityToCreate">The ServicePrincipalSignInActivity to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ServicePrincipalSignInActivity.</returns>
        System.Threading.Tasks.Task<ServicePrincipalSignInActivity> CreateAsync(ServicePrincipalSignInActivity servicePrincipalSignInActivityToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified ServicePrincipalSignInActivity using POST and returns a <see cref="GraphResponse{ServicePrincipalSignInActivity}"/> object.
        /// </summary>
        /// <param name="servicePrincipalSignInActivityToCreate">The ServicePrincipalSignInActivity to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ServicePrincipalSignInActivity}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ServicePrincipalSignInActivity>> CreateResponseAsync(ServicePrincipalSignInActivity servicePrincipalSignInActivityToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ServicePrincipalSignInActivity.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ServicePrincipalSignInActivity and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ServicePrincipalSignInActivity.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ServicePrincipalSignInActivity.</returns>
        System.Threading.Tasks.Task<ServicePrincipalSignInActivity> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ServicePrincipalSignInActivity and returns a <see cref="GraphResponse{ServicePrincipalSignInActivity}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ServicePrincipalSignInActivity}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ServicePrincipalSignInActivity>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ServicePrincipalSignInActivity using PATCH.
        /// </summary>
        /// <param name="servicePrincipalSignInActivityToUpdate">The ServicePrincipalSignInActivity to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ServicePrincipalSignInActivity.</returns>
        System.Threading.Tasks.Task<ServicePrincipalSignInActivity> UpdateAsync(ServicePrincipalSignInActivity servicePrincipalSignInActivityToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ServicePrincipalSignInActivity using PATCH and returns a <see cref="GraphResponse{ServicePrincipalSignInActivity}"/> object.
        /// </summary>
        /// <param name="servicePrincipalSignInActivityToUpdate">The ServicePrincipalSignInActivity to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ServicePrincipalSignInActivity}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ServicePrincipalSignInActivity>> UpdateResponseAsync(ServicePrincipalSignInActivity servicePrincipalSignInActivityToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ServicePrincipalSignInActivity using PUT.
        /// </summary>
        /// <param name="servicePrincipalSignInActivityToUpdate">The ServicePrincipalSignInActivity object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ServicePrincipalSignInActivity> PutAsync(ServicePrincipalSignInActivity servicePrincipalSignInActivityToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ServicePrincipalSignInActivity using PUT and returns a <see cref="GraphResponse{ServicePrincipalSignInActivity}"/> object.
        /// </summary>
        /// <param name="servicePrincipalSignInActivityToUpdate">The ServicePrincipalSignInActivity object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ServicePrincipalSignInActivity}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ServicePrincipalSignInActivity>> PutResponseAsync(ServicePrincipalSignInActivity servicePrincipalSignInActivityToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IServicePrincipalSignInActivityRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IServicePrincipalSignInActivityRequest Expand(Expression<Func<ServicePrincipalSignInActivity, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IServicePrincipalSignInActivityRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IServicePrincipalSignInActivityRequest Select(Expression<Func<ServicePrincipalSignInActivity, object>> selectExpression);

    }
}
