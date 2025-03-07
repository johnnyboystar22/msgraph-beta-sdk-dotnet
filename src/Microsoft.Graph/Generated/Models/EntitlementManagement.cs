// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class EntitlementManagement : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The accessPackageAssignmentApprovals property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Approval>? AccessPackageAssignmentApprovals
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Approval>?>("accessPackageAssignmentApprovals"); }
            set { BackingStore?.Set("accessPackageAssignmentApprovals", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Approval> AccessPackageAssignmentApprovals
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Approval>>("accessPackageAssignmentApprovals"); }
            set { BackingStore?.Set("accessPackageAssignmentApprovals", value); }
        }
#endif
        /// <summary>Represents the policy that governs which subjects can request or be assigned an access package via an access package assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.AccessPackageAssignmentPolicy>? AccessPackageAssignmentPolicies
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessPackageAssignmentPolicy>?>("accessPackageAssignmentPolicies"); }
            set { BackingStore?.Set("accessPackageAssignmentPolicies", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.AccessPackageAssignmentPolicy> AccessPackageAssignmentPolicies
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessPackageAssignmentPolicy>>("accessPackageAssignmentPolicies"); }
            set { BackingStore?.Set("accessPackageAssignmentPolicies", value); }
        }
#endif
        /// <summary>Represents access package assignment requests created by or on behalf of a user. DO NOT USE. TO BE RETIRED SOON. Use the assignmentRequests relationship instead.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.AccessPackageAssignmentRequest>? AccessPackageAssignmentRequests
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessPackageAssignmentRequest>?>("accessPackageAssignmentRequests"); }
            set { BackingStore?.Set("accessPackageAssignmentRequests", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.AccessPackageAssignmentRequest> AccessPackageAssignmentRequests
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessPackageAssignmentRequest>>("accessPackageAssignmentRequests"); }
            set { BackingStore?.Set("accessPackageAssignmentRequests", value); }
        }
#endif
        /// <summary>Represents the resource-specific role which a subject has been assigned through an access package assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.AccessPackageAssignmentResourceRole>? AccessPackageAssignmentResourceRoles
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessPackageAssignmentResourceRole>?>("accessPackageAssignmentResourceRoles"); }
            set { BackingStore?.Set("accessPackageAssignmentResourceRoles", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.AccessPackageAssignmentResourceRole> AccessPackageAssignmentResourceRoles
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessPackageAssignmentResourceRole>>("accessPackageAssignmentResourceRoles"); }
            set { BackingStore?.Set("accessPackageAssignmentResourceRoles", value); }
        }
#endif
        /// <summary>The assignment of an access package to a subject for a period of time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.AccessPackageAssignment>? AccessPackageAssignments
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessPackageAssignment>?>("accessPackageAssignments"); }
            set { BackingStore?.Set("accessPackageAssignments", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.AccessPackageAssignment> AccessPackageAssignments
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessPackageAssignment>>("accessPackageAssignments"); }
            set { BackingStore?.Set("accessPackageAssignments", value); }
        }
#endif
        /// <summary>A container of access packages.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.AccessPackageCatalog>? AccessPackageCatalogs
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessPackageCatalog>?>("accessPackageCatalogs"); }
            set { BackingStore?.Set("accessPackageCatalogs", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.AccessPackageCatalog> AccessPackageCatalogs
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessPackageCatalog>>("accessPackageCatalogs"); }
            set { BackingStore?.Set("accessPackageCatalogs", value); }
        }
#endif
        /// <summary>A reference to the geolocation environment in which a resource is located.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.AccessPackageResourceEnvironment>? AccessPackageResourceEnvironments
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessPackageResourceEnvironment>?>("accessPackageResourceEnvironments"); }
            set { BackingStore?.Set("accessPackageResourceEnvironments", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.AccessPackageResourceEnvironment> AccessPackageResourceEnvironments
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessPackageResourceEnvironment>>("accessPackageResourceEnvironments"); }
            set { BackingStore?.Set("accessPackageResourceEnvironments", value); }
        }
#endif
        /// <summary>Represents a request to add or remove a resource to or from a catalog respectively.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.AccessPackageResourceRequest>? AccessPackageResourceRequests
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessPackageResourceRequest>?>("accessPackageResourceRequests"); }
            set { BackingStore?.Set("accessPackageResourceRequests", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.AccessPackageResourceRequest> AccessPackageResourceRequests
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessPackageResourceRequest>>("accessPackageResourceRequests"); }
            set { BackingStore?.Set("accessPackageResourceRequests", value); }
        }
#endif
        /// <summary>A reference to both a scope within a resource, and a role in that resource for that scope.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.AccessPackageResourceRoleScope>? AccessPackageResourceRoleScopes
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessPackageResourceRoleScope>?>("accessPackageResourceRoleScopes"); }
            set { BackingStore?.Set("accessPackageResourceRoleScopes", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.AccessPackageResourceRoleScope> AccessPackageResourceRoleScopes
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessPackageResourceRoleScope>>("accessPackageResourceRoleScopes"); }
            set { BackingStore?.Set("accessPackageResourceRoleScopes", value); }
        }
#endif
        /// <summary>A reference to a resource associated with an access package catalog.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.AccessPackageResource>? AccessPackageResources
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessPackageResource>?>("accessPackageResources"); }
            set { BackingStore?.Set("accessPackageResources", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.AccessPackageResource> AccessPackageResources
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessPackageResource>>("accessPackageResources"); }
            set { BackingStore?.Set("accessPackageResources", value); }
        }
#endif
        /// <summary>Represents access package objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.AccessPackage>? AccessPackages
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessPackage>?>("accessPackages"); }
            set { BackingStore?.Set("accessPackages", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.AccessPackage> AccessPackages
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessPackage>>("accessPackages"); }
            set { BackingStore?.Set("accessPackages", value); }
        }
#endif
        /// <summary>Represents access package assignment requests created by or on behalf of a user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.AccessPackageAssignmentRequest>? AssignmentRequests
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessPackageAssignmentRequest>?>("assignmentRequests"); }
            set { BackingStore?.Set("assignmentRequests", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.AccessPackageAssignmentRequest> AssignmentRequests
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessPackageAssignmentRequest>>("assignmentRequests"); }
            set { BackingStore?.Set("assignmentRequests", value); }
        }
#endif
        /// <summary>Represents references to a directory or domain of another organization whose users can request access.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.ConnectedOrganization>? ConnectedOrganizations
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ConnectedOrganization>?>("connectedOrganizations"); }
            set { BackingStore?.Set("connectedOrganizations", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.ConnectedOrganization> ConnectedOrganizations
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ConnectedOrganization>>("connectedOrganizations"); }
            set { BackingStore?.Set("connectedOrganizations", value); }
        }
#endif
        /// <summary>Represents the settings that control the behavior of Microsoft Entra entitlement management.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.EntitlementManagementSettings? Settings
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EntitlementManagementSettings?>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.EntitlementManagementSettings Settings
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EntitlementManagementSettings>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#endif
        /// <summary>Represents the subjects within entitlement management.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.AccessPackageSubject>? Subjects
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessPackageSubject>?>("subjects"); }
            set { BackingStore?.Set("subjects", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.AccessPackageSubject> Subjects
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessPackageSubject>>("subjects"); }
            set { BackingStore?.Set("subjects", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.EntitlementManagement"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.EntitlementManagement CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.EntitlementManagement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accessPackageAssignmentApprovals", n => { AccessPackageAssignmentApprovals = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Approval>(Microsoft.Graph.Beta.Models.Approval.CreateFromDiscriminatorValue)?.ToList(); } },
                { "accessPackageAssignmentPolicies", n => { AccessPackageAssignmentPolicies = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackageAssignmentPolicy>(Microsoft.Graph.Beta.Models.AccessPackageAssignmentPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                { "accessPackageAssignmentRequests", n => { AccessPackageAssignmentRequests = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackageAssignmentRequest>(Microsoft.Graph.Beta.Models.AccessPackageAssignmentRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                { "accessPackageAssignmentResourceRoles", n => { AccessPackageAssignmentResourceRoles = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackageAssignmentResourceRole>(Microsoft.Graph.Beta.Models.AccessPackageAssignmentResourceRole.CreateFromDiscriminatorValue)?.ToList(); } },
                { "accessPackageAssignments", n => { AccessPackageAssignments = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackageAssignment>(Microsoft.Graph.Beta.Models.AccessPackageAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                { "accessPackageCatalogs", n => { AccessPackageCatalogs = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackageCatalog>(Microsoft.Graph.Beta.Models.AccessPackageCatalog.CreateFromDiscriminatorValue)?.ToList(); } },
                { "accessPackageResourceEnvironments", n => { AccessPackageResourceEnvironments = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackageResourceEnvironment>(Microsoft.Graph.Beta.Models.AccessPackageResourceEnvironment.CreateFromDiscriminatorValue)?.ToList(); } },
                { "accessPackageResourceRequests", n => { AccessPackageResourceRequests = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackageResourceRequest>(Microsoft.Graph.Beta.Models.AccessPackageResourceRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                { "accessPackageResourceRoleScopes", n => { AccessPackageResourceRoleScopes = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackageResourceRoleScope>(Microsoft.Graph.Beta.Models.AccessPackageResourceRoleScope.CreateFromDiscriminatorValue)?.ToList(); } },
                { "accessPackageResources", n => { AccessPackageResources = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackageResource>(Microsoft.Graph.Beta.Models.AccessPackageResource.CreateFromDiscriminatorValue)?.ToList(); } },
                { "accessPackages", n => { AccessPackages = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackage>(Microsoft.Graph.Beta.Models.AccessPackage.CreateFromDiscriminatorValue)?.ToList(); } },
                { "assignmentRequests", n => { AssignmentRequests = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackageAssignmentRequest>(Microsoft.Graph.Beta.Models.AccessPackageAssignmentRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                { "connectedOrganizations", n => { ConnectedOrganizations = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ConnectedOrganization>(Microsoft.Graph.Beta.Models.ConnectedOrganization.CreateFromDiscriminatorValue)?.ToList(); } },
                { "settings", n => { Settings = n.GetObjectValue<Microsoft.Graph.Beta.Models.EntitlementManagementSettings>(Microsoft.Graph.Beta.Models.EntitlementManagementSettings.CreateFromDiscriminatorValue); } },
                { "subjects", n => { Subjects = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackageSubject>(Microsoft.Graph.Beta.Models.AccessPackageSubject.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Approval>("accessPackageAssignmentApprovals", AccessPackageAssignmentApprovals);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackageAssignmentPolicy>("accessPackageAssignmentPolicies", AccessPackageAssignmentPolicies);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackageAssignmentRequest>("accessPackageAssignmentRequests", AccessPackageAssignmentRequests);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackageAssignmentResourceRole>("accessPackageAssignmentResourceRoles", AccessPackageAssignmentResourceRoles);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackageAssignment>("accessPackageAssignments", AccessPackageAssignments);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackageCatalog>("accessPackageCatalogs", AccessPackageCatalogs);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackageResourceEnvironment>("accessPackageResourceEnvironments", AccessPackageResourceEnvironments);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackageResourceRequest>("accessPackageResourceRequests", AccessPackageResourceRequests);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackageResourceRoleScope>("accessPackageResourceRoleScopes", AccessPackageResourceRoleScopes);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackageResource>("accessPackageResources", AccessPackageResources);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackage>("accessPackages", AccessPackages);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackageAssignmentRequest>("assignmentRequests", AssignmentRequests);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ConnectedOrganization>("connectedOrganizations", ConnectedOrganizations);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.EntitlementManagementSettings>("settings", Settings);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackageSubject>("subjects", Subjects);
        }
    }
}
