using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class CloudAppSecurityProfile : Entity, IParsable {
        /// <summary>The azureSubscriptionId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureSubscriptionId {
            get { return BackingStore?.Get<string?>("azureSubscriptionId"); }
            set { BackingStore?.Set("azureSubscriptionId", value); }
        }
#nullable restore
#else
        public string AzureSubscriptionId {
            get { return BackingStore?.Get<string>("azureSubscriptionId"); }
            set { BackingStore?.Set("azureSubscriptionId", value); }
        }
#endif
        /// <summary>The azureTenantId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureTenantId {
            get { return BackingStore?.Get<string?>("azureTenantId"); }
            set { BackingStore?.Set("azureTenantId", value); }
        }
#nullable restore
#else
        public string AzureTenantId {
            get { return BackingStore?.Get<string>("azureTenantId"); }
            set { BackingStore?.Set("azureTenantId", value); }
        }
#endif
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The deploymentPackageUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeploymentPackageUrl {
            get { return BackingStore?.Get<string?>("deploymentPackageUrl"); }
            set { BackingStore?.Set("deploymentPackageUrl", value); }
        }
#nullable restore
#else
        public string DeploymentPackageUrl {
            get { return BackingStore?.Get<string>("deploymentPackageUrl"); }
            set { BackingStore?.Set("deploymentPackageUrl", value); }
        }
#endif
        /// <summary>The destinationServiceName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DestinationServiceName {
            get { return BackingStore?.Get<string?>("destinationServiceName"); }
            set { BackingStore?.Set("destinationServiceName", value); }
        }
#nullable restore
#else
        public string DestinationServiceName {
            get { return BackingStore?.Get<string>("destinationServiceName"); }
            set { BackingStore?.Set("destinationServiceName", value); }
        }
#endif
        /// <summary>The isSigned property</summary>
        public bool? IsSigned {
            get { return BackingStore?.Get<bool?>("isSigned"); }
            set { BackingStore?.Set("isSigned", value); }
        }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The manifest property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Manifest {
            get { return BackingStore?.Get<string?>("manifest"); }
            set { BackingStore?.Set("manifest", value); }
        }
#nullable restore
#else
        public string Manifest {
            get { return BackingStore?.Get<string>("manifest"); }
            set { BackingStore?.Set("manifest", value); }
        }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The permissionsRequired property</summary>
        public ApplicationPermissionsRequired? PermissionsRequired {
            get { return BackingStore?.Get<ApplicationPermissionsRequired?>("permissionsRequired"); }
            set { BackingStore?.Set("permissionsRequired", value); }
        }
        /// <summary>The platform property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Platform {
            get { return BackingStore?.Get<string?>("platform"); }
            set { BackingStore?.Set("platform", value); }
        }
#nullable restore
#else
        public string Platform {
            get { return BackingStore?.Get<string>("platform"); }
            set { BackingStore?.Set("platform", value); }
        }
#endif
        /// <summary>The policyName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyName {
            get { return BackingStore?.Get<string?>("policyName"); }
            set { BackingStore?.Set("policyName", value); }
        }
#nullable restore
#else
        public string PolicyName {
            get { return BackingStore?.Get<string>("policyName"); }
            set { BackingStore?.Set("policyName", value); }
        }
#endif
        /// <summary>The publisher property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Publisher {
            get { return BackingStore?.Get<string?>("publisher"); }
            set { BackingStore?.Set("publisher", value); }
        }
#nullable restore
#else
        public string Publisher {
            get { return BackingStore?.Get<string>("publisher"); }
            set { BackingStore?.Set("publisher", value); }
        }
#endif
        /// <summary>The riskScore property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RiskScore {
            get { return BackingStore?.Get<string?>("riskScore"); }
            set { BackingStore?.Set("riskScore", value); }
        }
#nullable restore
#else
        public string RiskScore {
            get { return BackingStore?.Get<string>("riskScore"); }
            set { BackingStore?.Set("riskScore", value); }
        }
#endif
        /// <summary>The tags property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags {
            get { return BackingStore?.Get<List<string>?>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#nullable restore
#else
        public List<string> Tags {
            get { return BackingStore?.Get<List<string>>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#endif
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type {
            get { return BackingStore?.Get<string?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#nullable restore
#else
        public string Type {
            get { return BackingStore?.Get<string>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#endif
        /// <summary>The vendorInformation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SecurityVendorInformation? VendorInformation {
            get { return BackingStore?.Get<SecurityVendorInformation?>("vendorInformation"); }
            set { BackingStore?.Set("vendorInformation", value); }
        }
#nullable restore
#else
        public SecurityVendorInformation VendorInformation {
            get { return BackingStore?.Get<SecurityVendorInformation>("vendorInformation"); }
            set { BackingStore?.Set("vendorInformation", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CloudAppSecurityProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudAppSecurityProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"azureSubscriptionId", n => { AzureSubscriptionId = n.GetStringValue(); } },
                {"azureTenantId", n => { AzureTenantId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deploymentPackageUrl", n => { DeploymentPackageUrl = n.GetStringValue(); } },
                {"destinationServiceName", n => { DestinationServiceName = n.GetStringValue(); } },
                {"isSigned", n => { IsSigned = n.GetBoolValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"manifest", n => { Manifest = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"permissionsRequired", n => { PermissionsRequired = n.GetEnumValue<ApplicationPermissionsRequired>(); } },
                {"platform", n => { Platform = n.GetStringValue(); } },
                {"policyName", n => { PolicyName = n.GetStringValue(); } },
                {"publisher", n => { Publisher = n.GetStringValue(); } },
                {"riskScore", n => { RiskScore = n.GetStringValue(); } },
                {"tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"type", n => { Type = n.GetStringValue(); } },
                {"vendorInformation", n => { VendorInformation = n.GetObjectValue<SecurityVendorInformation>(SecurityVendorInformation.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("azureSubscriptionId", AzureSubscriptionId);
            writer.WriteStringValue("azureTenantId", AzureTenantId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("deploymentPackageUrl", DeploymentPackageUrl);
            writer.WriteStringValue("destinationServiceName", DestinationServiceName);
            writer.WriteBoolValue("isSigned", IsSigned);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("manifest", Manifest);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<ApplicationPermissionsRequired>("permissionsRequired", PermissionsRequired);
            writer.WriteStringValue("platform", Platform);
            writer.WriteStringValue("policyName", PolicyName);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteStringValue("riskScore", RiskScore);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteStringValue("type", Type);
            writer.WriteObjectValue<SecurityVendorInformation>("vendorInformation", VendorInformation);
        }
    }
}
