using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.BulkResize {
    public class BulkResizePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The cloudPcIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CloudPcIds {
            get { return BackingStore?.Get<List<string>?>("cloudPcIds"); }
            set { BackingStore?.Set("cloudPcIds", value); }
        }
#nullable restore
#else
        public List<string> CloudPcIds {
            get { return BackingStore?.Get<List<string>>("cloudPcIds"); }
            set { BackingStore?.Set("cloudPcIds", value); }
        }
#endif
        /// <summary>The targetServicePlanId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetServicePlanId {
            get { return BackingStore?.Get<string?>("targetServicePlanId"); }
            set { BackingStore?.Set("targetServicePlanId", value); }
        }
#nullable restore
#else
        public string TargetServicePlanId {
            get { return BackingStore?.Get<string>("targetServicePlanId"); }
            set { BackingStore?.Set("targetServicePlanId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new bulkResizePostRequestBody and sets the default values.
        /// </summary>
        public BulkResizePostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BulkResizePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BulkResizePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"cloudPcIds", n => { CloudPcIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"targetServicePlanId", n => { TargetServicePlanId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("cloudPcIds", CloudPcIds);
            writer.WriteStringValue("targetServicePlanId", TargetServicePlanId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
