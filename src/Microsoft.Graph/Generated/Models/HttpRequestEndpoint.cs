using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class HttpRequestEndpoint : CustomExtensionEndpointConfiguration, IParsable {
        /// <summary>The targetUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetUrl {
            get { return BackingStore?.Get<string?>("targetUrl"); }
            set { BackingStore?.Set("targetUrl", value); }
        }
#nullable restore
#else
        public string TargetUrl {
            get { return BackingStore?.Get<string>("targetUrl"); }
            set { BackingStore?.Set("targetUrl", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new HttpRequestEndpoint and sets the default values.
        /// </summary>
        public HttpRequestEndpoint() : base() {
            OdataType = "#microsoft.graph.httpRequestEndpoint";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new HttpRequestEndpoint CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new HttpRequestEndpoint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"targetUrl", n => { TargetUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("targetUrl", TargetUrl);
        }
    }
}
