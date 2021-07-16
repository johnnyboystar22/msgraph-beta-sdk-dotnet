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
    /// The interface INetworkIPv4ConfigurationManagementConditionRequest.
    /// </summary>
    public partial interface INetworkIPv4ConfigurationManagementConditionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified NetworkIPv4ConfigurationManagementCondition using POST.
        /// </summary>
        /// <param name="networkIPv4ConfigurationManagementConditionToCreate">The NetworkIPv4ConfigurationManagementCondition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created NetworkIPv4ConfigurationManagementCondition.</returns>
        System.Threading.Tasks.Task<NetworkIPv4ConfigurationManagementCondition> CreateAsync(NetworkIPv4ConfigurationManagementCondition networkIPv4ConfigurationManagementConditionToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified NetworkIPv4ConfigurationManagementCondition using POST and returns a <see cref="GraphResponse{NetworkIPv4ConfigurationManagementCondition}"/> object.
        /// </summary>
        /// <param name="networkIPv4ConfigurationManagementConditionToCreate">The NetworkIPv4ConfigurationManagementCondition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{NetworkIPv4ConfigurationManagementCondition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<NetworkIPv4ConfigurationManagementCondition>> CreateResponseAsync(NetworkIPv4ConfigurationManagementCondition networkIPv4ConfigurationManagementConditionToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified NetworkIPv4ConfigurationManagementCondition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified NetworkIPv4ConfigurationManagementCondition and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified NetworkIPv4ConfigurationManagementCondition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The NetworkIPv4ConfigurationManagementCondition.</returns>
        System.Threading.Tasks.Task<NetworkIPv4ConfigurationManagementCondition> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified NetworkIPv4ConfigurationManagementCondition and returns a <see cref="GraphResponse{NetworkIPv4ConfigurationManagementCondition}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{NetworkIPv4ConfigurationManagementCondition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<NetworkIPv4ConfigurationManagementCondition>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified NetworkIPv4ConfigurationManagementCondition using PATCH.
        /// </summary>
        /// <param name="networkIPv4ConfigurationManagementConditionToUpdate">The NetworkIPv4ConfigurationManagementCondition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated NetworkIPv4ConfigurationManagementCondition.</returns>
        System.Threading.Tasks.Task<NetworkIPv4ConfigurationManagementCondition> UpdateAsync(NetworkIPv4ConfigurationManagementCondition networkIPv4ConfigurationManagementConditionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified NetworkIPv4ConfigurationManagementCondition using PATCH and returns a <see cref="GraphResponse{NetworkIPv4ConfigurationManagementCondition}"/> object.
        /// </summary>
        /// <param name="networkIPv4ConfigurationManagementConditionToUpdate">The NetworkIPv4ConfigurationManagementCondition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{NetworkIPv4ConfigurationManagementCondition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<NetworkIPv4ConfigurationManagementCondition>> UpdateResponseAsync(NetworkIPv4ConfigurationManagementCondition networkIPv4ConfigurationManagementConditionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified NetworkIPv4ConfigurationManagementCondition using PUT.
        /// </summary>
        /// <param name="networkIPv4ConfigurationManagementConditionToUpdate">The NetworkIPv4ConfigurationManagementCondition object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<NetworkIPv4ConfigurationManagementCondition> PutAsync(NetworkIPv4ConfigurationManagementCondition networkIPv4ConfigurationManagementConditionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified NetworkIPv4ConfigurationManagementCondition using PUT and returns a <see cref="GraphResponse{NetworkIPv4ConfigurationManagementCondition}"/> object.
        /// </summary>
        /// <param name="networkIPv4ConfigurationManagementConditionToUpdate">The NetworkIPv4ConfigurationManagementCondition object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{NetworkIPv4ConfigurationManagementCondition}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<NetworkIPv4ConfigurationManagementCondition>> PutResponseAsync(NetworkIPv4ConfigurationManagementCondition networkIPv4ConfigurationManagementConditionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        INetworkIPv4ConfigurationManagementConditionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        INetworkIPv4ConfigurationManagementConditionRequest Expand(Expression<Func<NetworkIPv4ConfigurationManagementCondition, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        INetworkIPv4ConfigurationManagementConditionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        INetworkIPv4ConfigurationManagementConditionRequest Select(Expression<Func<NetworkIPv4ConfigurationManagementCondition, object>> selectExpression);

    }
}
