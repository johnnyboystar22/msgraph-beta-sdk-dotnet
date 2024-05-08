// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    #pragma warning disable CS1591
    public class TrainingCampaignReport : IAdditionalDataHolder, IBackedModel, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The overview of the attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserSimulationDetails>? CampaignUsers {
            get { return BackingStore?.Get<List<UserSimulationDetails>?>("campaignUsers"); }
            set { BackingStore?.Set("campaignUsers", value); }
        }
#nullable restore
#else
        public List<UserSimulationDetails> CampaignUsers {
            get { return BackingStore?.Get<List<UserSimulationDetails>>("campaignUsers"); }
            set { BackingStore?.Set("campaignUsers", value); }
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
        /// <summary>The overview property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TrainingCampaignReportOverview? Overview {
            get { return BackingStore?.Get<TrainingCampaignReportOverview?>("overview"); }
            set { BackingStore?.Set("overview", value); }
        }
#nullable restore
#else
        public TrainingCampaignReportOverview Overview {
            get { return BackingStore?.Get<TrainingCampaignReportOverview>("overview"); }
            set { BackingStore?.Set("overview", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="TrainingCampaignReport"/> and sets the default values.
        /// </summary>
        public TrainingCampaignReport()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TrainingCampaignReport"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TrainingCampaignReport CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TrainingCampaignReport();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"campaignUsers", n => { CampaignUsers = n.GetCollectionOfObjectValues<UserSimulationDetails>(UserSimulationDetails.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"overview", n => { Overview = n.GetObjectValue<TrainingCampaignReportOverview>(TrainingCampaignReportOverview.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<UserSimulationDetails>("campaignUsers", CampaignUsers);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<TrainingCampaignReportOverview>("overview", Overview);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
