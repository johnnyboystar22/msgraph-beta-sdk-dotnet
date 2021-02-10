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
    /// The type EntitlementManagementRequestBuilder.
    /// </summary>
    public partial class EntitlementManagementRequestBuilder : EntityRequestBuilder, IEntitlementManagementRequestBuilder
    {

        /// <summary>
        /// Constructs a new EntitlementManagementRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public EntitlementManagementRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IEntitlementManagementRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IEntitlementManagementRequest Request(IEnumerable<Option> options)
        {
            return new EntitlementManagementRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for AccessPackageAssignmentPolicies.
        /// </summary>
        /// <returns>The <see cref="IEntitlementManagementAccessPackageAssignmentPoliciesCollectionRequestBuilder"/>.</returns>
        public IEntitlementManagementAccessPackageAssignmentPoliciesCollectionRequestBuilder AccessPackageAssignmentPolicies
        {
            get
            {
                return new EntitlementManagementAccessPackageAssignmentPoliciesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("accessPackageAssignmentPolicies"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AccessPackageAssignmentRequests.
        /// </summary>
        /// <returns>The <see cref="IEntitlementManagementAccessPackageAssignmentRequestsCollectionRequestBuilder"/>.</returns>
        public IEntitlementManagementAccessPackageAssignmentRequestsCollectionRequestBuilder AccessPackageAssignmentRequests
        {
            get
            {
                return new EntitlementManagementAccessPackageAssignmentRequestsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("accessPackageAssignmentRequests"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AccessPackageAssignmentResourceRoles.
        /// </summary>
        /// <returns>The <see cref="IEntitlementManagementAccessPackageAssignmentResourceRolesCollectionRequestBuilder"/>.</returns>
        public IEntitlementManagementAccessPackageAssignmentResourceRolesCollectionRequestBuilder AccessPackageAssignmentResourceRoles
        {
            get
            {
                return new EntitlementManagementAccessPackageAssignmentResourceRolesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("accessPackageAssignmentResourceRoles"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AccessPackageAssignments.
        /// </summary>
        /// <returns>The <see cref="IEntitlementManagementAccessPackageAssignmentsCollectionRequestBuilder"/>.</returns>
        public IEntitlementManagementAccessPackageAssignmentsCollectionRequestBuilder AccessPackageAssignments
        {
            get
            {
                return new EntitlementManagementAccessPackageAssignmentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("accessPackageAssignments"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AccessPackageCatalogs.
        /// </summary>
        /// <returns>The <see cref="IEntitlementManagementAccessPackageCatalogsCollectionRequestBuilder"/>.</returns>
        public IEntitlementManagementAccessPackageCatalogsCollectionRequestBuilder AccessPackageCatalogs
        {
            get
            {
                return new EntitlementManagementAccessPackageCatalogsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("accessPackageCatalogs"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AccessPackageResourceEnvironments.
        /// </summary>
        /// <returns>The <see cref="IEntitlementManagementAccessPackageResourceEnvironmentsCollectionRequestBuilder"/>.</returns>
        public IEntitlementManagementAccessPackageResourceEnvironmentsCollectionRequestBuilder AccessPackageResourceEnvironments
        {
            get
            {
                return new EntitlementManagementAccessPackageResourceEnvironmentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("accessPackageResourceEnvironments"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AccessPackageResourceRequests.
        /// </summary>
        /// <returns>The <see cref="IEntitlementManagementAccessPackageResourceRequestsCollectionRequestBuilder"/>.</returns>
        public IEntitlementManagementAccessPackageResourceRequestsCollectionRequestBuilder AccessPackageResourceRequests
        {
            get
            {
                return new EntitlementManagementAccessPackageResourceRequestsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("accessPackageResourceRequests"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AccessPackageResourceRoleScopes.
        /// </summary>
        /// <returns>The <see cref="IEntitlementManagementAccessPackageResourceRoleScopesCollectionRequestBuilder"/>.</returns>
        public IEntitlementManagementAccessPackageResourceRoleScopesCollectionRequestBuilder AccessPackageResourceRoleScopes
        {
            get
            {
                return new EntitlementManagementAccessPackageResourceRoleScopesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("accessPackageResourceRoleScopes"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AccessPackageResources.
        /// </summary>
        /// <returns>The <see cref="IEntitlementManagementAccessPackageResourcesCollectionRequestBuilder"/>.</returns>
        public IEntitlementManagementAccessPackageResourcesCollectionRequestBuilder AccessPackageResources
        {
            get
            {
                return new EntitlementManagementAccessPackageResourcesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("accessPackageResources"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AccessPackages.
        /// </summary>
        /// <returns>The <see cref="IEntitlementManagementAccessPackagesCollectionRequestBuilder"/>.</returns>
        public IEntitlementManagementAccessPackagesCollectionRequestBuilder AccessPackages
        {
            get
            {
                return new EntitlementManagementAccessPackagesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("accessPackages"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ConnectedOrganizations.
        /// </summary>
        /// <returns>The <see cref="IEntitlementManagementConnectedOrganizationsCollectionRequestBuilder"/>.</returns>
        public IEntitlementManagementConnectedOrganizationsCollectionRequestBuilder ConnectedOrganizations
        {
            get
            {
                return new EntitlementManagementConnectedOrganizationsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("connectedOrganizations"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Settings.
        /// </summary>
        /// <returns>The <see cref="IEntitlementManagementSettingsRequestBuilder"/>.</returns>
        public IEntitlementManagementSettingsRequestBuilder Settings
        {
            get
            {
                return new EntitlementManagementSettingsRequestBuilder(this.AppendSegmentToRequestUrl("settings"), this.Client);
            }
        }
    
    }
}
