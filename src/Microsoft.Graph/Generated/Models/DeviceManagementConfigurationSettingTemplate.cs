using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Setting Template
    /// </summary>
    public class DeviceManagementConfigurationSettingTemplate : Entity, IParsable {
        /// <summary>List of related Setting Definitions</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementConfigurationSettingDefinition>? SettingDefinitions {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationSettingDefinition>?>("settingDefinitions"); }
            set { BackingStore?.Set("settingDefinitions", value); }
        }
#nullable restore
#else
        public List<DeviceManagementConfigurationSettingDefinition> SettingDefinitions {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationSettingDefinition>>("settingDefinitions"); }
            set { BackingStore?.Set("settingDefinitions", value); }
        }
#endif
        /// <summary>Setting Instance Template</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementConfigurationSettingInstanceTemplate? SettingInstanceTemplate {
            get { return BackingStore?.Get<DeviceManagementConfigurationSettingInstanceTemplate?>("settingInstanceTemplate"); }
            set { BackingStore?.Set("settingInstanceTemplate", value); }
        }
#nullable restore
#else
        public DeviceManagementConfigurationSettingInstanceTemplate SettingInstanceTemplate {
            get { return BackingStore?.Get<DeviceManagementConfigurationSettingInstanceTemplate>("settingInstanceTemplate"); }
            set { BackingStore?.Set("settingInstanceTemplate", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementConfigurationSettingTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationSettingTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"settingDefinitions", n => { SettingDefinitions = n.GetCollectionOfObjectValues<DeviceManagementConfigurationSettingDefinition>(DeviceManagementConfigurationSettingDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"settingInstanceTemplate", n => { SettingInstanceTemplate = n.GetObjectValue<DeviceManagementConfigurationSettingInstanceTemplate>(DeviceManagementConfigurationSettingInstanceTemplate.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationSettingDefinition>("settingDefinitions", SettingDefinitions);
            writer.WriteObjectValue<DeviceManagementConfigurationSettingInstanceTemplate>("settingInstanceTemplate", SettingInstanceTemplate);
        }
    }
}
