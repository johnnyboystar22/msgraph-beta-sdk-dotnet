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
    /// The interface IDeviceManagementConfigurationSettingRequest.
    /// </summary>
    public partial interface IDeviceManagementConfigurationSettingRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceManagementConfigurationSetting using POST.
        /// </summary>
        /// <param name="deviceManagementConfigurationSettingToCreate">The DeviceManagementConfigurationSetting to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementConfigurationSetting.</returns>
        System.Threading.Tasks.Task<DeviceManagementConfigurationSetting> CreateAsync(DeviceManagementConfigurationSetting deviceManagementConfigurationSettingToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified DeviceManagementConfigurationSetting using POST and returns a <see cref="GraphResponse{DeviceManagementConfigurationSetting}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationSettingToCreate">The DeviceManagementConfigurationSetting to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationSetting}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationSetting>> CreateResponseAsync(DeviceManagementConfigurationSetting deviceManagementConfigurationSettingToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceManagementConfigurationSetting.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceManagementConfigurationSetting and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceManagementConfigurationSetting.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementConfigurationSetting.</returns>
        System.Threading.Tasks.Task<DeviceManagementConfigurationSetting> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceManagementConfigurationSetting and returns a <see cref="GraphResponse{DeviceManagementConfigurationSetting}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationSetting}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationSetting>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationSetting using PATCH.
        /// </summary>
        /// <param name="deviceManagementConfigurationSettingToUpdate">The DeviceManagementConfigurationSetting to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementConfigurationSetting.</returns>
        System.Threading.Tasks.Task<DeviceManagementConfigurationSetting> UpdateAsync(DeviceManagementConfigurationSetting deviceManagementConfigurationSettingToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationSetting using PATCH and returns a <see cref="GraphResponse{DeviceManagementConfigurationSetting}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationSettingToUpdate">The DeviceManagementConfigurationSetting to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationSetting}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationSetting>> UpdateResponseAsync(DeviceManagementConfigurationSetting deviceManagementConfigurationSettingToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationSetting using PUT.
        /// </summary>
        /// <param name="deviceManagementConfigurationSettingToUpdate">The DeviceManagementConfigurationSetting object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DeviceManagementConfigurationSetting> PutAsync(DeviceManagementConfigurationSetting deviceManagementConfigurationSettingToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationSetting using PUT and returns a <see cref="GraphResponse{DeviceManagementConfigurationSetting}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationSettingToUpdate">The DeviceManagementConfigurationSetting object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DeviceManagementConfigurationSetting}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationSetting>> PutResponseAsync(DeviceManagementConfigurationSetting deviceManagementConfigurationSettingToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementConfigurationSettingRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementConfigurationSettingRequest Expand(Expression<Func<DeviceManagementConfigurationSetting, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementConfigurationSettingRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementConfigurationSettingRequest Select(Expression<Func<DeviceManagementConfigurationSetting, object>> selectExpression);

    }
}
