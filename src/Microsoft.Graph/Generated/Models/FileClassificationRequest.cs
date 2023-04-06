using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class FileClassificationRequest : Entity, IParsable {
        /// <summary>The file property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? File {
            get { return BackingStore?.Get<byte[]?>("file"); }
            set { BackingStore?.Set("file", value); }
        }
#nullable restore
#else
        public byte[] File {
            get { return BackingStore?.Get<byte[]>("file"); }
            set { BackingStore?.Set("file", value); }
        }
#endif
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
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new FileClassificationRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FileClassificationRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"file", n => { File = n.GetByteArrayValue(); } },
                {"sensitiveTypeIds", n => { SensitiveTypeIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteByteArrayValue("file", File);
            writer.WriteCollectionOfPrimitiveValues<string>("sensitiveTypeIds", SensitiveTypeIds);
        }
    }
}
