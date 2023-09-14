// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type HardwareOathAuthenticationMethodConfigurationIncludeTargetsCollectionRequestBuilder.
    /// </summary>
    public partial class HardwareOathAuthenticationMethodConfigurationIncludeTargetsCollectionRequestBuilder : BaseRequestBuilder, IHardwareOathAuthenticationMethodConfigurationIncludeTargetsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new HardwareOathAuthenticationMethodConfigurationIncludeTargetsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public HardwareOathAuthenticationMethodConfigurationIncludeTargetsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IHardwareOathAuthenticationMethodConfigurationIncludeTargetsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IHardwareOathAuthenticationMethodConfigurationIncludeTargetsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new HardwareOathAuthenticationMethodConfigurationIncludeTargetsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IAuthenticationMethodTargetRequestBuilder"/> for the specified HardwareOathAuthenticationMethodConfigurationAuthenticationMethodTarget.
        /// </summary>
        /// <param name="id">The ID for the HardwareOathAuthenticationMethodConfigurationAuthenticationMethodTarget.</param>
        /// <returns>The <see cref="IAuthenticationMethodTargetRequestBuilder"/>.</returns>
        public IAuthenticationMethodTargetRequestBuilder this[string id]
        {
            get
            {
                return new AuthenticationMethodTargetRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
