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
    /// The interface IDeviceCompliancePolicySettingStateSummaryRequest.
    /// </summary>
    public partial interface IDeviceCompliancePolicySettingStateSummaryRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceCompliancePolicySettingStateSummary using POST.
        /// </summary>
        /// <param name="deviceCompliancePolicySettingStateSummaryToCreate">The DeviceCompliancePolicySettingStateSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceCompliancePolicySettingStateSummary.</returns>
        System.Threading.Tasks.Task<DeviceCompliancePolicySettingStateSummary> CreateAsync(DeviceCompliancePolicySettingStateSummary deviceCompliancePolicySettingStateSummaryToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified DeviceCompliancePolicySettingStateSummary using POST and returns a <see cref="GraphResponse{DeviceCompliancePolicySettingStateSummary}"/> object.
        /// </summary>
        /// <param name="deviceCompliancePolicySettingStateSummaryToCreate">The DeviceCompliancePolicySettingStateSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceCompliancePolicySettingStateSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceCompliancePolicySettingStateSummary>> CreateResponseAsync(DeviceCompliancePolicySettingStateSummary deviceCompliancePolicySettingStateSummaryToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceCompliancePolicySettingStateSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceCompliancePolicySettingStateSummary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceCompliancePolicySettingStateSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceCompliancePolicySettingStateSummary.</returns>
        System.Threading.Tasks.Task<DeviceCompliancePolicySettingStateSummary> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceCompliancePolicySettingStateSummary and returns a <see cref="GraphResponse{DeviceCompliancePolicySettingStateSummary}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceCompliancePolicySettingStateSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceCompliancePolicySettingStateSummary>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceCompliancePolicySettingStateSummary using PATCH.
        /// </summary>
        /// <param name="deviceCompliancePolicySettingStateSummaryToUpdate">The DeviceCompliancePolicySettingStateSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceCompliancePolicySettingStateSummary.</returns>
        System.Threading.Tasks.Task<DeviceCompliancePolicySettingStateSummary> UpdateAsync(DeviceCompliancePolicySettingStateSummary deviceCompliancePolicySettingStateSummaryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceCompliancePolicySettingStateSummary using PATCH and returns a <see cref="GraphResponse{DeviceCompliancePolicySettingStateSummary}"/> object.
        /// </summary>
        /// <param name="deviceCompliancePolicySettingStateSummaryToUpdate">The DeviceCompliancePolicySettingStateSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceCompliancePolicySettingStateSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceCompliancePolicySettingStateSummary>> UpdateResponseAsync(DeviceCompliancePolicySettingStateSummary deviceCompliancePolicySettingStateSummaryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceCompliancePolicySettingStateSummary using PUT.
        /// </summary>
        /// <param name="deviceCompliancePolicySettingStateSummaryToUpdate">The DeviceCompliancePolicySettingStateSummary object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DeviceCompliancePolicySettingStateSummary> PutAsync(DeviceCompliancePolicySettingStateSummary deviceCompliancePolicySettingStateSummaryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceCompliancePolicySettingStateSummary using PUT and returns a <see cref="GraphResponse{DeviceCompliancePolicySettingStateSummary}"/> object.
        /// </summary>
        /// <param name="deviceCompliancePolicySettingStateSummaryToUpdate">The DeviceCompliancePolicySettingStateSummary object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DeviceCompliancePolicySettingStateSummary}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceCompliancePolicySettingStateSummary>> PutResponseAsync(DeviceCompliancePolicySettingStateSummary deviceCompliancePolicySettingStateSummaryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicySettingStateSummaryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicySettingStateSummaryRequest Expand(Expression<Func<DeviceCompliancePolicySettingStateSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicySettingStateSummaryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicySettingStateSummaryRequest Select(Expression<Func<DeviceCompliancePolicySettingStateSummary, object>> selectExpression);

    }
}
