using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Entity representing a setting category
    /// </summary>
    public class DeviceManagementSettingCategory : Entity, IParsable {
        /// <summary>The category name</summary>
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
        /// <summary>The category contains top level required setting</summary>
        public bool? HasRequiredSetting {
            get { return BackingStore?.Get<bool?>("hasRequiredSetting"); }
            set { BackingStore?.Set("hasRequiredSetting", value); }
        }
        /// <summary>The setting definitions this category contains</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementSettingDefinition>? SettingDefinitions {
            get { return BackingStore?.Get<List<DeviceManagementSettingDefinition>?>("settingDefinitions"); }
            set { BackingStore?.Set("settingDefinitions", value); }
        }
#nullable restore
#else
        public List<DeviceManagementSettingDefinition> SettingDefinitions {
            get { return BackingStore?.Get<List<DeviceManagementSettingDefinition>>("settingDefinitions"); }
            set { BackingStore?.Set("settingDefinitions", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementSettingCategory CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.deviceManagementIntentSettingCategory" => new DeviceManagementIntentSettingCategory(),
                "#microsoft.graph.deviceManagementTemplateSettingCategory" => new DeviceManagementTemplateSettingCategory(),
                _ => new DeviceManagementSettingCategory(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"hasRequiredSetting", n => { HasRequiredSetting = n.GetBoolValue(); } },
                {"settingDefinitions", n => { SettingDefinitions = n.GetCollectionOfObjectValues<DeviceManagementSettingDefinition>(DeviceManagementSettingDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("hasRequiredSetting", HasRequiredSetting);
            writer.WriteCollectionOfObjectValues<DeviceManagementSettingDefinition>("settingDefinitions", SettingDefinitions);
        }
    }
}
