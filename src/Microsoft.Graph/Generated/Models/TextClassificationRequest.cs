using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class TextClassificationRequest : Entity, IParsable {
        /// <summary>The contentMetaData property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ClassificationRequestContentMetaData? ContentMetaData {
            get { return BackingStore?.Get<ClassificationRequestContentMetaData?>("contentMetaData"); }
            set { BackingStore?.Set("contentMetaData", value); }
        }
#nullable restore
#else
        public ClassificationRequestContentMetaData ContentMetaData {
            get { return BackingStore?.Get<ClassificationRequestContentMetaData>("contentMetaData"); }
            set { BackingStore?.Set("contentMetaData", value); }
        }
#endif
        /// <summary>The fileExtension property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileExtension {
            get { return BackingStore?.Get<string?>("fileExtension"); }
            set { BackingStore?.Set("fileExtension", value); }
        }
#nullable restore
#else
        public string FileExtension {
            get { return BackingStore?.Get<string>("fileExtension"); }
            set { BackingStore?.Set("fileExtension", value); }
        }
#endif
        /// <summary>The matchTolerancesToInclude property</summary>
        public MlClassificationMatchTolerance? MatchTolerancesToInclude {
            get { return BackingStore?.Get<MlClassificationMatchTolerance?>("matchTolerancesToInclude"); }
            set { BackingStore?.Set("matchTolerancesToInclude", value); }
        }
        /// <summary>The scopesToRun property</summary>
        public SensitiveTypeScope? ScopesToRun {
            get { return BackingStore?.Get<SensitiveTypeScope?>("scopesToRun"); }
            set { BackingStore?.Set("scopesToRun", value); }
        }
        /// <summary>The sensitiveTypeIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SensitiveTypeIds {
            get { return BackingStore?.Get<List<string>?>("sensitiveTypeIds"); }
            set { BackingStore?.Set("sensitiveTypeIds", value); }
        }
#nullable restore
#else
        public List<string> SensitiveTypeIds {
            get { return BackingStore?.Get<List<string>>("sensitiveTypeIds"); }
            set { BackingStore?.Set("sensitiveTypeIds", value); }
        }
#endif
        /// <summary>The text property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Text {
            get { return BackingStore?.Get<string?>("text"); }
            set { BackingStore?.Set("text", value); }
        }
#nullable restore
#else
        public string Text {
            get { return BackingStore?.Get<string>("text"); }
            set { BackingStore?.Set("text", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TextClassificationRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TextClassificationRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"contentMetaData", n => { ContentMetaData = n.GetObjectValue<ClassificationRequestContentMetaData>(ClassificationRequestContentMetaData.CreateFromDiscriminatorValue); } },
                {"fileExtension", n => { FileExtension = n.GetStringValue(); } },
                {"matchTolerancesToInclude", n => { MatchTolerancesToInclude = n.GetEnumValue<MlClassificationMatchTolerance>(); } },
                {"scopesToRun", n => { ScopesToRun = n.GetEnumValue<SensitiveTypeScope>(); } },
                {"sensitiveTypeIds", n => { SensitiveTypeIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"text", n => { Text = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ClassificationRequestContentMetaData>("contentMetaData", ContentMetaData);
            writer.WriteStringValue("fileExtension", FileExtension);
            writer.WriteEnumValue<MlClassificationMatchTolerance>("matchTolerancesToInclude", MatchTolerancesToInclude);
            writer.WriteEnumValue<SensitiveTypeScope>("scopesToRun", ScopesToRun);
            writer.WriteCollectionOfPrimitiveValues<string>("sensitiveTypeIds", SensitiveTypeIds);
            writer.WriteStringValue("text", Text);
        }
    }
}
