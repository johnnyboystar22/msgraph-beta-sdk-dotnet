using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcForensicStorageAccount : Entity, IParsable {
        /// <summary>The ID of the storage account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StorageAccountId {
            get { return BackingStore?.Get<string?>("storageAccountId"); }
            set { BackingStore?.Set("storageAccountId", value); }
        }
#nullable restore
#else
        public string StorageAccountId {
            get { return BackingStore?.Get<string>("storageAccountId"); }
            set { BackingStore?.Set("storageAccountId", value); }
        }
#endif
        /// <summary>The name of the storage account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StorageAccountName {
            get { return BackingStore?.Get<string?>("storageAccountName"); }
            set { BackingStore?.Set("storageAccountName", value); }
        }
#nullable restore
#else
        public string StorageAccountName {
            get { return BackingStore?.Get<string>("storageAccountName"); }
            set { BackingStore?.Set("storageAccountName", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CloudPcForensicStorageAccount CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcForensicStorageAccount();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"storageAccountId", n => { StorageAccountId = n.GetStringValue(); } },
                {"storageAccountName", n => { StorageAccountName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("storageAccountId", StorageAccountId);
            writer.WriteStringValue("storageAccountName", StorageAccountName);
        }
    }
}
