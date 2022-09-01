using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.IdentityGovernance {
    public class RunSummary : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The failedRuns property</summary>
        public int? FailedRuns {
            get { return BackingStore?.Get<int?>("failedRuns"); }
            set { BackingStore?.Set("failedRuns", value); }
        }
        /// <summary>The failedTasks property</summary>
        public int? FailedTasks {
            get { return BackingStore?.Get<int?>("failedTasks"); }
            set { BackingStore?.Set("failedTasks", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The successfulRuns property</summary>
        public int? SuccessfulRuns {
            get { return BackingStore?.Get<int?>("successfulRuns"); }
            set { BackingStore?.Set("successfulRuns", value); }
        }
        /// <summary>The totalRuns property</summary>
        public int? TotalRuns {
            get { return BackingStore?.Get<int?>("totalRuns"); }
            set { BackingStore?.Set("totalRuns", value); }
        }
        /// <summary>The totalTasks property</summary>
        public int? TotalTasks {
            get { return BackingStore?.Get<int?>("totalTasks"); }
            set { BackingStore?.Set("totalTasks", value); }
        }
        /// <summary>The totalUsers property</summary>
        public int? TotalUsers {
            get { return BackingStore?.Get<int?>("totalUsers"); }
            set { BackingStore?.Set("totalUsers", value); }
        }
        /// <summary>
        /// Instantiates a new runSummary and sets the default values.
        /// </summary>
        public RunSummary() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.identityGovernance.runSummary";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RunSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RunSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"failedRuns", n => { FailedRuns = n.GetIntValue(); } },
                {"failedTasks", n => { FailedTasks = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"successfulRuns", n => { SuccessfulRuns = n.GetIntValue(); } },
                {"totalRuns", n => { TotalRuns = n.GetIntValue(); } },
                {"totalTasks", n => { TotalTasks = n.GetIntValue(); } },
                {"totalUsers", n => { TotalUsers = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("failedRuns", FailedRuns);
            writer.WriteIntValue("failedTasks", FailedTasks);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("successfulRuns", SuccessfulRuns);
            writer.WriteIntValue("totalRuns", TotalRuns);
            writer.WriteIntValue("totalTasks", TotalTasks);
            writer.WriteIntValue("totalUsers", TotalUsers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
