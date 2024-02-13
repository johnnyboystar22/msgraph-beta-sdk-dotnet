// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Entity that represents a collection of Microsoft Tunnel settings
    /// </summary>
    public class MicrosoftTunnelConfiguration : Entity, IParsable {
        /// <summary>Additional settings that may be applied to the server</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValuePair>? AdvancedSettings {
            get { return BackingStore?.Get<List<KeyValuePair>?>("advancedSettings"); }
            set { BackingStore?.Set("advancedSettings", value); }
        }
#nullable restore
#else
        public List<KeyValuePair> AdvancedSettings {
            get { return BackingStore?.Get<List<KeyValuePair>>("advancedSettings"); }
            set { BackingStore?.Set("advancedSettings", value); }
        }
#endif
        /// <summary>The Default Domain appendix that will be used by the clients</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultDomainSuffix {
            get { return BackingStore?.Get<string?>("defaultDomainSuffix"); }
            set { BackingStore?.Set("defaultDomainSuffix", value); }
        }
#nullable restore
#else
        public string DefaultDomainSuffix {
            get { return BackingStore?.Get<string>("defaultDomainSuffix"); }
            set { BackingStore?.Set("defaultDomainSuffix", value); }
        }
#endif
        /// <summary>The configuration&apos;s description (optional)</summary>
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
        /// <summary>When DisableUdpConnections is set, the clients and VPN server will not use DTLS connections to transfer data.</summary>
        public bool? DisableUdpConnections {
            get { return BackingStore?.Get<bool?>("disableUdpConnections"); }
            set { BackingStore?.Set("disableUdpConnections", value); }
        }
        /// <summary>The display name for the server configuration. This property is required when a server is created.</summary>
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
        /// <summary>The DNS servers that will be used by the clients</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DnsServers {
            get { return BackingStore?.Get<List<string>?>("dnsServers"); }
            set { BackingStore?.Set("dnsServers", value); }
        }
#nullable restore
#else
        public List<string> DnsServers {
            get { return BackingStore?.Get<List<string>>("dnsServers"); }
            set { BackingStore?.Set("dnsServers", value); }
        }
#endif
        /// <summary>When the configuration was last updated</summary>
        public DateTimeOffset? LastUpdateDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdateDateTime"); }
            set { BackingStore?.Set("lastUpdateDateTime", value); }
        }
        /// <summary>The port that both TCP and UPD will listen over on the server</summary>
        public int? ListenPort {
            get { return BackingStore?.Get<int?>("listenPort"); }
            set { BackingStore?.Set("listenPort", value); }
        }
        /// <summary>The subnet that will be used to allocate virtual address for the clients</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Network {
            get { return BackingStore?.Get<string?>("network"); }
            set { BackingStore?.Set("network", value); }
        }
#nullable restore
#else
        public string Network {
            get { return BackingStore?.Get<string>("network"); }
            set { BackingStore?.Set("network", value); }
        }
#endif
        /// <summary>List of Scope Tags for this Entity instance</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>?>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#nullable restore
#else
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#endif
        /// <summary>Subsets of the routes that will not be routed by the server</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RouteExcludes {
            get { return BackingStore?.Get<List<string>?>("routeExcludes"); }
            set { BackingStore?.Set("routeExcludes", value); }
        }
#nullable restore
#else
        public List<string> RouteExcludes {
            get { return BackingStore?.Get<List<string>>("routeExcludes"); }
            set { BackingStore?.Set("routeExcludes", value); }
        }
#endif
        /// <summary>The routes that will be routed by the server</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RouteIncludes {
            get { return BackingStore?.Get<List<string>?>("routeIncludes"); }
            set { BackingStore?.Set("routeIncludes", value); }
        }
#nullable restore
#else
        public List<string> RouteIncludes {
            get { return BackingStore?.Get<List<string>>("routeIncludes"); }
            set { BackingStore?.Set("routeIncludes", value); }
        }
#endif
        /// <summary>Subsets of the routes that will not be routed by the server. This property is going to be deprecated with the option of using the new property, &apos;RouteExcludes&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RoutesExclude {
            get { return BackingStore?.Get<List<string>?>("routesExclude"); }
            set { BackingStore?.Set("routesExclude", value); }
        }
#nullable restore
#else
        public List<string> RoutesExclude {
            get { return BackingStore?.Get<List<string>>("routesExclude"); }
            set { BackingStore?.Set("routesExclude", value); }
        }
#endif
        /// <summary>The routes that will be routed by the server. This property is going to be deprecated with the option of using the new property, &apos;RouteIncludes&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RoutesInclude {
            get { return BackingStore?.Get<List<string>?>("routesInclude"); }
            set { BackingStore?.Set("routesInclude", value); }
        }
#nullable restore
#else
        public List<string> RoutesInclude {
            get { return BackingStore?.Get<List<string>>("routesInclude"); }
            set { BackingStore?.Set("routesInclude", value); }
        }
#endif
        /// <summary>The domains that will be resolved using the provided dns servers</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SplitDNS {
            get { return BackingStore?.Get<List<string>?>("splitDNS"); }
            set { BackingStore?.Set("splitDNS", value); }
        }
#nullable restore
#else
        public List<string> SplitDNS {
            get { return BackingStore?.Get<List<string>>("splitDNS"); }
            set { BackingStore?.Set("splitDNS", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="MicrosoftTunnelConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MicrosoftTunnelConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MicrosoftTunnelConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"advancedSettings", n => { AdvancedSettings = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"defaultDomainSuffix", n => { DefaultDomainSuffix = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"disableUdpConnections", n => { DisableUdpConnections = n.GetBoolValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"dnsServers", n => { DnsServers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"lastUpdateDateTime", n => { LastUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                {"listenPort", n => { ListenPort = n.GetIntValue(); } },
                {"network", n => { Network = n.GetStringValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"routeExcludes", n => { RouteExcludes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"routeIncludes", n => { RouteIncludes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"routesExclude", n => { RoutesExclude = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"routesInclude", n => { RoutesInclude = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"splitDNS", n => { SplitDNS = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("advancedSettings", AdvancedSettings);
            writer.WriteStringValue("defaultDomainSuffix", DefaultDomainSuffix);
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("disableUdpConnections", DisableUdpConnections);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfPrimitiveValues<string>("dnsServers", DnsServers);
            writer.WriteDateTimeOffsetValue("lastUpdateDateTime", LastUpdateDateTime);
            writer.WriteIntValue("listenPort", ListenPort);
            writer.WriteStringValue("network", Network);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteCollectionOfPrimitiveValues<string>("routeExcludes", RouteExcludes);
            writer.WriteCollectionOfPrimitiveValues<string>("routeIncludes", RouteIncludes);
            writer.WriteCollectionOfPrimitiveValues<string>("routesExclude", RoutesExclude);
            writer.WriteCollectionOfPrimitiveValues<string>("routesInclude", RoutesInclude);
            writer.WriteCollectionOfPrimitiveValues<string>("splitDNS", SplitDNS);
        }
    }
}
