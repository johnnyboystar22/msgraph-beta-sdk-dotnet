using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// VPN On-Demand Rule definition.
    /// </summary>
    public class VpnOnDemandRule : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>VPN On-Demand Rule Connection Action.</summary>
        public VpnOnDemandRuleConnectionAction? Action {
            get { return BackingStore?.Get<VpnOnDemandRuleConnectionAction?>("action"); }
            set { BackingStore?.Set("action", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>DNS Search Domains.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DnsSearchDomains {
            get { return BackingStore?.Get<List<string>?>("dnsSearchDomains"); }
            set { BackingStore?.Set("dnsSearchDomains", value); }
        }
#nullable restore
#else
        public List<string> DnsSearchDomains {
            get { return BackingStore?.Get<List<string>>("dnsSearchDomains"); }
            set { BackingStore?.Set("dnsSearchDomains", value); }
        }
#endif
        /// <summary>DNS Search Server Address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DnsServerAddressMatch {
            get { return BackingStore?.Get<List<string>?>("dnsServerAddressMatch"); }
            set { BackingStore?.Set("dnsServerAddressMatch", value); }
        }
#nullable restore
#else
        public List<string> DnsServerAddressMatch {
            get { return BackingStore?.Get<List<string>>("dnsServerAddressMatch"); }
            set { BackingStore?.Set("dnsServerAddressMatch", value); }
        }
#endif
        /// <summary>VPN On-Demand Rule Connection Domain Action.</summary>
        public VpnOnDemandRuleConnectionDomainAction? DomainAction {
            get { return BackingStore?.Get<VpnOnDemandRuleConnectionDomainAction?>("domainAction"); }
            set { BackingStore?.Set("domainAction", value); }
        }
        /// <summary>Domains (Only applicable when Action is evaluate connection).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Domains {
            get { return BackingStore?.Get<List<string>?>("domains"); }
            set { BackingStore?.Set("domains", value); }
        }
#nullable restore
#else
        public List<string> Domains {
            get { return BackingStore?.Get<List<string>>("domains"); }
            set { BackingStore?.Set("domains", value); }
        }
#endif
        /// <summary>VPN On-Demand Rule Connection network interface type.</summary>
        public VpnOnDemandRuleInterfaceTypeMatch? InterfaceTypeMatch {
            get { return BackingStore?.Get<VpnOnDemandRuleInterfaceTypeMatch?>("interfaceTypeMatch"); }
            set { BackingStore?.Set("interfaceTypeMatch", value); }
        }
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
        /// <summary>Probe Required Url (Only applicable when Action is evaluate connection and DomainAction is connect if needed).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProbeRequiredUrl {
            get { return BackingStore?.Get<string?>("probeRequiredUrl"); }
            set { BackingStore?.Set("probeRequiredUrl", value); }
        }
#nullable restore
#else
        public string ProbeRequiredUrl {
            get { return BackingStore?.Get<string>("probeRequiredUrl"); }
            set { BackingStore?.Set("probeRequiredUrl", value); }
        }
#endif
        /// <summary>A URL to probe. If this URL is successfully fetched (returning a 200 HTTP status code) without redirection, this rule matches.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProbeUrl {
            get { return BackingStore?.Get<string?>("probeUrl"); }
            set { BackingStore?.Set("probeUrl", value); }
        }
#nullable restore
#else
        public string ProbeUrl {
            get { return BackingStore?.Get<string>("probeUrl"); }
            set { BackingStore?.Set("probeUrl", value); }
        }
#endif
        /// <summary>Network Service Set Identifiers (SSIDs).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Ssids {
            get { return BackingStore?.Get<List<string>?>("ssids"); }
            set { BackingStore?.Set("ssids", value); }
        }
#nullable restore
#else
        public List<string> Ssids {
            get { return BackingStore?.Get<List<string>>("ssids"); }
            set { BackingStore?.Set("ssids", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new vpnOnDemandRule and sets the default values.
        /// </summary>
        public VpnOnDemandRule() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static VpnOnDemandRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VpnOnDemandRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"action", n => { Action = n.GetEnumValue<VpnOnDemandRuleConnectionAction>(); } },
                {"dnsSearchDomains", n => { DnsSearchDomains = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"dnsServerAddressMatch", n => { DnsServerAddressMatch = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"domainAction", n => { DomainAction = n.GetEnumValue<VpnOnDemandRuleConnectionDomainAction>(); } },
                {"domains", n => { Domains = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"interfaceTypeMatch", n => { InterfaceTypeMatch = n.GetEnumValue<VpnOnDemandRuleInterfaceTypeMatch>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"probeRequiredUrl", n => { ProbeRequiredUrl = n.GetStringValue(); } },
                {"probeUrl", n => { ProbeUrl = n.GetStringValue(); } },
                {"ssids", n => { Ssids = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<VpnOnDemandRuleConnectionAction>("action", Action);
            writer.WriteCollectionOfPrimitiveValues<string>("dnsSearchDomains", DnsSearchDomains);
            writer.WriteCollectionOfPrimitiveValues<string>("dnsServerAddressMatch", DnsServerAddressMatch);
            writer.WriteEnumValue<VpnOnDemandRuleConnectionDomainAction>("domainAction", DomainAction);
            writer.WriteCollectionOfPrimitiveValues<string>("domains", Domains);
            writer.WriteEnumValue<VpnOnDemandRuleInterfaceTypeMatch>("interfaceTypeMatch", InterfaceTypeMatch);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("probeRequiredUrl", ProbeRequiredUrl);
            writer.WriteStringValue("probeUrl", ProbeUrl);
            writer.WriteCollectionOfPrimitiveValues<string>("ssids", Ssids);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
