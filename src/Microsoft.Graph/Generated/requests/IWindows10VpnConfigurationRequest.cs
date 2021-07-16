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
    /// The interface IWindows10VpnConfigurationRequest.
    /// </summary>
    public partial interface IWindows10VpnConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Windows10VpnConfiguration using POST.
        /// </summary>
        /// <param name="windows10VpnConfigurationToCreate">The Windows10VpnConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Windows10VpnConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10VpnConfiguration> CreateAsync(Windows10VpnConfiguration windows10VpnConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified Windows10VpnConfiguration using POST and returns a <see cref="GraphResponse{Windows10VpnConfiguration}"/> object.
        /// </summary>
        /// <param name="windows10VpnConfigurationToCreate">The Windows10VpnConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Windows10VpnConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows10VpnConfiguration>> CreateResponseAsync(Windows10VpnConfiguration windows10VpnConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Windows10VpnConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Windows10VpnConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Windows10VpnConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Windows10VpnConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10VpnConfiguration> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Windows10VpnConfiguration and returns a <see cref="GraphResponse{Windows10VpnConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Windows10VpnConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows10VpnConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Windows10VpnConfiguration using PATCH.
        /// </summary>
        /// <param name="windows10VpnConfigurationToUpdate">The Windows10VpnConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Windows10VpnConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10VpnConfiguration> UpdateAsync(Windows10VpnConfiguration windows10VpnConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Windows10VpnConfiguration using PATCH and returns a <see cref="GraphResponse{Windows10VpnConfiguration}"/> object.
        /// </summary>
        /// <param name="windows10VpnConfigurationToUpdate">The Windows10VpnConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Windows10VpnConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows10VpnConfiguration>> UpdateResponseAsync(Windows10VpnConfiguration windows10VpnConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Windows10VpnConfiguration using PUT.
        /// </summary>
        /// <param name="windows10VpnConfigurationToUpdate">The Windows10VpnConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<Windows10VpnConfiguration> PutAsync(Windows10VpnConfiguration windows10VpnConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Windows10VpnConfiguration using PUT and returns a <see cref="GraphResponse{Windows10VpnConfiguration}"/> object.
        /// </summary>
        /// <param name="windows10VpnConfigurationToUpdate">The Windows10VpnConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{Windows10VpnConfiguration}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows10VpnConfiguration>> PutResponseAsync(Windows10VpnConfiguration windows10VpnConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10VpnConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10VpnConfigurationRequest Expand(Expression<Func<Windows10VpnConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10VpnConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10VpnConfigurationRequest Select(Expression<Func<Windows10VpnConfiguration, object>> selectExpression);

    }
}
