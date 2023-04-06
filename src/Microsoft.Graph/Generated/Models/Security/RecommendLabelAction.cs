using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class RecommendLabelAction : InformationProtectionAction, IParsable {
        /// <summary>Actions to take if the label is accepted by the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InformationProtectionAction>? Actions {
            get { return BackingStore?.Get<List<InformationProtectionAction>?>("actions"); }
            set { BackingStore?.Set("actions", value); }
        }
#nullable restore
#else
        public List<InformationProtectionAction> Actions {
            get { return BackingStore?.Get<List<InformationProtectionAction>>("actions"); }
            set { BackingStore?.Set("actions", value); }
        }
#endif
        /// <summary>The actionSource property</summary>
        public Microsoft.Graph.Beta.Models.Security.ActionSource? ActionSource {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.ActionSource?>("actionSource"); }
            set { BackingStore?.Set("actionSource", value); }
        }
        /// <summary>The sensitive information type GUIDs that caused the recommendation to be given.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ResponsibleSensitiveTypeIds {
            get { return BackingStore?.Get<List<string>?>("responsibleSensitiveTypeIds"); }
            set { BackingStore?.Set("responsibleSensitiveTypeIds", value); }
        }
#nullable restore
#else
        public List<string> ResponsibleSensitiveTypeIds {
            get { return BackingStore?.Get<List<string>>("responsibleSensitiveTypeIds"); }
            set { BackingStore?.Set("responsibleSensitiveTypeIds", value); }
        }
#endif
        /// <summary>The sensitivityLabelId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SensitivityLabelId {
            get { return BackingStore?.Get<string?>("sensitivityLabelId"); }
            set { BackingStore?.Set("sensitivityLabelId", value); }
        }
#nullable restore
#else
        public string SensitivityLabelId {
            get { return BackingStore?.Get<string>("sensitivityLabelId"); }
            set { BackingStore?.Set("sensitivityLabelId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new RecommendLabelAction and sets the default values.
        /// </summary>
        public RecommendLabelAction() : base() {
            OdataType = "#microsoft.graph.security.recommendLabelAction";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RecommendLabelAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RecommendLabelAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"actions", n => { Actions = n.GetCollectionOfObjectValues<InformationProtectionAction>(InformationProtectionAction.CreateFromDiscriminatorValue)?.ToList(); } },
                {"actionSource", n => { ActionSource = n.GetEnumValue<ActionSource>(); } },
                {"responsibleSensitiveTypeIds", n => { ResponsibleSensitiveTypeIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"sensitivityLabelId", n => { SensitivityLabelId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<InformationProtectionAction>("actions", Actions);
            writer.WriteEnumValue<ActionSource>("actionSource", ActionSource);
            writer.WriteCollectionOfPrimitiveValues<string>("responsibleSensitiveTypeIds", ResponsibleSensitiveTypeIds);
            writer.WriteStringValue("sensitivityLabelId", SensitivityLabelId);
        }
    }
}
