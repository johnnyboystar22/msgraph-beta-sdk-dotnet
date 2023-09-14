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
    /// The interface IAuditLogRootRequestBuilder.
    /// </summary>
    public partial interface IAuditLogRootRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IAuditLogRootRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IAuditLogRootRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for CustomSecurityAttributeAudits.
        /// </summary>
        /// <returns>The <see cref="IAuditLogRootCustomSecurityAttributeAuditsCollectionRequestBuilder"/>.</returns>
        IAuditLogRootCustomSecurityAttributeAuditsCollectionRequestBuilder CustomSecurityAttributeAudits { get; }

        /// <summary>
        /// Gets the request builder for DirectoryAudits.
        /// </summary>
        /// <returns>The <see cref="IAuditLogRootDirectoryAuditsCollectionRequestBuilder"/>.</returns>
        IAuditLogRootDirectoryAuditsCollectionRequestBuilder DirectoryAudits { get; }

        /// <summary>
        /// Gets the request builder for DirectoryProvisioning.
        /// </summary>
        /// <returns>The <see cref="IAuditLogRootDirectoryProvisioningCollectionRequestBuilder"/>.</returns>
        IAuditLogRootDirectoryProvisioningCollectionRequestBuilder DirectoryProvisioning { get; }

        /// <summary>
        /// Gets the request builder for Provisioning.
        /// </summary>
        /// <returns>The <see cref="IAuditLogRootProvisioningCollectionRequestBuilder"/>.</returns>
        IAuditLogRootProvisioningCollectionRequestBuilder Provisioning { get; }

        /// <summary>
        /// Gets the request builder for SignIns.
        /// </summary>
        /// <returns>The <see cref="IAuditLogRootSignInsCollectionRequestBuilder"/>.</returns>
        IAuditLogRootSignInsCollectionRequestBuilder SignIns { get; }
    
    }
}
