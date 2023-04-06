using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Entity representing setting comparison result
    /// </summary>
    public class DeviceManagementSettingComparison : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Setting comparison result type</summary>
        public DeviceManagementComparisonResult? ComparisonResult {
            get { return BackingStore?.Get<DeviceManagementComparisonResult?>("comparisonResult"); }
            set { BackingStore?.Set("comparisonResult", value); }
        }
        /// <summary>JSON representation of current intent (or) template setting&apos;s value</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrentValueJson {
            get { return BackingStore?.Get<string?>("currentValueJson"); }
            set { BackingStore?.Set("currentValueJson", value); }
        }
#nullable restore
#else
        public string CurrentValueJson {
            get { return BackingStore?.Get<string>("currentValueJson"); }
            set { BackingStore?.Set("currentValueJson", value); }
        }
#endif
        /// <summary>The ID of the setting definition for this instance</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefinitionId {
            get { return BackingStore?.Get<string?>("definitionId"); }
            set { BackingStore?.Set("definitionId", value); }
        }
#nullable restore
#else
        public string DefinitionId {
            get { return BackingStore?.Get<string>("definitionId"); }
            set { BackingStore?.Set("definitionId", value); }
        }
#endif
        /// <summary>The setting&apos;s display name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The setting ID</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id {
            get { return BackingStore?.Get<string?>("id"); }
            set { BackingStore?.Set("id", value); }
        }
#nullable restore
#else
        public string Id {
            get { return BackingStore?.Get<string>("id"); }
            set { BackingStore?.Set("id", value); }
        }
#endif
        /// <summary>JSON representation of new template setting&apos;s value</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NewValueJson {
            get { return BackingStore?.Get<string?>("newValueJson"); }
            set { BackingStore?.Set("newValueJson", value); }
        }
#nullable restore
#else
        public string NewValueJson {
            get { return BackingStore?.Get<string>("newValueJson"); }
            set { BackingStore?.Set("newValueJson", value); }
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
        /// Instantiates a new deviceManagementSettingComparison and sets the default values.
        /// </summary>
        public DeviceManagementSettingComparison() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeviceManagementSettingComparison CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementSettingComparison();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"comparisonResult", n => { ComparisonResult = n.GetEnumValue<DeviceManagementComparisonResult>(); } },
                {"currentValueJson", n => { CurrentValueJson = n.GetStringValue(); } },
                {"definitionId", n => { DefinitionId = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"newValueJson", n => { NewValueJson = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<DeviceManagementComparisonResult>("comparisonResult", ComparisonResult);
            writer.WriteStringValue("currentValueJson", CurrentValueJson);
            writer.WriteStringValue("definitionId", DefinitionId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("newValueJson", NewValueJson);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
