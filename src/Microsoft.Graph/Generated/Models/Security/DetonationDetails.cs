// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    #pragma warning disable CS1591
    public class DetonationDetails : IAdditionalDataHolder, IBackedModel, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The time of detonation.</summary>
        public DateTimeOffset? AnalysisDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("analysisDateTime"); }
            set { BackingStore?.Set("analysisDateTime", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The chain of detonation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Security.DetonationChain? DetonationChain {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.DetonationChain?>("detonationChain"); }
            set { BackingStore?.Set("detonationChain", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Security.DetonationChain DetonationChain {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.DetonationChain>("detonationChain"); }
            set { BackingStore?.Set("detonationChain", value); }
        }
#endif
        /// <summary>All observables in the detonation tree.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Security.DetonationObservables? DetonationObservables {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.DetonationObservables?>("detonationObservables"); }
            set { BackingStore?.Set("detonationObservables", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Security.DetonationObservables DetonationObservables {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.DetonationObservables>("detonationObservables"); }
            set { BackingStore?.Set("detonationObservables", value); }
        }
#endif
        /// <summary>The verdict of the detonation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DetonationVerdict {
            get { return BackingStore?.Get<string?>("detonationVerdict"); }
            set { BackingStore?.Set("detonationVerdict", value); }
        }
#nullable restore
#else
        public string DetonationVerdict {
            get { return BackingStore?.Get<string>("detonationVerdict"); }
            set { BackingStore?.Set("detonationVerdict", value); }
        }
#endif
        /// <summary>The reason for the verdict of the detonation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DetonationVerdictReason {
            get { return BackingStore?.Get<string?>("detonationVerdictReason"); }
            set { BackingStore?.Set("detonationVerdictReason", value); }
        }
#nullable restore
#else
        public string DetonationVerdictReason {
            get { return BackingStore?.Get<string>("detonationVerdictReason"); }
            set { BackingStore?.Set("detonationVerdictReason", value); }
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
        /// <summary>
        /// Instantiates a new <see cref="DetonationDetails"/> and sets the default values.
        /// </summary>
        public DetonationDetails()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DetonationDetails"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DetonationDetails CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DetonationDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"analysisDateTime", n => { AnalysisDateTime = n.GetDateTimeOffsetValue(); } },
                {"detonationChain", n => { DetonationChain = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.DetonationChain>(Microsoft.Graph.Beta.Models.Security.DetonationChain.CreateFromDiscriminatorValue); } },
                {"detonationObservables", n => { DetonationObservables = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.DetonationObservables>(Microsoft.Graph.Beta.Models.Security.DetonationObservables.CreateFromDiscriminatorValue); } },
                {"detonationVerdict", n => { DetonationVerdict = n.GetStringValue(); } },
                {"detonationVerdictReason", n => { DetonationVerdictReason = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("analysisDateTime", AnalysisDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.DetonationChain>("detonationChain", DetonationChain);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.DetonationObservables>("detonationObservables", DetonationObservables);
            writer.WriteStringValue("detonationVerdict", DetonationVerdict);
            writer.WriteStringValue("detonationVerdictReason", DetonationVerdictReason);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
