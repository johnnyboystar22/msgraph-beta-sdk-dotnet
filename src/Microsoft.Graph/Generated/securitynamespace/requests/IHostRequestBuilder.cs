// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IHostRequestBuilder.
    /// </summary>
    public partial interface IHostRequestBuilder : IArtifactRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IHostRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IHostRequest Request(IEnumerable<Microsoft.Graph.Option> options);
    
        /// <summary>
        /// Gets the request builder for ChildHostPairs.
        /// </summary>
        /// <returns>The <see cref="IHostChildHostPairsCollectionWithReferencesRequestBuilder"/>.</returns>
        IHostChildHostPairsCollectionWithReferencesRequestBuilder ChildHostPairs { get; }

        /// <summary>
        /// Gets the request builder for Components.
        /// </summary>
        /// <returns>The <see cref="IHostComponentsCollectionWithReferencesRequestBuilder"/>.</returns>
        IHostComponentsCollectionWithReferencesRequestBuilder Components { get; }

        /// <summary>
        /// Gets the request builder for Cookies.
        /// </summary>
        /// <returns>The <see cref="IHostCookiesCollectionWithReferencesRequestBuilder"/>.</returns>
        IHostCookiesCollectionWithReferencesRequestBuilder Cookies { get; }

        /// <summary>
        /// Gets the request builder for HostPairs.
        /// </summary>
        /// <returns>The <see cref="IHostHostPairsCollectionWithReferencesRequestBuilder"/>.</returns>
        IHostHostPairsCollectionWithReferencesRequestBuilder HostPairs { get; }

        /// <summary>
        /// Gets the request builder for ParentHostPairs.
        /// </summary>
        /// <returns>The <see cref="IHostParentHostPairsCollectionWithReferencesRequestBuilder"/>.</returns>
        IHostParentHostPairsCollectionWithReferencesRequestBuilder ParentHostPairs { get; }

        /// <summary>
        /// Gets the request builder for PassiveDns.
        /// </summary>
        /// <returns>The <see cref="IHostPassiveDnsCollectionWithReferencesRequestBuilder"/>.</returns>
        IHostPassiveDnsCollectionWithReferencesRequestBuilder PassiveDns { get; }

        /// <summary>
        /// Gets the request builder for PassiveDnsReverse.
        /// </summary>
        /// <returns>The <see cref="IHostPassiveDnsReverseCollectionWithReferencesRequestBuilder"/>.</returns>
        IHostPassiveDnsReverseCollectionWithReferencesRequestBuilder PassiveDnsReverse { get; }

        /// <summary>
        /// Gets the request builder for Reputation.
        /// </summary>
        /// <returns>The <see cref="IHostReputationRequestBuilder"/>.</returns>
        IHostReputationRequestBuilder Reputation { get; }

        /// <summary>
        /// Gets the request builder for SslCertificates.
        /// </summary>
        /// <returns>The <see cref="IHostSslCertificatesCollectionWithReferencesRequestBuilder"/>.</returns>
        IHostSslCertificatesCollectionWithReferencesRequestBuilder SslCertificates { get; }

        /// <summary>
        /// Gets the request builder for Subdomains.
        /// </summary>
        /// <returns>The <see cref="IHostSubdomainsCollectionWithReferencesRequestBuilder"/>.</returns>
        IHostSubdomainsCollectionWithReferencesRequestBuilder Subdomains { get; }

        /// <summary>
        /// Gets the request builder for Trackers.
        /// </summary>
        /// <returns>The <see cref="IHostTrackersCollectionWithReferencesRequestBuilder"/>.</returns>
        IHostTrackersCollectionWithReferencesRequestBuilder Trackers { get; }

        /// <summary>
        /// Gets the request builder for Whois.
        /// </summary>
        /// <returns>The <see cref="IWhoisRecordWithReferenceRequestBuilder"/>.</returns>
        IWhoisRecordWithReferenceRequestBuilder Whois { get; }
    
    }
}
