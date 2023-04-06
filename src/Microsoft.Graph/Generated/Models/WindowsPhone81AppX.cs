using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsPhone81AppX : MobileLobApp, IParsable {
        /// <summary>Contains properties for Windows architecture.</summary>
        public WindowsArchitecture? ApplicableArchitectures {
            get { return BackingStore?.Get<WindowsArchitecture?>("applicableArchitectures"); }
            set { BackingStore?.Set("applicableArchitectures", value); }
        }
        /// <summary>The Identity Name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdentityName {
            get { return BackingStore?.Get<string?>("identityName"); }
            set { BackingStore?.Set("identityName", value); }
        }
#nullable restore
#else
        public string IdentityName {
            get { return BackingStore?.Get<string>("identityName"); }
            set { BackingStore?.Set("identityName", value); }
        }
#endif
        /// <summary>The Identity Publisher Hash.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdentityPublisherHash {
            get { return BackingStore?.Get<string?>("identityPublisherHash"); }
            set { BackingStore?.Set("identityPublisherHash", value); }
        }
#nullable restore
#else
        public string IdentityPublisherHash {
            get { return BackingStore?.Get<string>("identityPublisherHash"); }
            set { BackingStore?.Set("identityPublisherHash", value); }
        }
#endif
        /// <summary>The Identity Resource Identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdentityResourceIdentifier {
            get { return BackingStore?.Get<string?>("identityResourceIdentifier"); }
            set { BackingStore?.Set("identityResourceIdentifier", value); }
        }
#nullable restore
#else
        public string IdentityResourceIdentifier {
            get { return BackingStore?.Get<string>("identityResourceIdentifier"); }
            set { BackingStore?.Set("identityResourceIdentifier", value); }
        }
#endif
        /// <summary>The identity version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdentityVersion {
            get { return BackingStore?.Get<string?>("identityVersion"); }
            set { BackingStore?.Set("identityVersion", value); }
        }
#nullable restore
#else
        public string IdentityVersion {
            get { return BackingStore?.Get<string>("identityVersion"); }
            set { BackingStore?.Set("identityVersion", value); }
        }
#endif
        /// <summary>The minimum operating system required for a Windows mobile app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WindowsMinimumOperatingSystem? MinimumSupportedOperatingSystem {
            get { return BackingStore?.Get<WindowsMinimumOperatingSystem?>("minimumSupportedOperatingSystem"); }
            set { BackingStore?.Set("minimumSupportedOperatingSystem", value); }
        }
#nullable restore
#else
        public WindowsMinimumOperatingSystem MinimumSupportedOperatingSystem {
            get { return BackingStore?.Get<WindowsMinimumOperatingSystem>("minimumSupportedOperatingSystem"); }
            set { BackingStore?.Set("minimumSupportedOperatingSystem", value); }
        }
#endif
        /// <summary>The Phone Product Identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhoneProductIdentifier {
            get { return BackingStore?.Get<string?>("phoneProductIdentifier"); }
            set { BackingStore?.Set("phoneProductIdentifier", value); }
        }
#nullable restore
#else
        public string PhoneProductIdentifier {
            get { return BackingStore?.Get<string>("phoneProductIdentifier"); }
            set { BackingStore?.Set("phoneProductIdentifier", value); }
        }
#endif
        /// <summary>The Phone Publisher Id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhonePublisherId {
            get { return BackingStore?.Get<string?>("phonePublisherId"); }
            set { BackingStore?.Set("phonePublisherId", value); }
        }
#nullable restore
#else
        public string PhonePublisherId {
            get { return BackingStore?.Get<string>("phonePublisherId"); }
            set { BackingStore?.Set("phonePublisherId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new WindowsPhone81AppX and sets the default values.
        /// </summary>
        public WindowsPhone81AppX() : base() {
            OdataType = "#microsoft.graph.windowsPhone81AppX";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsPhone81AppX CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.windowsPhone81AppXBundle" => new WindowsPhone81AppXBundle(),
                _ => new WindowsPhone81AppX(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicableArchitectures", n => { ApplicableArchitectures = n.GetEnumValue<WindowsArchitecture>(); } },
                {"identityName", n => { IdentityName = n.GetStringValue(); } },
                {"identityPublisherHash", n => { IdentityPublisherHash = n.GetStringValue(); } },
                {"identityResourceIdentifier", n => { IdentityResourceIdentifier = n.GetStringValue(); } },
                {"identityVersion", n => { IdentityVersion = n.GetStringValue(); } },
                {"minimumSupportedOperatingSystem", n => { MinimumSupportedOperatingSystem = n.GetObjectValue<WindowsMinimumOperatingSystem>(WindowsMinimumOperatingSystem.CreateFromDiscriminatorValue); } },
                {"phoneProductIdentifier", n => { PhoneProductIdentifier = n.GetStringValue(); } },
                {"phonePublisherId", n => { PhonePublisherId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<WindowsArchitecture>("applicableArchitectures", ApplicableArchitectures);
            writer.WriteStringValue("identityName", IdentityName);
            writer.WriteStringValue("identityPublisherHash", IdentityPublisherHash);
            writer.WriteStringValue("identityResourceIdentifier", IdentityResourceIdentifier);
            writer.WriteStringValue("identityVersion", IdentityVersion);
            writer.WriteObjectValue<WindowsMinimumOperatingSystem>("minimumSupportedOperatingSystem", MinimumSupportedOperatingSystem);
            writer.WriteStringValue("phoneProductIdentifier", PhoneProductIdentifier);
            writer.WriteStringValue("phonePublisherId", PhonePublisherId);
        }
    }
}
