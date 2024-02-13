// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class DataCollectionInfo : Entity, IParsable {
        /// <summary>The entitlements property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EntitlementsDataCollectionInfo? Entitlements {
            get { return BackingStore?.Get<EntitlementsDataCollectionInfo?>("entitlements"); }
            set { BackingStore?.Set("entitlements", value); }
        }
#nullable restore
#else
        public EntitlementsDataCollectionInfo Entitlements {
            get { return BackingStore?.Get<EntitlementsDataCollectionInfo>("entitlements"); }
            set { BackingStore?.Set("entitlements", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DataCollectionInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DataCollectionInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DataCollectionInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"entitlements", n => { Entitlements = n.GetObjectValue<EntitlementsDataCollectionInfo>(EntitlementsDataCollectionInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<EntitlementsDataCollectionInfo>("entitlements", Entitlements);
        }
    }
}
