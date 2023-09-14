// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDetectionRuleRequest.
    /// </summary>
    public partial interface IDetectionRuleRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified DetectionRule using POST.
        /// </summary>
        /// <param name="detectionRuleToCreate">The DetectionRule to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DetectionRule.</returns>
        System.Threading.Tasks.Task<DetectionRule> CreateAsync(DetectionRule detectionRuleToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified DetectionRule using POST and returns a <see cref="GraphResponse{DetectionRule}"/> object.
        /// </summary>
        /// <param name="detectionRuleToCreate">The DetectionRule to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DetectionRule}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DetectionRule>> CreateResponseAsync(DetectionRule detectionRuleToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DetectionRule.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DetectionRule and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DetectionRule.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DetectionRule.</returns>
        System.Threading.Tasks.Task<DetectionRule> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DetectionRule and returns a <see cref="GraphResponse{DetectionRule}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DetectionRule}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DetectionRule>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DetectionRule using PATCH.
        /// </summary>
        /// <param name="detectionRuleToUpdate">The DetectionRule to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DetectionRule.</returns>
        System.Threading.Tasks.Task<DetectionRule> UpdateAsync(DetectionRule detectionRuleToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DetectionRule using PATCH and returns a <see cref="GraphResponse{DetectionRule}"/> object.
        /// </summary>
        /// <param name="detectionRuleToUpdate">The DetectionRule to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DetectionRule}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DetectionRule>> UpdateResponseAsync(DetectionRule detectionRuleToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DetectionRule using PUT.
        /// </summary>
        /// <param name="detectionRuleToUpdate">The DetectionRule object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DetectionRule> PutAsync(DetectionRule detectionRuleToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DetectionRule using PUT and returns a <see cref="GraphResponse{DetectionRule}"/> object.
        /// </summary>
        /// <param name="detectionRuleToUpdate">The DetectionRule object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DetectionRule}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DetectionRule>> PutResponseAsync(DetectionRule detectionRuleToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDetectionRuleRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDetectionRuleRequest Expand(Expression<Func<DetectionRule, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDetectionRuleRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDetectionRuleRequest Select(Expression<Func<DetectionRule, object>> selectExpression);

    }
}
