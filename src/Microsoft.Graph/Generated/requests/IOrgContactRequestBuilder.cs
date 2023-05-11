// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IOrgContactRequestBuilder.
    /// </summary>
    public partial interface IOrgContactRequestBuilder : IDirectoryObjectRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IOrgContactRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IOrgContactRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for DirectReports.
        /// </summary>
        /// <returns>The <see cref="IOrgContactDirectReportsCollectionWithReferencesRequestBuilder"/>.</returns>
        IOrgContactDirectReportsCollectionWithReferencesRequestBuilder DirectReports { get; }

        /// <summary>
        /// Gets the request builder for Manager.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectWithReferenceRequestBuilder"/>.</returns>
        IDirectoryObjectWithReferenceRequestBuilder Manager { get; }

        /// <summary>
        /// Gets the request builder for MemberOf.
        /// </summary>
        /// <returns>The <see cref="IOrgContactMemberOfCollectionWithReferencesRequestBuilder"/>.</returns>
        IOrgContactMemberOfCollectionWithReferencesRequestBuilder MemberOf { get; }

        /// <summary>
        /// Gets the request builder for TransitiveMemberOf.
        /// </summary>
        /// <returns>The <see cref="IOrgContactTransitiveMemberOfCollectionWithReferencesRequestBuilder"/>.</returns>
        IOrgContactTransitiveMemberOfCollectionWithReferencesRequestBuilder TransitiveMemberOf { get; }

        /// <summary>
        /// Gets the request builder for TransitiveReports.
        /// </summary>
        /// <returns>The <see cref="IOrgContactTransitiveReportsCollectionWithReferencesRequestBuilder"/>.</returns>
        IOrgContactTransitiveReportsCollectionWithReferencesRequestBuilder TransitiveReports { get; }
    
        /// <summary>
        /// Gets the request builder for OrgContactRetryServiceProvisioning.
        /// </summary>
        /// <returns>The <see cref="IOrgContactRetryServiceProvisioningRequestBuilder"/>.</returns>
        IOrgContactRetryServiceProvisioningRequestBuilder RetryServiceProvisioning();
    
    }
}
