using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class InformationProtectionPolicySetting : Entity, IParsable {
        /// <summary>The defaultLabelId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultLabelId {
            get { return BackingStore?.Get<string?>("defaultLabelId"); }
            set { BackingStore?.Set("defaultLabelId", value); }
        }
#nullable restore
#else
        public string DefaultLabelId {
            get { return BackingStore?.Get<string>("defaultLabelId"); }
            set { BackingStore?.Set("defaultLabelId", value); }
        }
#endif
        /// <summary>Exposes whether justification input is required on label downgrade.</summary>
        public bool? IsDowngradeJustificationRequired {
            get { return BackingStore?.Get<bool?>("isDowngradeJustificationRequired"); }
            set { BackingStore?.Set("isDowngradeJustificationRequired", value); }
        }
        /// <summary>Exposes whether mandatory labeling is enabled.</summary>
        public bool? IsMandatory {
            get { return BackingStore?.Get<bool?>("isMandatory"); }
            set { BackingStore?.Set("isMandatory", value); }
        }
        /// <summary>Exposes the more information URL that can be configured by the administrator.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MoreInfoUrl {
            get { return BackingStore?.Get<string?>("moreInfoUrl"); }
            set { BackingStore?.Set("moreInfoUrl", value); }
        }
#nullable restore
#else
        public string MoreInfoUrl {
            get { return BackingStore?.Get<string>("moreInfoUrl"); }
            set { BackingStore?.Set("moreInfoUrl", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new InformationProtectionPolicySetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InformationProtectionPolicySetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"defaultLabelId", n => { DefaultLabelId = n.GetStringValue(); } },
                {"isDowngradeJustificationRequired", n => { IsDowngradeJustificationRequired = n.GetBoolValue(); } },
                {"isMandatory", n => { IsMandatory = n.GetBoolValue(); } },
                {"moreInfoUrl", n => { MoreInfoUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
