using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class OnPremisesWritebackConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The distinguished name of the on-premises container that the customer is using to store unified groups which are created in the cloud.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UnifiedGroupContainer {
            get { return BackingStore?.Get<string?>("unifiedGroupContainer"); }
            set { BackingStore?.Set("unifiedGroupContainer", value); }
        }
#nullable restore
#else
        public string UnifiedGroupContainer {
            get { return BackingStore?.Get<string>("unifiedGroupContainer"); }
            set { BackingStore?.Set("unifiedGroupContainer", value); }
        }
#endif
        /// <summary>The distinguished name of the on-premises container that the customer is using to store users which are created in the cloud.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserContainer {
            get { return BackingStore?.Get<string?>("userContainer"); }
            set { BackingStore?.Set("userContainer", value); }
        }
#nullable restore
#else
        public string UserContainer {
            get { return BackingStore?.Get<string>("userContainer"); }
            set { BackingStore?.Set("userContainer", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new onPremisesWritebackConfiguration and sets the default values.
        /// </summary>
        public OnPremisesWritebackConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OnPremisesWritebackConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnPremisesWritebackConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"unifiedGroupContainer", n => { UnifiedGroupContainer = n.GetStringValue(); } },
                {"userContainer", n => { UserContainer = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("unifiedGroupContainer", UnifiedGroupContainer);
            writer.WriteStringValue("userContainer", UserContainer);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
