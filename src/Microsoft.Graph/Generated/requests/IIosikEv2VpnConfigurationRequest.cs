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
    /// The interface IIosikEv2VpnConfigurationRequest.
    /// </summary>
    public partial interface IIosikEv2VpnConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IosikEv2VpnConfiguration using POST.
        /// </summary>
        /// <param name="iosikEv2VpnConfigurationToCreate">The IosikEv2VpnConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosikEv2VpnConfiguration.</returns>
        System.Threading.Tasks.Task<IosikEv2VpnConfiguration> CreateAsync(IosikEv2VpnConfiguration iosikEv2VpnConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified IosikEv2VpnConfiguration using POST and returns a <see cref="GraphResponse{IosikEv2VpnConfiguration}"/> object.
        /// </summary>
        /// <param name="iosikEv2VpnConfigurationToCreate">The IosikEv2VpnConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosikEv2VpnConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosikEv2VpnConfiguration>> CreateResponseAsync(IosikEv2VpnConfiguration iosikEv2VpnConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified IosikEv2VpnConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified IosikEv2VpnConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified IosikEv2VpnConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosikEv2VpnConfiguration.</returns>
        System.Threading.Tasks.Task<IosikEv2VpnConfiguration> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified IosikEv2VpnConfiguration and returns a <see cref="GraphResponse{IosikEv2VpnConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosikEv2VpnConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosikEv2VpnConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IosikEv2VpnConfiguration using PATCH.
        /// </summary>
        /// <param name="iosikEv2VpnConfigurationToUpdate">The IosikEv2VpnConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosikEv2VpnConfiguration.</returns>
        System.Threading.Tasks.Task<IosikEv2VpnConfiguration> UpdateAsync(IosikEv2VpnConfiguration iosikEv2VpnConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IosikEv2VpnConfiguration using PATCH and returns a <see cref="GraphResponse{IosikEv2VpnConfiguration}"/> object.
        /// </summary>
        /// <param name="iosikEv2VpnConfigurationToUpdate">The IosikEv2VpnConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IosikEv2VpnConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosikEv2VpnConfiguration>> UpdateResponseAsync(IosikEv2VpnConfiguration iosikEv2VpnConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IosikEv2VpnConfiguration using PUT.
        /// </summary>
        /// <param name="iosikEv2VpnConfigurationToUpdate">The IosikEv2VpnConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<IosikEv2VpnConfiguration> PutAsync(IosikEv2VpnConfiguration iosikEv2VpnConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IosikEv2VpnConfiguration using PUT and returns a <see cref="GraphResponse{IosikEv2VpnConfiguration}"/> object.
        /// </summary>
        /// <param name="iosikEv2VpnConfigurationToUpdate">The IosikEv2VpnConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{IosikEv2VpnConfiguration}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosikEv2VpnConfiguration>> PutResponseAsync(IosikEv2VpnConfiguration iosikEv2VpnConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosikEv2VpnConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosikEv2VpnConfigurationRequest Expand(Expression<Func<IosikEv2VpnConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIosikEv2VpnConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIosikEv2VpnConfigurationRequest Select(Expression<Func<IosikEv2VpnConfiguration, object>> selectExpression);

    }
}
