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
    /// The interface ICustomerPaymentRequest.
    /// </summary>
    public partial interface ICustomerPaymentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified CustomerPayment using POST.
        /// </summary>
        /// <param name="customerPaymentToCreate">The CustomerPayment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CustomerPayment.</returns>
        System.Threading.Tasks.Task<CustomerPayment> CreateAsync(CustomerPayment customerPaymentToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified CustomerPayment using POST and returns a <see cref="GraphResponse{CustomerPayment}"/> object.
        /// </summary>
        /// <param name="customerPaymentToCreate">The CustomerPayment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CustomerPayment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CustomerPayment>> CreateResponseAsync(CustomerPayment customerPaymentToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified CustomerPayment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified CustomerPayment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified CustomerPayment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CustomerPayment.</returns>
        System.Threading.Tasks.Task<CustomerPayment> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified CustomerPayment and returns a <see cref="GraphResponse{CustomerPayment}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CustomerPayment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CustomerPayment>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CustomerPayment using PATCH.
        /// </summary>
        /// <param name="customerPaymentToUpdate">The CustomerPayment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CustomerPayment.</returns>
        System.Threading.Tasks.Task<CustomerPayment> UpdateAsync(CustomerPayment customerPaymentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CustomerPayment using PATCH and returns a <see cref="GraphResponse{CustomerPayment}"/> object.
        /// </summary>
        /// <param name="customerPaymentToUpdate">The CustomerPayment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{CustomerPayment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CustomerPayment>> UpdateResponseAsync(CustomerPayment customerPaymentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CustomerPayment using PUT.
        /// </summary>
        /// <param name="customerPaymentToUpdate">The CustomerPayment object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<CustomerPayment> PutAsync(CustomerPayment customerPaymentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CustomerPayment using PUT and returns a <see cref="GraphResponse{CustomerPayment}"/> object.
        /// </summary>
        /// <param name="customerPaymentToUpdate">The CustomerPayment object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{CustomerPayment}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<CustomerPayment>> PutResponseAsync(CustomerPayment customerPaymentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICustomerPaymentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICustomerPaymentRequest Expand(Expression<Func<CustomerPayment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICustomerPaymentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICustomerPaymentRequest Select(Expression<Func<CustomerPayment, object>> selectExpression);

    }
}
