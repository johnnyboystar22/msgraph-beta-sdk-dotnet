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
    /// The interface IDeviceManagementConfigurationSettingGroupDefinitionRequest.
    /// </summary>
    public partial interface IDeviceManagementConfigurationSettingGroupDefinitionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceManagementConfigurationSettingGroupDefinition using POST.
        /// </summary>
        /// <param name="deviceManagementConfigurationSettingGroupDefinitionToCreate">The DeviceManagementConfigurationSettingGroupDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementConfigurationSettingGroupDefinition.</returns>
        System.Threading.Tasks.Task<DeviceManagementConfigurationSettingGroupDefinition> CreateAsync(DeviceManagementConfigurationSettingGroupDefinition deviceManagementConfigurationSettingGroupDefinitionToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified DeviceManagementConfigurationSettingGroupDefinition using POST and returns a <see cref="GraphResponse{DeviceManagementConfigurationSettingGroupDefinition}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationSettingGroupDefinitionToCreate">The DeviceManagementConfigurationSettingGroupDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationSettingGroupDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationSettingGroupDefinition>> CreateResponseAsync(DeviceManagementConfigurationSettingGroupDefinition deviceManagementConfigurationSettingGroupDefinitionToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceManagementConfigurationSettingGroupDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceManagementConfigurationSettingGroupDefinition and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceManagementConfigurationSettingGroupDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementConfigurationSettingGroupDefinition.</returns>
        System.Threading.Tasks.Task<DeviceManagementConfigurationSettingGroupDefinition> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceManagementConfigurationSettingGroupDefinition and returns a <see cref="GraphResponse{DeviceManagementConfigurationSettingGroupDefinition}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationSettingGroupDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationSettingGroupDefinition>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationSettingGroupDefinition using PATCH.
        /// </summary>
        /// <param name="deviceManagementConfigurationSettingGroupDefinitionToUpdate">The DeviceManagementConfigurationSettingGroupDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementConfigurationSettingGroupDefinition.</returns>
        System.Threading.Tasks.Task<DeviceManagementConfigurationSettingGroupDefinition> UpdateAsync(DeviceManagementConfigurationSettingGroupDefinition deviceManagementConfigurationSettingGroupDefinitionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationSettingGroupDefinition using PATCH and returns a <see cref="GraphResponse{DeviceManagementConfigurationSettingGroupDefinition}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationSettingGroupDefinitionToUpdate">The DeviceManagementConfigurationSettingGroupDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationSettingGroupDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationSettingGroupDefinition>> UpdateResponseAsync(DeviceManagementConfigurationSettingGroupDefinition deviceManagementConfigurationSettingGroupDefinitionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationSettingGroupDefinition using PUT.
        /// </summary>
        /// <param name="deviceManagementConfigurationSettingGroupDefinitionToUpdate">The DeviceManagementConfigurationSettingGroupDefinition object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DeviceManagementConfigurationSettingGroupDefinition> PutAsync(DeviceManagementConfigurationSettingGroupDefinition deviceManagementConfigurationSettingGroupDefinitionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationSettingGroupDefinition using PUT and returns a <see cref="GraphResponse{DeviceManagementConfigurationSettingGroupDefinition}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationSettingGroupDefinitionToUpdate">The DeviceManagementConfigurationSettingGroupDefinition object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DeviceManagementConfigurationSettingGroupDefinition}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationSettingGroupDefinition>> PutResponseAsync(DeviceManagementConfigurationSettingGroupDefinition deviceManagementConfigurationSettingGroupDefinitionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementConfigurationSettingGroupDefinitionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementConfigurationSettingGroupDefinitionRequest Expand(Expression<Func<DeviceManagementConfigurationSettingGroupDefinition, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementConfigurationSettingGroupDefinitionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementConfigurationSettingGroupDefinitionRequest Select(Expression<Func<DeviceManagementConfigurationSettingGroupDefinition, object>> selectExpression);

    }
}
