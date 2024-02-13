// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class FileObject : Microsoft.Graph.Beta.Models.Entity, IParsable {
        /// <summary>The content property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Content {
            get { return BackingStore?.Get<byte[]?>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#nullable restore
#else
        public byte[] Content {
            get { return BackingStore?.Get<byte[]>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#endif
        /// <summary>The dateTime property</summary>
        public DateTimeOffset? DateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("dateTime"); }
            set { BackingStore?.Set("dateTime", value); }
        }
        /// <summary>The extension property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Extension {
            get { return BackingStore?.Get<string?>("extension"); }
            set { BackingStore?.Set("extension", value); }
        }
#nullable restore
#else
        public string Extension {
            get { return BackingStore?.Get<string>("extension"); }
            set { BackingStore?.Set("extension", value); }
        }
#endif
        /// <summary>The extractedTextContent property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? ExtractedTextContent {
            get { return BackingStore?.Get<byte[]?>("extractedTextContent"); }
            set { BackingStore?.Set("extractedTextContent", value); }
        }
#nullable restore
#else
        public byte[] ExtractedTextContent {
            get { return BackingStore?.Get<byte[]>("extractedTextContent"); }
            set { BackingStore?.Set("extractedTextContent", value); }
        }
#endif
        /// <summary>The mediaType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MediaType {
            get { return BackingStore?.Get<string?>("mediaType"); }
            set { BackingStore?.Set("mediaType", value); }
        }
#nullable restore
#else
        public string MediaType {
            get { return BackingStore?.Get<string>("mediaType"); }
            set { BackingStore?.Set("mediaType", value); }
        }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The otherProperties property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public StringValueDictionary? OtherProperties {
            get { return BackingStore?.Get<StringValueDictionary?>("otherProperties"); }
            set { BackingStore?.Set("otherProperties", value); }
        }
#nullable restore
#else
        public StringValueDictionary OtherProperties {
            get { return BackingStore?.Get<StringValueDictionary>("otherProperties"); }
            set { BackingStore?.Set("otherProperties", value); }
        }
#endif
        /// <summary>The processingStatus property</summary>
        public FileProcessingStatus? ProcessingStatus {
            get { return BackingStore?.Get<FileProcessingStatus?>("processingStatus"); }
            set { BackingStore?.Set("processingStatus", value); }
        }
        /// <summary>The senderOrAuthors property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SenderOrAuthors {
            get { return BackingStore?.Get<List<string>?>("senderOrAuthors"); }
            set { BackingStore?.Set("senderOrAuthors", value); }
        }
#nullable restore
#else
        public List<string> SenderOrAuthors {
            get { return BackingStore?.Get<List<string>>("senderOrAuthors"); }
            set { BackingStore?.Set("senderOrAuthors", value); }
        }
#endif
        /// <summary>The size property</summary>
        public long? Size {
            get { return BackingStore?.Get<long?>("size"); }
            set { BackingStore?.Set("size", value); }
        }
        /// <summary>The sourceType property</summary>
        public Microsoft.Graph.Beta.Models.Security.SourceType? SourceType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.SourceType?>("sourceType"); }
            set { BackingStore?.Set("sourceType", value); }
        }
        /// <summary>The subjectTitle property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubjectTitle {
            get { return BackingStore?.Get<string?>("subjectTitle"); }
            set { BackingStore?.Set("subjectTitle", value); }
        }
#nullable restore
#else
        public string SubjectTitle {
            get { return BackingStore?.Get<string>("subjectTitle"); }
            set { BackingStore?.Set("subjectTitle", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="FileObject"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new FileObject CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.security.ediscoveryFile" => new EdiscoveryFile(),
                _ => new FileObject(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"content", n => { Content = n.GetByteArrayValue(); } },
                {"dateTime", n => { DateTime = n.GetDateTimeOffsetValue(); } },
                {"extension", n => { Extension = n.GetStringValue(); } },
                {"extractedTextContent", n => { ExtractedTextContent = n.GetByteArrayValue(); } },
                {"mediaType", n => { MediaType = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"otherProperties", n => { OtherProperties = n.GetObjectValue<StringValueDictionary>(StringValueDictionary.CreateFromDiscriminatorValue); } },
                {"processingStatus", n => { ProcessingStatus = n.GetEnumValue<FileProcessingStatus>(); } },
                {"senderOrAuthors", n => { SenderOrAuthors = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"size", n => { Size = n.GetLongValue(); } },
                {"sourceType", n => { SourceType = n.GetEnumValue<SourceType>(); } },
                {"subjectTitle", n => { SubjectTitle = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteByteArrayValue("content", Content);
            writer.WriteDateTimeOffsetValue("dateTime", DateTime);
            writer.WriteStringValue("extension", Extension);
            writer.WriteByteArrayValue("extractedTextContent", ExtractedTextContent);
            writer.WriteStringValue("mediaType", MediaType);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<StringValueDictionary>("otherProperties", OtherProperties);
            writer.WriteEnumValue<FileProcessingStatus>("processingStatus", ProcessingStatus);
            writer.WriteCollectionOfPrimitiveValues<string>("senderOrAuthors", SenderOrAuthors);
            writer.WriteLongValue("size", Size);
            writer.WriteEnumValue<SourceType>("sourceType", SourceType);
            writer.WriteStringValue("subjectTitle", SubjectTitle);
        }
    }
}
