using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Device Enrollment Configuration that restricts the number of devices a user can enroll
    /// </summary>
    public class DeviceEnrollmentLimitConfiguration : DeviceEnrollmentConfiguration, IParsable {
        /// <summary>The maximum number of devices that a user can enroll</summary>
        public int? Limit {
            get { return BackingStore?.Get<int?>("limit"); }
            set { BackingStore?.Set("limit", value); }
        }
        /// <summary>
        /// Instantiates a new deviceEnrollmentLimitConfiguration and sets the default values.
        /// </summary>
        public DeviceEnrollmentLimitConfiguration() : base() {
            OdataType = "#microsoft.graph.deviceEnrollmentLimitConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceEnrollmentLimitConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceEnrollmentLimitConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"limit", n => { Limit = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("limit", Limit);
        }
    }
}
