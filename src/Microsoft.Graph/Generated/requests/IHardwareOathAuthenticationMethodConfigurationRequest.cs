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
    /// The interface IHardwareOathAuthenticationMethodConfigurationRequest.
    /// </summary>
    public partial interface IHardwareOathAuthenticationMethodConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified HardwareOathAuthenticationMethodConfiguration using POST.
        /// </summary>
        /// <param name="hardwareOathAuthenticationMethodConfigurationToCreate">The HardwareOathAuthenticationMethodConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created HardwareOathAuthenticationMethodConfiguration.</returns>
        System.Threading.Tasks.Task<HardwareOathAuthenticationMethodConfiguration> CreateAsync(HardwareOathAuthenticationMethodConfiguration hardwareOathAuthenticationMethodConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified HardwareOathAuthenticationMethodConfiguration using POST and returns a <see cref="GraphResponse{HardwareOathAuthenticationMethodConfiguration}"/> object.
        /// </summary>
        /// <param name="hardwareOathAuthenticationMethodConfigurationToCreate">The HardwareOathAuthenticationMethodConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{HardwareOathAuthenticationMethodConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<HardwareOathAuthenticationMethodConfiguration>> CreateResponseAsync(HardwareOathAuthenticationMethodConfiguration hardwareOathAuthenticationMethodConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified HardwareOathAuthenticationMethodConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified HardwareOathAuthenticationMethodConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified HardwareOathAuthenticationMethodConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The HardwareOathAuthenticationMethodConfiguration.</returns>
        System.Threading.Tasks.Task<HardwareOathAuthenticationMethodConfiguration> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified HardwareOathAuthenticationMethodConfiguration and returns a <see cref="GraphResponse{HardwareOathAuthenticationMethodConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{HardwareOathAuthenticationMethodConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<HardwareOathAuthenticationMethodConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified HardwareOathAuthenticationMethodConfiguration using PATCH.
        /// </summary>
        /// <param name="hardwareOathAuthenticationMethodConfigurationToUpdate">The HardwareOathAuthenticationMethodConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated HardwareOathAuthenticationMethodConfiguration.</returns>
        System.Threading.Tasks.Task<HardwareOathAuthenticationMethodConfiguration> UpdateAsync(HardwareOathAuthenticationMethodConfiguration hardwareOathAuthenticationMethodConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified HardwareOathAuthenticationMethodConfiguration using PATCH and returns a <see cref="GraphResponse{HardwareOathAuthenticationMethodConfiguration}"/> object.
        /// </summary>
        /// <param name="hardwareOathAuthenticationMethodConfigurationToUpdate">The HardwareOathAuthenticationMethodConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{HardwareOathAuthenticationMethodConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<HardwareOathAuthenticationMethodConfiguration>> UpdateResponseAsync(HardwareOathAuthenticationMethodConfiguration hardwareOathAuthenticationMethodConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified HardwareOathAuthenticationMethodConfiguration using PUT.
        /// </summary>
        /// <param name="hardwareOathAuthenticationMethodConfigurationToUpdate">The HardwareOathAuthenticationMethodConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<HardwareOathAuthenticationMethodConfiguration> PutAsync(HardwareOathAuthenticationMethodConfiguration hardwareOathAuthenticationMethodConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified HardwareOathAuthenticationMethodConfiguration using PUT and returns a <see cref="GraphResponse{HardwareOathAuthenticationMethodConfiguration}"/> object.
        /// </summary>
        /// <param name="hardwareOathAuthenticationMethodConfigurationToUpdate">The HardwareOathAuthenticationMethodConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{HardwareOathAuthenticationMethodConfiguration}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<HardwareOathAuthenticationMethodConfiguration>> PutResponseAsync(HardwareOathAuthenticationMethodConfiguration hardwareOathAuthenticationMethodConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IHardwareOathAuthenticationMethodConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IHardwareOathAuthenticationMethodConfigurationRequest Expand(Expression<Func<HardwareOathAuthenticationMethodConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IHardwareOathAuthenticationMethodConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IHardwareOathAuthenticationMethodConfigurationRequest Select(Expression<Func<HardwareOathAuthenticationMethodConfiguration, object>> selectExpression);

    }
}
