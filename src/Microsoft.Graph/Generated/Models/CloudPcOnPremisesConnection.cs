// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcOnPremisesConnection : Entity, IParsable {
        /// <summary>The fully qualified domain name (FQDN) of the Active Directory domain you want to join. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdDomainName {
            get { return BackingStore?.Get<string?>("adDomainName"); }
            set { BackingStore?.Set("adDomainName", value); }
        }
#nullable restore
#else
        public string AdDomainName {
            get { return BackingStore?.Get<string>("adDomainName"); }
            set { BackingStore?.Set("adDomainName", value); }
        }
#endif
        /// <summary>The password associated with adDomainUsername.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdDomainPassword {
            get { return BackingStore?.Get<string?>("adDomainPassword"); }
            set { BackingStore?.Set("adDomainPassword", value); }
        }
#nullable restore
#else
        public string AdDomainPassword {
            get { return BackingStore?.Get<string>("adDomainPassword"); }
            set { BackingStore?.Set("adDomainPassword", value); }
        }
#endif
        /// <summary>The username of an Active Directory account (user or service account) that has permissions to create computer objects in Active Directory. Required format: admin@contoso.com. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdDomainUsername {
            get { return BackingStore?.Get<string?>("adDomainUsername"); }
            set { BackingStore?.Set("adDomainUsername", value); }
        }
#nullable restore
#else
        public string AdDomainUsername {
            get { return BackingStore?.Get<string>("adDomainUsername"); }
            set { BackingStore?.Set("adDomainUsername", value); }
        }
#endif
        /// <summary>The interface URL of the partner service&apos;s resource that links to this Azure network connection. Returned only on $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlternateResourceUrl {
            get { return BackingStore?.Get<string?>("alternateResourceUrl"); }
            set { BackingStore?.Set("alternateResourceUrl", value); }
        }
#nullable restore
#else
        public string AlternateResourceUrl {
            get { return BackingStore?.Get<string>("alternateResourceUrl"); }
            set { BackingStore?.Set("alternateResourceUrl", value); }
        }
#endif
        /// <summary>The connectionType property</summary>
        public CloudPcOnPremisesConnectionType? ConnectionType {
            get { return BackingStore?.Get<CloudPcOnPremisesConnectionType?>("connectionType"); }
            set { BackingStore?.Set("connectionType", value); }
        }
        /// <summary>The display name for the Azure network connection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The healthCheckStatus property</summary>
        public CloudPcOnPremisesConnectionStatus? HealthCheckStatus {
            get { return BackingStore?.Get<CloudPcOnPremisesConnectionStatus?>("healthCheckStatus"); }
            set { BackingStore?.Set("healthCheckStatus", value); }
        }
        /// <summary>The healthCheckStatusDetail property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CloudPcOnPremisesConnectionStatusDetail? HealthCheckStatusDetail {
            get { return BackingStore?.Get<CloudPcOnPremisesConnectionStatusDetail?>("healthCheckStatusDetail"); }
            set { BackingStore?.Set("healthCheckStatusDetail", value); }
        }
#nullable restore
#else
        public CloudPcOnPremisesConnectionStatusDetail HealthCheckStatusDetail {
            get { return BackingStore?.Get<CloudPcOnPremisesConnectionStatusDetail>("healthCheckStatusDetail"); }
            set { BackingStore?.Set("healthCheckStatusDetail", value); }
        }
#endif
        /// <summary>The details of the connection&apos;s health checks and the corresponding results. Returned only on $select. For an example that shows how to get the inUse property, see Example 2: Get the selected properties of an Azure network connection, including healthCheckStatusDetails. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CloudPcOnPremisesConnectionStatusDetails? HealthCheckStatusDetails {
            get { return BackingStore?.Get<CloudPcOnPremisesConnectionStatusDetails?>("healthCheckStatusDetails"); }
            set { BackingStore?.Set("healthCheckStatusDetails", value); }
        }
#nullable restore
#else
        public CloudPcOnPremisesConnectionStatusDetails HealthCheckStatusDetails {
            get { return BackingStore?.Get<CloudPcOnPremisesConnectionStatusDetails>("healthCheckStatusDetails"); }
            set { BackingStore?.Set("healthCheckStatusDetails", value); }
        }
#endif
        /// <summary>When true, the Azure network connection is in use. When false, the connection isn&apos;t in use. You can&apos;t delete a connection that’s in use. Returned only on $select. For an example that shows how to get the inUse property, see Example 2: Get the selected properties of an Azure network connection, including healthCheckStatusDetails. Read-only.</summary>
        public bool? InUse {
            get { return BackingStore?.Get<bool?>("inUse"); }
            set { BackingStore?.Set("inUse", value); }
        }
        /// <summary>The managedBy property</summary>
        public CloudPcManagementService? ManagedBy {
            get { return BackingStore?.Get<CloudPcManagementService?>("managedBy"); }
            set { BackingStore?.Set("managedBy", value); }
        }
        /// <summary>The organizational unit (OU) in which the computer account is created. If left null, the OU that’s configured as the default (a well-known computer object container) in your Active Directory domain (OU) is used. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrganizationalUnit {
            get { return BackingStore?.Get<string?>("organizationalUnit"); }
            set { BackingStore?.Set("organizationalUnit", value); }
        }
#nullable restore
#else
        public string OrganizationalUnit {
            get { return BackingStore?.Get<string>("organizationalUnit"); }
            set { BackingStore?.Set("organizationalUnit", value); }
        }
#endif
        /// <summary>The ID of the target resource group. Required format: /subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceGroupId {
            get { return BackingStore?.Get<string?>("resourceGroupId"); }
            set { BackingStore?.Set("resourceGroupId", value); }
        }
#nullable restore
#else
        public string ResourceGroupId {
            get { return BackingStore?.Get<string>("resourceGroupId"); }
            set { BackingStore?.Set("resourceGroupId", value); }
        }
#endif
        /// <summary>The scopeIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ScopeIds {
            get { return BackingStore?.Get<List<string>?>("scopeIds"); }
            set { BackingStore?.Set("scopeIds", value); }
        }
#nullable restore
#else
        public List<string> ScopeIds {
            get { return BackingStore?.Get<List<string>>("scopeIds"); }
            set { BackingStore?.Set("scopeIds", value); }
        }
#endif
        /// <summary>The ID of the target subnet. Required format: /subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkId}/subnets/{subnetName}.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubnetId {
            get { return BackingStore?.Get<string?>("subnetId"); }
            set { BackingStore?.Set("subnetId", value); }
        }
#nullable restore
#else
        public string SubnetId {
            get { return BackingStore?.Get<string>("subnetId"); }
            set { BackingStore?.Set("subnetId", value); }
        }
#endif
        /// <summary>The ID of the target Azure subscription that’s associated with your tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubscriptionId {
            get { return BackingStore?.Get<string?>("subscriptionId"); }
            set { BackingStore?.Set("subscriptionId", value); }
        }
#nullable restore
#else
        public string SubscriptionId {
            get { return BackingStore?.Get<string>("subscriptionId"); }
            set { BackingStore?.Set("subscriptionId", value); }
        }
#endif
        /// <summary>The name of the target Azure subscription. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubscriptionName {
            get { return BackingStore?.Get<string?>("subscriptionName"); }
            set { BackingStore?.Set("subscriptionName", value); }
        }
#nullable restore
#else
        public string SubscriptionName {
            get { return BackingStore?.Get<string>("subscriptionName"); }
            set { BackingStore?.Set("subscriptionName", value); }
        }
#endif
        /// <summary>Specifies how the provisioned Cloud PC is joined to Microsoft Entra ID. Default value is hybridAzureADJoin. Possible values are: azureADJoin, hybridAzureADJoin, unknownFutureValue.</summary>
        public CloudPcOnPremisesConnectionType? Type {
            get { return BackingStore?.Get<CloudPcOnPremisesConnectionType?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
        /// <summary>The ID of the target virtual network. Required format: /subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VirtualNetworkId {
            get { return BackingStore?.Get<string?>("virtualNetworkId"); }
            set { BackingStore?.Set("virtualNetworkId", value); }
        }
#nullable restore
#else
        public string VirtualNetworkId {
            get { return BackingStore?.Get<string>("virtualNetworkId"); }
            set { BackingStore?.Set("virtualNetworkId", value); }
        }
#endif
        /// <summary>Indicates resource location of the virtual target network. Read-only, computed value.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VirtualNetworkLocation {
            get { return BackingStore?.Get<string?>("virtualNetworkLocation"); }
            set { BackingStore?.Set("virtualNetworkLocation", value); }
        }
#nullable restore
#else
        public string VirtualNetworkLocation {
            get { return BackingStore?.Get<string>("virtualNetworkLocation"); }
            set { BackingStore?.Set("virtualNetworkLocation", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CloudPcOnPremisesConnection"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CloudPcOnPremisesConnection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcOnPremisesConnection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"adDomainName", n => { AdDomainName = n.GetStringValue(); } },
                {"adDomainPassword", n => { AdDomainPassword = n.GetStringValue(); } },
                {"adDomainUsername", n => { AdDomainUsername = n.GetStringValue(); } },
                {"alternateResourceUrl", n => { AlternateResourceUrl = n.GetStringValue(); } },
                {"connectionType", n => { ConnectionType = n.GetEnumValue<CloudPcOnPremisesConnectionType>(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"healthCheckStatus", n => { HealthCheckStatus = n.GetEnumValue<CloudPcOnPremisesConnectionStatus>(); } },
                {"healthCheckStatusDetail", n => { HealthCheckStatusDetail = n.GetObjectValue<CloudPcOnPremisesConnectionStatusDetail>(CloudPcOnPremisesConnectionStatusDetail.CreateFromDiscriminatorValue); } },
                {"healthCheckStatusDetails", n => { HealthCheckStatusDetails = n.GetObjectValue<CloudPcOnPremisesConnectionStatusDetails>(CloudPcOnPremisesConnectionStatusDetails.CreateFromDiscriminatorValue); } },
                {"inUse", n => { InUse = n.GetBoolValue(); } },
                {"managedBy", n => { ManagedBy = n.GetEnumValue<CloudPcManagementService>(); } },
                {"organizationalUnit", n => { OrganizationalUnit = n.GetStringValue(); } },
                {"resourceGroupId", n => { ResourceGroupId = n.GetStringValue(); } },
                {"scopeIds", n => { ScopeIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"subnetId", n => { SubnetId = n.GetStringValue(); } },
                {"subscriptionId", n => { SubscriptionId = n.GetStringValue(); } },
                {"subscriptionName", n => { SubscriptionName = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<CloudPcOnPremisesConnectionType>(); } },
                {"virtualNetworkId", n => { VirtualNetworkId = n.GetStringValue(); } },
                {"virtualNetworkLocation", n => { VirtualNetworkLocation = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("adDomainName", AdDomainName);
            writer.WriteStringValue("adDomainPassword", AdDomainPassword);
            writer.WriteStringValue("adDomainUsername", AdDomainUsername);
            writer.WriteStringValue("alternateResourceUrl", AlternateResourceUrl);
            writer.WriteEnumValue<CloudPcOnPremisesConnectionType>("connectionType", ConnectionType);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<CloudPcOnPremisesConnectionStatus>("healthCheckStatus", HealthCheckStatus);
            writer.WriteObjectValue<CloudPcOnPremisesConnectionStatusDetail>("healthCheckStatusDetail", HealthCheckStatusDetail);
            writer.WriteObjectValue<CloudPcOnPremisesConnectionStatusDetails>("healthCheckStatusDetails", HealthCheckStatusDetails);
            writer.WriteBoolValue("inUse", InUse);
            writer.WriteEnumValue<CloudPcManagementService>("managedBy", ManagedBy);
            writer.WriteStringValue("organizationalUnit", OrganizationalUnit);
            writer.WriteStringValue("resourceGroupId", ResourceGroupId);
            writer.WriteCollectionOfPrimitiveValues<string>("scopeIds", ScopeIds);
            writer.WriteStringValue("subnetId", SubnetId);
            writer.WriteStringValue("subscriptionId", SubscriptionId);
            writer.WriteStringValue("subscriptionName", SubscriptionName);
            writer.WriteEnumValue<CloudPcOnPremisesConnectionType>("type", Type);
            writer.WriteStringValue("virtualNetworkId", VirtualNetworkId);
            writer.WriteStringValue("virtualNetworkLocation", VirtualNetworkLocation);
        }
    }
}
