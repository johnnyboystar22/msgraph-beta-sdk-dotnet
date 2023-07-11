using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AccessReviewInstanceDecisionItemAccessPackageAssignmentPolicyResource : AccessReviewInstanceDecisionItemResource, IParsable {
        /// <summary>Display name of the access package to which access has been granted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccessPackageDisplayName {
            get { return BackingStore?.Get<string?>("accessPackageDisplayName"); }
            set { BackingStore?.Set("accessPackageDisplayName", value); }
        }
#nullable restore
#else
        public string AccessPackageDisplayName {
            get { return BackingStore?.Get<string>("accessPackageDisplayName"); }
            set { BackingStore?.Set("accessPackageDisplayName", value); }
        }
#endif
        /// <summary>Identifier of the access package to which access has been granted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccessPackageId {
            get { return BackingStore?.Get<string?>("accessPackageId"); }
            set { BackingStore?.Set("accessPackageId", value); }
        }
#nullable restore
#else
        public string AccessPackageId {
            get { return BackingStore?.Get<string>("accessPackageId"); }
            set { BackingStore?.Set("accessPackageId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new accessReviewInstanceDecisionItemAccessPackageAssignmentPolicyResource and sets the default values.
        /// </summary>
        public AccessReviewInstanceDecisionItemAccessPackageAssignmentPolicyResource() : base() {
            OdataType = "#microsoft.graph.accessReviewInstanceDecisionItemAccessPackageAssignmentPolicyResource";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessReviewInstanceDecisionItemAccessPackageAssignmentPolicyResource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessReviewInstanceDecisionItemAccessPackageAssignmentPolicyResource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessPackageDisplayName", n => { AccessPackageDisplayName = n.GetStringValue(); } },
                {"accessPackageId", n => { AccessPackageId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("accessPackageDisplayName", AccessPackageDisplayName);
            writer.WriteStringValue("accessPackageId", AccessPackageId);
        }
    }
}
