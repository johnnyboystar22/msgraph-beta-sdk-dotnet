using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class ExactMatchSession : ExactMatchSessionBase, IParsable {
        /// <summary>The checksum property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Checksum {
            get { return BackingStore?.Get<string?>("checksum"); }
            set { BackingStore?.Set("checksum", value); }
        }
#nullable restore
#else
        public string Checksum {
            get { return BackingStore?.Get<string>("checksum"); }
            set { BackingStore?.Set("checksum", value); }
        }
#endif
        /// <summary>The dataUploadURI property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DataUploadURI {
            get { return BackingStore?.Get<string?>("dataUploadURI"); }
            set { BackingStore?.Set("dataUploadURI", value); }
        }
#nullable restore
#else
        public string DataUploadURI {
            get { return BackingStore?.Get<string>("dataUploadURI"); }
            set { BackingStore?.Set("dataUploadURI", value); }
        }
#endif
        /// <summary>The fields property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Fields {
            get { return BackingStore?.Get<List<string>?>("fields"); }
            set { BackingStore?.Set("fields", value); }
        }
#nullable restore
#else
        public List<string> Fields {
            get { return BackingStore?.Get<List<string>>("fields"); }
            set { BackingStore?.Set("fields", value); }
        }
#endif
        /// <summary>The fileName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileName {
            get { return BackingStore?.Get<string?>("fileName"); }
            set { BackingStore?.Set("fileName", value); }
        }
#nullable restore
#else
        public string FileName {
            get { return BackingStore?.Get<string>("fileName"); }
            set { BackingStore?.Set("fileName", value); }
        }
#endif
        /// <summary>The rowsPerBlock property</summary>
        public int? RowsPerBlock {
            get { return BackingStore?.Get<int?>("rowsPerBlock"); }
            set { BackingStore?.Set("rowsPerBlock", value); }
        }
        /// <summary>The salt property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Salt {
            get { return BackingStore?.Get<string?>("salt"); }
            set { BackingStore?.Set("salt", value); }
        }
#nullable restore
#else
        public string Salt {
            get { return BackingStore?.Get<string>("salt"); }
            set { BackingStore?.Set("salt", value); }
        }
#endif
        /// <summary>The uploadAgent property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ExactMatchUploadAgent? UploadAgent {
            get { return BackingStore?.Get<ExactMatchUploadAgent?>("uploadAgent"); }
            set { BackingStore?.Set("uploadAgent", value); }
        }
#nullable restore
#else
        public ExactMatchUploadAgent UploadAgent {
            get { return BackingStore?.Get<ExactMatchUploadAgent>("uploadAgent"); }
            set { BackingStore?.Set("uploadAgent", value); }
        }
#endif
        /// <summary>The uploadAgentId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UploadAgentId {
            get { return BackingStore?.Get<string?>("uploadAgentId"); }
            set { BackingStore?.Set("uploadAgentId", value); }
        }
#nullable restore
#else
        public string UploadAgentId {
            get { return BackingStore?.Get<string>("uploadAgentId"); }
            set { BackingStore?.Set("uploadAgentId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ExactMatchSession CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExactMatchSession();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"checksum", n => { Checksum = n.GetStringValue(); } },
                {"dataUploadURI", n => { DataUploadURI = n.GetStringValue(); } },
                {"fields", n => { Fields = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"fileName", n => { FileName = n.GetStringValue(); } },
                {"rowsPerBlock", n => { RowsPerBlock = n.GetIntValue(); } },
                {"salt", n => { Salt = n.GetStringValue(); } },
                {"uploadAgent", n => { UploadAgent = n.GetObjectValue<ExactMatchUploadAgent>(ExactMatchUploadAgent.CreateFromDiscriminatorValue); } },
                {"uploadAgentId", n => { UploadAgentId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("checksum", Checksum);
            writer.WriteStringValue("dataUploadURI", DataUploadURI);
            writer.WriteCollectionOfPrimitiveValues<string>("fields", Fields);
            writer.WriteStringValue("fileName", FileName);
            writer.WriteIntValue("rowsPerBlock", RowsPerBlock);
            writer.WriteStringValue("salt", Salt);
            writer.WriteObjectValue<ExactMatchUploadAgent>("uploadAgent", UploadAgent);
            writer.WriteStringValue("uploadAgentId", UploadAgentId);
        }
    }
}
