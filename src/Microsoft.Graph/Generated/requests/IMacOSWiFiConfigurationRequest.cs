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
    /// The interface IMacOSWiFiConfigurationRequest.
    /// </summary>
    public partial interface IMacOSWiFiConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MacOSWiFiConfiguration using POST.
        /// </summary>
        /// <param name="macOSWiFiConfigurationToCreate">The MacOSWiFiConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MacOSWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSWiFiConfiguration> CreateAsync(MacOSWiFiConfiguration macOSWiFiConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified MacOSWiFiConfiguration using POST and returns a <see cref="GraphResponse{MacOSWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="macOSWiFiConfigurationToCreate">The MacOSWiFiConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSWiFiConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSWiFiConfiguration>> CreateResponseAsync(MacOSWiFiConfiguration macOSWiFiConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified MacOSWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified MacOSWiFiConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified MacOSWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MacOSWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSWiFiConfiguration> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified MacOSWiFiConfiguration and returns a <see cref="GraphResponse{MacOSWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSWiFiConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSWiFiConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MacOSWiFiConfiguration using PATCH.
        /// </summary>
        /// <param name="macOSWiFiConfigurationToUpdate">The MacOSWiFiConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MacOSWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSWiFiConfiguration> UpdateAsync(MacOSWiFiConfiguration macOSWiFiConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MacOSWiFiConfiguration using PATCH and returns a <see cref="GraphResponse{MacOSWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="macOSWiFiConfigurationToUpdate">The MacOSWiFiConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MacOSWiFiConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSWiFiConfiguration>> UpdateResponseAsync(MacOSWiFiConfiguration macOSWiFiConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MacOSWiFiConfiguration using PUT.
        /// </summary>
        /// <param name="macOSWiFiConfigurationToUpdate">The MacOSWiFiConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<MacOSWiFiConfiguration> PutAsync(MacOSWiFiConfiguration macOSWiFiConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MacOSWiFiConfiguration using PUT and returns a <see cref="GraphResponse{MacOSWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="macOSWiFiConfigurationToUpdate">The MacOSWiFiConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{MacOSWiFiConfiguration}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSWiFiConfiguration>> PutResponseAsync(MacOSWiFiConfiguration macOSWiFiConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSWiFiConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSWiFiConfigurationRequest Expand(Expression<Func<MacOSWiFiConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSWiFiConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSWiFiConfigurationRequest Select(Expression<Func<MacOSWiFiConfiguration, object>> selectExpression);

    }
}
