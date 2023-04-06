using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.Days360 {
    public class Days360PostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The endDate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? EndDate {
            get { return BackingStore?.Get<Json?>("endDate"); }
            set { BackingStore?.Set("endDate", value); }
        }
#nullable restore
#else
        public Json EndDate {
            get { return BackingStore?.Get<Json>("endDate"); }
            set { BackingStore?.Set("endDate", value); }
        }
#endif
        /// <summary>The method property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Method {
            get { return BackingStore?.Get<Json?>("method"); }
            set { BackingStore?.Set("method", value); }
        }
#nullable restore
#else
        public Json Method {
            get { return BackingStore?.Get<Json>("method"); }
            set { BackingStore?.Set("method", value); }
        }
#endif
        /// <summary>The startDate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? StartDate {
            get { return BackingStore?.Get<Json?>("startDate"); }
            set { BackingStore?.Set("startDate", value); }
        }
#nullable restore
#else
        public Json StartDate {
            get { return BackingStore?.Get<Json>("startDate"); }
            set { BackingStore?.Set("startDate", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new days360PostRequestBody and sets the default values.
        /// </summary>
        public Days360PostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Days360PostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Days360PostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"endDate", n => { EndDate = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"method", n => { Method = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"startDate", n => { StartDate = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("endDate", EndDate);
            writer.WriteObjectValue<Json>("method", Method);
            writer.WriteObjectValue<Json>("startDate", StartDate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
