using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class DetectedSensitiveContent : DetectedSensitiveContentBase, IParsable {
        /// <summary>The classificationAttributes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ClassificationAttribute>? ClassificationAttributes {
            get { return BackingStore?.Get<List<ClassificationAttribute>?>("classificationAttributes"); }
            set { BackingStore?.Set("classificationAttributes", value); }
        }
#nullable restore
#else
        public List<ClassificationAttribute> ClassificationAttributes {
            get { return BackingStore?.Get<List<ClassificationAttribute>>("classificationAttributes"); }
            set { BackingStore?.Set("classificationAttributes", value); }
        }
#endif
        /// <summary>The classificationMethod property</summary>
        public Microsoft.Graph.Beta.Models.ClassificationMethod? ClassificationMethod {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ClassificationMethod?>("classificationMethod"); }
            set { BackingStore?.Set("classificationMethod", value); }
        }
        /// <summary>The matches property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SensitiveContentLocation>? Matches {
            get { return BackingStore?.Get<List<SensitiveContentLocation>?>("matches"); }
            set { BackingStore?.Set("matches", value); }
        }
#nullable restore
#else
        public List<SensitiveContentLocation> Matches {
            get { return BackingStore?.Get<List<SensitiveContentLocation>>("matches"); }
            set { BackingStore?.Set("matches", value); }
        }
#endif
        /// <summary>The scope property</summary>
        public SensitiveTypeScope? Scope {
            get { return BackingStore?.Get<SensitiveTypeScope?>("scope"); }
            set { BackingStore?.Set("scope", value); }
        }
        /// <summary>The sensitiveTypeSource property</summary>
        public Microsoft.Graph.Beta.Models.SensitiveTypeSource? SensitiveTypeSource {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SensitiveTypeSource?>("sensitiveTypeSource"); }
            set { BackingStore?.Set("sensitiveTypeSource", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DetectedSensitiveContent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.machineLearningDetectedSensitiveContent" => new MachineLearningDetectedSensitiveContent(),
                _ => new DetectedSensitiveContent(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"classificationAttributes", n => { ClassificationAttributes = n.GetCollectionOfObjectValues<ClassificationAttribute>(ClassificationAttribute.CreateFromDiscriminatorValue)?.ToList(); } },
                {"classificationMethod", n => { ClassificationMethod = n.GetEnumValue<ClassificationMethod>(); } },
                {"matches", n => { Matches = n.GetCollectionOfObjectValues<SensitiveContentLocation>(SensitiveContentLocation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"scope", n => { Scope = n.GetEnumValue<SensitiveTypeScope>(); } },
                {"sensitiveTypeSource", n => { SensitiveTypeSource = n.GetEnumValue<SensitiveTypeSource>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ClassificationAttribute>("classificationAttributes", ClassificationAttributes);
            writer.WriteEnumValue<ClassificationMethod>("classificationMethod", ClassificationMethod);
            writer.WriteCollectionOfObjectValues<SensitiveContentLocation>("matches", Matches);
            writer.WriteEnumValue<SensitiveTypeScope>("scope", Scope);
            writer.WriteEnumValue<SensitiveTypeSource>("sensitiveTypeSource", SensitiveTypeSource);
        }
    }
}
