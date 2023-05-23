using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class VirtualEventPresenterInfo : MeetingParticipantInfo, IParsable {
        /// <summary>The presenterDetails property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public VirtualEventPresenterDetails? PresenterDetails {
            get { return BackingStore?.Get<VirtualEventPresenterDetails?>("presenterDetails"); }
            set { BackingStore?.Set("presenterDetails", value); }
        }
#nullable restore
#else
        public VirtualEventPresenterDetails PresenterDetails {
            get { return BackingStore?.Get<VirtualEventPresenterDetails>("presenterDetails"); }
            set { BackingStore?.Set("presenterDetails", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new VirtualEventPresenterInfo and sets the default values.
        /// </summary>
        public VirtualEventPresenterInfo() : base() {
            OdataType = "#microsoft.graph.virtualEventPresenterInfo";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new VirtualEventPresenterInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VirtualEventPresenterInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"presenterDetails", n => { PresenterDetails = n.GetObjectValue<VirtualEventPresenterDetails>(VirtualEventPresenterDetails.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<VirtualEventPresenterDetails>("presenterDetails", PresenterDetails);
        }
    }
}
