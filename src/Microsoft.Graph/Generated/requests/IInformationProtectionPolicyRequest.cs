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
    /// The interface IInformationProtectionPolicyRequest.
    /// </summary>
    public partial interface IInformationProtectionPolicyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified InformationProtectionPolicy using POST.
        /// </summary>
        /// <param name="informationProtectionPolicyToCreate">The InformationProtectionPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created InformationProtectionPolicy.</returns>
        System.Threading.Tasks.Task<InformationProtectionPolicy> CreateAsync(InformationProtectionPolicy informationProtectionPolicyToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified InformationProtectionPolicy using POST and returns a <see cref="GraphResponse{InformationProtectionPolicy}"/> object.
        /// </summary>
        /// <param name="informationProtectionPolicyToCreate">The InformationProtectionPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{InformationProtectionPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<InformationProtectionPolicy>> CreateResponseAsync(InformationProtectionPolicy informationProtectionPolicyToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified InformationProtectionPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified InformationProtectionPolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified InformationProtectionPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The InformationProtectionPolicy.</returns>
        System.Threading.Tasks.Task<InformationProtectionPolicy> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified InformationProtectionPolicy and returns a <see cref="GraphResponse{InformationProtectionPolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{InformationProtectionPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<InformationProtectionPolicy>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified InformationProtectionPolicy using PATCH.
        /// </summary>
        /// <param name="informationProtectionPolicyToUpdate">The InformationProtectionPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated InformationProtectionPolicy.</returns>
        System.Threading.Tasks.Task<InformationProtectionPolicy> UpdateAsync(InformationProtectionPolicy informationProtectionPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified InformationProtectionPolicy using PATCH and returns a <see cref="GraphResponse{InformationProtectionPolicy}"/> object.
        /// </summary>
        /// <param name="informationProtectionPolicyToUpdate">The InformationProtectionPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{InformationProtectionPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<InformationProtectionPolicy>> UpdateResponseAsync(InformationProtectionPolicy informationProtectionPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified InformationProtectionPolicy using PUT.
        /// </summary>
        /// <param name="informationProtectionPolicyToUpdate">The InformationProtectionPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<InformationProtectionPolicy> PutAsync(InformationProtectionPolicy informationProtectionPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified InformationProtectionPolicy using PUT and returns a <see cref="GraphResponse{InformationProtectionPolicy}"/> object.
        /// </summary>
        /// <param name="informationProtectionPolicyToUpdate">The InformationProtectionPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{InformationProtectionPolicy}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<InformationProtectionPolicy>> PutResponseAsync(InformationProtectionPolicy informationProtectionPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IInformationProtectionPolicyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IInformationProtectionPolicyRequest Expand(Expression<Func<InformationProtectionPolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IInformationProtectionPolicyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IInformationProtectionPolicyRequest Select(Expression<Func<InformationProtectionPolicy, object>> selectExpression);

    }
}
