// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IPrivilegedAccessGroupAssignmentApprovalsCollectionRequestBuilder.
    /// </summary>
    public partial interface IPrivilegedAccessGroupAssignmentApprovalsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IPrivilegedAccessGroupAssignmentApprovalsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IPrivilegedAccessGroupAssignmentApprovalsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IApprovalRequestBuilder"/> for the specified Approval.
        /// </summary>
        /// <param name="id">The ID for the Approval.</param>
        /// <returns>The <see cref="IApprovalRequestBuilder"/>.</returns>
        IApprovalRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for ApprovalFilterByCurrentUser.
        /// </summary>
        /// <returns>The <see cref="IApprovalFilterByCurrentUserRequestBuilder"/>.</returns>
        IApprovalFilterByCurrentUserRequestBuilder FilterByCurrentUser(
            ApprovalFilterByCurrentUserOptions on);
    }
}
