using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationGroupSettingInstanceTemplate : DeviceManagementConfigurationSettingInstanceTemplate, IParsable {
        /// <summary>Group Setting Value Template</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementConfigurationGroupSettingValueTemplate? GroupSettingValueTemplate {
            get { return BackingStore?.Get<DeviceManagementConfigurationGroupSettingValueTemplate?>("groupSettingValueTemplate"); }
            set { BackingStore?.Set("groupSettingValueTemplate", value); }
        }
#nullable restore
#else
        public DeviceManagementConfigurationGroupSettingValueTemplate GroupSettingValueTemplate {
            get { return BackingStore?.Get<DeviceManagementConfigurationGroupSettingValueTemplate>("groupSettingValueTemplate"); }
            set { BackingStore?.Set("groupSettingValueTemplate", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new DeviceManagementConfigurationGroupSettingInstanceTemplate and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationGroupSettingInstanceTemplate() : base() {
            OdataType = "#microsoft.graph.deviceManagementConfigurationGroupSettingInstanceTemplate";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementConfigurationGroupSettingInstanceTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationGroupSettingInstanceTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"groupSettingValueTemplate", n => { GroupSettingValueTemplate = n.GetObjectValue<DeviceManagementConfigurationGroupSettingValueTemplate>(DeviceManagementConfigurationGroupSettingValueTemplate.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DeviceManagementConfigurationGroupSettingValueTemplate>("groupSettingValueTemplate", GroupSettingValueTemplate);
        }
    }
}
