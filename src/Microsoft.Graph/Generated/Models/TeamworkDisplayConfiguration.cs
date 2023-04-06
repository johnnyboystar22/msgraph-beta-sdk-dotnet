using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkDisplayConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The list of configured displays. Applicable only for Microsoft Teams Rooms devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TeamworkConfiguredPeripheral>? ConfiguredDisplays {
            get { return BackingStore?.Get<List<TeamworkConfiguredPeripheral>?>("configuredDisplays"); }
            set { BackingStore?.Set("configuredDisplays", value); }
        }
#nullable restore
#else
        public List<TeamworkConfiguredPeripheral> ConfiguredDisplays {
            get { return BackingStore?.Get<List<TeamworkConfiguredPeripheral>>("configuredDisplays"); }
            set { BackingStore?.Set("configuredDisplays", value); }
        }
#endif
        /// <summary>Total number of connected displays, including the inbuilt display. Applicable only for Teams Rooms devices.</summary>
        public int? DisplayCount {
            get { return BackingStore?.Get<int?>("displayCount"); }
            set { BackingStore?.Set("displayCount", value); }
        }
        /// <summary>Configuration for the inbuilt display. Not applicable for Teams Rooms devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkDisplayScreenConfiguration? InBuiltDisplayScreenConfiguration {
            get { return BackingStore?.Get<TeamworkDisplayScreenConfiguration?>("inBuiltDisplayScreenConfiguration"); }
            set { BackingStore?.Set("inBuiltDisplayScreenConfiguration", value); }
        }
#nullable restore
#else
        public TeamworkDisplayScreenConfiguration InBuiltDisplayScreenConfiguration {
            get { return BackingStore?.Get<TeamworkDisplayScreenConfiguration>("inBuiltDisplayScreenConfiguration"); }
            set { BackingStore?.Set("inBuiltDisplayScreenConfiguration", value); }
        }
#endif
        /// <summary>True if content duplication is allowed. Applicable only for Teams Rooms devices.</summary>
        public bool? IsContentDuplicationAllowed {
            get { return BackingStore?.Get<bool?>("isContentDuplicationAllowed"); }
            set { BackingStore?.Set("isContentDuplicationAllowed", value); }
        }
        /// <summary>True if dual display mode is enabled. If isDualDisplayModeEnabled is true, then the content will be displayed on both front of room screens instead of just the one screen, when it is shared via the HDMI ingest module on the Microsoft Teams Rooms device. Applicable only for Teams Rooms devices.</summary>
        public bool? IsDualDisplayModeEnabled {
            get { return BackingStore?.Get<bool?>("isDualDisplayModeEnabled"); }
            set { BackingStore?.Set("isDualDisplayModeEnabled", value); }
        }
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
        /// Instantiates a new teamworkDisplayConfiguration and sets the default values.
        /// </summary>
        public TeamworkDisplayConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TeamworkDisplayConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkDisplayConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"configuredDisplays", n => { ConfiguredDisplays = n.GetCollectionOfObjectValues<TeamworkConfiguredPeripheral>(TeamworkConfiguredPeripheral.CreateFromDiscriminatorValue)?.ToList(); } },
                {"displayCount", n => { DisplayCount = n.GetIntValue(); } },
                {"inBuiltDisplayScreenConfiguration", n => { InBuiltDisplayScreenConfiguration = n.GetObjectValue<TeamworkDisplayScreenConfiguration>(TeamworkDisplayScreenConfiguration.CreateFromDiscriminatorValue); } },
                {"isContentDuplicationAllowed", n => { IsContentDuplicationAllowed = n.GetBoolValue(); } },
                {"isDualDisplayModeEnabled", n => { IsDualDisplayModeEnabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<TeamworkConfiguredPeripheral>("configuredDisplays", ConfiguredDisplays);
            writer.WriteIntValue("displayCount", DisplayCount);
            writer.WriteObjectValue<TeamworkDisplayScreenConfiguration>("inBuiltDisplayScreenConfiguration", InBuiltDisplayScreenConfiguration);
            writer.WriteBoolValue("isContentDuplicationAllowed", IsContentDuplicationAllowed);
            writer.WriteBoolValue("isDualDisplayModeEnabled", IsDualDisplayModeEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
