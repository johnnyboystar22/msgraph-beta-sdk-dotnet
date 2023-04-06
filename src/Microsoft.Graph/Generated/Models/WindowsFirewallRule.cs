using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// A rule controlling traffic through the Windows Firewall.
    /// </summary>
    public class WindowsFirewallRule : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>State Management Setting.</summary>
        public StateManagementSetting? Action {
            get { return BackingStore?.Get<StateManagementSetting?>("action"); }
            set { BackingStore?.Set("action", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The description of the rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The display name of the rule. Does not need to be unique.</summary>
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
        /// <summary>State Management Setting.</summary>
        public StateManagementSetting? EdgeTraversal {
            get { return BackingStore?.Get<StateManagementSetting?>("edgeTraversal"); }
            set { BackingStore?.Set("edgeTraversal", value); }
        }
        /// <summary>The full file path of an app that&apos;s affected by the firewall rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FilePath {
            get { return BackingStore?.Get<string?>("filePath"); }
            set { BackingStore?.Set("filePath", value); }
        }
#nullable restore
#else
        public string FilePath {
            get { return BackingStore?.Get<string>("filePath"); }
            set { BackingStore?.Set("filePath", value); }
        }
#endif
        /// <summary>Flags representing firewall rule interface types.</summary>
        public WindowsFirewallRuleInterfaceTypes? InterfaceTypes {
            get { return BackingStore?.Get<WindowsFirewallRuleInterfaceTypes?>("interfaceTypes"); }
            set { BackingStore?.Set("interfaceTypes", value); }
        }
        /// <summary>List of local addresses covered by the rule. Default is any address. Valid tokens include:&apos;&apos; indicates any local address. If present, this must be the only token included.A subnet can be specified using either the subnet mask or network prefix notation. If neither a subnet mask nor a network prefix is specified, the subnet mask defaults to 255.255.255.255.A valid IPv6 address.An IPv4 address range in the format of &apos;start address - end address&apos; with no spaces included.An IPv6 address range in the format of &apos;start address - end address&apos; with no spaces included.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? LocalAddressRanges {
            get { return BackingStore?.Get<List<string>?>("localAddressRanges"); }
            set { BackingStore?.Set("localAddressRanges", value); }
        }
#nullable restore
#else
        public List<string> LocalAddressRanges {
            get { return BackingStore?.Get<List<string>>("localAddressRanges"); }
            set { BackingStore?.Set("localAddressRanges", value); }
        }
#endif
        /// <summary>List of local port ranges. For example, &apos;100-120&apos;, &apos;200&apos;, &apos;300-320&apos;. If not specified, the default is All.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? LocalPortRanges {
            get { return BackingStore?.Get<List<string>?>("localPortRanges"); }
            set { BackingStore?.Set("localPortRanges", value); }
        }
#nullable restore
#else
        public List<string> LocalPortRanges {
            get { return BackingStore?.Get<List<string>>("localPortRanges"); }
            set { BackingStore?.Set("localPortRanges", value); }
        }
#endif
        /// <summary>Specifies the list of authorized local users for the app container. This is a string in Security Descriptor Definition Language (SDDL) format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LocalUserAuthorizations {
            get { return BackingStore?.Get<string?>("localUserAuthorizations"); }
            set { BackingStore?.Set("localUserAuthorizations", value); }
        }
#nullable restore
#else
        public string LocalUserAuthorizations {
            get { return BackingStore?.Get<string>("localUserAuthorizations"); }
            set { BackingStore?.Set("localUserAuthorizations", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The package family name of a Microsoft Store application that&apos;s affected by the firewall rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PackageFamilyName {
            get { return BackingStore?.Get<string?>("packageFamilyName"); }
            set { BackingStore?.Set("packageFamilyName", value); }
        }
#nullable restore
#else
        public string PackageFamilyName {
            get { return BackingStore?.Get<string>("packageFamilyName"); }
            set { BackingStore?.Set("packageFamilyName", value); }
        }
#endif
        /// <summary>Flags representing which network profile types apply to a firewall rule.</summary>
        public WindowsFirewallRuleNetworkProfileTypes? ProfileTypes {
            get { return BackingStore?.Get<WindowsFirewallRuleNetworkProfileTypes?>("profileTypes"); }
            set { BackingStore?.Set("profileTypes", value); }
        }
        /// <summary>0-255 number representing the IP protocol (TCP = 6, UDP = 17). If not specified, the default is All. Valid values 0 to 255</summary>
        public int? Protocol {
            get { return BackingStore?.Get<int?>("protocol"); }
            set { BackingStore?.Set("protocol", value); }
        }
        /// <summary>List of tokens specifying the remote addresses covered by the rule. Tokens are case insensitive. Default is any address. Valid tokens include:&apos;&apos; indicates any remote address. If present, this must be the only token included.&apos;Defaultgateway&apos;&apos;DHCP&apos;&apos;DNS&apos;&apos;WINS&apos;&apos;Intranet&apos; (supported on Windows versions 1809+)&apos;RmtIntranet&apos; (supported on Windows versions 1809+)&apos;Internet&apos; (supported on Windows versions 1809+)&apos;Ply2Renders&apos; (supported on Windows versions 1809+)&apos;LocalSubnet&apos; indicates any local address on the local subnet.A subnet can be specified using either the subnet mask or network prefix notation. If neither a subnet mask nor a network prefix is specified, the subnet mask defaults to 255.255.255.255.A valid IPv6 address.An IPv4 address range in the format of &apos;start address - end address&apos; with no spaces included.An IPv6 address range in the format of &apos;start address - end address&apos; with no spaces included.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RemoteAddressRanges {
            get { return BackingStore?.Get<List<string>?>("remoteAddressRanges"); }
            set { BackingStore?.Set("remoteAddressRanges", value); }
        }
#nullable restore
#else
        public List<string> RemoteAddressRanges {
            get { return BackingStore?.Get<List<string>>("remoteAddressRanges"); }
            set { BackingStore?.Set("remoteAddressRanges", value); }
        }
#endif
        /// <summary>List of remote port ranges. For example, &apos;100-120&apos;, &apos;200&apos;, &apos;300-320&apos;. If not specified, the default is All.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RemotePortRanges {
            get { return BackingStore?.Get<List<string>?>("remotePortRanges"); }
            set { BackingStore?.Set("remotePortRanges", value); }
        }
#nullable restore
#else
        public List<string> RemotePortRanges {
            get { return BackingStore?.Get<List<string>>("remotePortRanges"); }
            set { BackingStore?.Set("remotePortRanges", value); }
        }
#endif
        /// <summary>The name used in cases when a service, not an application, is sending or receiving traffic.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceName {
            get { return BackingStore?.Get<string?>("serviceName"); }
            set { BackingStore?.Set("serviceName", value); }
        }
#nullable restore
#else
        public string ServiceName {
            get { return BackingStore?.Get<string>("serviceName"); }
            set { BackingStore?.Set("serviceName", value); }
        }
#endif
        /// <summary>Firewall rule traffic directions.</summary>
        public WindowsFirewallRuleTrafficDirectionType? TrafficDirection {
            get { return BackingStore?.Get<WindowsFirewallRuleTrafficDirectionType?>("trafficDirection"); }
            set { BackingStore?.Set("trafficDirection", value); }
        }
        /// <summary>
        /// Instantiates a new windowsFirewallRule and sets the default values.
        /// </summary>
        public WindowsFirewallRule() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WindowsFirewallRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsFirewallRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"action", n => { Action = n.GetEnumValue<StateManagementSetting>(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"edgeTraversal", n => { EdgeTraversal = n.GetEnumValue<StateManagementSetting>(); } },
                {"filePath", n => { FilePath = n.GetStringValue(); } },
                {"interfaceTypes", n => { InterfaceTypes = n.GetEnumValue<WindowsFirewallRuleInterfaceTypes>(); } },
                {"localAddressRanges", n => { LocalAddressRanges = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"localPortRanges", n => { LocalPortRanges = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"localUserAuthorizations", n => { LocalUserAuthorizations = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"packageFamilyName", n => { PackageFamilyName = n.GetStringValue(); } },
                {"profileTypes", n => { ProfileTypes = n.GetEnumValue<WindowsFirewallRuleNetworkProfileTypes>(); } },
                {"protocol", n => { Protocol = n.GetIntValue(); } },
                {"remoteAddressRanges", n => { RemoteAddressRanges = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"remotePortRanges", n => { RemotePortRanges = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"serviceName", n => { ServiceName = n.GetStringValue(); } },
                {"trafficDirection", n => { TrafficDirection = n.GetEnumValue<WindowsFirewallRuleTrafficDirectionType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<StateManagementSetting>("action", Action);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<StateManagementSetting>("edgeTraversal", EdgeTraversal);
            writer.WriteStringValue("filePath", FilePath);
            writer.WriteEnumValue<WindowsFirewallRuleInterfaceTypes>("interfaceTypes", InterfaceTypes);
            writer.WriteCollectionOfPrimitiveValues<string>("localAddressRanges", LocalAddressRanges);
            writer.WriteCollectionOfPrimitiveValues<string>("localPortRanges", LocalPortRanges);
            writer.WriteStringValue("localUserAuthorizations", LocalUserAuthorizations);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("packageFamilyName", PackageFamilyName);
            writer.WriteEnumValue<WindowsFirewallRuleNetworkProfileTypes>("profileTypes", ProfileTypes);
            writer.WriteIntValue("protocol", Protocol);
            writer.WriteCollectionOfPrimitiveValues<string>("remoteAddressRanges", RemoteAddressRanges);
            writer.WriteCollectionOfPrimitiveValues<string>("remotePortRanges", RemotePortRanges);
            writer.WriteStringValue("serviceName", ServiceName);
            writer.WriteEnumValue<WindowsFirewallRuleTrafficDirectionType>("trafficDirection", TrafficDirection);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
