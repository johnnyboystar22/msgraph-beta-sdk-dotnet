using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationRedirectSettingDefinition : DeviceManagementConfigurationSettingDefinition, IParsable {
        /// <summary>A deep link that points to the specific location in the Intune console where feature support must be managed from.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeepLink {
            get { return BackingStore?.Get<string?>("deepLink"); }
            set { BackingStore?.Set("deepLink", value); }
        }
#nullable restore
#else
        public string DeepLink {
            get { return BackingStore?.Get<string>("deepLink"); }
            set { BackingStore?.Set("deepLink", value); }
        }
#endif
        /// <summary>A message that explains that clicking the link will redirect the user to a supported page to manage the settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RedirectMessage {
            get { return BackingStore?.Get<string?>("redirectMessage"); }
            set { BackingStore?.Set("redirectMessage", value); }
        }
#nullable restore
#else
        public string RedirectMessage {
            get { return BackingStore?.Get<string>("redirectMessage"); }
            set { BackingStore?.Set("redirectMessage", value); }
        }
#endif
        /// <summary>Indicates the reason for redirecting the user to an alternative location in the console.  For example: WiFi profiles are not supported in the settings catalog and must be created with a template policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RedirectReason {
            get { return BackingStore?.Get<string?>("redirectReason"); }
            set { BackingStore?.Set("redirectReason", value); }
        }
#nullable restore
#else
        public string RedirectReason {
            get { return BackingStore?.Get<string>("redirectReason"); }
            set { BackingStore?.Set("redirectReason", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementConfigurationRedirectSettingDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationRedirectSettingDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deepLink", n => { DeepLink = n.GetStringValue(); } },
                {"redirectMessage", n => { RedirectMessage = n.GetStringValue(); } },
                {"redirectReason", n => { RedirectReason = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("deepLink", DeepLink);
            writer.WriteStringValue("redirectMessage", RedirectMessage);
            writer.WriteStringValue("redirectReason", RedirectReason);
        }
    }
}
