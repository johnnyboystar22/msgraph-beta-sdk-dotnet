using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class SequentialActivationRenewalsAlertConfiguration : UnifiedRoleManagementAlertConfiguration, IParsable {
        /// <summary>The sequentialActivationCounterThreshold property</summary>
        public int? SequentialActivationCounterThreshold {
            get { return BackingStore?.Get<int?>("sequentialActivationCounterThreshold"); }
            set { BackingStore?.Set("sequentialActivationCounterThreshold", value); }
        }
        /// <summary>The timeIntervalBetweenActivations property</summary>
        public TimeSpan? TimeIntervalBetweenActivations {
            get { return BackingStore?.Get<TimeSpan?>("timeIntervalBetweenActivations"); }
            set { BackingStore?.Set("timeIntervalBetweenActivations", value); }
        }
        /// <summary>
        /// Instantiates a new SequentialActivationRenewalsAlertConfiguration and sets the default values.
        /// </summary>
        public SequentialActivationRenewalsAlertConfiguration() : base() {
            OdataType = "#microsoft.graph.sequentialActivationRenewalsAlertConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SequentialActivationRenewalsAlertConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SequentialActivationRenewalsAlertConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"sequentialActivationCounterThreshold", n => { SequentialActivationCounterThreshold = n.GetIntValue(); } },
                {"timeIntervalBetweenActivations", n => { TimeIntervalBetweenActivations = n.GetTimeSpanValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("sequentialActivationCounterThreshold", SequentialActivationCounterThreshold);
            writer.WriteTimeSpanValue("timeIntervalBetweenActivations", TimeIntervalBetweenActivations);
        }
    }
}
