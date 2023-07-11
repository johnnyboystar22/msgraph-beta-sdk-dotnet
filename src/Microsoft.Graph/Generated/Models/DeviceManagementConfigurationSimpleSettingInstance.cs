using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Simple setting instance
    /// </summary>
    public class DeviceManagementConfigurationSimpleSettingInstance : DeviceManagementConfigurationSettingInstance, IParsable {
        /// <summary>The simpleSettingValue property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementConfigurationSimpleSettingValue? SimpleSettingValue {
            get { return BackingStore?.Get<DeviceManagementConfigurationSimpleSettingValue?>("simpleSettingValue"); }
            set { BackingStore?.Set("simpleSettingValue", value); }
        }
#nullable restore
#else
        public DeviceManagementConfigurationSimpleSettingValue SimpleSettingValue {
            get { return BackingStore?.Get<DeviceManagementConfigurationSimpleSettingValue>("simpleSettingValue"); }
            set { BackingStore?.Set("simpleSettingValue", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new deviceManagementConfigurationSimpleSettingInstance and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationSimpleSettingInstance() : base() {
            OdataType = "#microsoft.graph.deviceManagementConfigurationSimpleSettingInstance";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementConfigurationSimpleSettingInstance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationSimpleSettingInstance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"simpleSettingValue", n => { SimpleSettingValue = n.GetObjectValue<DeviceManagementConfigurationSimpleSettingValue>(DeviceManagementConfigurationSimpleSettingValue.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DeviceManagementConfigurationSimpleSettingValue>("simpleSettingValue", SimpleSettingValue);
        }
    }
}
