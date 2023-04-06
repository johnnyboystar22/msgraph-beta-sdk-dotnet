using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class UsageRight : Entity, IParsable {
        /// <summary>Product id corresponding to the usage right.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CatalogId {
            get { return BackingStore?.Get<string?>("catalogId"); }
            set { BackingStore?.Set("catalogId", value); }
        }
#nullable restore
#else
        public string CatalogId {
            get { return BackingStore?.Get<string>("catalogId"); }
            set { BackingStore?.Set("catalogId", value); }
        }
#endif
        /// <summary>Identifier of the service corresponding to the usage right.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceIdentifier {
            get { return BackingStore?.Get<string?>("serviceIdentifier"); }
            set { BackingStore?.Set("serviceIdentifier", value); }
        }
#nullable restore
#else
        public string ServiceIdentifier {
            get { return BackingStore?.Get<string>("serviceIdentifier"); }
            set { BackingStore?.Set("serviceIdentifier", value); }
        }
#endif
        /// <summary>The state property</summary>
        public UsageRightState? State {
            get { return BackingStore?.Get<UsageRightState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UsageRight CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UsageRight();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"catalogId", n => { CatalogId = n.GetStringValue(); } },
                {"serviceIdentifier", n => { ServiceIdentifier = n.GetStringValue(); } },
                {"state", n => { State = n.GetEnumValue<UsageRightState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("catalogId", CatalogId);
            writer.WriteStringValue("serviceIdentifier", ServiceIdentifier);
            writer.WriteEnumValue<UsageRightState>("state", State);
        }
    }
}
