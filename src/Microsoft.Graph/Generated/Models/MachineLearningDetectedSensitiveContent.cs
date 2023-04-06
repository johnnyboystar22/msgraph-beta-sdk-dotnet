using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class MachineLearningDetectedSensitiveContent : DetectedSensitiveContent, IParsable {
        /// <summary>The matchTolerance property</summary>
        public MlClassificationMatchTolerance? MatchTolerance {
            get { return BackingStore?.Get<MlClassificationMatchTolerance?>("matchTolerance"); }
            set { BackingStore?.Set("matchTolerance", value); }
        }
        /// <summary>The modelVersion property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ModelVersion {
            get { return BackingStore?.Get<string?>("modelVersion"); }
            set { BackingStore?.Set("modelVersion", value); }
        }
#nullable restore
#else
        public string ModelVersion {
            get { return BackingStore?.Get<string>("modelVersion"); }
            set { BackingStore?.Set("modelVersion", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MachineLearningDetectedSensitiveContent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MachineLearningDetectedSensitiveContent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"matchTolerance", n => { MatchTolerance = n.GetEnumValue<MlClassificationMatchTolerance>(); } },
                {"modelVersion", n => { ModelVersion = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<MlClassificationMatchTolerance>("matchTolerance", MatchTolerance);
            writer.WriteStringValue("modelVersion", ModelVersion);
        }
    }
}
