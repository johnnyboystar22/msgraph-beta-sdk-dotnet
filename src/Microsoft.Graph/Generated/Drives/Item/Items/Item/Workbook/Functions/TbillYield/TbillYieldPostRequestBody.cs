using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.TbillYield {
    public class TbillYieldPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The maturity property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Maturity {
            get { return BackingStore?.Get<Json?>("maturity"); }
            set { BackingStore?.Set("maturity", value); }
        }
#nullable restore
#else
        public Json Maturity {
            get { return BackingStore?.Get<Json>("maturity"); }
            set { BackingStore?.Set("maturity", value); }
        }
#endif
        /// <summary>The pr property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Pr {
            get { return BackingStore?.Get<Json?>("pr"); }
            set { BackingStore?.Set("pr", value); }
        }
#nullable restore
#else
        public Json Pr {
            get { return BackingStore?.Get<Json>("pr"); }
            set { BackingStore?.Set("pr", value); }
        }
#endif
        /// <summary>The settlement property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Settlement {
            get { return BackingStore?.Get<Json?>("settlement"); }
            set { BackingStore?.Set("settlement", value); }
        }
#nullable restore
#else
        public Json Settlement {
            get { return BackingStore?.Get<Json>("settlement"); }
            set { BackingStore?.Set("settlement", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new tbillYieldPostRequestBody and sets the default values.
        /// </summary>
        public TbillYieldPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TbillYieldPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TbillYieldPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"maturity", n => { Maturity = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"pr", n => { Pr = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"settlement", n => { Settlement = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("maturity", Maturity);
            writer.WriteObjectValue<Json>("pr", Pr);
            writer.WriteObjectValue<Json>("settlement", Settlement);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
