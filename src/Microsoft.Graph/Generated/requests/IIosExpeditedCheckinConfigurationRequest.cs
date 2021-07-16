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
    /// The interface IIosExpeditedCheckinConfigurationRequest.
    /// </summary>
    public partial interface IIosExpeditedCheckinConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IosExpeditedCheckinConfiguration using POST.
        /// </summary>
        /// <param name="iosExpeditedCheckinConfigurationToCreate">The IosExpeditedCheckinConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosExpeditedCheckinConfiguration.</returns>
        System.Threading.Tasks.Task<IosExpeditedCheckinConfiguration> CreateAsync(IosExpeditedCheckinConfiguration iosExpeditedCheckinConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified IosExpeditedCheckinConfiguration using POST and returns a <see cref="GraphResponse{IosExpeditedCheckinConfiguration}"/> object.
        /// </summary>
        /// <param name="iosExpeditedCheckinConfigurationToCreate">The IosExpeditedCheckinConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosExpeditedCheckinConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosExpeditedCheckinConfiguration>> CreateResponseAsync(IosExpeditedCheckinConfiguration iosExpeditedCheckinConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified IosExpeditedCheckinConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified IosExpeditedCheckinConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified IosExpeditedCheckinConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosExpeditedCheckinConfiguration.</returns>
        System.Threading.Tasks.Task<IosExpeditedCheckinConfiguration> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified IosExpeditedCheckinConfiguration and returns a <see cref="GraphResponse{IosExpeditedCheckinConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosExpeditedCheckinConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosExpeditedCheckinConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IosExpeditedCheckinConfiguration using PATCH.
        /// </summary>
        /// <param name="iosExpeditedCheckinConfigurationToUpdate">The IosExpeditedCheckinConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosExpeditedCheckinConfiguration.</returns>
        System.Threading.Tasks.Task<IosExpeditedCheckinConfiguration> UpdateAsync(IosExpeditedCheckinConfiguration iosExpeditedCheckinConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IosExpeditedCheckinConfiguration using PATCH and returns a <see cref="GraphResponse{IosExpeditedCheckinConfiguration}"/> object.
        /// </summary>
        /// <param name="iosExpeditedCheckinConfigurationToUpdate">The IosExpeditedCheckinConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IosExpeditedCheckinConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosExpeditedCheckinConfiguration>> UpdateResponseAsync(IosExpeditedCheckinConfiguration iosExpeditedCheckinConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IosExpeditedCheckinConfiguration using PUT.
        /// </summary>
        /// <param name="iosExpeditedCheckinConfigurationToUpdate">The IosExpeditedCheckinConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<IosExpeditedCheckinConfiguration> PutAsync(IosExpeditedCheckinConfiguration iosExpeditedCheckinConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IosExpeditedCheckinConfiguration using PUT and returns a <see cref="GraphResponse{IosExpeditedCheckinConfiguration}"/> object.
        /// </summary>
        /// <param name="iosExpeditedCheckinConfigurationToUpdate">The IosExpeditedCheckinConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{IosExpeditedCheckinConfiguration}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosExpeditedCheckinConfiguration>> PutResponseAsync(IosExpeditedCheckinConfiguration iosExpeditedCheckinConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosExpeditedCheckinConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosExpeditedCheckinConfigurationRequest Expand(Expression<Func<IosExpeditedCheckinConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIosExpeditedCheckinConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIosExpeditedCheckinConfigurationRequest Select(Expression<Func<IosExpeditedCheckinConfiguration, object>> selectExpression);

    }
}
