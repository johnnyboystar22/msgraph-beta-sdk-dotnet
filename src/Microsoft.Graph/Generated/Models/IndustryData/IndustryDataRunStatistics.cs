using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.IndustryData {
    public class IndustryDataRunStatistics : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The collection of statistics for each activity included in this run.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IndustryDataActivityStatistics>? ActivityStatistics {
            get { return BackingStore?.Get<List<IndustryDataActivityStatistics>?>("activityStatistics"); }
            set { BackingStore?.Set("activityStatistics", value); }
        }
#nullable restore
#else
        public List<IndustryDataActivityStatistics> ActivityStatistics {
            get { return BackingStore?.Get<List<IndustryDataActivityStatistics>>("activityStatistics"); }
            set { BackingStore?.Set("activityStatistics", value); }
        }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The aggregate statistics for all inbound flows.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AggregatedInboundStatistics? InboundTotals {
            get { return BackingStore?.Get<AggregatedInboundStatistics?>("inboundTotals"); }
            set { BackingStore?.Set("inboundTotals", value); }
        }
#nullable restore
#else
        public AggregatedInboundStatistics InboundTotals {
            get { return BackingStore?.Get<AggregatedInboundStatistics>("inboundTotals"); }
            set { BackingStore?.Set("inboundTotals", value); }
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
        /// <summary>The ID of the underlying run for the statistics.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RunId {
            get { return BackingStore?.Get<string?>("runId"); }
            set { BackingStore?.Set("runId", value); }
        }
#nullable restore
#else
        public string RunId {
            get { return BackingStore?.Get<string>("runId"); }
            set { BackingStore?.Set("runId", value); }
        }
#endif
        /// <summary>The status property</summary>
        public IndustryDataRunStatus? Status {
            get { return BackingStore?.Get<IndustryDataRunStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Instantiates a new industryDataRunStatistics and sets the default values.
        /// </summary>
        public IndustryDataRunStatistics() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IndustryDataRunStatistics CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IndustryDataRunStatistics();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"activityStatistics", n => { ActivityStatistics = n.GetCollectionOfObjectValues<IndustryDataActivityStatistics>(IndustryDataActivityStatistics.CreateFromDiscriminatorValue)?.ToList(); } },
                {"inboundTotals", n => { InboundTotals = n.GetObjectValue<AggregatedInboundStatistics>(AggregatedInboundStatistics.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"runId", n => { RunId = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<IndustryDataRunStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<IndustryDataRunStatus>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
