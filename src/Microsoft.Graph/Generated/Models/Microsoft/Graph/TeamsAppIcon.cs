using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class TeamsAppIcon : Entity, IParsable {
        /// <summary>The contents of the app icon if the icon is hosted within the Teams infrastructure.</summary>
        public TeamworkHostedContent HostedContent { get; set; }
        /// <summary>The web URL that can be used for downloading the image.</summary>
        public string WebUrl { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TeamsAppIcon CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamsAppIcon();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"hostedContent", (o,n) => { (o as TeamsAppIcon).HostedContent = n.GetObjectValue<TeamworkHostedContent>(TeamworkHostedContent.CreateFromDiscriminatorValue); } },
                {"webUrl", (o,n) => { (o as TeamsAppIcon).WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<TeamworkHostedContent>("hostedContent", HostedContent);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
