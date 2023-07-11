using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Result of the ConfigurationManager action
    /// </summary>
    public class ConfigurationManagerActionResult : DeviceActionResult, IParsable {
        /// <summary>Delivery state of Configuration Manager device action</summary>
        public ConfigurationManagerActionDeliveryStatus? ActionDeliveryStatus {
            get { return BackingStore?.Get<ConfigurationManagerActionDeliveryStatus?>("actionDeliveryStatus"); }
            set { BackingStore?.Set("actionDeliveryStatus", value); }
        }
        /// <summary>Error code of Configuration Manager action from client</summary>
        public int? ErrorCode {
            get { return BackingStore?.Get<int?>("errorCode"); }
            set { BackingStore?.Set("errorCode", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ConfigurationManagerActionResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConfigurationManagerActionResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"actionDeliveryStatus", n => { ActionDeliveryStatus = n.GetEnumValue<ConfigurationManagerActionDeliveryStatus>(); } },
                {"errorCode", n => { ErrorCode = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ConfigurationManagerActionDeliveryStatus>("actionDeliveryStatus", ActionDeliveryStatus);
            writer.WriteIntValue("errorCode", ErrorCode);
        }
    }
}
