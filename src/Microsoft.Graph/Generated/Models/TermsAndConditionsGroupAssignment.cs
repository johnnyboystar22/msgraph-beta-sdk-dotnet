using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// A termsAndConditionsGroupAssignment entity represents the assignment of a given Terms and Conditions (T&amp;C) policy to a given group. Users in the group will be required to accept the terms in order to have devices enrolled into Intune.
    /// </summary>
    public class TermsAndConditionsGroupAssignment : Entity, IParsable {
        /// <summary>Unique identifier of a group that the T&amp;C policy is assigned to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetGroupId {
            get { return BackingStore?.Get<string?>("targetGroupId"); }
            set { BackingStore?.Set("targetGroupId", value); }
        }
#nullable restore
#else
        public string TargetGroupId {
            get { return BackingStore?.Get<string>("targetGroupId"); }
            set { BackingStore?.Set("targetGroupId", value); }
        }
#endif
        /// <summary>Navigation link to the terms and conditions that are assigned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.TermsAndConditions? TermsAndConditions {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TermsAndConditions?>("termsAndConditions"); }
            set { BackingStore?.Set("termsAndConditions", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.TermsAndConditions TermsAndConditions {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TermsAndConditions>("termsAndConditions"); }
            set { BackingStore?.Set("termsAndConditions", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TermsAndConditionsGroupAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TermsAndConditionsGroupAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"targetGroupId", n => { TargetGroupId = n.GetStringValue(); } },
                {"termsAndConditions", n => { TermsAndConditions = n.GetObjectValue<Microsoft.Graph.Beta.Models.TermsAndConditions>(Microsoft.Graph.Beta.Models.TermsAndConditions.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("targetGroupId", TargetGroupId);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TermsAndConditions>("termsAndConditions", TermsAndConditions);
        }
    }
}
