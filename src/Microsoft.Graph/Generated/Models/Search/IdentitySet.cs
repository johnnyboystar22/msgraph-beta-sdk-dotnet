using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Search {
    public class IdentitySet : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The application property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Identity? Application {
            get { return BackingStore?.Get<Identity?>("application"); }
            set { BackingStore?.Set("application", value); }
        }
#nullable restore
#else
        public Identity Application {
            get { return BackingStore?.Get<Identity>("application"); }
            set { BackingStore?.Set("application", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The device property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Identity? Device {
            get { return BackingStore?.Get<Identity?>("device"); }
            set { BackingStore?.Set("device", value); }
        }
#nullable restore
#else
        public Identity Device {
            get { return BackingStore?.Get<Identity>("device"); }
            set { BackingStore?.Set("device", value); }
        }
#endif
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
        /// <summary>The user property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Identity? User {
            get { return BackingStore?.Get<Identity?>("user"); }
            set { BackingStore?.Set("user", value); }
        }
#nullable restore
#else
        public Identity User {
            get { return BackingStore?.Get<Identity>("user"); }
            set { BackingStore?.Set("user", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new identitySet and sets the default values.
        /// </summary>
        public IdentitySet() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IdentitySet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IdentitySet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"application", n => { Application = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"device", n => { Device = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"user", n => { User = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Identity>("application", Application);
            writer.WriteObjectValue<Identity>("device", Device);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<Identity>("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
