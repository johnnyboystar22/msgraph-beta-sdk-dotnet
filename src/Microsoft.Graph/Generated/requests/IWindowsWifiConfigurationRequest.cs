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
    /// The interface IWindowsWifiConfigurationRequest.
    /// </summary>
    public partial interface IWindowsWifiConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsWifiConfiguration using POST.
        /// </summary>
        /// <param name="windowsWifiConfigurationToCreate">The WindowsWifiConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsWifiConfiguration.</returns>
        System.Threading.Tasks.Task<WindowsWifiConfiguration> CreateAsync(WindowsWifiConfiguration windowsWifiConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified WindowsWifiConfiguration using POST and returns a <see cref="GraphResponse{WindowsWifiConfiguration}"/> object.
        /// </summary>
        /// <param name="windowsWifiConfigurationToCreate">The WindowsWifiConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsWifiConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsWifiConfiguration>> CreateResponseAsync(WindowsWifiConfiguration windowsWifiConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WindowsWifiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WindowsWifiConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WindowsWifiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsWifiConfiguration.</returns>
        System.Threading.Tasks.Task<WindowsWifiConfiguration> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WindowsWifiConfiguration and returns a <see cref="GraphResponse{WindowsWifiConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsWifiConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsWifiConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WindowsWifiConfiguration using PATCH.
        /// </summary>
        /// <param name="windowsWifiConfigurationToUpdate">The WindowsWifiConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsWifiConfiguration.</returns>
        System.Threading.Tasks.Task<WindowsWifiConfiguration> UpdateAsync(WindowsWifiConfiguration windowsWifiConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WindowsWifiConfiguration using PATCH and returns a <see cref="GraphResponse{WindowsWifiConfiguration}"/> object.
        /// </summary>
        /// <param name="windowsWifiConfigurationToUpdate">The WindowsWifiConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WindowsWifiConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsWifiConfiguration>> UpdateResponseAsync(WindowsWifiConfiguration windowsWifiConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WindowsWifiConfiguration using PUT.
        /// </summary>
        /// <param name="windowsWifiConfigurationToUpdate">The WindowsWifiConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<WindowsWifiConfiguration> PutAsync(WindowsWifiConfiguration windowsWifiConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WindowsWifiConfiguration using PUT and returns a <see cref="GraphResponse{WindowsWifiConfiguration}"/> object.
        /// </summary>
        /// <param name="windowsWifiConfigurationToUpdate">The WindowsWifiConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{WindowsWifiConfiguration}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsWifiConfiguration>> PutResponseAsync(WindowsWifiConfiguration windowsWifiConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsWifiConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsWifiConfigurationRequest Expand(Expression<Func<WindowsWifiConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsWifiConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsWifiConfigurationRequest Select(Expression<Func<WindowsWifiConfiguration, object>> selectExpression);

    }
}
