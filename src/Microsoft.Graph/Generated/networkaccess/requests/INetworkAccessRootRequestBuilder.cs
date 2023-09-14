// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph.Networkaccess
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface INetworkAccessRootRequestBuilder.
    /// </summary>
    public partial interface INetworkAccessRootRequestBuilder : Microsoft.Graph.IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new INetworkAccessRootRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new INetworkAccessRootRequest Request(IEnumerable<Microsoft.Graph.Option> options);
    
        /// <summary>
        /// Gets the request builder for Logs.
        /// </summary>
        /// <returns>The <see cref="ILogsRequestBuilder"/>.</returns>
        ILogsRequestBuilder Logs { get; }

        /// <summary>
        /// Gets the request builder for Reports.
        /// </summary>
        /// <returns>The <see cref="IReportsRequestBuilder"/>.</returns>
        IReportsRequestBuilder Reports { get; }

        /// <summary>
        /// Gets the request builder for Connectivity.
        /// </summary>
        /// <returns>The <see cref="IConnectivityRequestBuilder"/>.</returns>
        IConnectivityRequestBuilder Connectivity { get; }

        /// <summary>
        /// Gets the request builder for ForwardingPolicies.
        /// </summary>
        /// <returns>The <see cref="INetworkAccessRootForwardingPoliciesCollectionRequestBuilder"/>.</returns>
        INetworkAccessRootForwardingPoliciesCollectionRequestBuilder ForwardingPolicies { get; }

        /// <summary>
        /// Gets the request builder for ForwardingProfiles.
        /// </summary>
        /// <returns>The <see cref="INetworkAccessRootForwardingProfilesCollectionRequestBuilder"/>.</returns>
        INetworkAccessRootForwardingProfilesCollectionRequestBuilder ForwardingProfiles { get; }

        /// <summary>
        /// Gets the request builder for Settings.
        /// </summary>
        /// <returns>The <see cref="ISettingsRequestBuilder"/>.</returns>
        ISettingsRequestBuilder Settings { get; }

        /// <summary>
        /// Gets the request builder for TenantStatus.
        /// </summary>
        /// <returns>The <see cref="ITenantStatusRequestBuilder"/>.</returns>
        ITenantStatusRequestBuilder TenantStatus { get; }
    
        /// <summary>
        /// Gets the request builder for NetworkAccessRootOnboard.
        /// </summary>
        /// <returns>The <see cref="INetworkAccessRootOnboardRequestBuilder"/>.</returns>
        INetworkAccessRootOnboardRequestBuilder Onboard();
    
    }
}
