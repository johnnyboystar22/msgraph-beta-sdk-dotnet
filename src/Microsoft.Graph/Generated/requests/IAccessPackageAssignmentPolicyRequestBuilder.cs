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
    /// The interface IAccessPackageAssignmentPolicyRequestBuilder.
    /// </summary>
    public partial interface IAccessPackageAssignmentPolicyRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IAccessPackageAssignmentPolicyRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IAccessPackageAssignmentPolicyRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for AccessPackage.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageWithReferenceRequestBuilder"/>.</returns>
        IAccessPackageWithReferenceRequestBuilder AccessPackage { get; }

        /// <summary>
        /// Gets the request builder for AccessPackageCatalog.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageCatalogRequestBuilder"/>.</returns>
        IAccessPackageCatalogRequestBuilder AccessPackageCatalog { get; }

        /// <summary>
        /// Gets the request builder for CustomExtensionHandlers.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageAssignmentPolicyCustomExtensionHandlersCollectionRequestBuilder"/>.</returns>
        IAccessPackageAssignmentPolicyCustomExtensionHandlersCollectionRequestBuilder CustomExtensionHandlers { get; }

        /// <summary>
        /// Gets the request builder for CustomExtensionStageSettings.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageAssignmentPolicyCustomExtensionStageSettingsCollectionRequestBuilder"/>.</returns>
        IAccessPackageAssignmentPolicyCustomExtensionStageSettingsCollectionRequestBuilder CustomExtensionStageSettings { get; }
    
    }
}
