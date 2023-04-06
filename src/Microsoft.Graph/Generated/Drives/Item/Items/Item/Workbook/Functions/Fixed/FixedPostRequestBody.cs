using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.Fixed {
    public class FixedPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The decimals property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Decimals {
            get { return BackingStore?.Get<Json?>("decimals"); }
            set { BackingStore?.Set("decimals", value); }
        }
#nullable restore
#else
        public Json Decimals {
            get { return BackingStore?.Get<Json>("decimals"); }
            set { BackingStore?.Set("decimals", value); }
        }
#endif
        /// <summary>The noCommas property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? NoCommas {
            get { return BackingStore?.Get<Json?>("noCommas"); }
            set { BackingStore?.Set("noCommas", value); }
        }
#nullable restore
#else
        public Json NoCommas {
            get { return BackingStore?.Get<Json>("noCommas"); }
            set { BackingStore?.Set("noCommas", value); }
        }
#endif
        /// <summary>The number property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Number {
            get { return BackingStore?.Get<Json?>("number"); }
            set { BackingStore?.Set("number", value); }
        }
#nullable restore
#else
        public Json Number {
            get { return BackingStore?.Get<Json>("number"); }
            set { BackingStore?.Set("number", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new fixedPostRequestBody and sets the default values.
        /// </summary>
        public FixedPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static FixedPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FixedPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"decimals", n => { Decimals = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"noCommas", n => { NoCommas = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"number", n => { Number = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("decimals", Decimals);
            writer.WriteObjectValue<Json>("noCommas", NoCommas);
            writer.WriteObjectValue<Json>("number", Number);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
