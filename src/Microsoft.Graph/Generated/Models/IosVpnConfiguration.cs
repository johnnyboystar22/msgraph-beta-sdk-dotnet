// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// By providing the configurations in this profile you can instruct the iOS device to connect to desired VPN endpoint. By specifying the authentication method and security types expected by VPN endpoint you can make the VPN connection seamless for end user.
    /// </summary>
    public class IosVpnConfiguration : Microsoft.Graph.Beta.Models.AppleVpnConfiguration, IParsable
    {
        /// <summary>Zscaler only. Zscaler cloud which the user is assigned to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CloudName
        {
            get { return BackingStore?.Get<string?>("cloudName"); }
            set { BackingStore?.Set("cloudName", value); }
        }
#nullable restore
#else
        public string CloudName
        {
            get { return BackingStore?.Get<string>("cloudName"); }
            set { BackingStore?.Set("cloudName", value); }
        }
#endif
        /// <summary>Tenant level settings for the Derived Credentials to be used for authentication.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.DeviceManagementDerivedCredentialSettings? DerivedCredentialSettings
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagementDerivedCredentialSettings?>("derivedCredentialSettings"); }
            set { BackingStore?.Set("derivedCredentialSettings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.DeviceManagementDerivedCredentialSettings DerivedCredentialSettings
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagementDerivedCredentialSettings>("derivedCredentialSettings"); }
            set { BackingStore?.Set("derivedCredentialSettings", value); }
        }
#endif
        /// <summary>Zscaler only. List of network addresses which are not sent through the Zscaler cloud.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ExcludeList
        {
            get { return BackingStore?.Get<List<string>?>("excludeList"); }
            set { BackingStore?.Set("excludeList", value); }
        }
#nullable restore
#else
        public List<string> ExcludeList
        {
            get { return BackingStore?.Get<List<string>>("excludeList"); }
            set { BackingStore?.Set("excludeList", value); }
        }
#endif
        /// <summary>Identity certificate for client authentication when authentication method is certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.IosCertificateProfileBase? IdentityCertificate
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IosCertificateProfileBase?>("identityCertificate"); }
            set { BackingStore?.Set("identityCertificate", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.IosCertificateProfileBase IdentityCertificate
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IosCertificateProfileBase>("identityCertificate"); }
            set { BackingStore?.Set("identityCertificate", value); }
        }
#endif
        /// <summary>Microsoft Tunnel site ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MicrosoftTunnelSiteId
        {
            get { return BackingStore?.Get<string?>("microsoftTunnelSiteId"); }
            set { BackingStore?.Set("microsoftTunnelSiteId", value); }
        }
#nullable restore
#else
        public string MicrosoftTunnelSiteId
        {
            get { return BackingStore?.Get<string>("microsoftTunnelSiteId"); }
            set { BackingStore?.Set("microsoftTunnelSiteId", value); }
        }
#endif
        /// <summary>Zscaler only. Blocks network traffic until the user signs into Zscaler app. &apos;True&apos; means traffic is blocked.</summary>
        public bool? StrictEnforcement
        {
            get { return BackingStore?.Get<bool?>("strictEnforcement"); }
            set { BackingStore?.Set("strictEnforcement", value); }
        }
        /// <summary>Targeted mobile apps. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.AppListItem>? TargetedMobileApps
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AppListItem>?>("targetedMobileApps"); }
            set { BackingStore?.Set("targetedMobileApps", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.AppListItem> TargetedMobileApps
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AppListItem>>("targetedMobileApps"); }
            set { BackingStore?.Set("targetedMobileApps", value); }
        }
#endif
        /// <summary>Zscaler only. Enter a static domain to pre-populate the login field with in the Zscaler app. If this is left empty, the user&apos;s Azure Active Directory domain will be used instead.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserDomain
        {
            get { return BackingStore?.Get<string?>("userDomain"); }
            set { BackingStore?.Set("userDomain", value); }
        }
#nullable restore
#else
        public string UserDomain
        {
            get { return BackingStore?.Get<string>("userDomain"); }
            set { BackingStore?.Set("userDomain", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.IosVpnConfiguration"/> and sets the default values.
        /// </summary>
        public IosVpnConfiguration() : base()
        {
            OdataType = "#microsoft.graph.iosVpnConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.IosVpnConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.IosVpnConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.iosikEv2VpnConfiguration" => new Microsoft.Graph.Beta.Models.IosikEv2VpnConfiguration(),
                _ => new Microsoft.Graph.Beta.Models.IosVpnConfiguration(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "cloudName", n => { CloudName = n.GetStringValue(); } },
                { "derivedCredentialSettings", n => { DerivedCredentialSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceManagementDerivedCredentialSettings>(Microsoft.Graph.Beta.Models.DeviceManagementDerivedCredentialSettings.CreateFromDiscriminatorValue); } },
                { "excludeList", n => { ExcludeList = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "identityCertificate", n => { IdentityCertificate = n.GetObjectValue<Microsoft.Graph.Beta.Models.IosCertificateProfileBase>(Microsoft.Graph.Beta.Models.IosCertificateProfileBase.CreateFromDiscriminatorValue); } },
                { "microsoftTunnelSiteId", n => { MicrosoftTunnelSiteId = n.GetStringValue(); } },
                { "strictEnforcement", n => { StrictEnforcement = n.GetBoolValue(); } },
                { "targetedMobileApps", n => { TargetedMobileApps = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AppListItem>(Microsoft.Graph.Beta.Models.AppListItem.CreateFromDiscriminatorValue)?.ToList(); } },
                { "userDomain", n => { UserDomain = n.GetStringValue(); } },
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
            writer.WriteStringValue("cloudName", CloudName);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceManagementDerivedCredentialSettings>("derivedCredentialSettings", DerivedCredentialSettings);
            writer.WriteCollectionOfPrimitiveValues<string>("excludeList", ExcludeList);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IosCertificateProfileBase>("identityCertificate", IdentityCertificate);
            writer.WriteStringValue("microsoftTunnelSiteId", MicrosoftTunnelSiteId);
            writer.WriteBoolValue("strictEnforcement", StrictEnforcement);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AppListItem>("targetedMobileApps", TargetedMobileApps);
            writer.WriteStringValue("userDomain", UserDomain);
        }
    }
}
