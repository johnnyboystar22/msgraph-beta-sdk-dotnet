using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.Security {
    public class InformationProtectionPolicySetting : Entity, IParsable {
        public string DefaultLabelId { get; set; }
        public bool? IsDowngradeJustificationRequired { get; set; }
        public bool? IsMandatory { get; set; }
        public string MoreInfoUrl { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new InformationProtectionPolicySetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InformationProtectionPolicySetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"defaultLabelId", (o,n) => { (o as InformationProtectionPolicySetting).DefaultLabelId = n.GetStringValue(); } },
                {"isDowngradeJustificationRequired", (o,n) => { (o as InformationProtectionPolicySetting).IsDowngradeJustificationRequired = n.GetBoolValue(); } },
                {"isMandatory", (o,n) => { (o as InformationProtectionPolicySetting).IsMandatory = n.GetBoolValue(); } },
                {"moreInfoUrl", (o,n) => { (o as InformationProtectionPolicySetting).MoreInfoUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("defaultLabelId", DefaultLabelId);
            writer.WriteBoolValue("isDowngradeJustificationRequired", IsDowngradeJustificationRequired);
            writer.WriteBoolValue("isMandatory", IsMandatory);
            writer.WriteStringValue("moreInfoUrl", MoreInfoUrl);
        }
    }
}
