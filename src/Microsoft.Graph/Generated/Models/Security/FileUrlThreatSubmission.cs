using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class FileUrlThreatSubmission : FileThreatSubmission, IParsable {
        /// <summary>It specifies the URL of the file which needs to be submitted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileUrl {
            get { return BackingStore?.Get<string?>("fileUrl"); }
            set { BackingStore?.Set("fileUrl", value); }
        }
#nullable restore
#else
        public string FileUrl {
            get { return BackingStore?.Get<string>("fileUrl"); }
            set { BackingStore?.Set("fileUrl", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new fileUrlThreatSubmission and sets the default values.
        /// </summary>
        public FileUrlThreatSubmission() : base() {
            OdataType = "#microsoft.graph.security.fileUrlThreatSubmission";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new FileUrlThreatSubmission CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FileUrlThreatSubmission();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"fileUrl", n => { FileUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("fileUrl", FileUrl);
        }
    }
}
