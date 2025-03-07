// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class AccessPackageCatalog : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The attributes of a logic app, which can be called at various stages of an access package request and assignment cycle.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.CustomCalloutExtension>? AccessPackageCustomWorkflowExtensions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.CustomCalloutExtension>?>("accessPackageCustomWorkflowExtensions"); }
            set { BackingStore?.Set("accessPackageCustomWorkflowExtensions", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.CustomCalloutExtension> AccessPackageCustomWorkflowExtensions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.CustomCalloutExtension>>("accessPackageCustomWorkflowExtensions"); }
            set { BackingStore?.Set("accessPackageCustomWorkflowExtensions", value); }
        }
#endif
        /// <summary>The roles in each resource in a catalog. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.AccessPackageResourceRole>? AccessPackageResourceRoles
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessPackageResourceRole>?>("accessPackageResourceRoles"); }
            set { BackingStore?.Set("accessPackageResourceRoles", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.AccessPackageResourceRole> AccessPackageResourceRoles
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessPackageResourceRole>>("accessPackageResourceRoles"); }
            set { BackingStore?.Set("accessPackageResourceRoles", value); }
        }
#endif
        /// <summary>The accessPackageResources property</summary>
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
        /// <summary>The accessPackageResourceScopes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.AccessPackageResourceScope>? AccessPackageResourceScopes
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessPackageResourceScope>?>("accessPackageResourceScopes"); }
            set { BackingStore?.Set("accessPackageResourceScopes", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.AccessPackageResourceScope> AccessPackageResourceScopes
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessPackageResourceScope>>("accessPackageResourceScopes"); }
            set { BackingStore?.Set("accessPackageResourceScopes", value); }
        }
#endif
        /// <summary>The access packages in this catalog. Read-only. Nullable. Supports $expand.</summary>
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
        /// <summary>Has the value Published if the access packages are available for management.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CatalogStatus
        {
            get { return BackingStore?.Get<string?>("catalogStatus"); }
            set { BackingStore?.Set("catalogStatus", value); }
        }
#nullable restore
#else
        public string CatalogStatus
        {
            get { return BackingStore?.Get<string>("catalogStatus"); }
            set { BackingStore?.Set("catalogStatus", value); }
        }
#endif
        /// <summary>One of UserManaged or ServiceDefault.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CatalogType
        {
            get { return BackingStore?.Get<string?>("catalogType"); }
            set { BackingStore?.Set("catalogType", value); }
        }
#nullable restore
#else
        public string CatalogType
        {
            get { return BackingStore?.Get<string>("catalogType"); }
            set { BackingStore?.Set("catalogType", value); }
        }
#endif
        /// <summary>UPN of the user who created this resource. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedBy
        {
            get { return BackingStore?.Get<string?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public string CreatedBy
        {
            get { return BackingStore?.Get<string>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The customAccessPackageWorkflowExtensions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.CustomAccessPackageWorkflowExtension>? CustomAccessPackageWorkflowExtensions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.CustomAccessPackageWorkflowExtension>?>("customAccessPackageWorkflowExtensions"); }
            set { BackingStore?.Set("customAccessPackageWorkflowExtensions", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.CustomAccessPackageWorkflowExtension> CustomAccessPackageWorkflowExtensions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.CustomAccessPackageWorkflowExtension>>("customAccessPackageWorkflowExtensions"); }
            set { BackingStore?.Set("customAccessPackageWorkflowExtensions", value); }
        }
#endif
        /// <summary>The description of the access package catalog.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The display name of the access package catalog. Supports $filter (eq, contains).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Whether the access packages in this catalog can be requested by users outside of the tenant.</summary>
        public bool? IsExternallyVisible
        {
            get { return BackingStore?.Get<bool?>("isExternallyVisible"); }
            set { BackingStore?.Set("isExternallyVisible", value); }
        }
        /// <summary>The UPN of the user who last modified this resource. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ModifiedBy
        {
            get { return BackingStore?.Get<string?>("modifiedBy"); }
            set { BackingStore?.Set("modifiedBy", value); }
        }
#nullable restore
#else
        public string ModifiedBy
        {
            get { return BackingStore?.Get<string>("modifiedBy"); }
            set { BackingStore?.Set("modifiedBy", value); }
        }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? ModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("modifiedDateTime"); }
            set { BackingStore?.Set("modifiedDateTime", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.AccessPackageCatalog"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.AccessPackageCatalog CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.AccessPackageCatalog();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accessPackageCustomWorkflowExtensions", n => { AccessPackageCustomWorkflowExtensions = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.CustomCalloutExtension>(Microsoft.Graph.Beta.Models.CustomCalloutExtension.CreateFromDiscriminatorValue)?.ToList(); } },
                { "accessPackageResourceRoles", n => { AccessPackageResourceRoles = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackageResourceRole>(Microsoft.Graph.Beta.Models.AccessPackageResourceRole.CreateFromDiscriminatorValue)?.ToList(); } },
                { "accessPackageResourceScopes", n => { AccessPackageResourceScopes = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackageResourceScope>(Microsoft.Graph.Beta.Models.AccessPackageResourceScope.CreateFromDiscriminatorValue)?.ToList(); } },
                { "accessPackageResources", n => { AccessPackageResources = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackageResource>(Microsoft.Graph.Beta.Models.AccessPackageResource.CreateFromDiscriminatorValue)?.ToList(); } },
                { "accessPackages", n => { AccessPackages = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackage>(Microsoft.Graph.Beta.Models.AccessPackage.CreateFromDiscriminatorValue)?.ToList(); } },
                { "catalogStatus", n => { CatalogStatus = n.GetStringValue(); } },
                { "catalogType", n => { CatalogType = n.GetStringValue(); } },
                { "createdBy", n => { CreatedBy = n.GetStringValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "customAccessPackageWorkflowExtensions", n => { CustomAccessPackageWorkflowExtensions = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.CustomAccessPackageWorkflowExtension>(Microsoft.Graph.Beta.Models.CustomAccessPackageWorkflowExtension.CreateFromDiscriminatorValue)?.ToList(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "isExternallyVisible", n => { IsExternallyVisible = n.GetBoolValue(); } },
                { "modifiedBy", n => { ModifiedBy = n.GetStringValue(); } },
                { "modifiedDateTime", n => { ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.CustomCalloutExtension>("accessPackageCustomWorkflowExtensions", AccessPackageCustomWorkflowExtensions);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackageResourceRole>("accessPackageResourceRoles", AccessPackageResourceRoles);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackageResource>("accessPackageResources", AccessPackageResources);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackageResourceScope>("accessPackageResourceScopes", AccessPackageResourceScopes);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessPackage>("accessPackages", AccessPackages);
            writer.WriteStringValue("catalogStatus", CatalogStatus);
            writer.WriteStringValue("catalogType", CatalogType);
            writer.WriteStringValue("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.CustomAccessPackageWorkflowExtension>("customAccessPackageWorkflowExtensions", CustomAccessPackageWorkflowExtensions);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isExternallyVisible", IsExternallyVisible);
            writer.WriteStringValue("modifiedBy", ModifiedBy);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
        }
    }
}
