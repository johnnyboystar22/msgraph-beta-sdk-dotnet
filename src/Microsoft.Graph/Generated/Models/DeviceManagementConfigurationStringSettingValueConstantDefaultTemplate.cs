using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// String Setting Value Constant Default Template
    /// </summary>
    public class DeviceManagementConfigurationStringSettingValueConstantDefaultTemplate : DeviceManagementConfigurationStringSettingValueDefaultTemplate, IParsable {
        /// <summary>Default Constant Value</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConstantValue {
            get { return BackingStore?.Get<string?>("constantValue"); }
            set { BackingStore?.Set("constantValue", value); }
        }
#nullable restore
#else
        public string ConstantValue {
            get { return BackingStore?.Get<string>("constantValue"); }
            set { BackingStore?.Set("constantValue", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new deviceManagementConfigurationStringSettingValueConstantDefaultTemplate and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationStringSettingValueConstantDefaultTemplate() : base() {
            OdataType = "#microsoft.graph.deviceManagementConfigurationStringSettingValueConstantDefaultTemplate";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementConfigurationStringSettingValueConstantDefaultTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationStringSettingValueConstantDefaultTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"constantValue", n => { ConstantValue = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("constantValue", ConstantValue);
        }
    }
}
