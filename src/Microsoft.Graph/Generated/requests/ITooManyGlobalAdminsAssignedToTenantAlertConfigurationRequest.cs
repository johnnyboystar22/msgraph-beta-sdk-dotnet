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
    /// The interface ITooManyGlobalAdminsAssignedToTenantAlertConfigurationRequest.
    /// </summary>
    public partial interface ITooManyGlobalAdminsAssignedToTenantAlertConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TooManyGlobalAdminsAssignedToTenantAlertConfiguration using POST.
        /// </summary>
        /// <param name="tooManyGlobalAdminsAssignedToTenantAlertConfigurationToCreate">The TooManyGlobalAdminsAssignedToTenantAlertConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TooManyGlobalAdminsAssignedToTenantAlertConfiguration.</returns>
        System.Threading.Tasks.Task<TooManyGlobalAdminsAssignedToTenantAlertConfiguration> CreateAsync(TooManyGlobalAdminsAssignedToTenantAlertConfiguration tooManyGlobalAdminsAssignedToTenantAlertConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified TooManyGlobalAdminsAssignedToTenantAlertConfiguration using POST and returns a <see cref="GraphResponse{TooManyGlobalAdminsAssignedToTenantAlertConfiguration}"/> object.
        /// </summary>
        /// <param name="tooManyGlobalAdminsAssignedToTenantAlertConfigurationToCreate">The TooManyGlobalAdminsAssignedToTenantAlertConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TooManyGlobalAdminsAssignedToTenantAlertConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TooManyGlobalAdminsAssignedToTenantAlertConfiguration>> CreateResponseAsync(TooManyGlobalAdminsAssignedToTenantAlertConfiguration tooManyGlobalAdminsAssignedToTenantAlertConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified TooManyGlobalAdminsAssignedToTenantAlertConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified TooManyGlobalAdminsAssignedToTenantAlertConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified TooManyGlobalAdminsAssignedToTenantAlertConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TooManyGlobalAdminsAssignedToTenantAlertConfiguration.</returns>
        System.Threading.Tasks.Task<TooManyGlobalAdminsAssignedToTenantAlertConfiguration> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified TooManyGlobalAdminsAssignedToTenantAlertConfiguration and returns a <see cref="GraphResponse{TooManyGlobalAdminsAssignedToTenantAlertConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TooManyGlobalAdminsAssignedToTenantAlertConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TooManyGlobalAdminsAssignedToTenantAlertConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TooManyGlobalAdminsAssignedToTenantAlertConfiguration using PATCH.
        /// </summary>
        /// <param name="tooManyGlobalAdminsAssignedToTenantAlertConfigurationToUpdate">The TooManyGlobalAdminsAssignedToTenantAlertConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TooManyGlobalAdminsAssignedToTenantAlertConfiguration.</returns>
        System.Threading.Tasks.Task<TooManyGlobalAdminsAssignedToTenantAlertConfiguration> UpdateAsync(TooManyGlobalAdminsAssignedToTenantAlertConfiguration tooManyGlobalAdminsAssignedToTenantAlertConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TooManyGlobalAdminsAssignedToTenantAlertConfiguration using PATCH and returns a <see cref="GraphResponse{TooManyGlobalAdminsAssignedToTenantAlertConfiguration}"/> object.
        /// </summary>
        /// <param name="tooManyGlobalAdminsAssignedToTenantAlertConfigurationToUpdate">The TooManyGlobalAdminsAssignedToTenantAlertConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TooManyGlobalAdminsAssignedToTenantAlertConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TooManyGlobalAdminsAssignedToTenantAlertConfiguration>> UpdateResponseAsync(TooManyGlobalAdminsAssignedToTenantAlertConfiguration tooManyGlobalAdminsAssignedToTenantAlertConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TooManyGlobalAdminsAssignedToTenantAlertConfiguration using PUT.
        /// </summary>
        /// <param name="tooManyGlobalAdminsAssignedToTenantAlertConfigurationToUpdate">The TooManyGlobalAdminsAssignedToTenantAlertConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<TooManyGlobalAdminsAssignedToTenantAlertConfiguration> PutAsync(TooManyGlobalAdminsAssignedToTenantAlertConfiguration tooManyGlobalAdminsAssignedToTenantAlertConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TooManyGlobalAdminsAssignedToTenantAlertConfiguration using PUT and returns a <see cref="GraphResponse{TooManyGlobalAdminsAssignedToTenantAlertConfiguration}"/> object.
        /// </summary>
        /// <param name="tooManyGlobalAdminsAssignedToTenantAlertConfigurationToUpdate">The TooManyGlobalAdminsAssignedToTenantAlertConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{TooManyGlobalAdminsAssignedToTenantAlertConfiguration}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<TooManyGlobalAdminsAssignedToTenantAlertConfiguration>> PutResponseAsync(TooManyGlobalAdminsAssignedToTenantAlertConfiguration tooManyGlobalAdminsAssignedToTenantAlertConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITooManyGlobalAdminsAssignedToTenantAlertConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITooManyGlobalAdminsAssignedToTenantAlertConfigurationRequest Expand(Expression<Func<TooManyGlobalAdminsAssignedToTenantAlertConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITooManyGlobalAdminsAssignedToTenantAlertConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITooManyGlobalAdminsAssignedToTenantAlertConfigurationRequest Select(Expression<Func<TooManyGlobalAdminsAssignedToTenantAlertConfiguration, object>> selectExpression);

    }
}
