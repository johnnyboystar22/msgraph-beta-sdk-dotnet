using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Default and customized value of a setting in a Security Baseline
    /// </summary>
    public class DeviceManagementIntentCustomizedSetting : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>JSON representation of the customized value, if different from default</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomizedJson {
            get { return BackingStore?.Get<string?>("customizedJson"); }
            set { BackingStore?.Set("customizedJson", value); }
        }
#nullable restore
#else
        public string CustomizedJson {
            get { return BackingStore?.Get<string>("customizedJson"); }
            set { BackingStore?.Set("customizedJson", value); }
        }
#endif
        /// <summary>JSON representation of the default value from the template</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultJson {
            get { return BackingStore?.Get<string?>("defaultJson"); }
            set { BackingStore?.Set("defaultJson", value); }
        }
#nullable restore
#else
        public string DefaultJson {
            get { return BackingStore?.Get<string>("defaultJson"); }
            set { BackingStore?.Set("defaultJson", value); }
        }
#endif
        /// <summary>The ID of the setting definition for this setting</summary>
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
        /// Instantiates a new deviceManagementIntentCustomizedSetting and sets the default values.
        /// </summary>
        public DeviceManagementIntentCustomizedSetting() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeviceManagementIntentCustomizedSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementIntentCustomizedSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"customizedJson", n => { CustomizedJson = n.GetStringValue(); } },
                {"defaultJson", n => { DefaultJson = n.GetStringValue(); } },
                {"definitionId", n => { DefinitionId = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("customizedJson", CustomizedJson);
            writer.WriteStringValue("defaultJson", DefaultJson);
            writer.WriteStringValue("definitionId", DefinitionId);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
