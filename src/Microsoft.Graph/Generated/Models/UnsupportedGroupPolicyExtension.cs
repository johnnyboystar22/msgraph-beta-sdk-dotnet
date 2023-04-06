using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Unsupported Group Policy Extension.
    /// </summary>
    public class UnsupportedGroupPolicyExtension : Entity, IParsable {
        /// <summary>ExtensionType of the unsupported extension.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionType {
            get { return BackingStore?.Get<string?>("extensionType"); }
            set { BackingStore?.Set("extensionType", value); }
        }
#nullable restore
#else
        public string ExtensionType {
            get { return BackingStore?.Get<string>("extensionType"); }
            set { BackingStore?.Set("extensionType", value); }
        }
#endif
        /// <summary>Namespace Url of the unsupported extension.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NamespaceUrl {
            get { return BackingStore?.Get<string?>("namespaceUrl"); }
            set { BackingStore?.Set("namespaceUrl", value); }
        }
#nullable restore
#else
        public string NamespaceUrl {
            get { return BackingStore?.Get<string>("namespaceUrl"); }
            set { BackingStore?.Set("namespaceUrl", value); }
        }
#endif
        /// <summary>Node name of the unsupported extension.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeName {
            get { return BackingStore?.Get<string?>("nodeName"); }
            set { BackingStore?.Set("nodeName", value); }
        }
#nullable restore
#else
        public string NodeName {
            get { return BackingStore?.Get<string>("nodeName"); }
            set { BackingStore?.Set("nodeName", value); }
        }
#endif
        /// <summary>Scope of the group policy setting.</summary>
        public GroupPolicySettingScope? SettingScope {
            get { return BackingStore?.Get<GroupPolicySettingScope?>("settingScope"); }
            set { BackingStore?.Set("settingScope", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UnsupportedGroupPolicyExtension CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnsupportedGroupPolicyExtension();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"extensionType", n => { ExtensionType = n.GetStringValue(); } },
                {"namespaceUrl", n => { NamespaceUrl = n.GetStringValue(); } },
                {"nodeName", n => { NodeName = n.GetStringValue(); } },
                {"settingScope", n => { SettingScope = n.GetEnumValue<GroupPolicySettingScope>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("extensionType", ExtensionType);
            writer.WriteStringValue("namespaceUrl", NamespaceUrl);
            writer.WriteStringValue("nodeName", NodeName);
            writer.WriteEnumValue<GroupPolicySettingScope>("settingScope", SettingScope);
        }
    }
}
