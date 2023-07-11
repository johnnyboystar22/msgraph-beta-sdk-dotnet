using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Instance of a GroupSetting
    /// </summary>
    public class DeviceManagementConfigurationGroupSettingInstance : DeviceManagementConfigurationSettingInstance, IParsable {
        /// <summary>The groupSettingValue property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementConfigurationGroupSettingValue? GroupSettingValue {
            get { return BackingStore?.Get<DeviceManagementConfigurationGroupSettingValue?>("groupSettingValue"); }
            set { BackingStore?.Set("groupSettingValue", value); }
        }
#nullable restore
#else
        public DeviceManagementConfigurationGroupSettingValue GroupSettingValue {
            get { return BackingStore?.Get<DeviceManagementConfigurationGroupSettingValue>("groupSettingValue"); }
            set { BackingStore?.Set("groupSettingValue", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new deviceManagementConfigurationGroupSettingInstance and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationGroupSettingInstance() : base() {
            OdataType = "#microsoft.graph.deviceManagementConfigurationGroupSettingInstance";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementConfigurationGroupSettingInstance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationGroupSettingInstance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"groupSettingValue", n => { GroupSettingValue = n.GetObjectValue<DeviceManagementConfigurationGroupSettingValue>(DeviceManagementConfigurationGroupSettingValue.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DeviceManagementConfigurationGroupSettingValue>("groupSettingValue", GroupSettingValue);
        }
    }
}
