using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceHealthScriptRunOnceSchedule : DeviceHealthScriptTimeSchedule, IParsable {
        /// <summary>The date the script is scheduled to run. This collection can contain a maximum of 20 elements.</summary>
        public Date? Date {
            get { return BackingStore?.Get<Date?>("date"); }
            set { BackingStore?.Set("date", value); }
        }
        /// <summary>
        /// Instantiates a new DeviceHealthScriptRunOnceSchedule and sets the default values.
        /// </summary>
        public DeviceHealthScriptRunOnceSchedule() : base() {
            OdataType = "#microsoft.graph.deviceHealthScriptRunOnceSchedule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceHealthScriptRunOnceSchedule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceHealthScriptRunOnceSchedule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"date", n => { Date = n.GetDateValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateValue("date", Date);
        }
    }
}
