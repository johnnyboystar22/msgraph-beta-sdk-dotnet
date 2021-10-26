// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ApplicationRequestBuilder.
    /// </summary>
    public partial class ApplicationRequestBuilder : DirectoryObjectRequestBuilder, IApplicationRequestBuilder
    {

        /// <summary>
        /// Constructs a new ApplicationRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ApplicationRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IApplicationRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IApplicationRequest Request(IEnumerable<Option> options)
        {
            return new ApplicationRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for AppManagementPolicies.
        /// </summary>
        /// <returns>The <see cref="IApplicationAppManagementPoliciesCollectionWithReferencesRequestBuilder"/>.</returns>
        public IApplicationAppManagementPoliciesCollectionWithReferencesRequestBuilder AppManagementPolicies
        {
            get
            {
                return new ApplicationAppManagementPoliciesCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("appManagementPolicies"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for CreatedOnBehalfOf.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectWithReferenceRequestBuilder"/>.</returns>
        public IDirectoryObjectWithReferenceRequestBuilder CreatedOnBehalfOf
        {
            get
            {
                return new DirectoryObjectWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("createdOnBehalfOf"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ExtensionProperties.
        /// </summary>
        /// <returns>The <see cref="IApplicationExtensionPropertiesCollectionRequestBuilder"/>.</returns>
        public IApplicationExtensionPropertiesCollectionRequestBuilder ExtensionProperties
        {
            get
            {
                return new ApplicationExtensionPropertiesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("extensionProperties"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for FederatedIdentityCredentials.
        /// </summary>
        /// <returns>The <see cref="IApplicationFederatedIdentityCredentialsCollectionRequestBuilder"/>.</returns>
        public IApplicationFederatedIdentityCredentialsCollectionRequestBuilder FederatedIdentityCredentials
        {
            get
            {
                return new ApplicationFederatedIdentityCredentialsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("federatedIdentityCredentials"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for HomeRealmDiscoveryPolicies.
        /// </summary>
        /// <returns>The <see cref="IApplicationHomeRealmDiscoveryPoliciesCollectionWithReferencesRequestBuilder"/>.</returns>
        public IApplicationHomeRealmDiscoveryPoliciesCollectionWithReferencesRequestBuilder HomeRealmDiscoveryPolicies
        {
            get
            {
                return new ApplicationHomeRealmDiscoveryPoliciesCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("homeRealmDiscoveryPolicies"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Owners.
        /// </summary>
        /// <returns>The <see cref="IApplicationOwnersCollectionWithReferencesRequestBuilder"/>.</returns>
        public IApplicationOwnersCollectionWithReferencesRequestBuilder Owners
        {
            get
            {
                return new ApplicationOwnersCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("owners"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for TokenIssuancePolicies.
        /// </summary>
        /// <returns>The <see cref="IApplicationTokenIssuancePoliciesCollectionWithReferencesRequestBuilder"/>.</returns>
        public IApplicationTokenIssuancePoliciesCollectionWithReferencesRequestBuilder TokenIssuancePolicies
        {
            get
            {
                return new ApplicationTokenIssuancePoliciesCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("tokenIssuancePolicies"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for TokenLifetimePolicies.
        /// </summary>
        /// <returns>The <see cref="IApplicationTokenLifetimePoliciesCollectionWithReferencesRequestBuilder"/>.</returns>
        public IApplicationTokenLifetimePoliciesCollectionWithReferencesRequestBuilder TokenLifetimePolicies
        {
            get
            {
                return new ApplicationTokenLifetimePoliciesCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("tokenLifetimePolicies"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ConnectorGroup.
        /// </summary>
        /// <returns>The <see cref="IConnectorGroupWithReferenceRequestBuilder"/>.</returns>
        public IConnectorGroupWithReferenceRequestBuilder ConnectorGroup
        {
            get
            {
                return new ConnectorGroupWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("connectorGroup"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Synchronization.
        /// </summary>
        /// <returns>The <see cref="ISynchronizationRequestBuilder"/>.</returns>
        public ISynchronizationRequestBuilder Synchronization
        {
            get
            {
                return new SynchronizationRequestBuilder(this.AppendSegmentToRequestUrl("synchronization"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for Logo.
        /// </summary>
        /// <returns>The <see cref="IApplicationLogoRequestBuilder"/>.</returns>
        public IApplicationLogoRequestBuilder Logo
        {
            get
            {
                return new ApplicationLogoRequestBuilder(this.AppendSegmentToRequestUrl("logo"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for ApplicationSetVerifiedPublisher.
        /// </summary>
        /// <returns>The <see cref="IApplicationSetVerifiedPublisherRequestBuilder"/>.</returns>
        public IApplicationSetVerifiedPublisherRequestBuilder SetVerifiedPublisher(
            string verifiedPublisherId)
        {
            return new ApplicationSetVerifiedPublisherRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.setVerifiedPublisher"),
                this.Client,
                verifiedPublisherId);
        }

        /// <summary>
        /// Gets the request builder for ApplicationUnsetVerifiedPublisher.
        /// </summary>
        /// <returns>The <see cref="IApplicationUnsetVerifiedPublisherRequestBuilder"/>.</returns>
        public IApplicationUnsetVerifiedPublisherRequestBuilder UnsetVerifiedPublisher()
        {
            return new ApplicationUnsetVerifiedPublisherRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.unsetVerifiedPublisher"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for ApplicationAddKey.
        /// </summary>
        /// <returns>The <see cref="IApplicationAddKeyRequestBuilder"/>.</returns>
        public IApplicationAddKeyRequestBuilder AddKey(
            KeyCredential keyCredential,
            string proof,
            PasswordCredential passwordCredential = null)
        {
            return new ApplicationAddKeyRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.addKey"),
                this.Client,
                keyCredential,
                proof,
                passwordCredential);
        }

        /// <summary>
        /// Gets the request builder for ApplicationAddPassword.
        /// </summary>
        /// <returns>The <see cref="IApplicationAddPasswordRequestBuilder"/>.</returns>
        public IApplicationAddPasswordRequestBuilder AddPassword(
            PasswordCredential passwordCredential = null)
        {
            return new ApplicationAddPasswordRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.addPassword"),
                this.Client,
                passwordCredential);
        }

        /// <summary>
        /// Gets the request builder for ApplicationRemoveKey.
        /// </summary>
        /// <returns>The <see cref="IApplicationRemoveKeyRequestBuilder"/>.</returns>
        public IApplicationRemoveKeyRequestBuilder RemoveKey(
            Guid keyId,
            string proof)
        {
            return new ApplicationRemoveKeyRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.removeKey"),
                this.Client,
                keyId,
                proof);
        }

        /// <summary>
        /// Gets the request builder for ApplicationRemovePassword.
        /// </summary>
        /// <returns>The <see cref="IApplicationRemovePasswordRequestBuilder"/>.</returns>
        public IApplicationRemovePasswordRequestBuilder RemovePassword(
            Guid keyId)
        {
            return new ApplicationRemovePasswordRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.removePassword"),
                this.Client,
                keyId);
        }
    
    }
}
