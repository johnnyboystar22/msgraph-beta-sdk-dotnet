using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class DlpEvaluatePoliciesJobResponse : JobResponseBase, IParsable {
        /// <summary>The result property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DlpPoliciesJobResult? Result {
            get { return BackingStore?.Get<DlpPoliciesJobResult?>("result"); }
            set { BackingStore?.Set("result", value); }
        }
#nullable restore
#else
        public DlpPoliciesJobResult Result {
            get { return BackingStore?.Get<DlpPoliciesJobResult>("result"); }
            set { BackingStore?.Set("result", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DlpEvaluatePoliciesJobResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DlpEvaluatePoliciesJobResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"result", n => { Result = n.GetObjectValue<DlpPoliciesJobResult>(DlpPoliciesJobResult.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DlpPoliciesJobResult>("result", Result);
        }
    }
}
