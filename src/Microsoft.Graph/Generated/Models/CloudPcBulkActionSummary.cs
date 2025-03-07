// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class CloudPcBulkActionSummary : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The number of Cloud PCs where the action failed.</summary>
        public int? FailedCount
        {
            get { return BackingStore?.Get<int?>("failedCount"); }
            set { BackingStore?.Set("failedCount", value); }
        }
        /// <summary>The number of Cloud PCs where the action is in progress.</summary>
        public int? InProgressCount
        {
            get { return BackingStore?.Get<int?>("inProgressCount"); }
            set { BackingStore?.Set("inProgressCount", value); }
        }
        /// <summary>The number of Cloud PCs where the action isn&apos;t supported.</summary>
        public int? NotSupportedCount
        {
            get { return BackingStore?.Get<int?>("notSupportedCount"); }
            set { BackingStore?.Set("notSupportedCount", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The number of Cloud PCs where the action is pending.</summary>
        public int? PendingCount
        {
            get { return BackingStore?.Get<int?>("pendingCount"); }
            set { BackingStore?.Set("pendingCount", value); }
        }
        /// <summary>The number of Cloud PCs where the action is successful.</summary>
        public int? SuccessfulCount
        {
            get { return BackingStore?.Get<int?>("successfulCount"); }
            set { BackingStore?.Set("successfulCount", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.CloudPcBulkActionSummary"/> and sets the default values.
        /// </summary>
        public CloudPcBulkActionSummary()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.CloudPcBulkActionSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.CloudPcBulkActionSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.CloudPcBulkActionSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "failedCount", n => { FailedCount = n.GetIntValue(); } },
                { "inProgressCount", n => { InProgressCount = n.GetIntValue(); } },
                { "notSupportedCount", n => { NotSupportedCount = n.GetIntValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "pendingCount", n => { PendingCount = n.GetIntValue(); } },
                { "successfulCount", n => { SuccessfulCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("failedCount", FailedCount);
            writer.WriteIntValue("inProgressCount", InProgressCount);
            writer.WriteIntValue("notSupportedCount", NotSupportedCount);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("pendingCount", PendingCount);
            writer.WriteIntValue("successfulCount", SuccessfulCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
