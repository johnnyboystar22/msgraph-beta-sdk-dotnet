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
    /// The type PolicyRootRequestBuilder.
    /// </summary>
    public partial class PolicyRootRequestBuilder : BaseRequestBuilder, IPolicyRootRequestBuilder
    {

        /// <summary>
        /// Constructs a new PolicyRootRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PolicyRootRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IPolicyRootRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IPolicyRootRequest Request(IEnumerable<Option> options)
        {
            return new PolicyRootRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for AuthenticationMethodsPolicy.
        /// </summary>
        /// <returns>The <see cref="IAuthenticationMethodsPolicyRequestBuilder"/>.</returns>
        public IAuthenticationMethodsPolicyRequestBuilder AuthenticationMethodsPolicy
        {
            get
            {
                return new AuthenticationMethodsPolicyRequestBuilder(this.AppendSegmentToRequestUrl("authenticationMethodsPolicy"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AuthenticationFlowsPolicy.
        /// </summary>
        /// <returns>The <see cref="IAuthenticationFlowsPolicyRequestBuilder"/>.</returns>
        public IAuthenticationFlowsPolicyRequestBuilder AuthenticationFlowsPolicy
        {
            get
            {
                return new AuthenticationFlowsPolicyRequestBuilder(this.AppendSegmentToRequestUrl("authenticationFlowsPolicy"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for B2cAuthenticationMethodsPolicy.
        /// </summary>
        /// <returns>The <see cref="IB2cAuthenticationMethodsPolicyRequestBuilder"/>.</returns>
        public IB2cAuthenticationMethodsPolicyRequestBuilder B2cAuthenticationMethodsPolicy
        {
            get
            {
                return new B2cAuthenticationMethodsPolicyRequestBuilder(this.AppendSegmentToRequestUrl("b2cAuthenticationMethodsPolicy"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ActivityBasedTimeoutPolicies.
        /// </summary>
        /// <returns>The <see cref="IPolicyRootActivityBasedTimeoutPoliciesCollectionRequestBuilder"/>.</returns>
        public IPolicyRootActivityBasedTimeoutPoliciesCollectionRequestBuilder ActivityBasedTimeoutPolicies
        {
            get
            {
                return new PolicyRootActivityBasedTimeoutPoliciesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("activityBasedTimeoutPolicies"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AuthorizationPolicy.
        /// </summary>
        /// <returns>The <see cref="IPolicyRootAuthorizationPolicyCollectionRequestBuilder"/>.</returns>
        public IPolicyRootAuthorizationPolicyCollectionRequestBuilder AuthorizationPolicy
        {
            get
            {
                return new PolicyRootAuthorizationPolicyCollectionRequestBuilder(this.AppendSegmentToRequestUrl("authorizationPolicy"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ClaimsMappingPolicies.
        /// </summary>
        /// <returns>The <see cref="IPolicyRootClaimsMappingPoliciesCollectionRequestBuilder"/>.</returns>
        public IPolicyRootClaimsMappingPoliciesCollectionRequestBuilder ClaimsMappingPolicies
        {
            get
            {
                return new PolicyRootClaimsMappingPoliciesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("claimsMappingPolicies"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for HomeRealmDiscoveryPolicies.
        /// </summary>
        /// <returns>The <see cref="IPolicyRootHomeRealmDiscoveryPoliciesCollectionRequestBuilder"/>.</returns>
        public IPolicyRootHomeRealmDiscoveryPoliciesCollectionRequestBuilder HomeRealmDiscoveryPolicies
        {
            get
            {
                return new PolicyRootHomeRealmDiscoveryPoliciesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("homeRealmDiscoveryPolicies"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for PermissionGrantPolicies.
        /// </summary>
        /// <returns>The <see cref="IPolicyRootPermissionGrantPoliciesCollectionRequestBuilder"/>.</returns>
        public IPolicyRootPermissionGrantPoliciesCollectionRequestBuilder PermissionGrantPolicies
        {
            get
            {
                return new PolicyRootPermissionGrantPoliciesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("permissionGrantPolicies"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for TokenIssuancePolicies.
        /// </summary>
        /// <returns>The <see cref="IPolicyRootTokenIssuancePoliciesCollectionRequestBuilder"/>.</returns>
        public IPolicyRootTokenIssuancePoliciesCollectionRequestBuilder TokenIssuancePolicies
        {
            get
            {
                return new PolicyRootTokenIssuancePoliciesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("tokenIssuancePolicies"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for TokenLifetimePolicies.
        /// </summary>
        /// <returns>The <see cref="IPolicyRootTokenLifetimePoliciesCollectionRequestBuilder"/>.</returns>
        public IPolicyRootTokenLifetimePoliciesCollectionRequestBuilder TokenLifetimePolicies
        {
            get
            {
                return new PolicyRootTokenLifetimePoliciesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("tokenLifetimePolicies"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for FeatureRolloutPolicies.
        /// </summary>
        /// <returns>The <see cref="IPolicyRootFeatureRolloutPoliciesCollectionRequestBuilder"/>.</returns>
        public IPolicyRootFeatureRolloutPoliciesCollectionRequestBuilder FeatureRolloutPolicies
        {
            get
            {
                return new PolicyRootFeatureRolloutPoliciesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("featureRolloutPolicies"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AdminConsentRequestPolicy.
        /// </summary>
        /// <returns>The <see cref="IAdminConsentRequestPolicyRequestBuilder"/>.</returns>
        public IAdminConsentRequestPolicyRequestBuilder AdminConsentRequestPolicy
        {
            get
            {
                return new AdminConsentRequestPolicyRequestBuilder(this.AppendSegmentToRequestUrl("adminConsentRequestPolicy"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DirectoryRoleAccessReviewPolicy.
        /// </summary>
        /// <returns>The <see cref="IDirectoryRoleAccessReviewPolicyRequestBuilder"/>.</returns>
        public IDirectoryRoleAccessReviewPolicyRequestBuilder DirectoryRoleAccessReviewPolicy
        {
            get
            {
                return new DirectoryRoleAccessReviewPolicyRequestBuilder(this.AppendSegmentToRequestUrl("directoryRoleAccessReviewPolicy"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ConditionalAccessPolicies.
        /// </summary>
        /// <returns>The <see cref="IPolicyRootConditionalAccessPoliciesCollectionRequestBuilder"/>.</returns>
        public IPolicyRootConditionalAccessPoliciesCollectionRequestBuilder ConditionalAccessPolicies
        {
            get
            {
                return new PolicyRootConditionalAccessPoliciesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("conditionalAccessPolicies"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for IdentitySecurityDefaultsEnforcementPolicy.
        /// </summary>
        /// <returns>The <see cref="IIdentitySecurityDefaultsEnforcementPolicyRequestBuilder"/>.</returns>
        public IIdentitySecurityDefaultsEnforcementPolicyRequestBuilder IdentitySecurityDefaultsEnforcementPolicy
        {
            get
            {
                return new IdentitySecurityDefaultsEnforcementPolicyRequestBuilder(this.AppendSegmentToRequestUrl("identitySecurityDefaultsEnforcementPolicy"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for RoleManagementPolicies.
        /// </summary>
        /// <returns>The <see cref="IPolicyRootRoleManagementPoliciesCollectionRequestBuilder"/>.</returns>
        public IPolicyRootRoleManagementPoliciesCollectionRequestBuilder RoleManagementPolicies
        {
            get
            {
                return new PolicyRootRoleManagementPoliciesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("roleManagementPolicies"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for RoleManagementPolicyAssignments.
        /// </summary>
        /// <returns>The <see cref="IPolicyRootRoleManagementPolicyAssignmentsCollectionRequestBuilder"/>.</returns>
        public IPolicyRootRoleManagementPolicyAssignmentsCollectionRequestBuilder RoleManagementPolicyAssignments
        {
            get
            {
                return new PolicyRootRoleManagementPolicyAssignmentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("roleManagementPolicyAssignments"), this.Client);
            }
        }
    
    }
}
